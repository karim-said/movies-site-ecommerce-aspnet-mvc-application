using Microsoft.EntityFrameworkCore;
using MoveisSite.Models;

namespace MoveisSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.ActorId);

            //Actor
            modelBuilder.Entity<Actor>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Actor>()
                .Property(e => e.ProfilePictureURL)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Actor>()
                .Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(true);
            modelBuilder.Entity<Actor>()
                .Property(e => e.Bio)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);

            //Cinema
            modelBuilder.Entity<Cinema>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Logo)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(true);
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);

            //Movie
            modelBuilder.Entity<Movie>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(true);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Year)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Description)
                .IsRequired(false)
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Movie>()
                .Property(e => e.Price)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(e => e.ImageURL)
                .IsRequired(false)
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Movie>()
                .Property(e => e.StartDate)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(e => e.EndDate)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieCategory)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(e => e.CinemaId)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(e => e.ProducerId)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .HasOne(e => e.Cinema)
                .WithMany(e => e.Movies)
                .HasForeignKey(e => e.CinemaId)
                .HasPrincipalKey(e => e.Id);
            modelBuilder.Entity<Movie>()
                .HasOne(e => e.Producer)
                .WithMany(e => e.Movies)
                .HasForeignKey(e => e.ProducerId)
                .HasPrincipalKey(e => e.Id);

            //Producer
            modelBuilder.Entity<Producer>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Producer>()
                .Property(e => e.ProfilePictureURL)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);
            modelBuilder.Entity<Producer>()
                .Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(true);
            modelBuilder.Entity<Producer>()
                .Property(e => e.Bio)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(true);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
