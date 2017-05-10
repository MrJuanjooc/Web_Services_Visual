using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Mi_Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        int Get_Suma(int Numero1, int Numero2);

    }
}
