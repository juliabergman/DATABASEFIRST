using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains
{
    public partial class InLockContext : DbContext
    {
        public InLockContext()
        {
        }

        public InLockContext(DbContextOptions<InLockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EstudiosDomain> Estudios { get; set; }
        public virtual DbSet<JogosDomain> Jogos { get; set; }
        public virtual DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }
        public virtual DbSet<UsuariosDomain> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=N-1S-DEV-17\\SQLEXPRESS; initial catalog=InLock_Games_Tarde; User Id=sa;Password=sa@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudiosDomain>(entity =>
            {
                entity.HasKey(e => e.IdEstudio);

                entity.Property(e => e.NomeEstudio)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JogosDomain>(entity =>
            {
                entity.HasKey(e => e.IdJogo);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NomeJogo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstudioNavigation)
                    .WithMany(p => p.Jogos)
                    .HasForeignKey(d => d.IdEstudio)
                    .HasConstraintName("FK__Jogos__IdEstudio__3E52440B");
            });

            modelBuilder.Entity<TiposUsuarioDomain>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosDomain>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__398D8EEE");
            });
        }
    }
}
