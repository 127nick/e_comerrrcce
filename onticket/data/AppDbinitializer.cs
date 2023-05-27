using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using onticket.Models;

namespace onticket.data
{
    public class AppDbinitializer
    {
        public class AppDbContext : IdentityDbContext<ApplicationUser>
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Actor_Movie>().HasKey(am => new
                {
                    am.ActorId,
                    am.MovieId
                });

                modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
                modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


                base.OnModelCreating(modelBuilder);
            }
        }
