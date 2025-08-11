using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tipo_Datos.Data;
using Tipo_Datos.Models.Entidades;

namespace Tipo_Datos.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DatosDbContext _dbContext;
        public ClientesController(DatosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // READ - Lista todos los clientes
        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Clientes.ToListAsync());
        }

        // CREATE - Mostrar formulario nuevo cliente
        public IActionResult Nuevo()
        {
            return View();
        }

        // CREATE - Guardar nuevo cliente
        [HttpPost]
        public async Task<IActionResult> Nuevo([Bind("Nombres,Email,Telefono,Direccion,Cedula_RUC,Create_At,Update_At,isDelete")] ClientesModel cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Create_At = DateTime.Now;
                cliente.Update_At = DateTime.Now;
                _dbContext.Add(cliente);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // Mostrar formulario editar cliente
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _dbContext.Clientes.FindAsync(id);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        // Guardar cambios cliente
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombres,Email,Telefono,Direccion,Cedula_RUC,Create_At,Update_At,isDelete")] ClientesModel cliente)
        {
            if (id != cliente.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Traemos la entidad original desde la DB
                    var clienteDb = await _dbContext.Clientes.FindAsync(id);
                    if (clienteDb == null) return NotFound();

                    // Actualizamos solo las propiedades necesarias
                    clienteDb.Nombres = cliente.Nombres;
                    clienteDb.Email = cliente.Email;
                    clienteDb.Telefono = cliente.Telefono;
                    clienteDb.Direccion = cliente.Direccion;
                    clienteDb.Cedula_RUC = cliente.Cedula_RUC;
                    clienteDb.Update_At = DateTime.Now;

                    // Guardamos cambios
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                        return NotFound();
                    else
                        throw;
                }
            }
            return View(cliente);
        }

        // DELETE - Mostrar confirmación eliminar cliente
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _dbContext.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        // DELETE - Confirmar y eliminar cliente
        [HttpPost, ActionName("EliminarConfirmado")]
        public async Task<IActionResult> EliminarConfirmado(int id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _dbContext.Clientes.Remove(cliente);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _dbContext.Clientes.Any(e => e.Id == id);
        }
    }
}
