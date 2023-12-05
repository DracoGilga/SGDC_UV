using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ProfesorDAO
    {
        public static List<Profesor> ObtenerNumerosPersonales()
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

                List<Profesor> profesores = new List<Profesor>();
                IQueryable<Profesor> consulta = DBConexion.Profesors.Select(p => p);
                if(consulta != null)
                {
                    foreach(Profesor profesor in consulta)
                    {
                        profesores.Add(new Profesor()
                        {
                            Id_profesor = profesor.Id_profesor,
                            nombreCompleto = profesor.nombreCompleto,
                            numeroPersonal = profesor.numeroPersonal
                        });
                    }
                    return profesores;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool ModificarProfesor(Profesor profesor)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

                var consulta = from p in DBConexion.Profesors //ToDo
                               where p.Id_profesor == profesor.Id_profesor
                               select p;

                var profesorEncontrado = consulta.SingleOrDefault();

                if (profesorEncontrado != null)
                {
                    profesorEncontrado.nombreCompleto = profesor.nombreCompleto;
                    profesorEncontrado.numeroPersonal = profesor.numeroPersonal;

                    DBConexion.SubmitChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RegistrarProfesor(Profesor nuevoProfesor)
        {
            try
            {
               
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

             
                var consulta = from p in DBConexion.Profesors
                                        where p.numeroPersonal == nuevoProfesor.numeroPersonal
                                        select p;

                var profesorExistente = consulta.SingleOrDefault();

                if (profesorExistente == null)
                {
                  
                    Profesor profesorNuevo = new Profesor
                    {
                        nombreCompleto = nuevoProfesor.nombreCompleto,
                        numeroPersonal = nuevoProfesor.numeroPersonal
                        
                    };

                    DBConexion.Profesors.InsertOnSubmit(profesorNuevo);
                    DBConexion.SubmitChanges();

                    return true;
                }
                else
                {
                   
                    return false;
                }
            }
            catch (Exception)
            {
               
                return false;
            }
        }

        public static Profesor BuscarProfesorNoPersonal(string numeroPersonal)
        {
            try
            {
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();

                var consulta = from p in DBConexion.Profesors
                               where p.numeroPersonal == numeroPersonal
                               select p;

                var profesorEncontrado = consulta.SingleOrDefault();

                if (profesorEncontrado != null)
                {
                    Profesor profesor = new Profesor()
                    {
                        Id_profesor = profesorEncontrado.Id_profesor,
                        nombreCompleto = profesorEncontrado.nombreCompleto,
                        numeroPersonal = profesorEncontrado.numeroPersonal
                    };

                    return profesor;
                }
                else
                {
                    return null;
                }
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
    }
}