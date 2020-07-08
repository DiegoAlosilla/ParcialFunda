namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medico")]
    public partial class Medico
    {
        [Key]
        [StringLength(8)]
        public string DNI { get; set; }

        [Column("Nombre completo")]
        [StringLength(50)]
        public string Nombre_completo { get; set; }

        [Column("Numero de colegiatura")]
        public int? Numero_de_colegiatura { get; set; }

        [Column("Fecha de nacimiento")]
        public int? Fecha_de_nacimiento { get; set; }

        [StringLength(9)]
        public string Sexo { get; set; }

        [StringLength(2)]
        public string Embarazada { get; set; }

        [StringLength(30)]
        public string Especialidad { get; set; }
    }
}
