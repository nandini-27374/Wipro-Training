using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _03_06_2025_Exercise_WebAPI.Models;

namespace _03_06_2025_Exercise_WebAPI.Data
{
    public class _03_06_2025_Exercise_WebAPIContext : DbContext
    {
        public _03_06_2025_Exercise_WebAPIContext (DbContextOptions<_03_06_2025_Exercise_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<_03_06_2025_Exercise_WebAPI.Models.Product> Product { get; set; } = default!;
    }
}
