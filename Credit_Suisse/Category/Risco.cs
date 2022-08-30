using System;
using Category.Interfaces;

namespace Category
{
    public class Risco : iRisco
    {
        private readonly iServico_Risco servico_risco;

        public Risco()
        {
            servico_risco = new Servico_Risco();
        }

        public IList<string> getRisco_Negocio(IList<iNegocio> negocios)
        {
            var listaRisco_Negocio = servico_risco.getRisco_Negocio(negocios);
            return listaRisco_Negocio;
        }
    }
}