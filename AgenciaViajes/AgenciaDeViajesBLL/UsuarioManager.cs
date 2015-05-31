using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class UsuarioManager
    {
        public static string[] GetRolesByUserName(string userName)
        {
            switch (userName.ToLower())
            {
                case "administrador":
                    return new string[] { "administrador", };
                case "usuario":
                    return new string[] { "usuario" };
                default:
                    return new string[] { "clientes" };
            }
        }

        public static bool AutenticarUsuario(string usuario, string password)
        {
            if (usuario.ToLower() == "administrador" && password == "123") return true;
            if (usuario.ToLower() == "cliente" && password == "123") return true;
           
            return false;
        }

        public static bool CurrentUserIs(string rol)
        {
            
            throw new NotImplementedException();
        }
    }
}
