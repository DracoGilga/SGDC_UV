using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class PersonalAdministrativoDAO
    {
        public static PersonalAdministrativo Login(String usuario, String password)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                PersonalAdministrativo consulta = DBConexion.PersonalAdministrativos.Where(p => p.usuario == usuario && p.password == password).First();

                if (consulta != null)
                    return new PersonalAdministrativo()
                    {
                        Id_personalAdministrativo = consulta.Id_personalAdministrativo,
                        nombreCompleto = consulta.nombreCompleto,
                        usuario = consulta.usuario,
                        password = consulta.password
                    };
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);//cambiar el string de acuerdo a la base de datos
        }

        internal static bool Login2(PersonalAdministrativo personalAdministrativo)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                PersonalAdministrativo consulta = DBConexion.PersonalAdministrativos.Where(p => p.usuario == personalAdministrativo.usuario && p.password == personalAdministrativo.password).First();

                if (consulta != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}