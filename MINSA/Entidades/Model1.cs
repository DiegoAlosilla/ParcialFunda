namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=dbMinsa")
        {
        }

        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hospital>()
                .Property(e => e.Numero_de_Identificacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Distrito)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.presupuesto_anual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medico>()
                .Property(e => e.DNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Nombre_completo)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Embarazada)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);
        }
    }
}
