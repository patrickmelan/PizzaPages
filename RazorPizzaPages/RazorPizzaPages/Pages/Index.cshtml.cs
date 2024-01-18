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
    public class IndexModel : PageModel
    {
        private readonly RazorPizzaPages.Data.RazorPizzaPagesContext _context;

        public IndexModel(RazorPizzaPages.Data.RazorPizzaPagesContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizza.ToListAsync();
        }
    }
}
