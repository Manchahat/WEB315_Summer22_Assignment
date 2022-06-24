using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WEB315_Summer22_Assignment.Models;
using System;
using System.Linq;


namespace WEB315_Summer22_Assignment.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WEB315_Summer22_AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WEB315_Summer22_AssignmentContext>>()))
            {
                // Look for any movies.
                if (context.photography.Any())
                {
                    return;   // DB has been seeded
                }

                context.photography.AddRange(
                    new photography
                    {
                        Name = "CN Tower",
                        Visited = DateTime.Parse("2022-1-3"),
                        Location = "Toronto",
                        Type = "Building",
                        Rating = "A"
                    },
                    new photography
                    {
                        Name = "Chevrolet Corvette",
                        Visited = DateTime.Parse("2022-4-15"),
                        Location = "Mississuga",
                        Type = "Car",
                        Rating = "C"                        
                    },
                    new photography
                    {
                        Name = "Sun Rise",
                        Visited = DateTime.Parse("2021-6-12"),
                        Location = "Punjab",
                        Type = "Landscape",
                        Rating = "B"  
                    },
                    new photography
                    {
                        Name = "Snow Fall",
                        Visited = DateTime.Parse("2022-1-4"),
                        Location = "Brampton",
                        Type = "Potrait",
                        Rating="A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}