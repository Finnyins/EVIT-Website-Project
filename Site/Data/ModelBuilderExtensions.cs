using Website.Models;
using Microsoft.EntityFrameworkCore;
using Website.Data;
namespace Website.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Definitely Something",
                    Description = "Don't even ask me what this is supposed to be.",
                    Price = 1265274658.99m,
                    ImageName = "amazingimage.png"
                },
                new Product
                {
                    Id = 2,
                    Name = "A Copy of E.T For the Atari 2600",
                    Description = "I have no idea why anyone would bother wanting to buy this.",
                    Price = -9.99m,
                    ImageName = "et.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "A Picture of My Dog",
                    Description = "Good Boy.",
                    Price = 900.99m,
                    ImageName = "dog.png"
                },
                new Product
                {
                    Id = 4,
                    Name = "Nintendo Power Issue #47",
                    Description = "Before you ask, we do not have any other issues of Nintendo Power in stock.",
                    Price = 24.99m,
                    ImageName = "nintendopower.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Michael Jordan's Shoelace",
                    Description = "This shoelace totally belonged to Michael Jordan at one point. Trust me.",
                    Price = 999.99m,
                    ImageName = "shoelace.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "A Hershey's Chocolate Bar",
                    Description = "Yum.",
                    Price = 0.99m,
                    ImageName = "chocolate.png"
                }
            );
            return modelBuilder;
        }
    }
}