using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FabricaProductor
    {
        public static FabricaAbstracta getFactory(String tipoFabrica)
        {
            if(tipoFabrica == "BD")
            {
                return new ConexionFabrica();
            }else if(tipoFabrica == "REST")
            {
                return new ConexionRESTFabrica();
            }
            return null;
        }
    }
}
