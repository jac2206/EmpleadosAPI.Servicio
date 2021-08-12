using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIEmpleados.Servicio.Common
{
    public class DataInput
    {
    }

    public class Empleado
    {

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public long Salario { get; set; }
        public string VacunadoCovid { get; set; }

    }

    public class EditarEmpleado
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public long Salario { get; set; }
        public string VacunadoCovid { get; set; }
    }

    public class EliminarEmpleado
    {

        public int Id { get; set; }

    }

    public class EnvioJson
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public long Salario { get; set; }
        public string VacunadoCovid { get; set; }
    }

    public class EnvioJsonEmpleadosSalario
    {

        public int NumeroEmpleados { get; set; }
        public long TotalSalarioEmpleados { get; set; }
       
    }

}