using System;
using Category.Interfaces;

namespace Category
{
    public class Negocio : iNegocio
    {
        public double Valor { get; set; }
        public string Setor_Cliente { get; set; }
        public DateTime Proximo_Pagamento { get; set; }
    }
}