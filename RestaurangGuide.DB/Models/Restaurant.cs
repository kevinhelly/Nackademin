namespace RestaurangGuide.DB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restaurant")]
    public partial class Restaurant
    {
        public Restaurant()
        {
            Orders = new HashSet<Order>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string RestaurantName { get; set; }

        public string Description { get; set; }

        [StringLength(20)]
        public string Address { get; set; }

        public int? ZipCode { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Commune { get; set; }

        public int? NumberOfSeats { get; set; }

        public int? Capacity { get; set; }

        public int? TotalGuests { get; set; }

        public string Image { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
