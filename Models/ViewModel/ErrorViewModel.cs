namespace Tipo_Datos.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RespuestId { get; set; }
        public bool MostrarIdRespuesta => !string.IsNullOrEmpty(RespuestId);
    }
}
