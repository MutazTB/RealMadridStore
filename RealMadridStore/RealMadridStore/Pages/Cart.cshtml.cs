using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealMadridStore.Models;
using RealMadridStore.Models.ViewModel;

namespace RealMadridStore.Pages
{
    [Authorize]
    public class CartModel : PageModel
    {
        public string Name { get; set; }
        public string Products { get; set; }

        public void OnGet()
        {
            Name = User.Identity.Name;
            Products = Request.Cookies["CartCookie"];
        }

    }
}
