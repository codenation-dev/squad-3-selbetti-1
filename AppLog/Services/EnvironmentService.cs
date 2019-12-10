using AppLog.Domain.Models;
using AppLog.Repository;
using AppLog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public class EnvironmentService : IEnvironment
    {
        private EnvironmentRepository _repository;
        public Domain.Models.Environment Create(Domain.Models.Environment env)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Models.Environment> GetAllByApplication(int idApp)
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Environment GetById(int idEnv)
        {
            throw new NotImplementedException();
        }

        public void UpdateEnvironment(Domain.Models.Environment env)
        {
            throw new NotImplementedException();
        }
    }
}
