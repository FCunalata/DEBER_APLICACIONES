using Microsoft.EntityFrameworkCore;
using Tipo_Datos.Models.Entidades;
namespace Tipo_Datos.Data
{
    public class DatosDbContext:DbContext
    {
        public DatosDbContext(DbContextOptions op):base(op){}
        public DbSet<ClientesModel> Clientes { get; set; }
        public DbSet<ProductosModel> Productos { get; set; }
        public DbSet<ProductosVendidosModel> ProductosVendidos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<VentasModel> Ventas { get; set; }
        public DbSet<ConfiguracionesModel> ConfiguracionesEmpresa { get; set; }
    }
}