using AppDomainContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Repository
{
    public class EnvironmentRepository : BaseRepository
    {
        public EnvironmentRepository(LogContext context) : base(context) { }
        public async Task<IEnumerable<Domain.Models.Environment>> ListAsync()
        {
            return await _context.Enviroments
                                 .AsNoTracking()
                                 .ToListAsync();
        }
        public async Task AddAsync(Domain.Models.Environment environment)
        {
            await _context.Enviroments.AddAsync(environment);
        }
        public Domain.Models.Environment Create(Domain.Models.Environment env)
        {
            this._context.Enviroments.Add(env);
            this._context.SaveChanges();
            return env;
        }

        public async Task<Domain.Models.Environment> FindByIdAsync(int id)
        {
            return await _context.Enviroments.FindAsync(id);
        }

        public Domain.Models.Environment FindById(int id)
        {
            return this._context.Enviroments.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Domain.Models.Environment env)
        {

        var environment = FindById(env.Id);
            environment.Name = env.Name;
            environment.Url = env.Url;
            environment.Ip = env.Ip;
            this._context.Enviroments.Update(environment);
            this._context.SaveChanges();
        }

        public void Remove(Domain.Models.Environment environment)
        {
            _context.Enviroments.Remove(environment);
        }
    }
}
