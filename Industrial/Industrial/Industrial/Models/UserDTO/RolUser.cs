using System;
using System.Collections.Generic;
using System.Text;

namespace Industrial.Models.UserDTO
{
    public class RolUser
    {
        public int idRol { get; set; }
        public string name { get; set; }

        public RolUser() { }

        public RolUser(int idRol, string name)
        {
            this.idRol = idRol;
            this.name = name;
        }
    }
}
