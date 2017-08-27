namespace Pizzeria
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MydbContex : DbContext
    {
        public MydbContex()
            : base("name=MydbContex")
        {
        }

        public virtual DbSet<Comentario> Comentario { get; set; }
        public virtual DbSet<Ingrediente> Ingrediente { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentario>()
                .Property(e => e.Texto)
                .IsFixedLength();

            modelBuilder.Entity<Ingrediente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ingrediente>()
                .Property(e => e.Precio)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Ingredientes)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Precio)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Pizza>()
                .HasMany(e => e.Comentario1)
                .WithRequired(e => e.Pizza1)
                .HasForeignKey(e => e.Pizza)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Comentario)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
