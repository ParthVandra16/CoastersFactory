using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoastersFactory.Data;


namespace CoastersFactory.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CoastersFactoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CoastersFactoryContext>>()))
            {
                // Look for any movies.
                if (context.Coasters.Any())
                {
                    return;   // DB has been seeded
                }

                context.Coasters.AddRange(
                    new Coasters
                    {
                        BrandName = "Adidas",
                        Material = "Rubber",
                        Color = "Black",
                        Size = "Medium",
                        Shape = "Circle",
                        Price = 700,
                        ReleaseDate = DateTime.Parse("1999-2-12"),
                        Rating = 5
                    },

                    new Coasters
                    {
                        BrandName = "Puma",
                        Material = "Metal",
                        Color = "Red",
                        Size = "Small",
                        Shape = "Square",
                        Price = 250,
                        ReleaseDate = DateTime.Parse("1989-5-20"),
                        Rating = 4

                    },

                    new Coasters
                    {
                        BrandName = "Levis",
                        Material = "Wooden",
                        Color = "Brown",
                        Size = "Small",
                        Shape = "Triangle",
                        Price = 200,
                        ReleaseDate = DateTime.Parse("2020-1-23"),
                        Rating = 2
                    },

                    new Coasters
                    {
                        BrandName = "UnderArmour",
                        Material = "Gold",
                        Color = "Gold",
                        Size = "Large",
                        Shape = "Circle",
                        Price = 2500,
                        ReleaseDate = DateTime.Parse("2022-8-16"),
                        Rating = 3
                    },

                    new Coasters
                    {
                        BrandName = "Guess",
                        Material = "Aluminium",
                        Color = "Blue",
                        Size = "Medium",
                        Shape = "Pantagon",
                        Price = 150,
                        ReleaseDate = DateTime.Parse("2012-11-30"),
                        Rating = 1
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
