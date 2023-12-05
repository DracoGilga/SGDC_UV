using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciJudgeDAO
    {
        public static bool CrearConstanciaJudge(Constancia constancia, ConstanciaJurado constanciaJurado)
        {
            try
            {
                constancia.Id_Constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                if(constancia.Id_Constancia != -1)
                {
                    var consulta = new ConstanciaJurado()
                    {
                        FK_Id_constancia = constancia.Id_Constancia,
                        fechaPresentacion = constanciaJurado.fechaPresentacion,
                        modalidad = constanciaJurado.modalidad,
                        nombreAlumno = constanciaJurado.nombreAlumno,
                        nombreProyecto = constanciaJurado.nombreProyecto,
                        resultado = constanciaJurado.resultado,
                        Cargo = constanciaJurado.Cargo,
                        Licenciatura = constanciaJurado.Licenciatura,
                    };
                    DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                    DBConexion.ConstanciaJurados.InsertOnSubmit(consulta);
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