using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HDaycareManager.Models
{
    public class Kid
    {
        public Kid()
        {
            Parents = new Collection<Parent>();
        }

        [Required]
        public string ProviderId { get; set; }

        public int Id  { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Years { get; set; }

        [Required]
        public int Months { get; set; }

        public ICollection<Parent> Parents { get; set; }

    }
}