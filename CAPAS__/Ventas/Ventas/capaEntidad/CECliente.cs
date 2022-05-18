using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CECliente
    {
        private int Cod_cliente;
        private string nom_cliente;
        private string cell_cliente;
        private string gmail_cliente;

        public int Cod_cliente1 { get => Cod_cliente; set => Cod_cliente = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Cell_cliente { get => cell_cliente; set => cell_cliente = value; }
        public string Gmail_cliente { get => gmail_cliente; set => gmail_cliente = value; }
    }
}
