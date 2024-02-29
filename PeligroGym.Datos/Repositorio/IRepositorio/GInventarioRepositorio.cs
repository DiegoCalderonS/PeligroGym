using PeligroGym.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeligroGym.Datos.Repositorio.IRepositorio
{
    public interface GInventarioRepositorio : IRepositorio<Inventario>
    {
        void actualizar(Inventario inventario);
    }
}
