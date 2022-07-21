using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_EF_CODEFIRST.DatabaseContext;
using DAL_EF_CODEFIRST.DomainClass;
using DAL_EF_CODEFIRST.IServices;

namespace DAL_EF_CODEFIRST.Services
{
    public class KhachHangService : AllServices, IKhachHangService
    {
        public List<KhachHang>  GetAll()
        {
            return _Context.KhachHangs.ToList();
        }
    }
}
