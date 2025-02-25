using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VykazyPrace.Models;

public partial class VykazyContext : DbContext
{
    public VykazyContext()
    {
    }

    public VykazyContext(DbContextOptions<VykazyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<ProjectArchive> ProjectArchives { get; set; }

    public virtual DbSet<Projekty> Projekties { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<Zakazky> Zakazkies { get; set; }

    public virtual DbSet<ZakazkyArchive> ZakazkyArchives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite($"Data Source={Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Database\\Vykazy.db"))}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Logs_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId).HasColumnName("ActionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ProjectArchive>(entity =>
        {
            entity.ToTable("ProjectArchive");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Projekty>(entity =>
        {
            entity.ToTable("Projekty");

            entity.HasIndex(e => e.Id, "IX_Projekty_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Records_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.OsCis);

            entity.HasIndex(e => e.OsCis, "IX_Users_OsCis").IsUnique();

            entity.Property(e => e.Loa).HasColumnName("LOA");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.ToTable("UserInfo");

            entity.HasIndex(e => e.Id, "IX_UserInfo_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Zakazky>(entity =>
        {
            entity.ToTable("Zakazky");

            entity.HasIndex(e => e.Id, "IX_Zakazky_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Autor).HasDefaultValueSql("0");
            entity.Property(e => e.CisloZakazky).HasDefaultValue(0);
            entity.Property(e => e.Nazev).HasDefaultValueSql("0");
            entity.Property(e => e.Poznamky).HasDefaultValueSql("0");
            entity.Property(e => e.TypZakazky).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ZakazkyArchive>(entity =>
        {
            entity.ToTable("ZakazkyArchive");

            entity.HasIndex(e => e.Id, "IX_ZakazkyArchive_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
