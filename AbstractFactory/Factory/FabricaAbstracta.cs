using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface FabricaAbstracta
    {
        IConexion getBD(String motor);
        IConexionREST getREST(String area);
    }
}
