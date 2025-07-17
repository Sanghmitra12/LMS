using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class PoLiabilityViewModel
    {
         
        
            public PoLiabilityMaster Master { get; set; }
            public List<PoLiabilityDetail> Details { get; set; }
        }
    }

