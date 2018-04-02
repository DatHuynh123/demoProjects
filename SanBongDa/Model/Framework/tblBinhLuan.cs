namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBinhLuan")]
    public partial class tblBinhLuan
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

        public virtual tblSan tblSan { get; set; }

        public virtual tblkhachhang tblkhachhang { get; set; }

        public virtual tblThanhVien tblThanhVien { get; set; }
    }
}
