//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Web;

//namespace LMS.Models
//{
//        public class PoLiabilityMaster
//        {
//            [Key]
//            public string PONumber { get; set; }


//            public string VendorCode { get; set; }

//            public string PODescription { get; set; }

//            public string VendorName { get; set; }

//            [DataType(DataType.Date)]
//            public DateTime POStartDate { get; set; }

//            [DataType(DataType.Date)]
//            public DateTime POEndDate { get; set; }

//            public decimal POValue { get; set; }

//            public string EICRemarks { get; set; }
//        }
//}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class PoLiabilityMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int LIABILITY_ID { get; set; }

        public string PONumber { get; set; }

        public string VendorCode { get; set; }

        public string PODescription { get; set; }

        public string VendorName { get; set; }

        [DataType(DataType.Date)]
        public DateTime POStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime POEndDate { get; set; }

        public decimal POValue { get; set; }

        public string EICRemarks { get; set; }
    }
}
