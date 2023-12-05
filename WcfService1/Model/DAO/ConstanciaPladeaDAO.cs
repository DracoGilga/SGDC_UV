using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaPladeaDAO
    {
        public static bool CrearConstanciaPladea(Constancia constancia, ConstanciaPLADEA constanciaPladea)
        {
            try
            {
                constancia.Id_Constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                if(constancia.Id_Constancia != -1)
                {
                    var consulta = new ConstanciaPLADEA()
                    {
                        FK_Id_constancia = constancia.Id_Constancia,
                        acciones = constanciaPladea.acciones,
                        ejeEstrategico = constanciaPladea.ejeEstrategico,
                        metas = constanciaPladea.metas,
                        objetivosGenerales = constanciaPladea.objetivosGenerales,
                        programaEstrategico = constanciaPladea.programaEstrategico
                    };
                    DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                    DBConexion.ConstanciaPLADEAs.InsertOnSubmit(consulta);
                    DBConexion.SubmitChanges();
                    return true;
                }
                else
                    return false;
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