using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model
{
    public class ConstanciaImparticionParams
    {
        public int FK_Id_constancia { get; set; }
        public string bloque { get; set; }
        public string credito { get; set; }
        public string esperienciaEducativa { get; set; }
        public TimeSpan hora { get; set; }
        public DateTime mes { get; set; }
        public string prograamaEducativo { get; set; }
        public string seccion { get; set; }
    }

}