using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marc_Loredana_Lab8.Models;

namespace Marc_Loredana_Lab8.Data
{
    public class Marc_Loredana_Lab8Context : DbContext
    {
        public Marc_Loredana_Lab8Context (DbContextOptions<Marc_Loredana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marc_Loredana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marc_Loredana_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
