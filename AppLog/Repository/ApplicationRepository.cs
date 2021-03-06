﻿using AppDomainContext;
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

        public Application Create(Application app)
        {
            this._context.Applications.Add(app);
            this._context.SaveChanges();
            return app;
        }

        public async Task<Application> FindByIdAsync(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public Application FindById(int id)
        {
            return this._context.Applications.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Application app)
        {
            _context.Applications.Update(app);
            _context.SaveChanges();
        }

        public void Remove(Application application)
        {
            _context.Applications.Remove(application);
        }

        public Application GetByUserId(int userId)
        {
            return _context.Applications.FirstOrDefault(x => x.UserId == userId);
        }
    }
}
