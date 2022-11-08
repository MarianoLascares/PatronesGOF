using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class ConexionRESTFabrica : FabricaAbstracta
    {
        public IConexion getBD(string motor)
        {
            return null;
        }

        public IConexionREST getREST(string area)
        {
            if(area == null)
            {
                return new ConexionRESTNoArea();
            }
            if (area == "COMPRAS")
            {
                return new ConexionRESTCompras();
            } else if (area == "VENTAS")
            {
                return new ConexionRESTVentas();
            }
            return new ConexionRESTNoArea();
        }
    }
}
