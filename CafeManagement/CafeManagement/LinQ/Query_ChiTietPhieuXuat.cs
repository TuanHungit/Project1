using CafeManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.LinQ
{
    public class Query_ChiTietPhieuXuat
    {
        CaPheContext caPheContext = new CaPheContext();

        public bool ThemChiTietPhieuXuat(int PhieuXuatId, int HangHoaId, int SoLuongXuat)
        {
            if (PhieuXuatId != 0 && SoLuongXuat != 0 && HangHoaId != 0)
            {
                ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat()
                {
                    PhieuXuatId = PhieuXuatId,
                    HangHoaId = HangHoaId,
                    SoLuongXuat = SoLuongXuat
                };
                caPheContext.ChiTietPhieuXuats.Add(chiTietPhieuXuat);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public void CapNhatChiTietPhieuXuat(int HangHoaId, int SoLuong, DateTime NgayLap)
        {

            ChiTietPhieuXuat hangHoa = (from item in caPheContext.ChiTietPhieuXuats
                                        where item.HangHoaId.Equals(HangHoaId)
                                        select item).FirstOrDefault();

            hangHoa.SoLuongXuat = hangHoa.SoLuongXuat + SoLuong;
            caPheContext.SaveChanges();

        }
    }
}
