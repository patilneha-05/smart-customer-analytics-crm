using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SmartCRM.Services;   // ✅ IMPORTANT
using System.Linq;

namespace SmartCRM.Pages.Customers
{
    public class DashboardModel : PageModel   // ✅ FIXED NAME
    {
        private readonly ILogger<DashboardModel> _logger;

        public int TotalCustomers { get; set; }

        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var service = new CustomerService();

            // ✅ FIXED METHOD NAME
            TotalCustomers = service.GetAll().Count();
        }
    }
}