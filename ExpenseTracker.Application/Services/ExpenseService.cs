using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
        public async Task AddExpenseAsync(Expense expense)
        {
            expense.Date = DateTime.UtcNow; // Set the date to current UTC time
            await _expenseRepository.AddAsync(expense);
        }

        public async Task<List<Expense>> GetExpensesByUserIdAsync(string userId)
        {
            return await _expenseRepository.GetByUserIdAsync(userId);
        }
    }
}
