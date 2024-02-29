using PeligroGym.Datos.Datos;
using PeligroGym.Datos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeligroGym.Datos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public GInventarioRepositorio Inventario { get; set; }
        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Inventario = new InventarioRepositorio(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
