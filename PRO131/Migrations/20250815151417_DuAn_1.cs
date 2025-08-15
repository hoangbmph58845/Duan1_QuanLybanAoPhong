using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRO131.Migrations
{
    /// <inheritdoc />
    public partial class DuAn_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__27258E76FF785957", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    MaHangSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HangSanX__8C6D28FE2283B8AB", x => x.MaHangSX);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__2725CF1E61085AAD", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    MaSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KichThuoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KichCo__A787E7ED651B8863", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiSanP__730A57592AA95BF1", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    MaMau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MauSac__3A5BBB7DDC923CFF", x => x.MaMau);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    MaCV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__2725D70A9E4C081B", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK__NhanVien__MaCV__48CFD27E",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaHangSX = table.Column<int>(type: "int", nullable: false),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__2725081C16443D9B", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK__SanPham__MaHangS__5629CD9C",
                        column: x => x.MaHangSX,
                        principalTable: "HangSanXuat",
                        principalColumn: "MaHangSX");
                    table.ForeignKey(
                        name: "FK__SanPham__MaLoai__571DF1D5",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSanPham",
                        principalColumn: "MaLoai");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    NgayBan = table.Column<DateOnly>(type: "date", nullable: false),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__2725A6E0586855FA", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK__HoaDon__MaKH__656C112C",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK__HoaDon__MaNV__6477ECF3",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    TenDangNhap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TaiKhoan__27250070984E880E", x => x.MaTK);
                    table.ForeignKey(
                        name: "FK__TaiKhoan__MaNV__4D94879B",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet",
                columns: table => new
                {
                    MaSPCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSize = table.Column<int>(type: "int", nullable: false),
                    MaMau = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPhamC__9ED62547551A29C8", x => x.MaSPCT);
                    table.ForeignKey(
                        name: "FK__SanPhamCh__MaMau__5FB337D6",
                        column: x => x.MaMau,
                        principalTable: "MauSac",
                        principalColumn: "MaMau");
                    table.ForeignKey(
                        name: "FK__SanPhamCh__MaSiz__5EBF139D",
                        column: x => x.MaSize,
                        principalTable: "KichCo",
                        principalColumn: "MaSize");
                    table.ForeignKey(
                        name: "FK__SanPhamChi__MaSP__5DCAEF64",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHDCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSPCT = table.Column<int>(type: "int", nullable: false),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDonCh__1419C129D1FA11E9", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK__HoaDonChiT__MaHD__6B24EA82",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__HoaDonChi__MaSPC__6A30C649",
                        column: x => x.MaSPCT,
                        principalTable: "SanPhamChiTiet",
                        principalColumn: "MaSPCT");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__ChucVu__A7E2123EAF5212F9",
                table: "ChucVu",
                column: "TenChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__HangSanX__FC53413B6B59E892",
                table: "HangSanXuat",
                column: "TenHangSanXuat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NgayBan",
                table: "HoaDon",
                column: "NgayBan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaHD",
                table: "HoaDonChiTiet",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSPCT",
                table: "HoaDonChiTiet",
                column: "MaSPCT");

            migrationBuilder.CreateIndex(
                name: "UQ__KhachHan__0389B7BD36D4066C",
                table: "KhachHang",
                column: "SoDienThoai",
                unique: true,
                filter: "[SoDienThoai] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__LoaiSanP__E29B1042CE671788",
                table: "LoaiSanPham",
                column: "TenLoai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaCV",
                table: "NhanVien",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "UQ__NhanVien__0389B7BDB25EE620",
                table: "NhanVien",
                column: "SoDienThoai",
                unique: true,
                filter: "[SoDienThoai] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaHangSX",
                table: "SanPham",
                column: "MaHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPham",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_Ten",
                table: "SanPham",
                column: "TenSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_MaMau",
                table: "SanPhamChiTiet",
                column: "MaMau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_MaSize",
                table: "SanPhamChiTiet",
                column: "MaSize");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_MaSP",
                table: "SanPhamChiTiet",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaNV",
                table: "TaiKhoan",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "UQ__TaiKhoan__55F68FC046B0C3C0",
                table: "TaiKhoan",
                column: "TenDangNhap",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "HangSanXuat");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");
        }
    }
}
