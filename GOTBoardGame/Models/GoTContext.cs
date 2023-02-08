using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GOTBoardGame.Models;

public partial class GoTContext : DbContext
{
    public GoTContext()
    {
    }

    public GoTContext(DbContextOptions<GoTContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Card> Cards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=projbbsql.database.windows.net; Initial Catalog=GoT;Trusted_Connection=True; TrustServerCertificate=True; user id=BBunchL; password=x7TWC4e968bcb; Integrated Security=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.CardId).HasName("PK__Cards__55FECD8E2CF2941B");

            entity.Property(e => e.CardId).HasColumnName("CardID");
            entity.Property(e => e.AbilityDescription).HasMaxLength(1000);
            entity.Property(e => e.CharacterName).HasMaxLength(40);
            entity.Property(e => e.House).HasMaxLength(30);
            entity.Property(e => e.Quote).HasMaxLength(1000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
