using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services.Interfaces
{
    public interface IApplicationService
    {
        IEnumerable<Application> GetAllByUser(int idUser);
        Application GetById(int idApplication);
        Application Create(Application app);
        void UpdateApplication(Application app);
        void Delete(int Id);
    }
}
