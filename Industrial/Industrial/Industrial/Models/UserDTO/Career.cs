using System;
using System.Collections.Generic;
using System.Text;

namespace Industrial.Models.UserDTO
{
    public class Career
    {
        int idCareer { get; set; }
        string name { get; set; }

        public Career() { }

        public Career(int idCareer, string name)
        {
            this.idCareer = idCareer;
            this.name = name;
        }
    }
}
