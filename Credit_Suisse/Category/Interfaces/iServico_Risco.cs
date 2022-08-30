using System;

namespace Category.Interfaces
{
    public interface iServico_Risco
    {
        IList<string> getRisco_Negocio(IList<iNegocio> negocios);
    }
}
