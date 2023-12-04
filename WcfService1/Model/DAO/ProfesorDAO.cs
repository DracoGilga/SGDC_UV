using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ProfesorDAO
    {
        public static List<string> ObtenerNumerosPersonales()
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

                var consulta = from p in DBConexion.Profesors
                               select p.numeroPersonal;

                List<string> numerosPersonales = consulta.ToList();

                return numerosPersonales;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool ModificarProfesor(Profesor profesor)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

                var consulta = from p in DBConexion.Profesors //ToDo
                               where p.Id_profesor == profesor.Id_profesor
                               select p;

                var profesorEncontrado = consulta.SingleOrDefault();

                if (profesorEncontrado != null)
                {
                    profesorEncontrado.nombreCompleto = profesor.nombreCompleto;
                    profesorEncontrado.numeroPersonal = profesor.numeroPersonal;

                    DBConexion.SubmitChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);
        }
    }
}