  using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PRO131.Models;

namespace PRO131.DataContext;

public partial class DuAn1Context : DbContext
{
    public DuAn1Context()
    {
    }

    public DuAn1Context(DbContextOptions<DuAn1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=GNAS\\SQLEXPRESS;Database=DuAn_1;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E76FF785957");
             
            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.TenChucVu, "UQ__ChucVu__A7E2123EAF5212F9").IsUnique();

            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.TenChucVu).HasMaxLength(50);
        });

        modelBuilder.Entity<HangSanXuat>(entity =>
        {
            entity.HasKey(e => e.MaHangSx).HasName("PK__HangSanX__8C6D28FE2283B8AB");

            entity.ToTable("HangSanXuat");

            entity.HasIndex(e => e.TenHangSanXuat, "UQ__HangSanX__FC53413B6B59E892").IsUnique();

            entity.Property(e => e.MaHangSx).HasColumnName("MaHangSX");
            entity.Property(e => e.QuocGia).HasMaxLength(50);
            entity.Property(e => e.TenHangSanXuat).HasMaxLength(100);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0586855FA");

            entity.ToTable("HoaDon");

            entity.HasIndex(e => e.NgayBan, "IX_HoaDon_NgayBan");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.PhuongThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaKH__656C112C");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaNV__6477ECF3");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C129D1FA11E9");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.MaHdct).HasColumnName("MaHDCT");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaSpct).HasColumnName("MaSPCT");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHd)
                .HasConstraintName("FK__HoaDonChiT__MaHD__6B24EA82");

            entity.HasOne(d => d.MaSpctNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaSpct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaSPC__6A30C649");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E61085AAD");

            entity.ToTable("KhachHang");

            entity.HasIndex(e => e.SoDienThoai, "UQ__KhachHan__0389B7BD36D4066C").IsUnique();

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__KichCo__A787E7ED651B8863");

            entity.ToTable("KichCo");

            entity.Property(e => e.KichThuoc).HasMaxLength(10);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LoaiSanP__730A57592AA95BF1");

            entity.ToTable("LoaiSanPham");

            entity.HasIndex(e => e.TenLoai, "UQ__LoaiSanP__E29B1042CE671788").IsUnique();

            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7DDC923CFF");

            entity.ToTable("MauSac");

            entity.Property(e => e.TenMau).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A9E4C081B");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.SoDienThoai, "UQ__NhanVien__0389B7BDB25EE620").IsUnique();

            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(100);

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaCv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__MaCV__48CFD27E");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C16443D9B");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.TenSanPham, "IX_SanPham_Ten");

            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.MaHangSx).HasColumnName("MaHangSX");
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.MaHangSxNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaHangSx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MaHangS__5629CD9C");

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MaLoai__571DF1D5");
        });

        modelBuilder.Entity<SanPhamChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaSpct).HasName("PK__SanPhamC__9ED62547551A29C8");

            entity.ToTable("SanPhamChiTiet");

            entity.Property(e => e.MaSpct).HasColumnName("MaSPCT");
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiaNhap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.SanPhamChiTiets)
                .HasForeignKey(d => d.MaMau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPhamCh__MaMau__5FB337D6");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.SanPhamChiTiets)
                .HasForeignKey(d => d.MaSize)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPhamCh__MaSiz__5EBF139D");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.SanPhamChiTiets)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__SanPhamChi__MaSP__5DCAEF64");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TaiKhoan__27250070984E880E");

            entity.ToTable("TaiKhoan");

            entity.HasIndex(e => e.TenDangNhap, "UQ__TaiKhoan__55F68FC046B0C3C0").IsUnique();

            entity.Property(e => e.MaTk).HasColumnName("MaTK");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__TaiKhoan__MaNV__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
