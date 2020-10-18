using ChainOfResponsibilityDesignPattern.Lab_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern.Lab_3.Abstraction
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase _successor;

        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            _successor = successor;
        }
    }
}
