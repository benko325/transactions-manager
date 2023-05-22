using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PV178.BussinessContext
{
    public class Transaction
    {
        public int Id { get; }
        public bool Income { get; }
        public decimal Amount { get; }
        public string Description { get; }
        public DateTime Date { get; }
        public int MakerId { get; }

        public Transaction(int id, bool income, decimal amount, string description, DateTime date, int makerId)
        {
            Id = id;
            Income = income;
            Amount = amount;
            Description = description;
            Date = date;
            MakerId = makerId;
        }
    }
}
