using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_EF_CODEFIRST.IServices
{
    public interface IMainService
    {
        bool Add<T>(T obj);
        bool Update(object obj);
        bool Delete<T>(T obj);
    }
}
