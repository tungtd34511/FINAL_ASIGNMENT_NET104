using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DAL_EF_CODEFIRST.DatabaseContext;
using DAL_EF_CODEFIRST.DomainClass;
using DAL_EF_CODEFIRST.IServices;

namespace DAL_EF_CODEFIRST.Services
{
    public class ChitietSPService : AllServices, IChiTietSPService
    {
        public List<ChiTietSP> GetAll()
        {
            return _Context.ChiTietSps.ToList();
        }

    }
}
