namespace ClassLibrary1.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBinhLuan1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBL { get; set; }

        public int? MaSan { get; set; }

        public int? MaKH { get; set; }

        public int? MaTV { get; set; }

        [Required]
        [StringLength(350)]
        public string NoiDung { get; set; }

        public virtual tblSan1 tblSan1 { get; set; }

        public virtual tblkhachhang1 tblkhachhang1 { get; set; }

        public virtual tblThanhVien tblThanhVien { get; set; }
    }
}
