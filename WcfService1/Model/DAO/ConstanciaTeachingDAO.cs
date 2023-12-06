using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaTeachingDAO
    {
        public static bool CrearConstanciaTeaching(Constancia constancia,ConstanciaImparticion constanciaImparticion)
        {
            try
            {
                constancia.Id_Constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                if (constancia.Id_Constancia != -1)
                {
                    var consulta = new ConstanciaImparticion()
                    {
                        FK_Id_constancia = constancia.Id_Constancia,
                        bloque = constanciaImparticion.bloque,
                        credito = constanciaImparticion.credito,
                        esperienciaEducativa = constanciaImparticion.esperienciaEducativa,
                        hora = constanciaImparticion.hora,
                        mes = constanciaImparticion.mes,
                        prograamaEducativo = constanciaImparticion.prograamaEducativo,
                        seccion = constanciaImparticion.seccion,
                        semana = constanciaImparticion.semana
                    };
                    DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                    DBConexion.ConstanciaImparticion.InsertOnSubmit(consulta);
                    DBConexion.SubmitChanges();

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar constancia: {ex.Message}");
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