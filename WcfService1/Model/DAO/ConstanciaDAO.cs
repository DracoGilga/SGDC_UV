using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaDAO
    {
        public static List<Constancia> ConsultarConstancias()
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                List<Constancia> constancias = new List<Constancia>();
                var consulta = DBConexion.Constancia;
                if (consulta != null)
                {
                    foreach (Constancia constancia in consulta)
                    {
                        constancias.Add(new Constancia
                        {
                            Id_Constancia = constancia.Id_Constancia,
                            fechaCreacionConstancia = constancia.fechaCreacionConstancia,
                            FK_id_Profesor = constancia.FK_id_Profesor,
                            FK_Id_Firma = constancia.FK_Id_Firma,
                            Profesor = new Profesor()
                            {
                                Id_profesor = constancia.FK_id_Profesor,
                                nombreCompleto = constancia.Profesor.nombreCompleto
                            },
                            FirmaElectronica = new FirmaElectronica()
                            {
                                Id_firma = constancia.FK_Id_Firma
                            }
                        });
                    }

                    return constancias;

                }
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
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);
        }
    }
}