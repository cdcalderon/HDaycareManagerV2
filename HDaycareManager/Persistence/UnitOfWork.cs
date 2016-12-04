using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HDaycareManager.Core;
using HDaycareManager.Core.Repositories;
using HDaycareManager.Models;
using HDaycareManager.Persistence.Repositories;

namespace HDaycareManager.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IKidRepository Kids { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Kids = new KidRepository(context);
        }
    }
}