using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace smart_customer_analytics_crm.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        public int Id { get; set; }

        public void OnGet(int id)
        {
            Id = id;
        }

        public IActionResult OnPost(int id)
        {
            // For now just redirect (no DB delete yet)
            return RedirectToPage("Index");
        }
    }
}