namespace ClassLibrary1.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUser")]
    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            tblkhachhangs = new HashSet<tblkhachhang>();
            tblkhachhang1 = new HashSet<tblkhachhang1>();
            tblNhanViens = new HashSet<tblNhanVien>();
            tblThanhViens = new HashSet<tblThanhVien>();
            tblThanhVien1 = new HashSet<tblThanhVien1>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(20)]
        public string PW { get; set; }

        public DateTime NgayTao { get; set; }

        public int MaQH { get; set; }

        [Required]
        [StringLength(50)]
        public string TT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblkhachhang> tblkhachhangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblkhachhang1> tblkhachhang1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanVien> tblNhanViens { get; set; }

        public virtual tblQuyenHan tblQuyenHan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThanhVien> tblThanhViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThanhVien1> tblThanhVien1 { get; set; }
    }
}
