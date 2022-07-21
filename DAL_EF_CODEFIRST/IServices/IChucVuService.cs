using System;
using System.Collections.Generic;
using System.Text;
using DAL_EF_CODEFIRST.DomainClass;

namespace DAL_EF_CODEFIRST.IServices
{
    public interface IChucVuService : IMainService
    {
        List<ChucVu> GetAll();
    }
}
