using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Polifloris.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polifloris.Models
{
    public static class DbSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                var categories = new Category[]
                {
                    new Category { CategoryName = "Miere", Description = "Renumitul aliment cu numeroase beneficii" },
                    new Category { CategoryName = "Ceara", Description = "Ingredientul folosit în numeroase locuri" },
                    new Category { CategoryName = "Propolis", Description = "Substanta rasinoasa aromata colectat de albine" }
                };

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(categories);
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            Name = "Miere de salcâm",
                            Description = "Miere de salcâm",
                            Price = 20,
                            Quantity = 500,
                            ImageUrl = "/images/miere_salcam.jpg",
                            ImageThumbnailUrl = "/images/thumbnails/miere_salcam_thn.jpg",
                            InStock = false,
                            Category = categories[0],
                        },
                        new Product
                        {
                            Name = "Ceara",
                            Description = "Ceara de albine",
                            Price = 15,
                            Quantity = 200,
                            ImageUrl = "/images/ceara.jpg",
                            ImageThumbnailUrl = "/images/thumbnails/ceara_thn.jpg",
                            InStock = true,
                            Category = categories[1],
                        },
                        new Product
                        {
                            Name = "Baton Propolis",
                            Description = "Baton din substanta rasinoasa",
                            Price = 5,
                            Quantity = 5,
                            ImageUrl = "/images/baton_propolis.jpg",
                            ImageThumbnailUrl = "/images/thumbnails/baton_propolis_thn.jpg",
                            InStock = true,
                            Category = categories[2],
                        },
                        new Product
                        {
                            Name = "Miere poliflora",
                            Description = "Miere poliflora",
                            Price = 15,
                            Quantity = 1000,
                            ImageUrl = "/images/miere_poliflora.jpg",
                            ImageThumbnailUrl = "/images/thumbnails/miere_poliflora_thn.jpg",
                            InStock = true,
                            Category = categories[0],
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
