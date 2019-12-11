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
        public DateTime Date { get; set; }
        public String Category { get; set; }
        public string Solution { get; set; }
        public int EnvironmentId { get; set; }
        public string Description { get; set; }

        public Log ConvertToLog()
        {
            Log log = new Log();
            if (this.GetType().GetProperty("Category") != null)
            {
                log.Category = this.Category; //TODO
            }
            else
            {
                log.Category = "";//TODO
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
                log.EnvironmentId = this.EnvironmentId;//TODO
            }
            else
            {
                log.EnvironmentId = 0;//TODO
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
