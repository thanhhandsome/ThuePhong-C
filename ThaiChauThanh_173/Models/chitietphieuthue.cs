namespace ThaiChauThanh_173.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chitietphieuthue")]
    public partial class chitietphieuthue
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string sopt { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string maphong { get; set; }

        public double? dongia { get; set; }

        public int? songaythue { get; set; }

        public virtual phieuthue phieuthue { get; set; }

        public virtual phong phong { get; set; }
    }
}
