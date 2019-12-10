using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLog.Domain.Models;

namespace AppLog.Services.Interfaces
{
    interface IEnvironment
    {
        IEnumerable<Domain.Models.Environment> GetAllByApplication(int idApp);
        Domain.Models.Environment GetById(int idEnv);
        Domain.Models.Environment Create(Domain.Models.Environment env);
        void UpdateEnvironment(Domain.Models.Environment env);
        void Delete(int Id);
    }
}
