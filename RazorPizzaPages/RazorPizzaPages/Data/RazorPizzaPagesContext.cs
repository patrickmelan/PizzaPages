using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPizzaPages.Models;

namespace RazorPizzaPages.Data
{
    public class RazorPizzaPagesContext : DbContext
    {
        public RazorPizzaPagesContext (DbContextOptions<RazorPizzaPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPizzaPages.Models.Pizza> Pizza { get; set; } = default!;
    }
}
