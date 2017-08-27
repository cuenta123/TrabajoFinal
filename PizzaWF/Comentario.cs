namespace Pizzeria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comentario")]
    public partial class Comentario
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Texto { get; set; }

        public int Puntuacion { get; set; }

        public DateTime Fecha { get; set; }

        public Guid Usuario { get; set; }

        public Guid Pizza { get; set; }

        public virtual Pizza Pizza1 { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}
