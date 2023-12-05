using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_SGDC.Modelo
{
    internal class ConstanciaViewModel
    {
        public ConstanciaViewModel()
        {

        }

        public async Task<List<ConstanciaUnion1>?> ListarConstancia()
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
            {
                ConstanciaUnion1[] lista = await servicio.ListarConstanciaAsync();

                if (lista != null)
                {
                     List<ConstanciaUnion1> listaConstancia = new List<ConstanciaUnion1>(lista);
                    return listaConstancia;
                }
                else
                    return null;
            }
            else
                return null;
        }
        public async Task<bool> rearConstanciaJudge(Constancia constancia, ConstanciaJurado constanciaJurado)
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
                return await servicio.CrearConstanciaJudgeAsync(constancia, constanciaJurado);
            else
                return false;
        }
        public async Task<bool> CrearConstanciaPladea(Constancia constancia, ConstanciaPLADEA constanciaPladea)
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
                return await servicio.CrearConstanciaPladeaAsync(constancia, constanciaPladea);
            else
                return false;
        }
        public async Task<bool> CrearConstanciaProject(Constancia constancia, ConstanciaProyecto constanciaProyecto)
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
                return await servicio.CrearConstanciaProjectAsync(constancia, constanciaProyecto);
            else
                return false;
        }
        public async Task<bool> CrearConstanciaTeaching(Constancia constancia, ConstanciaImparticion constanciaImparticion)
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
                return await servicio.CrearConstanciaTeachingAsync(constancia, constanciaImparticion);
            else
                return false;
        }
    }
}
