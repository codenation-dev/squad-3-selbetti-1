using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Dto
{
    public class EnvironmentDto
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ApplicationId { get; set; }
        public Domain.Models.Environment ConvertToEnvironment()
        {
            Domain.Models.Environment env = new Domain.Models.Environment();
            if (this.GetType().GetProperty("Name") != null)
            {
                env.Name = this.Name;
            }
            else
            {
                env.Name = "";
            }
            if (this.GetType().GetProperty("Description") != null)
            {
                env.Ip = this.Ip;
            }
            else
            {
                env.Ip = "";
            }
            if (this.GetType().GetProperty("Ip") != null)
            {
                env.Ip = this.Ip;
            }
            else
            {
                env.Ip = "";
            }
            if (this.GetType().GetProperty("Url") != null)
            {
                env.Url = this.Url;
            }
            else
            {
                env.Url = "";
            }
            if (this.GetType().GetProperty("ApplicationId") != null)
            {
                if (Convert.ToInt32(this.ApplicationId) != 0)
                {
                    env.ApplicationId = Convert.ToInt32(this.ApplicationId);
                }
                else
                {
                    env.ApplicationId = -1;
                }
            }
            else
            {
                env.ApplicationId = 0;
            }
            return env;
        }
    }
}
