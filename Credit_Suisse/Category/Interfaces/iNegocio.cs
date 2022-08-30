using System;

namespace Category.Interfaces
{
    public interface iNegocio
    {
        double Valor { get; }
        string Setor_Cliente { get; }
        DateTime Proximo_Pagamento { get; }
    }
}