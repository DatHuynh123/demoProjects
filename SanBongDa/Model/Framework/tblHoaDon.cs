namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHoaDon")]
    public partial class tblHoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHoaDon()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public int MaSan { get; set; }

        public int MaTV { get; set; }

        public int MaNV { get; set; }

        public DateTime NgayDa { get; set; }

        [Required]
        [StringLength(50)]
        public string DichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual tblNhanVien tblNhanVien { get; set; }

        public virtual tblSan tblSan { get; set; }

        public virtual tblThanhVien tblThanhVien { get; set; }
    }
}
