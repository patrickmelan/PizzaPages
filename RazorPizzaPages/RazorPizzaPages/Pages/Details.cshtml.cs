using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPizzaPages.Data;
using RazorPizzaPages.Models;

namespace RazorPizzaPages.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPizzaPages.Data.RazorPizzaPagesContext _context;

        public DetailsModel(RazorPizzaPages.Data.RazorPizzaPagesContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            else
            {
                Pizza = pizza;
            }
            return Page();
        }
    }
}
