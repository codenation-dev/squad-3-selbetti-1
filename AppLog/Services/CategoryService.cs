using AppLog.Domain.Models;
using AppLog.Repository;
using AppLog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public class CategoryService : ICategoryService
    {
        private CategoryRepository _repository;
        /*public CategoryService()
        {
            this._repository = new CategoryRepository(new AppDomainContext.LogContext());
        }*/

        public Category Create(Category cat)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetCategorysByIdEnv(int idEnv)
        {
            throw new NotImplementedException();
        }
    }
}
