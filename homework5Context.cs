using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using homework5.Models;

namespace homework5.Data
{
    public class homework5Context : DbContext
    {
        public homework5Context (DbContextOptions<homework5Context> options)
            : base(options)
        {
        }

        public DbSet<homework5.Models.Cart> Cart { get; set; } = default!;
    }
}
