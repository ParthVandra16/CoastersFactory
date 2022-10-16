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

                    // Add 10 data of CoastersFactory 

                    new Coasters
                    {
                        BrandName = "Jeam Beam",
                        Material = "Rubber",
                        Color = "Black",
                        Size = "Medium",
                        Shape = "Circle",
                        Price = 550,
                        ReleaseDate = DateTime.Parse("2021-1-29"),
                        Rating = 5

                    },

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
                        BrandName = "BMW",
                        Material = "Rubber",
                        Color = "Blue",
                        Size = "Small",
                        Shape = "Square",
                        Price = 250,
                        ReleaseDate = DateTime.Parse("2008-10-25"),
                        Rating = 4
                    },

                    new Coasters
                    {
                        BrandName = "Gap",
                        Material = "Plastic",
                        Color = "Yellow",
                        Size = "Medium",
                        Shape = "Circle",
                        Price = 900,
                        ReleaseDate = DateTime.Parse("1998-5-1"),
                        Rating = 4
                    },

                    new Coasters
                    {
                        BrandName = "JP",
                        Material = "Wooden",
                        Color = "Teal",
                        Size = "Small",
                        Shape = "Triangle",
                        Price = 100,
                        ReleaseDate = DateTime.Parse("2004-1-3"),
                        Rating = 3
                    },

                    new Coasters
                    {
                        BrandName = "Nike",
                        Material = "Wooden",
                        Color = "White",
                        Size = "Small",
                        Shape = "Triangle",
                        Price = 350,
                        ReleaseDate = DateTime.Parse("2005-10-30"),
                        Rating = 4
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
