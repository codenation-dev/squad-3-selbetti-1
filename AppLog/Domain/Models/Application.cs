using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int UserId {get ; set;}
        public User User { get; set; } 
        public virtual ICollection<Environment> Environments { get; set; }
        public IList<Validation> ValidateObj()
        {
            IList<Validation> validation = new List<Validation>();
            
            if (this.Name.Equals(""))
            {
                validation.Add(new Validation("Name", "O campo Name é Obrigatório"));
            }
            if (this.Description.Equals(""))
            {
                validation.Add(new Validation("Description", "O campo Description é Obrigatório"));
            }
            return validation;
        }
    }
}
