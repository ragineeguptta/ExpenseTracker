using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Web.Models.ViewModels
{
    public class ExpenseViewModel
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
