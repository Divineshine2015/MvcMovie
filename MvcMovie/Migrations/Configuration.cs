namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MvcMovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MvcMovieContext";
        }

        protected override void Seed(MvcMovie.Models.MvcMovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(i => i.Title, 
                new Movie
            {
                Title = "Migration Test Seed",
                ReleaseDate = DateTime.Parse("2014-1-11"),
                Genre = "MvcMovie MigrationTest",
                Rating="PG",
                Price = 0.01M
            },
             new Movie
            {
                Title = "2 Migration Test Seed",
                ReleaseDate = DateTime.Parse("2014-1-11"),
                Genre = "MvcMovie MigrationTest",
                Rating = "PG-13",
                Price = 0.01M
            },

             new Movie
            {
                Title = "3 Migration Test Seed",
                ReleaseDate = DateTime.Parse("2014-1-11"),
                Genre = "MvcMovie MigrationTest",
                Rating = "R",
                Price = 0.01M
            }
            
            );
        }
    }
}
