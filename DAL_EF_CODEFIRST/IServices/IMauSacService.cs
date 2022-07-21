using System;
using System.Collections.Generic;
using System.Text;
using DAL_EF_CODEFIRST.DomainClass;

namespace DAL_EF_CODEFIRST.IServices
{
    public interface IMauSacService //phải public
    {
        List<MauSac> GetAll();
        bool Add(MauSac mauSac);
        bool Update(MauSac mauSac);
        bool Delete(MauSac mauSac);
    }
}
