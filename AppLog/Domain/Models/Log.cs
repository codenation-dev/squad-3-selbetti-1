using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models
{
    public class Log
    {
        /*public int UserId {get ; set;}
          public User User { get; set; }*/
        public int Id { get; set; } 
        public String Category { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public DateTime Date { get; set; }
        public int EnvironmentId { get; set; }

        public IList<Validation> ValidateObj()
        {
            IList<Validation> validation = new List<Validation>();
            if (this.Category.Equals(""))
            {
                validation.Add(new Validation("Category", "O campo Category é Obrigatório"));
            }            
            if (this.Description.Equals(""))
            {
                validation.Add(new Validation("Description", "O campo Description é Obrigatório"));
            }            
            if (this.Date == null)
            {
                validation.Add(new Validation("Date", "O campo Date é Obrigatório"));
            }            
            if (this.EnvironmentId == 0)
            {
                validation.Add(new Validation("Environment", "O campo Environment é Obrigatório"));
            }
            return validation;
        }

    }
}
