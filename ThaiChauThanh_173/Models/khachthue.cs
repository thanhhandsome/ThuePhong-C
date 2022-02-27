namespace ThaiChauThanh_173.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachthue")]
    public partial class khachthue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khachthue()
        {
            phieuthues = new HashSet<phieuthue>();
        }

        [Key]
        [StringLength(50)]
        public string makh { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        [StringLength(50)]
        public string socmnd { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieuthue> phieuthues { get; set; }
    }
}
