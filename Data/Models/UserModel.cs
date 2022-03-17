using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taanbus.Data.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Usertype { get; set; } = 0;
    }
}