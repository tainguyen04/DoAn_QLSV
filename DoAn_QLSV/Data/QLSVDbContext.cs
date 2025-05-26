using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DoAn_QLSV.Data
{
    public class QLSVDbContext : DbContext
    {
        public DbSet<ThongTinSinhVien> ThongTinSinhVien {  get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<DiemHocTap> DiemHocTap { get; set; }
        public DbSet<DiemRenLuyen> DiemRenLuyen { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<HocKy> HocKy { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Lop>()
        //        .HasOne(l => l.Khoa)
        //        .WithMany(k => k.Lop)
        //        .HasForeignKey(l => l.maKhoa)
        //        .OnDelete(DeleteBehavior.Restrict); // hoặc DeleteBehavior.NoAction

        //    modelBuilder.Entity<ThongTinSinhVien>()
        //        .HasOne(sv => sv.Lop)
        //        .WithMany(l => l.SinhVien)
        //        .HasForeignKey(sv => sv.lopID)
        //        .OnDelete(DeleteBehavior.Cascade); // Hoặc tùy bạn chọn
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLSVConnection"].ConnectionString);
        }
        



    }
}
