using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcVetement.Data;
using System;
using System.Linq;

namespace MvcVetement.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcVetementContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcVetementContext>>()))
            {
                // Look for any movies.
                if (context.Vetement.Any())
                {
                    return;   // DB has been seeded
                }

                context.Vetement.AddRange(
                    new Vetement
                    {
                        Title = "Marinière",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Homme",
                        Rating = "R",
                        Price = 24.99M
                    },

                    new Vetement
                    {
                        Title = "Jeans ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Mixte",
                        Rating = "R",
                        Price = 40M
                    },

                    new Vetement
                    {
                        Title = "Robe 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Femme",
                        Rating = "R",
                        Price = 200M
                    },

                    new Vetement
                    {
                        Title = "Foulard",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Mixte",
                        Rating = "R",
                        Price = 10M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
