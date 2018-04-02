namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNhanVien")]
    public partial class tblNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhanVien()
        {
            tblHoaDons = new HashSet<tblHoaDon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Required(ErrorMessage="Bạn chưa nhập Họ")]
        [StringLength(50, ErrorMessage = "Số kí tự tối đa là 50")]
        [DisplayName("Họ")]        
        public string Ho { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Tên")]
        [StringLength(15,ErrorMessage="Số kí tự tối đa là 15")]
        [DisplayName("Tên")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập ID Nhân Viên")]
        [DisplayName("ID Nhân Viên")]
        [Range(0, Int32.MaxValue, ErrorMessage = ("Bạn phải nhập số"))]
        public int IDNV { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Địa chỉ")]
        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Số điện thoại")]
        [StringLength(11)]
        [DisplayName("Số điện thoại")]
        [Range(0,Int32.MaxValue,ErrorMessage=("Bạn phải nhập số"))]
        public string SDT { get; set; }        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHoaDon> tblHoaDons { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
