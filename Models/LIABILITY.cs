using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    

public class LIABILITY
{
    public int LIABILITY_ID { get; set; }
    public string QTR_NO { get; set; }
    public string FY { get; set; }
    public string PO_NUMBER { get; set; }
    public int IS_LIABILITY_BOOKED { get; set; }
    public string SES_NUMBER { get; set; }
    public decimal LIABILITY_VALUE { get; set; }
    public string LBT_NOT_BOOKED_REMARKS { get; set; }
    public string FA_REMARKS { get; set; }
    public string EIC_REMARKS { get; set; }
    public string SCHEDULER_CPF { get; set; }
    public DateTime? SCHEDULE_CREATED_ON { get; set; } 
    public int ALERT_STATUS { get; set; }
    public string IS_ROW_EDITABLE { get; set; }
    public string SCHEDULE_NAME { get; set; }
    public string EIC_CPF { get; set; }
    public DateTime? FA_ACTION_ON { get; set; } 
    public string FA_ACTION_BY { get; set; }
    public DateTime? EIC_SUBMITTED_ON { get; set; } 
    public DateTime? ALERT_LAST_SENT_ON { get; set; } 
    public string HOD_CPF { get; set; }
}
}