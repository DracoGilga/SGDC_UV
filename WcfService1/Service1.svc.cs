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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        
        public List<ConstanciaUnion1> ListarConstancia()
        {
            return Model.DAO.ConstanciaDAO.ConsultarConstancias();
        }
        public PersonalAdministrativo Login(String usuario, String password)
        {
            return Model.DAO.PersonalAdministrativoDAO.Login(usuario, password);
        }

        public bool AgregarProfesor(Profesor profesor)
        {
            return Model.DAO.ProfesorDAO.RegistrarProfesor(profesor);
        }
        public bool login2(PersonalAdministrativo personalAdministrativo)
        {
            return Model.DAO.PersonalAdministrativoDAO.Login2(personalAdministrativo);
        }

        public bool ModificarProfesor(Profesor profesor)
        {
            return Model.DAO.ProfesorDAO.ModificarProfesor(profesor);
        }

        public List<Profesor> ObtenerNumerosPersonales()
        {
            return Model.DAO.ProfesorDAO.ObtenerNumerosPersonales();
        }

        //constanciass
        public bool CrearConstanciaTeaching(Constancia constancia,ConstanciaImparticion constanciaImparticion)
        {
            return Model.DAO.ConstanciaTeachingDAO.CrearConstanciaTeaching(constancia,constanciaImparticion);
        }  
        public bool CrearConstanciaJudge(Constancia constancia, ConstanciaJurado constanciaJurado)
        {
            return Model.DAO.ConstanciJudgeDAO.CrearConstanciaJudge(constancia, constanciaJurado);
        }
        public bool CrearConstanciaProject(Constancia constancia, ConstanciaProyecto constanciaProyecto)
        {
            return Model.DAO.ConstanciaProjectDAO.CrearConstanciaProject(constancia, constanciaProyecto);
        }
        public bool CrearConstanciaPladea(Constancia constancia, ConstanciaPLADEA constanciaPladea)
        {
            return Model.DAO.ConstanciaPladeaDAO.CrearConstanciaPladea(constancia, constanciaPladea);
        }

        public Profesor BuscarProfesorNoPersonal(string numeroPersonal)
        {
            return Model.DAO.ProfesorDAO.BuscarProfesorNoPersonal(numeroPersonal);
        }
    }
}