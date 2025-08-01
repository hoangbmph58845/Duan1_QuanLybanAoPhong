using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class HoaDonChiTiet
{
    public int MaHdct { get; set; }

    public int MaSpct { get; set; }

    public int MaHd { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPhamChiTiet MaSpctNavigation { get; set; } = null!;
}
