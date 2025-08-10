using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string TenSanPham { get; set; } = null!;

    public int MaHangSx { get; set; }

    public int MaLoai { get; set; }

    public bool TrangThai { get; set; }

    public virtual HangSanXuat MaHangSxNavigation { get; set; } = null!;

    public virtual LoaiSanPham MaLoaiNavigation { get; set; } = null!;

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
