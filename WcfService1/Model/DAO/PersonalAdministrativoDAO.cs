using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class PersonalAdministrativoDAO
    {
        /*
        public static Boolean Login(String usuario, String password)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                var consulta = (
                    from p in DBConexion.PersonalAdministrativo
                    where p.usuario == usuario && p.password == password
                    select p).FirstOrDefault();

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
        */

        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);
        }
    }
}