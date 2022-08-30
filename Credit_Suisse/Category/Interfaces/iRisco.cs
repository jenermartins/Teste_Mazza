using System;

namespace Category.Interfaces
{
    public interface iRisco
    {
        IList<string> getRisco_Negocio(IList<iNegocio> negocios);
    }
}