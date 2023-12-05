using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Model;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        
        [OperationContract]
        List<ConstanciaUnion1> ListarConstancia();
        [OperationContract]
        PersonalAdministrativo Login(String usuario, String password);
        
        [OperationContract]
        bool ModificarProfesor(Profesor profesor);
        [OperationContract]
        List<Profesor> ObtenerNumerosPersonales();
        [OperationContract]
        bool login2(PersonalAdministrativo personalAdministrativo);
        [OperationContract]
        bool AgregarProfesor(Profesor profesor);


        //constancias
        [OperationContract]
        bool CrearConstanciaTeaching(Constancia constancia,ConstanciaImparticion constanciaImparticion);
        [OperationContract]
        bool CrearConstanciaJudge(Constancia constancia, ConstanciaJurado constanciaJurado);
        [OperationContract]
        bool CrearConstanciaProject(Constancia constancia, ConstanciaProyecto constanciaProyecto);
        [OperationContract]
        bool CrearConstanciaPladea(Constancia constancia, ConstanciaPLADEA constanciaPladea);
    }
}