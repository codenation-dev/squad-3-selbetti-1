using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain
{
    public class Validation
    {
        public string AttributeName { get; set; }
        public string MessageValidation { get; set; }

        public Validation(string attributeName, string messageValidation)
        {
            this.AttributeName = attributeName;
            this.MessageValidation = MessageValidation;
        }
    }
}
