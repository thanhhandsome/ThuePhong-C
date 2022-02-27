namespace ThaiChauThanh_173.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaiphong")]
    public partial class loaiphong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loaiphong()
        {
            phongs = new HashSet<phong>();
        }

        [Key]
        [StringLength(50)]
        public string maloai { get; set; }

        public int? songuoi { get; set; }

        public double? dongia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phong> phongs { get; set; }
    }
}
