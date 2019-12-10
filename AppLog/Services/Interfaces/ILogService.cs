using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services.Interfaces
{
    public interface ILogService
    {
        Log GetById(int idLog);
        Log Create(Log log);
        IList<Log> GetLogsByApplicationId(int appId);
        Log Update(Log log);
    }
}
