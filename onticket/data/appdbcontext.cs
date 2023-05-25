using Microsoft.EntityFrameworkCore;
using onticket.@enum;
using onticket.Models;

namespace onticket.data
{
    public class appdbcontext:DbContext
    {
        public appdbcontext(DbContextOptions<appdbcontext>options):base(options)
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actor_movie>().HasKey(am => new
            {
                am.Actorid,
                am.movieid

            });


            modelBuilder.Entity<actor_movie>().HasOne(m => m.movie).WithMany(am => am.actor_Movies).HasForeignKey(M => M.movieid);


            modelBuilder.Entity<actor_movie>().HasOne(m => m.actor).WithMany(am => am.actors_movie).HasForeignKey(M => M.Actorid);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<actor> actors { get; set; }
        public DbSet<actor_movie> actor_movies { get;}

        public DbSet<Cinema>cinemas { get; set; }

        public DbSet<Movie> movies { get; set; }

        public DbSet<Produser> produsers { get; set; }
    }

}
