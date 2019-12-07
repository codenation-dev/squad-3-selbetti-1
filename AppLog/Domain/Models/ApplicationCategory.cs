using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models
{
    public class ApplicationCategory
    {
        public int ApplicationId { get; set; }
        public int CategoryId { get; set; }
        public bool RequireSolution { get; set; } = false;

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application Application { get; set; }

    }
}
