using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
      //  public ApplicationUser Provider { get; set; }
        public int Id  { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Years { get; set; }
        public int Months { get; set; }

        public ICollection<Parent> Parents { get; set; }

    }
}