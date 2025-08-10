using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class NhanVien
{
    public int MaNv { get; set; }

    public string TenNhanVien { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public bool TrangThai { get; set; }

    public int MaCv { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ChucVu MaCvNavigation { get; set; } = null!;

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
