namespace WpfApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingrediente")]
    public partial class Ingrediente
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
    }
}
