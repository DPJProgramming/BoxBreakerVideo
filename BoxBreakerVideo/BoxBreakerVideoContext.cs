using System;
using System.Collections.Generic;
using BoxBreakerVideo.Models;
using Microsoft.EntityFrameworkCore;

namespace BoxBreakerVideo;

public partial class BoxBreakerVideoContext : DbContext
{
    public BoxBreakerVideoContext()
    {
    }

    public BoxBreakerVideoContext(DbContextOptions<BoxBreakerVideoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberMovie> MemberMovies { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDb;Initial Catalog = BoxBreakerVideo");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Members__0CF04B18E3BA3C88");

            entity.HasIndex(e => e.MemberEmail, "UQ__Members__3F37B77ADB487270").IsUnique();

            entity.HasIndex(e => e.MemberPhone, "UQ__Members__8B704E8BF8615F45").IsUnique();

            entity.HasIndex(e => e.MemberAddress, "UQ__Members__9FE4ACC3F5C92740").IsUnique();

            entity.Property(e => e.MemberAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MemberEmail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MemberFname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MemberFName");
            entity.Property(e => e.MemberLname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MemberLName");
            entity.Property(e => e.MemberPassword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MemberPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MemberMovie>(entity =>
        {
            entity.HasKey(e => new { e.MovieId, e.MemberId }).HasName("PK__MemberMo__DB1D90AB51A88CB5");

            entity.Property(e => e.CheckoutDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("date");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberMovies)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberMov__Membe__2C3393D0");

            entity.HasOne(d => d.Movie).WithMany(p => p.MemberMovies)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberMov__Movie__2B3F6F97");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movie__4BD2941ABBE7F478");

            entity.ToTable("Movie");

            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaturityRating)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovieDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MoviePoster)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MoviePrice).HasColumnType("smallmoney");
            entity.Property(e => e.MovieRuntime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
