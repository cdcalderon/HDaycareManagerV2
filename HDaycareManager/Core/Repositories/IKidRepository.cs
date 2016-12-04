using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDaycareManager.Models;

namespace HDaycareManager.Core.Repositories
{
    public interface IKidRepository
    {
        IEnumerable<Kid> GetKids();
    }
}
