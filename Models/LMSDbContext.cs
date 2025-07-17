using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace LMS.Models
{
    
        public class LMSDbContext : DbContext
        {
            public LMSDbContext() : base("LMS") { }

            public DbSet<PoLiabilityMaster> PoLiabilityMasters { get; set; }

            // If you also have a detail table like PoLiabilityDetail, add it here:
             public DbSet<PoLiabilityDetail> PoLiabilityDetails { get; set; }
        }
    }
