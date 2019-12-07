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
        public virtual ICollection<Envinroment> Envinroments { get; set; }
    }
}
