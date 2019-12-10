using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Dto
{
    public class LogDto
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public DateTime Date { get; set; }
        public Domain.Models.Environment Environment { get; set; }

        public Log ConvertToLog()
        {
            Log log = new Log();
            if (this.GetType().GetProperty("Category") != null)
            {
                log.Category = null; //TODO
            }
            else
            {
                log.Category = null;//TODO
            }
            if (this.GetType().GetProperty("Description") != null)
            {
                log.Description = this.Description;
            }else
            {
                log.Description = "";
            }
            if (this.GetType().GetProperty("Environment") != null)
            {
                log.Environment = null;//TODO
            }
            else
            {
                log.Environment = null;//TODO
            }
            if (this.GetType().GetProperty("Solution") != null)
            {
                log.Solution = this.Solution;
            }
            else
            {
                log.Solution = "";
            }
            return log;
        }
    }
}
