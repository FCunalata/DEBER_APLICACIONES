using Tipo_Datos.Models.Entidades;

namespace Tipo_Datos.Models.ViewModel
{
    public class DashboardViewModel
    {
        public int Clienntes { get; set; }
        public int Productos { get; set; }
        public int Numero_Ventas { get; set; }
        public double Total_Ventas { get; set; }
        public List<VentasModel> UltimasVentas { get; set; }

    }
}
