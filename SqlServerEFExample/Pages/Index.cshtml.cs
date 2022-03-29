using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlServerEFExample.Context;
using SqlServerEFExample.Model;

namespace SqlServerEFExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration , ILogger<IndexModel> logger)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {

        }

        //http://localhost:5123?handler=SaveProduct
        public IActionResult OnGetSaveProduct()
        {
            DataContext context = new DataContext(_configuration);
            context.Products.Add(new Product() { ProductName = "Product 1" }); // Add product to database
            context.SaveChanges();
            var resultOb = new { result = "OK" };
            return new OkResult();
        }
    }
}