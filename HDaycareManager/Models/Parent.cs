using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace HDaycareManager.Models
{
    public class Parent
    {
       // public ApplicationUser Provider { get; set; }
        public Parent()
        {
            Kids = new Collection<Kid>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<Kid> Kids { get; set; }              
    }
}