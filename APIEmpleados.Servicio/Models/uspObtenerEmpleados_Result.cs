//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIEmpleados.Servicio.Models
{
    using System;
    
    public partial class uspObtenerEmpleados_Result
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string EdadALaFecha { get; set; }
        public long Salario { get; set; }
        public string VacunadoCovid { get; set; }
    }
}