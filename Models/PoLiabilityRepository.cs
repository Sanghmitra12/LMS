using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    

public class PoLiabilityRepository
    {
        private LMSDbContext _context;

        public PoLiabilityRepository()
        {
            _context = new LMSDbContext();
        }

        public void InsertDummyData()
        {
            var dummy = new PoLiabilityMaster
            {
                PONumber = "PO001",
                VendorCode = "VC001",
                PODescription = "Dummy PO for testing",
                VendorName = "Dummy Vendor Pvt Ltd",
                POStartDate = DateTime.Now,
                POEndDate = DateTime.Now.AddMonths(1),
                POValue = 1234567.89M,
                EICRemarks = "Test Entry"
            };

            _context.PoLiabilityMasters.Add(dummy);
            _context.SaveChanges();
        }
    }

}
