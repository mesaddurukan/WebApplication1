using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BM4D6CF; database=corepersonel; integrated security=true;");
        }
        public DbSet<departmanlar> Departmanlars { get; set; }

        public DbSet<personel> Personels { get; set; }

    }
}
