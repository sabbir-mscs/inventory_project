using InventoryManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Core.Context
{
   public class InventoryDbContext:DbContext
    {

        public   InventoryDbContext(DbContextOptions<InventoryDbContext>options):base(options)
        {
            
        }
        public  DbSet<Product> Products { get; set; }
    }
}
