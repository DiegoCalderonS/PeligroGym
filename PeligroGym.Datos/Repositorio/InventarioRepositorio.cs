using PeligroGym.Datos.Datos;
using PeligroGym.Datos.Repositorio.IRepositorio;

using PeligroGym.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeligroGym.Datos.Repositorio
{
    public class InventarioRepositorio : Repositorio<Inventario>, GInventarioRepositorio
    {
        private readonly ApplicationDbContext _db;
        public InventarioRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void actualizar(Inventario inventario)
        {
            var bodegaBD = _db.inventarios.FirstOrDefault(b => b.id == inventario.id);
            if (bodegaBD != null)
            {

                bodegaBD.Nombre = inventario.Nombre;
                bodegaBD.Descripcion = inventario.Descripcion;
                bodegaBD.Estado = inventario.Estado;
                _db.SaveChanges();
            }
        }
    }
}
