using ServiceReference1;
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

        public async Task<List<string>?> ObtenerNumerosPersonales()
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
            {
                string[] lista = await servicio.ObtenerNumerosPersonalesAsync();

                if (lista != null)
                {
                    List<string> listaConstancia = new List<string>(lista);
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
    }
}
