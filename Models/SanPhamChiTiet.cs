using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class SanPhamChiTiet
{
    //internal readonly object TenSanPham;

    public int MaSpct { get; set; }

    public int MaSp { get; set; }
    public string TenSanPham { get; set; }

    public int MaSize { get; set; }

    public int MaMau { get; set; }

    public int SoLuong { get; set; }

    public decimal GiaNhap { get; set; }

    public decimal GiaBan { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual MauSac MaMauNavigation { get; set; } = null!;

    public virtual KichCo MaSizeNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
