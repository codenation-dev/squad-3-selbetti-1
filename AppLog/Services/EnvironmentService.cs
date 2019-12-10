using AppLog.Domain.Models;
using AppLog.Repository;
using AppLog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public class EnvironmentService : IEnvironmentService
    {
        private EnvironmentRepository _repository;
        public EnvironmentService()
        {
            this._repository = new EnvironmentRepository(new AppDomainContext.LogContext());
        }
        public Domain.Models.Environment Create(Domain.Models.Environment env)
        {
            return this._repository.Create(env);
        }

        public void Delete(int Id)
        {
            var env = GetById(Id);
            this._repository.Remove(env);
        }

        public IList<Domain.Models.Environment> FindByAppId(int appId)
        {
            return this._repository.FindByAppId(appId);
        }

        public Domain.Models.Environment GetById(int idEnv)
        {
            return this._repository.FindById(idEnv);
        }

        public void UpdateEnvironment(Domain.Models.Environment env)
        {
            this._repository.Update(env);
        }
    }
}
