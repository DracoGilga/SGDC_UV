using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaProjectDAO
    {
        public static bool CrearConstanciaProject(Constancia constancia, ConstanciaProyecto constanciaProyecto)
        {
            try
            {
                constanciaProyecto.FK_Id_constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                DBConexion.Constancias.InsertOnSubmit(constancia);
                DBConexion.ConstanciaProyectos.InsertOnSubmit(constanciaProyecto);
                DBConexion.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);//cambiar el string de acuerdo a la base de datos
        }
    }
}