using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDaycareManager.Core.Repositories;

namespace HDaycareManager.Core
{
    public interface IUnitOfWork
    {
        IKidRepository Kids { get; }
    }
}
