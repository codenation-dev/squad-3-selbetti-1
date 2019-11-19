using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aceleradev.Models
{
    public class User
    {
        private long _Id;
        private string _Description;


        public User(long id, string desc)
        {
            if(User.ValidateId(id)) this._Id = id;
            if(User.ValidateDescription(desc)) this._Description = desc;
        }


        public void SetId(int id)
        {
            if (User.ValidateId(id))
            {
                this._Id = id;
            }
        }

        public void SetDescription(string desc)
        {
            if(User.ValidateDescription(desc))
            {
                this._Description = desc;
            }
        }

       

        public long GetId()
        {
            return this._Id;
        }

        public string GetDescription()
        {
            return this._Description;
        }

        private static bool ValidateId(long id)
        {
            if(id > 0 && id < long.MaxValue)
            {
                return true;
            }
            else
            {
                if(id < 1)
                {
                    throw new TypeInitializationException("O Id não pode ser menor que 1", null);
                }
                else
                {
                    throw new TypeInitializationException("O Id não pode ser maior que o máximo comportado por um Int64", null);
                }
            }
        }

        private static bool ValidateDescription(string desc)
        {
            if(desc == null)
            {
                throw new NullReferenceException("Um valor deve ser informado, tendo entre 1 e 512 caracteres");
            }
            if (desc.Length > 0 && desc.Length < 512 && desc != null)
            {
                return true;
            }
            else
            {
                if (desc.Length < 1 || desc.Equals(""))
                {
                    throw new ArgumentOutOfRangeException("A Descrição deve conter ao menos um caracter");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A Descrição deve conter no máximo 512 caracteres");
                }
            }
        }
    }
}
