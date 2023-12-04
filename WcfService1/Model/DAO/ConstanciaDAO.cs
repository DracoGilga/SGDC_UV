﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciaDAO
    {
        /*
        public static List<ConstanciaUnion1> ConsultarConstancias()
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                List<ConstanciaUnion1> constancias = new List<ConstanciaUnion1>();
                var consulta = (
                    from c in DBConexion.Constancia
                    join p in DBConexion.Profesor on c.FK_id_Profesor equals p.Id_profesor
                    select new
                    {
                        Profesor = p,
                        Constancia = c
                    }
                ).ToList();
                

                if (consulta != null)
                {
                    foreach (var constancia in consulta)
                    {
                        constancias.Add(new ConstanciaUnion1()
                        {
                            constancia = new Constancia()
                            {
                                Id_Constancia = constancia.Constancia.Id_Constancia,
                                FK_id_Profesor = constancia.Constancia.FK_id_Profesor,
                                fechaCreacionConstancia = constancia.Constancia.fechaCreacionConstancia,
                                FK_Id_Firma = constancia.Constancia.FK_Id_Firma,
                            },
                            profesor = new Profesor()
                            {
                                Id_profesor = constancia.Profesor.Id_profesor,
                                nombreCompleto = constancia.Profesor.nombreCompleto,
                                numeroPersonal = constancia.Profesor.numeroPersonal
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
        */

        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);
        }
    }
}