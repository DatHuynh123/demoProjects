namespace Model2.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SBDDBConText : DbContext
    {
        public SBDDBConText()
            : base("name=SBDDBConText")
        {
        }

        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUser>()
                .Property(e => e.PW)
                .IsUnicode(false);
        }
    }
}
