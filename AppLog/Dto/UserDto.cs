using AppLog.Domain.Models.Util;
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

        public IList<Validation> ValidateObj()
        {
            IList<Validation> validation = new List<Validation>();
            if (this.Email.Equals(""))
            {
                validation.Add(new Validation("Email", "O campo E-Mail é Obrigatório"));
            }
            if (this.Name.Equals(""))
            {
                validation.Add(new Validation("Nome", "O campo Nome é Obrigatório"));
            }
            if (this.Password.Equals(""))
            {
                validation.Add(new Validation("Senha", "O campo Senha é Obrigatório"));
            }

            return validation;
        }
    }
}
