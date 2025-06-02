using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_02_06_2025.Models;

namespace WebAPI_02_06_2025.Data
{
    public class WebAPI_02_06_2025Context : DbContext
    {
        public WebAPI_02_06_2025Context (DbContextOptions<WebAPI_02_06_2025Context> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_02_06_2025.Models.Student> Student { get; set; } = default!;
    }
}
