using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalSalesWebMvc.Models
{
    public class ProjetoFinalSalesWebMvcContext : DbContext
    {
        public ProjetoFinalSalesWebMvcContext (DbContextOptions<ProjetoFinalSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
