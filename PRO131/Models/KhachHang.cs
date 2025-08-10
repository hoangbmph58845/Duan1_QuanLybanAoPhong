using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class KhachHang
{
    public int MaKh { get; set; }

    public string TenKhachHang { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
