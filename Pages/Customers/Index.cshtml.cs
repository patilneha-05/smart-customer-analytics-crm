using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCRM.Models;
using SmartCRM.Services;
using Microsoft.AspNetCore.Authorization;

namespace SmartCRM.Pages.Customers
{
[Authorize]
    public class IndexModel : PageModel
    {
        public List<Customer> Customers { get; set; } = new();

        public string Search { get; set; } = "";

        public void OnGet(string? search)
        {
            var service = new CustomerService();
            var data = service.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                Search = search;

                data = data.Where(c =>
                    c.Name != null &&
                    c.Name.Contains(search, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            Customers = data;
        }
    }
}