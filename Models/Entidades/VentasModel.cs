using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tipo_Datos.Models.Entidades.Base;

namespace Tipo_Datos.Models.Entidades
{
    [Table("Ventas")]
    public class VentasModel:BaseModel
    {
       
        [Required(ErrorMessage ="El campo es requerido")]
        [Display(Name ="Fecha de Venta")]
        public DateTime FechaVenta { get; set; }
        [Display(Name = "Codigo de venta")]
        public string Codigo_Venta { get; set; }
        public string Notas { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public double Sub_Total_Venta { get; set; }
        public string Estado_Venta { get; set; }
        public double? Descuento { get; set; }
        public double Total_Venta { get; set; }

        public string Metodo_Pago { get; set; }
        [Display(Name ="ClienteId")]
        [ForeignKey("ClientesModel")]
        public int ClientesModelId { get; set; }
        public ClientesModel ClientesModel { get; set; }
        public ICollection<ProductosVendidosModel> Productos_Vendidos { get; set; }

        public VentasModel()
        {
            Productos_Vendidos = new List<ProductosVendidosModel>();
        }
    }
}
