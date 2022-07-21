using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_EF_CODEFIRST.DatabaseContext;
using DAL_EF_CODEFIRST.DomainClass;
using DAL_EF_CODEFIRST.IServices;

namespace DAL_EF_CODEFIRST.Services
{
    public class MauSacService : IMauSacService //Kế thừa 
    {
        public QLBH_Context _Context;

        public MauSacService()
        {
            _Context = new QLBH_Context();//khởi tạo context và tự kết nối đến cơ sở dữ liệu
        }


        public List<MauSac> GetAll()
        {
            return _Context.MauSacs.ToList();
        }

        public bool Add(MauSac mauSac)
        {
            if (mauSac != null) return false;
            {
                _Context.MauSacs.Add(mauSac);
                _Context.SaveChanges();//Lưu dữ liệu thay đổi vao db
                return true;
            }
        }

        public bool Update(MauSac mauSac)
        {
            if (mauSac != null) return false;
            {
                _Context.MauSacs.Add(mauSac);
                _Context.SaveChanges();
                return true;
            }
        }

        public bool Delete(MauSac mauSac)
        {
            if (mauSac != null) return false;
            {
                _Context.MauSacs.Remove(mauSac);
                _Context.SaveChanges();
                return true;
            }
        }
    }
}
