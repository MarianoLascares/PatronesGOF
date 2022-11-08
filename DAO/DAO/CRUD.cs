using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface CRUD<T>
    {
        List<T> GetAll();
        T leerPorId(int id);
        void Registrar(T t);
        void Actualizar(T t);
        void Eliminar(int id);
    }
}
