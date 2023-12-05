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
                constancia.Id_Constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                if (constancia.Id_Constancia != -1)
                {
                    var consulta = new ConstanciaProyecto()
                    {
                        FK_Id_constancia = constancia.Id_Constancia,
                        duracion = constanciaProyecto.duracion,
                        impactoObtenido = constanciaProyecto.impactoObtenido,
                        lugarDesarrollo = constanciaProyecto.lugarDesarrollo,
                        nombreAlumno = constanciaProyecto.nombreAlumno,
                        proyectoRealizado = constanciaProyecto.proyectoRealizado,
                    };
                    DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                    DBConexion.ConstanciaProyectos.InsertOnSubmit(consulta);
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