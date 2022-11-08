using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionFabrica
    {
        public IConexion getConexion(String motor)
        {
            if (motor == null)
            {
                return new ConexionVacia();
            }
            if(motor == "MYSQL")
            {
                return new ConexionMySQL();
            }else if(motor == "ORACLE")
            {
                return new ConexionOracle();
            }else if(motor == "POSTGRE")
            {
                return new ConexionPostgreSQL();
            }else if(motor == "SQL")
            {
                return new ConexionSQLServer();
            }

            return new ConexionVacia();
        }
    }
}
