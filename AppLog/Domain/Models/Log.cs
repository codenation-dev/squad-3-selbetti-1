using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models
{
    public class Log
    {
        public int Id { get; set; } 
        public Category Category { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public DateTime Date { get; set; }
        public Environment Environment { get; set; }

        public IList<Validation> ValidateObj()
        {
            IList<Validation> validation = new List<Validation>();

            if (this.Category == null)
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
            if (this.Environment == null)
            {
                validation.Add(new Validation("Environment", "O campo Environment é Obrigatório"));
            }
            return validation;
        }

    }
}
