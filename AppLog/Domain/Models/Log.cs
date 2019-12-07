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
        public Envinroment Enviroment { get; set; }

    }
}
