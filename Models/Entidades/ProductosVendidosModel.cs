using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tipo_Datos.Models.Entidades.Base;

namespace Tipo_Datos.Models.Entidades
{
    [Table("ProductosVendidosModel")]
    public class ProductosVendidosModel: BaseModel
    {
        [Required]
        public int ProductosModelId { get; set; }
        public ProductosModel ProductosModel { get; set; }

        public string Nombre { get; set; }

        [Required]
        public double Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Monto { get; set; }

        [Display(Name ="Ventas")]
        [ForeignKey("VentasModel")]
        public int VentasModelId { get; set; }
        public VentasModel VentasModel { get; set; }
    }
}
