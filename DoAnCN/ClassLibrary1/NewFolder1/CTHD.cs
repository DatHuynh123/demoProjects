namespace ClassLibrary1.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        public int? MaHD { get; set; }

        public int? MaSan { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal GiaSan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Soluong { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ThanhTien { get; set; }

        public virtual tblHoaDon tblHoaDon { get; set; }

        public virtual tblSan1 tblSan1 { get; set; }
    }
}
