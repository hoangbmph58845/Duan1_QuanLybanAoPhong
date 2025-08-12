using System;
using System.Collections.Generic;

namespace PRO131.Models;

public partial class ChucVu
{
    public int MaCv { get; set; }

    public string TenChucVu { get; set; } = null!;

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
