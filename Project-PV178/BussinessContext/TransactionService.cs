using Project_PV178.BussinessContext.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PV178.BussinessContext
{
    public class TransactionService
    {
        private int _transactionId;
        private TransactionsDBContext _dbContext = new TransactionsDBContext();

        public static async Task<TransactionService> CreateAsync()
        {
            var transactionService = new TransactionService();
            var transactions = await transactionService._dbContext.ReadAllTransactionsAsync();
            if (transactions.Count == 0)
            {
                transactionService._transactionId = 1;
            }
            else
            {
                transactionService._transactionId = transactions.Last().Id + 1;
            }
            return transactionService;
        }

        private TransactionService()
        {
            // Private constructor to prevent creating instances from outside of the class.
        }

        public async Task AddNewTransactionAsync(bool isIncome, decimal amount, string description, DateTime date, int makerId)
        {
            var transaction = new Transaction(_transactionId ,isIncome, amount, description, date, makerId);
            _transactionId++;

            await _dbContext.AddNewTransactionAsync(transaction);
        }

        public void CheckOnlyNumbericButtonsKeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public async Task<List<Transaction>> FindTransactionsAsync(int userId, bool expenses, bool incomes, decimal minValue, decimal maxValue, 
            string descriptionContains, DateTime minDate, DateTime maxDate)
        {
            var transactions = await _dbContext.ReadAllTransactionsAsync();
            var filterTransactions = await Task.Run(() => transactions.Where(x => true));

            //userId == 0 means that superuser wants to see transactions of all users
            if (userId > 0)
            {
                filterTransactions = await Task.Run(() => transactions.Where(x => x.MakerId == userId));
            }
            if (expenses && !incomes)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => !x.Income));
            }
            if (incomes && !expenses)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Income));
            }
            if (minValue > decimal.MinValue)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Amount >= minValue));
            }
            if (maxValue < decimal.MaxValue)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Amount <= maxValue));
            }
            if (descriptionContains.Count() > 0)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Description.ToLower().Contains(descriptionContains.ToLower())));
            }
            if (minDate > new DateTime(1753, 1, 1).Date)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Date.Date >= minDate.Date));
            }
            if (maxDate < new DateTime(9998, 12, 31).Date)
            {
                filterTransactions = await Task.Run(() => filterTransactions.Where(x => x.Date.Date <= maxDate.Date));
            }

            return await Task.Run(() => filterTransactions.ToList());
        }

        public async Task<decimal> GetSummaryAsync(List<Transaction> transactions)
        {
            return await Task.Run(() =>
            {
                decimal sum = 0;
                foreach (Transaction transaction in transactions)
                {
                    if (transaction.Income)
                    {
                        sum += transaction.Amount;
                    }
                    else
                    {
                        sum -= transaction.Amount;
                    }
                }

                return sum;
            });
        }
    }
}
