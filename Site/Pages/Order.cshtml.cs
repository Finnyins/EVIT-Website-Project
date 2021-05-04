using System;
using System.Threading.Tasks;
using Website.Data;
using Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
namespace Website.Pages
{
    public class OrderModel : PageModel
    {
        private WebsiteContext db;
        public OrderModel(WebsiteContext db) => this.db = db;
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public Product Product { get; set;}
                [BindProperty, EmailAddress, Required(ErrorMessage="Please input a valid email"), Display(Name="Email Address")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage="Please supply a shipping address"), Display(Name="Shipping Address")]
        public string OrderShipping { get; set; } 
        [BindProperty, Display(Name="Quantity")]
        public int OrderQuantity { get; set; } = 1;
        public async Task OnGetAsync() =>  Product = await db.Products.FindAsync(Id);
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await db.Products.FindAsync(Id);
            if(ModelState.IsValid){
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
