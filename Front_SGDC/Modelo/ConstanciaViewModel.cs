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
    }
}
