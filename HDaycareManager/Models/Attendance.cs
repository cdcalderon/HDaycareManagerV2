using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HDaycareManager.Models
{
    public class Attendance
    {
        
        public string ProviderId { get; set; }

        public int Id { get; set; }

        [Required]
        public Kid Kid { get; set; }

        [Required]
        public Parent Parent { get; set; }

        [Required]
        public DateTime ModifiedDateTime { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}