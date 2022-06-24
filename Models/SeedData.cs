using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
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
                        Visited = DateTime.Parse("toronto"),
                        Location = "2022-1-3",
                        Type = "Building"
                    },
                    new photography
                    {
                        Name = "Chevrolet Corvette",
                        Visited = DateTime.Parse("2022-4-15"),
                        Location = "Mississuga",
                        Type = "Car"
                    },
                    new photography
                    {
                        Name = "Sun Rise",
                        Visited = DateTime.Parse("2021-6-12"),
                        Location = "Punjab",
                        Type = "Landscape"
                    },
                    new photography
                    {
                        Name = "Snow Fall",
                        Visited = DateTime.Parse("2022-1-4"),
                        Location = "Brampton",
                        Type = "Potrait"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}