using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cif_Andreea_Lab8.Models;

namespace Cif_Andreea_Lab8.Data
{
    public class Cif_Andreea_Lab8Context : DbContext
    {
        public Cif_Andreea_Lab8Context (DbContextOptions<Cif_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cif_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cif_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cif_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
