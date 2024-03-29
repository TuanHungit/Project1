﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class SanPham
    {
       
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int LoaiSanPhamId { get; set; }
        public string TinhTrang { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public ICollection<ChiTietHoaDon> chiTietHoaDons { get; set; }

    }
}
