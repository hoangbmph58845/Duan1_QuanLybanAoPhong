using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class KichCo
{
    public int MaSize { get; set; }

    public string KichThuoc { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
