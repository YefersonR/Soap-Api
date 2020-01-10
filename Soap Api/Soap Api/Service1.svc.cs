using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap_Api
{
    public class Service1 : IService1
    {
        public Usuario GetUsuario(int id, string nombre, string direccion, string telefono)
        {
            Usuario user = new Usuario();

            user.id=id;
            user.Nombre =nombre;
            user.Direccion = direccion;
            user.Telefono = telefono;

            return user;
        }
    }
}
