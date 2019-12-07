using AppLog.Domain.Models;
using AppLog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
    public class UserService : IUserService
    {
        UserRepository _repository;

        public UserService()
        {
            this._repository = new UserRepository(new AppDomainContext.LogContext());
        }

        public User Authenticate(string email, string password)
        {
            return _repository.Authenticate(email, password);
        }

        public User Create(User user, string password)
        {
            return _repository.Create(user, password);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(User user, string password = null)
        {
            _repository.Update(user, password);
        }
    }
}
