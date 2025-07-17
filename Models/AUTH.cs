using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class AUTH
    {
        public int AUTH_ID { get; set; }
        public string PO_SERIES { get; set; }
        public string AUTH_CPF { get; set; }
        public string AUTH_BY_CPF { get; set; }
        public DateTime? AUTH_DATE { get; set; }

    }
}