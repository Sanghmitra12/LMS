using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models

    {
        public class PoLiabilityDetail
        {
            [Key]
            public int SrNo { get; set; }

            public string QtrNo { get; set; }

            public string IsLiabilityBooked { get; set; } 

            public decimal LiabilityValue { get; set; }

            public string SESNumber { get; set; }

            public string Status { get; set; }  

            public string Remarks { get; set; }

            public string FARemarks { get; set; }

            
            public string PONumber { get; set; }

          
            public PoLiabilityMaster PoLiabilityMaster { get; set; }
        }
    }

