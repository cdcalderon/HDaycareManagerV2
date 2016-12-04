using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDaycareManager.Models
{
    public interface IApplicationDbContext
    {
         DbSet<Kid> Kids { get; set; }
         DbSet<Parent> Parents { get; set; }
         DbSet<Attendance> Attendances { get; set; }
    }
}
