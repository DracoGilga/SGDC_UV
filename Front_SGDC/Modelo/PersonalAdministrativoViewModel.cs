using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_SGDC.Modelo
{
    internal class PersonalAdministrativoViewModel
    {
        public PersonalAdministrativoViewModel()
        {
        }

        public async Task<Boolean> InicioSesion(String usuario, String password)
        {
            Service1Client servicio = new Service1Client();
            if (servicio != null)
            {
                bool result = await servicio.LoginAsync(usuario, password);
                if (result)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}