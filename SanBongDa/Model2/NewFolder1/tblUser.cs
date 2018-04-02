namespace Model2.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUser")]
    public partial class tblUser
    {
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
    }
}
