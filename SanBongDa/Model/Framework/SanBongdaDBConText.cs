namespace Model.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SanBongdaDBConText : DbContext
    {
        public SanBongdaDBConText()
            : base("name=SanBongdaDBConText")
        {
        }

        public virtual DbSet<tblBinhLuan> tblBinhLuans { get; set; }
        public virtual DbSet<tblHoaDon> tblHoaDons { get; set; }
        public virtual DbSet<tblkhachhang> tblkhachhangs { get; set; }
        public virtual DbSet<tblKhuyenMai> tblKhuyenMais { get; set; }
        public virtual DbSet<tblLoaisan> tblLoaisans { get; set; }
        public virtual DbSet<tblNhacungcap> tblNhacungcaps { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblQuyenHan> tblQuyenHans { get; set; }
        public virtual DbSet<tblSan> tblSans { get; set; }
        public virtual DbSet<tblThanhVien> tblThanhViens { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblkhachhang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanVien>()
                .HasMany(e => e.tblHoaDons)
                .WithRequired(e => e.tblNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQuyenHan>()
                .HasMany(e => e.tblUsers)
                .WithRequired(e => e.tblQuyenHan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSan>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblSan>()
                .HasMany(e => e.tblHoaDons)
                .WithRequired(e => e.tblSan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblThanhVien>()
                .HasMany(e => e.tblHoaDons)
                .WithRequired(e => e.tblThanhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.PW)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblkhachhangs)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.IDKH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblNhanViens)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.IDNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblThanhViens)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.IDTV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.GiaSan)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 3);
        }
    }
}
