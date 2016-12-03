using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HDaycareManager.Models
{
    public class Attendance
    {
        public Kid Kid { get; set; }
        public Parent Parent { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public Status Status { get; set; }
    }
}