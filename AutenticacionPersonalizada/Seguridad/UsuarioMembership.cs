using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using AutenticacionPersonalizada.Models;
using AutenticacionPersonalizada.Utilidades;

namespace AutenticacionPersonalizada.Seguridad
{
  public class UsuarioMembership:MembershipUser
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public UsuarioMembership(Usuario us)
        {
            id = us.id;
            login = us.login;
            password = SeguridadUtilidades.GetSha1(us.password);
            nombre = us.nombre;
            apellidos = us.apellidos;
        }
    }
}
