﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class TaiKhoan
    {
     
     
        [Key,ForeignKey("NhanVien")]
        public int NhanVienID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string LoaiTaiKhoan { get; set; }
        public virtual NhanVien NhanVien { get; set; }

    }
}
