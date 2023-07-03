using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Data;

public partial class MovieDbContext : IdentityDbContext
{
    public MovieDbContext()
    {
    }

    // Get key and IV from a Base64String or any other ways.
    // You can generate a key and IV using "AesProvider.GenerateKey()"
    private static string aesBase64Key = "XqvEf6FSdD6qyTHxUesINughNiFe+kZi3xfe2LeVURw=";
    private static string ivBase64Key = "PJU7zdaaos45xrCQ9j3Lhg==";
    private readonly byte[] _encryptionKey = Convert.FromBase64String(aesBase64Key);
    private readonly byte[] _encryptionIV = Convert.FromBase64String(ivBase64Key);
    private readonly IEncryptionProvider _provider;

    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options)
    {
        _provider = new AesProvider(_encryptionKey, _encryptionIV);
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Cinema> Cinemas { get; set; }

    public virtual DbSet<CinemaOffer> CinemaOffers { get; set; }

    public virtual DbSet<Comments> Comments { get; set; }

    public virtual DbSet<Critics> Critics { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Function> Functions { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<RoomCinema> CinemaRooms { get; set; }

    public virtual DbSet<RoomCinemaLocation> RoomLocations { get; set; }

    public virtual new DbSet<User> Users { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ActorMovie> ActorMovie { get; set; }

    public virtual DbSet<Role> Roles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //Configure the value converter for the encripted property
        modelBuilder.UseEncryption(_provider);

        modelBuilder.Entity<Actor>(entity =>
        {
            entity.Property(e => e.Biography).HasMaxLength(2000);
            entity.Property(e => e.UrlPhoto).HasColumnName("UrlPhoto");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Cinema>(entity =>
        {
            entity.HasIndex(e => e.MovieId, "IX_Cinemas_MovieId");

            entity.HasOne(d => d.Movie).WithMany(p => p.Cinemas).HasForeignKey(d => d.MovieId);
        });

        modelBuilder.Entity<CinemaOffer>(entity =>
        {
            entity.HasIndex(e => e.CinemaId, "IX_CinemaOffers_CinemaId");

            entity.Property(e => e.Discount).HasColumnType("decimal(2, 2)");

            entity.HasOne(d => d.Cinema).WithMany(p => p.CinemaOffer).HasForeignKey(d => d.CinemaId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.IdentificationNumber).HasColumnName("IdentificationNumber");
            entity.HasKey(e => e.Id);
            //entity.HasAlternateKey(e => e.UserName);
            //entity.HasAlternateKey(e => e.Email);
        });

        modelBuilder.Entity<Comments>(entity =>
        {
            entity.HasIndex(e => e.MovieId, "IX_Comments_MovieId");

            entity.HasOne(d => d.Movie).WithMany(p => p.Comments).HasForeignKey(d => d.MovieId);
        });

        modelBuilder.Entity<Critics>(entity =>
        {
            entity.HasIndex(e => e.MovieId, "IX_Critics_MovieId");

            entity.HasOne(d => d.Movie).WithMany(p => p.Critics).HasForeignKey(d => d.MovieId);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.ZipCode).HasColumnName("ZipCode");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasIndex(e => e.ClientId, "IX_Tickets_ClientId");

            entity.HasIndex(e => e.FunctionId, "IX_Tickets_FunctionId");

            entity.HasIndex(e => e.RoomCinemaId, "IX_Tickets_RoomCinemaId");

            entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");
            
            entity.Property(e => e.QrcodeImage).HasColumnName("QRCodeImage");
                       
            entity.HasOne(d => d.Function).WithMany(p => p.Ticket).HasForeignKey(d => d.FunctionId);

            entity.HasOne(d => d.RoomCinema).WithMany(p => p.Ticket).HasForeignKey(d => d.RoomCinemaId);
        });

        modelBuilder.Entity<Function>(entity =>
        {
            entity.HasIndex(e => e.MovieId, "IX_Functions_MovieId");

            entity.HasOne(d => d.Movie).WithMany(p => p.Functions).HasForeignKey(d => d.MovieId);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasMany(d => d.Movies).WithMany(p => p.Genders)
                .UsingEntity<Dictionary<string, object>>(
                    "GenderMovie",
                    r => r.HasOne<Movie>().WithMany().HasForeignKey("MovieId"),
                    l => l.HasOne<Gender>().WithMany().HasForeignKey("GenderId"),
                    j =>
                    {
                        j.HasKey("GenderId", "MovieId");
                        j.ToTable("GenderMovie");
                        j.HasIndex(new[] { "MovieId" }, "IX_GenderMovie_MoviesId");
                    });
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.PosterLink)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.TrailerLink)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomCinema>(entity =>
        {
            entity.ToTable("RoomCinema");

            entity.HasIndex(e => e.CineId, "IX_RoomCinema_CinemaId");

            entity.HasOne(d => d.Cinema).WithMany(p => p.CinemaRoom).HasForeignKey(d => d.CineId);
        });

        modelBuilder.Entity<RoomCinemaLocation>(entity =>
        {
            entity.ToTable("RoomCinemaLocation");

            entity.HasIndex(e => e.RoomCinemaId, "IX_RoomCinemaLocation_RoomCinemaId");

            entity.HasOne(d => d.RoomCinema).WithMany(p => p.RoomCinemaLocations).HasForeignKey(d => d.RoomCinemaId);
        });

       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
