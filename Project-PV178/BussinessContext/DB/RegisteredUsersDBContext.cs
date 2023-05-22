using Project_PV178.BussinessContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Project_PV178.Data
{
    public class RegisteredUsersDBContext
    {
        private readonly string[] _paths = { "..", "..", "..", "BussinessContext", "DB", "Storage", "RegisteredUsers.json" };
        private readonly string _filePath;

        public RegisteredUsersDBContext()
        {
            _filePath = Path.Combine(_paths);
            if (!File.Exists(_filePath))
            {
                using var fs = File.Create(_filePath);
            }
        }

        public async Task<List<RegisteredUser>> ReadAllUsersAsync()
        {
            string? line;

            using (StreamReader inputFile = new StreamReader(_filePath))
            {
                line = await inputFile.ReadLineAsync();
            }

            if (line == null)
            {
                return new List<RegisteredUser>();
            }

            var model = await Task.Run(() => JsonSerializer.Deserialize<List<RegisteredUser>>(line));
            return model;
        }

        public async Task AddNewUserAsync(RegisteredUser user)
        {
            var users = await ReadAllUsersAsync();
            users.Add(user);

            var jsonString = await Task.Run(() => JsonSerializer.Serialize(users));

            File.Delete(_filePath);
            using StreamWriter outputFile = new StreamWriter(_filePath);
            await Task.Run(() => outputFile.WriteLine(jsonString));
        }

        public async Task UpdateUserAsync(RegisteredUser user)
        {
            var users = await ReadAllUsersAsync();
            await Task.Run(() =>
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Id == user.Id)
                    {
                        users[i] = user;
                    }
                }
            }); 

            var jsonString = await Task.Run(() => JsonSerializer.Serialize(users));

            File.Delete(_filePath);
            using StreamWriter outputFile = new StreamWriter(_filePath);
            await Task.Run(() => outputFile.WriteLine(jsonString));
        }
    }
}
