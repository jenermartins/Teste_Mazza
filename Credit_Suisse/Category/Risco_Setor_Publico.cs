using System;
using Category.Interfaces;

namespace Category
{
    public class Risco_Setor_Publico : iRisco_Negocio
    {
        public string getRisco(double Valor, double Limite_Risco)
        {

            if (Valor < Limite_Risco)
            {
                return "LOWRISK";
            }
            else
            {
                return "MEDIUMRISK";
            }
        }

    }
}