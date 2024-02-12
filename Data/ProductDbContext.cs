using Microsoft.EntityFrameworkCore;
using PracticeProject1.Models;

namespace PracticeProject1.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base(options)
        {

        }
        public DbSet<Product>Laptops { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Product>().HasData(
            
                new Product {LaptopId=201,LaptopName="HP",LaptopDescription= "12th Generation Intel® Core™ i3 processor\r\nFreeDOS 3.0\r\n(15.6) 39.62 cm diagonal, HD anti-glare display with Intel® Iris® Xᵉ Graphics\r\n8 GB DDR4-3200 MHz RAM (1 x 8 GB)",LaptopRate=48000 }

            );
        }
    }
}
