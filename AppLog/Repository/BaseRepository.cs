using AppDomainContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Repository
{
    public class BaseRepository
    {
        protected readonly LogContext _context;

        public BaseRepository(LogContext context)
        {
            _context = context;
        }   
    }
}
