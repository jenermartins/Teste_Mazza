using System;
using Category.Interfaces;

namespace Category
{
    public class Servico_Risco : iServico_Risco
    {
        private iRisco_Negocio risco_negocio { get; set; }

        public IList<string> getRisco_Negocio(IList<iNegocio> negocios)
        {
            IList<string> listaRisco_Negocio = new List<string>();

            var vDicionario_Negocio = new Dictionary<string, Delegate>
            {
                ["Privado"] = new Func<double, string>(getRisco_Privado),
                ["Publico"] = new Func<double, string>(getRisco_Publico)
            };

            foreach (var negocio in negocios)
            {
                var tipo_Risco = vDicionario_Negocio[negocio.Setor_Cliente].DynamicInvoke(negocio.Valor);
                listaRisco_Negocio.Add(tipo_Risco.ToString());
            }

            return listaRisco_Negocio;
        }

        private string getRisco_Privado(double Valor_Operacao)
        {
            risco_negocio = new Risco_Setor_Privado();
            string strRisco_Privado = risco_negocio.getRisco(Valor_Operacao, 1000000);
            return strRisco_Privado;
        }

        private string getRisco_Publico(double Valor_Operacao)
        {
            risco_negocio = new Risco_Setor_Publico();
            string strRisco_Publico = risco_negocio.getRisco(Valor_Operacao, 1000000);
            return strRisco_Publico;
        }

    }
}