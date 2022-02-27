namespace ThaiChauThanh_173.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phong")]
    public partial class phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phong()
        {
            chitietphieuthues = new HashSet<chitietphieuthue>();
        }

        [Key]
        [StringLength(50)]
        public string maphong { get; set; }

        public int? tinhtrang { get; set; }

        [StringLength(50)]
        public string maloai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphieuthue> chitietphieuthues { get; set; }

        public virtual loaiphong loaiphong { get; set; }
    }
}
