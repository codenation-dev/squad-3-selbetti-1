using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User ConvertToUser()
        {
            User user = new User();
            if (this.GetType().GetProperty("Name") != null)
            {
                user.Name = this.Name;
            }
            else
            {
                user.Name = "";
            }
            if (this.GetType().GetProperty("Email") != null)
            {
                user.Email = this.Email;
            }
            else
            {
                user.Email = "";
            }
            if (this.GetType().GetProperty("Password") != null)
            {
                user.Password = this.Password;
            }
            else
            {
                user.Password = "";
            }
            return user;
        }
    }
}
