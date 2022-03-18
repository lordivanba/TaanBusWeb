using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace taanbus.Data.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        // [Required(ErrorMessage="El nombre es un campo requerido")]
        public string? Nombre { get; set; }
        // [Required(ErrorMessage="Los apellidos son un campo requerido")]
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        [Required(ErrorMessage="El nombre de usuario es un camporequerido")]
        public string? Username { get; set; }
        [Required(ErrorMessage="La contraseña es un campo requerido")]
        public string? Password { get; set; }
        public int Usertype { get; set; } = 0;
    }
}