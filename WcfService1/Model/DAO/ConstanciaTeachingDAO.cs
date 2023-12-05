using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaTeachingDAO
    {
        public static bool CrearConstanciaTeaching(Constancia constancia, ConstanciaImparticion constanciaDocencia)
        {
            try
            {
                constanciaDocencia.FK_Id_constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                DBConexion.Constancias.InsertOnSubmit(constancia);
                DBConexion.ConstanciaImparticions.InsertOnSubmit(constanciaDocencia);
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