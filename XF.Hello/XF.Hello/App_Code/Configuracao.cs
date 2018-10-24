using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello.App_Code
{
    public class Configuracao
    {
        public bool RastrearLocalizacao { get; set; }

        public bool PermitirCookie { get; set; }

        public bool DisponibilizarNoMural { get; set; }

        public bool EnviarPorEmail { get; set; }
        
        public bool ReceberSMS { get; set; }
        
    }
}
