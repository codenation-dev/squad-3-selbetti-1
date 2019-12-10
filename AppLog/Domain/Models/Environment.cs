using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models
{
    public class Environment
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ApplicationId { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual Application Application { get; set; }
    }
}
