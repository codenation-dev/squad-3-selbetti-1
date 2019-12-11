using AppLog.Dto;
using AppLog.Services.Interfaces;
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
        public virtual IList<Log> logs { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual Application Application { get; set; }

        public IList<Validation> ValidateObj()
        {
            IList<Validation> validation = new List<Validation>();

            if (this.Ip.Equals(""))
            {
                validation.Add(new Validation("Ip", "O campo Ip é Obrigatório"));
            }
            if (this.Name.Equals(""))
            {
                validation.Add(new Validation("Name", "O campo Name é Obrigatório"));
            }
            if (this.Url.Equals(""))
            {
                validation.Add(new Validation("Url", "O campo Url é Obrigatório"));
            }
            if (this.ApplicationId == -1)
            { 
                validation.Add(new Validation("Url", "É necessário ter um ApplicationId Vinculado"));
            }
            return validation;
        }
        public EnvironmentDto ConvertToDTO()
        {
            EnvironmentDto envDto = new EnvironmentDto();
            envDto.Id = this.Id;
            envDto.Ip = this.Ip;
            envDto.Url = this.Url;
            envDto.Name = this.Name;
            return envDto;
        }
    }
}
