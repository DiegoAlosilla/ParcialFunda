namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        [Key]
        [Column("Numero de Identificacion")]
        [StringLength(6)]
        public string Numero_de_Identificacion { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Distrito { get; set; }

        [Column("Cantidad de camas")]
        public int? Cantidad_de_camas { get; set; }

        [Column("presupuesto anual", TypeName = "money")]
        public decimal? presupuesto_anual { get; set; }
    }
}
