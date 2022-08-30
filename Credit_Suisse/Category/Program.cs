using System;
using Category;
using Category.Interfaces;

namespace Credit_Suisse
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                
                Console.WriteLine("Iniciando processo em: " + DateTime.Now.ToString() + "\n");
                IList<iNegocio> lst_Negocios = new List<iNegocio>();
                iRisco risco_negocio = new Risco();

                
                Console.Write("Data de referência: ");
                string data_referencia = Console.ReadLine();
                
                Console.Write("Qtde. de negócios: ");
                int qtde_negocios = int.Parse(Console.ReadLine());

                double valor;
                string setor_cliente;
                DateTime proximo_pagamento;

                for (int i = 0; i < qtde_negocios; i++)
                {
                    Console.Write("\nDados da negociação: ");
                    string linha_digitada = Console.ReadLine();
                    string[] array_dados = linha_digitada.Split(' ');

                    valor = double.Parse(array_dados[0]);
                    setor_cliente = array_dados[1];
                    proximo_pagamento = DateTime.Parse(array_dados[2]);


                    lst_Negocios.Add(new Negocio { Valor = valor, Setor_Cliente = setor_cliente, Proximo_Pagamento = proximo_pagamento });

                }
                
                var lst_risco = risco_negocio.getRisco_Negocio((IList<iNegocio>)lst_Negocios);

                foreach(var riscos in lst_risco)
                {
                    Console.WriteLine("\n" + riscos);
                }

                Console.WriteLine("\nProcesso finalizado em: " + DateTime.Now.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();

        }
    }
}