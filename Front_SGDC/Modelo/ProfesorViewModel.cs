﻿using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_SGDC.Modelo
{
    class ProfesorViewModel
    {
        public ProfesorViewModel()
        {

        }

        public async Task<List<Profesor>?> ObtenerNumerosPersonales()
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
            {
                Profesor[] lista = await servicio.ObtenerNumerosPersonalesAsync();

                if (lista != null)
                {
                    List<Profesor> listaConstancia = new List<Profesor>(lista);
                    return listaConstancia;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public async Task<bool> ModificarProfesor(Profesor profesor)
        {
            try
            {
                Service1Client servicio = new Service1Client();
                if (servicio != null)
                {
                    bool result = await servicio.ModificarProfesorAsync(profesor);
                    if (result)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AgregarProfesor(Profesor profesor)
        {
            try
            {
                Service1Client servicio = new Service1Client();
                if (servicio != null)
                {
                    bool result = await servicio.AgregarProfesorAsync(profesor);
                    if (result)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Task<Profesor> BuscarProfesorNoPersonal(string numeroPersonal)
        {
            try
            {
                Service1Client servicio = new Service1Client();
                if (servicio != null)
                {
                    servicio.BuscarProfesorNoPersonalAsync(numeroPersonal);
                    if(servicio != null)
                        return servicio.BuscarProfesorNoPersonalAsync(numeroPersonal);
                    else
                        return null;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

    }
}
