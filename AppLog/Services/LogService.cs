using AppLog.Domain.Models;
using AppLog.Repository;
using AppLog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public class LogService : ILogService
    {
        private LogRepository _repository;
        public LogService()
        {
            this._repository = new LogRepository(new AppDomainContext.LogContext());
        }
        public Log GetById(int idLog)
        {
            return this._repository.FindById(idLog);
        }

        //TODO
        public IList<Log> GetLogsByApplicationId(int appId)
        {
            throw new NotImplementedException();
        }

        public Log Create(Log log)
        {
            return this._repository.Create(log);
        }

        public Log Update(Log log)
        {
            return this.Update(log);
        }
    }
}
