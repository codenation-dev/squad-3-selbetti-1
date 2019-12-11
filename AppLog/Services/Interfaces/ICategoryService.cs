using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services.Interfaces
{
    public interface ICategoryService
    {
        Category Create(Category cat);
        IList<Category> GetCategorysByIdEnv(int idEnv);
        Category GetCategoryById(int id);
    }
}
