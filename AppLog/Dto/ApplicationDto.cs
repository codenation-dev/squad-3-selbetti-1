using AppLog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Dto
{
    public class ApplicationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int userId { get; set; }

        public Application ConvertToApplication()
        {
            Application app = new Application();
            if (this.GetType().GetProperty("Name") != null)
            {
                app.Name = this.Name;
            }
            else
            {
                app.Name = "";
            }
            if (this.GetType().GetProperty("Description") != null)
            {
                app.Description = this.Description;
            }
            else
            {
                app.Description = "";
            }
            /*if (this.GetType().GetProperty("User") != null)
            {
                app.User = this.User;
            }
            else
            {
                app.User = null;
            }*/
            return app;
        }
    }
}
