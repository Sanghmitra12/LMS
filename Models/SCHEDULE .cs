using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class SCHEDULE
    {
        public string SCHEDULE_NAME { get; set; }
        public string SCHEDULER_CPF { get; set; }
        public DateTime? SCHEDULED_ON { get; set; }
        public string STATUS { get; set; }
        public string IS_CLOSED { get; set; }
        public DateTime? CLOSED_ON { get; set; }
        public string CLOSED_BY { get; set; }
    

}
}