using AppDomainContext;
using AppLog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Repository
{
    public class LogRepository : BaseRepository
    {
        public LogRepository(LogContext context) : base(context) { }
        public async Task<IEnumerable<Log>> ListAsync()
        {
            return await _context.Logs
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task AddAsync(Log log)
        {
            await _context.Logs.AddAsync(log);
        }

        public Log Create(Log log)
        {
            this._context.Logs.Add(log);
            this._context.SaveChanges();
            return log;
        }

        public async Task<Log> FindByIdAsync(int id)
        {
            return await _context.Logs.FindAsync(id);
        }

        public Log FindById(int id)
        {
            return this._context.Logs.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Log logUpdate)
        {
            var log = FindById(logUpdate.Id);
            log.Date = logUpdate.Date;
            log.Category= logUpdate.Category;
            log.Solution = logUpdate.Solution;
            log.Description = logUpdate.Description;
            log.Environment = logUpdate.Environment;
            _context.Logs.Update(log);
            _context.SaveChanges();
        }
        public void Remove(Log log)
        {
            _context.Logs.Remove(log);
        }
    }
}
