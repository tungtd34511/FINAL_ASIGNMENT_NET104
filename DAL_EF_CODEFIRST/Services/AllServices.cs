using DAL_EF_CODEFIRST.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_EF_CODEFIRST.Services
{
    public class AllServices
    {
        public QLBH_Context _Context;

        public AllServices()
        {
            _Context = new QLBH_Context();
        }

        public bool Add<T>(T obj)
        {
            if (obj != null)
            {
                _Context.Add(obj);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(object obj)
        {
            if (obj != null)
            {
                _Context.Update(obj);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete<T>(T obj)
        {
            if (obj != null) return false;
            {
                _Context.Remove(obj);
                _Context.SaveChanges();
                return true;
            }
        }
    }
}
