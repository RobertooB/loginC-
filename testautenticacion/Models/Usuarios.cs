using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testautenticacion.Models
{
    public class Users
    {

        //relacionar con campos de tabla users
        public string name { get; set; }
        public string lastname { get; set; }
        public string name_user { get; set; }

        public string password { get; set; }

        public Rol rol { get; set; }

    }
}