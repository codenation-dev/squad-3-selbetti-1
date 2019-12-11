using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services.Interfaces
{
    public interface IApplicationService
    {
        Application GetByUserId(int userId);
        Application GetById(int idApplication);
        Application Create(Application app);
        void Update(Application app);
        void Delete(int Id);
    }
}
