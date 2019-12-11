using AppLog.Domain.Models;
using AppLog.Repository;
using AppLog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public class ApplicationService : IApplicationService
    {
        private ApplicationRepository _repository;

        public ApplicationService()
        {
            this._repository = new ApplicationRepository(new AppDomainContext.LogContext());
        }
        public Application Create(Application app)
        {
            return this._repository.Create(app);
        }

        public void Delete(int Id)
        {
            var app = GetById(Id);
            this._repository.Remove(app);
        }

        public IEnumerable<Application> GetAllByUser(int idUser)
        {
            throw new NotImplementedException();
        }

        public Application GetById(int idApplication)
        {
            return this._repository.FindById(idApplication);
        }

        public void UpdateApplication(Application app)
        {
            this._repository.Update(app);
        }
        //TODO GET APPLICATIONS BY USERID
    }
}
