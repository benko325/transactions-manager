using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_PV178.BussinessContext.DB
{
    public class TransactionsDBContext
    {
        private readonly string[] _paths = { "..", "..", "..", "BussinessContext", "DB", "Storage", "Transactions.json" };
        private readonly string _filePath;

        public TransactionsDBContext()
        {
            _filePath = Path.Combine(_paths);
            if (!File.Exists(_filePath))
            {
                using var fs = File.Create(_filePath);
            }
        }

        // read functions in "...DBContext" and "DB" structure inspired by pv178-hw02-2023
        public async Task<List<Transaction>> ReadAllTransactionsAsync()
        {
            string? line;

            using (StreamReader inputFile = new StreamReader(_filePath))
            {
                line = await inputFile.ReadLineAsync();
            }

            if (line == null)
            {
                return new List<Transaction>();
            }

            var model = await Task.Run(() => JsonSerializer.Deserialize<List<Transaction>>(line));
            return model;
        }

        public async Task AddNewTransactionAsync(Transaction transaction)
        {
            var transactions = await ReadAllTransactionsAsync();
            transactions.Add(transaction);

            var jsonString = await Task.Run(() => JsonSerializer.Serialize(transactions));

            File.Delete(_filePath);
            using StreamWriter outputFile = new StreamWriter(_filePath);
            await Task.Run(() => outputFile.WriteLine(jsonString));
        }
    }
}
