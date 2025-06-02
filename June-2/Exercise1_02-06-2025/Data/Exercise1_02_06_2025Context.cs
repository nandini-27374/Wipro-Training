using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercise1_02_06_2025.Models;

namespace Exercise1_02_06_2025.Data
{
    public class Exercise1_02_06_2025Context : DbContext
    {
        public Exercise1_02_06_2025Context (DbContextOptions<Exercise1_02_06_2025Context> options)
            : base(options)
        {
        }

        public DbSet<Exercise1_02_06_2025.Models.Employee> Employee { get; set; } = default!;
    }
}
