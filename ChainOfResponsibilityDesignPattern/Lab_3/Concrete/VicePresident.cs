using ChainOfResponsibilityDesignPattern.Lab_3.Abstraction;
using ChainOfResponsibilityDesignPattern.Lab_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern.Lab_3.Concrete
{
    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice president handle the expense..!");
            }
            else if (_successor != null)
            {
                _successor.HandleExpense(expense);
            }
        }
    }
}
