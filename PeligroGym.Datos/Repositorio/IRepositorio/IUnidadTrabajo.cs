using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeligroGym.Datos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        GInventarioRepositorio Inventario {  get; }

        Task Guardar();
    }
}
