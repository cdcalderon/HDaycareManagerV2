using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HDaycareManager.Core.Repositories;
using HDaycareManager.Models;

namespace HDaycareManager.Persistence.Repositories
{
    public class KidRepository : IKidRepository
    {
        private readonly IApplicationDbContext _context;

        public KidRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Kid> GetKids()
        {
            return _context.Kids.ToList();
        }
    }
}