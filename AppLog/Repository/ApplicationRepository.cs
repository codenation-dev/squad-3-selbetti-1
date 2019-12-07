using AppDomainContext;
using AppLog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Repository
{
    public class ApplicationRepository : BaseRepository
    {
        public ApplicationRepository(LogContext context) : base(context) { }
        public async Task<IEnumerable<Application>> ListAsync()
        {
            return await _context.Applications
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task AddAsync(Application application)
        {
            await _context.Applications.AddAsync(application);
        }

        public async Task<Application> FindByIdAsync(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public void Update(Application application)
        {
            _context.Applications.Update(application);
        }

        public void Remove(Application application)
        {
            _context.Applications.Remove(application);
        }
    }
}
