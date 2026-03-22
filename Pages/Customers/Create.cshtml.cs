using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCRM.Models;
using SmartCRM.Services;

namespace SmartCRM.Pages.Customers
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Customer.Name))
                return Page();

            var service = new CustomerService();
            service.Add(Customer);

            return RedirectToPage("Index");
        }
    }
}