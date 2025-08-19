using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public int MaNv { get; set; }

    public int? MaKh { get; set; }

    public DateOnly NgayBan { get; set; }

    public string? PhuongThucThanhToan { get; set; }

    public decimal TongTien { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
