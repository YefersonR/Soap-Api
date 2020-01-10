using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap_Api
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Usuario GetUsuario(int id, string nombre, string direccion, string telefono);

    
    }
}
