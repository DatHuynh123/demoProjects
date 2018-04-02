namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLoaisan")]
    public partial class tblLoaisan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TTLSP { get; set; }
    }
}
