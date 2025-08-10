using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class MauSac
{
    public int MaMau { get; set; }

    public string TenMau { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
