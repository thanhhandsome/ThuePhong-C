namespace ThaiChauThanh_173.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phieuthue")]
    public partial class phieuthue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phieuthue()
        {
            chitietphieuthues = new HashSet<chitietphieuthue>();
        }

        [Key]
        [StringLength(50)]
        public string sopt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaythue { get; set; }

        [StringLength(50)]
        public string makh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphieuthue> chitietphieuthues { get; set; }

        public virtual khachthue khachthue { get; set; }
    }
}
