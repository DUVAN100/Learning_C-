using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECleinte
    {
        private int ref_cliente;
        private string nom_cliente;
        private string dir_cliente;
        private string tell_cliente;

        public int Ref_cliente { get => ref_cliente; set => ref_cliente = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Dir_cliente { get => dir_cliente; set => dir_cliente = value; }
        public string Tell_cliente { get => tell_cliente; set => tell_cliente = value; }
    }
}
