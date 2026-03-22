using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCRM.Models;
using SmartCRM.Services;

namespace SmartCRM.Pages.Customers
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; } = new();

        CustomerService service = new();

        public void OnGet(int id)
        {
            Customer = service.GetAll().FirstOrDefault(x => x.Id == id) ?? new Customer();
        }

        public IActionResult OnPost()
        {
            service.Update(Customer);
            TempData["Success"] = "Customer Updated!";
            return RedirectToPage("Index");
        }
    }
}