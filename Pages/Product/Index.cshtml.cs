#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab3.Models;
using System.Security.Claims;

namespace ProductModel
{
    public class IndexModel : PageModel
    {
        private readonly DBContext _context;

        public IndexModel(DBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }
        public string? UserEmail { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();

            if (User.Identity != null)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                if (claimsIdentity.IsAuthenticated)
                {
                    var email = claimsIdentity.FindFirst(ClaimTypes.Email);
                    if (email != null)
                    {
                        UserEmail = email.Value;
                    }
                }
            }

        }
    }
}
