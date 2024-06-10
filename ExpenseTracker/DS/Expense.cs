using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DS
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int ExpenseCategory { get; set; }
        public double ExpenseAmount { get; set; }
        public string ExpenseDetails { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
