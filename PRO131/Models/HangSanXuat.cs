using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class HangSanXuat
{
    public int MaHangSx { get; set; }

    public string TenHangSanXuat { get; set; } = null!;

    public string? QuocGia { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
