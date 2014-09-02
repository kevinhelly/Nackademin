namespace RestaurangGuide.DB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rating
    {
        public int Id { get; set; }

        public int RestaurangId { get; set; }

        [Column("Rating")]
        public decimal Rating1 { get; set; }

        public string Review { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
