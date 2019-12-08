using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models.Util
{
    public class Validation
    {

        public string AttributeName { get; set; }
        public string MessageError { get; set; }
       public Validation(string attributeName, string message)
        {
            this.AttributeName = attributeName;
            this.MessageError = message;
        }
    }
}
