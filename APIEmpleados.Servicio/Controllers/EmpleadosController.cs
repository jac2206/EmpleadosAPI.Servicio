using APIEmpleados.Servicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Globalization;
using APIEmpleados.Servicio.Common;

namespace APIEmpleados.Servicio.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Empleados")]
    public class EmpleadosController : ApiController
    {

        [Route("ObtenerEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpGet]
        public List<uspObtenerEmpleados_Result> ObtenerEmpleados()
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                List<uspObtenerEmpleados_Result> empleadosList = new List<uspObtenerEmpleados_Result>();

                using (var DB = new FisaPayEmpleadosDBEntities())
                {
                    empleadosList = DB.uspObtenerEmpleados().ToList();
                    return (empleadosList);
                }


            }

            catch (Exception ex)
            {
                return null;
                //return (ex.ToString());

            }
        }

        [Route("ObtenerTotalSalario")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpGet]
        public long? ObtenerTotalSalario()
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                long? totalSalario;

                using (var DB = new FisaPayEmpleadosDBEntities())
                {
                    totalSalario = DB.uspObtenerTotalSalario().FirstOrDefault();
                    return (totalSalario);
                }


            }

            catch (Exception ex)
            {
                return 0;
                //return (ex.ToString());

            }
        }

        [Route("GuardarEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpPost]
        public string GuardarEmpleado([FromBody] Empleado datos)
        {
            try
            {

                using (var DB = new FisaPayEmpleadosDBEntities())
                {
                    if (datos != null && ModelState.IsValid)
                    {
                        DB.uspGuardarEmpleado(
                              datos.Nombres,
                              datos.Apellidos,
                              datos.Sexo,
                              datos.FechaNacimiento,
                              datos.Salario,
                              datos.VacunadoCovid);
                        DB.SaveChanges();
                    }
                }


                return ("Los datos se guardaron correctamente");

            }

            catch (Exception ex)
            {
                return (ex.ToString());

            }

        }

        [Route("RecibirJsonEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpPost]
        public string RecibirJsonEmpleados([FromBody] List<EnvioJson> datos)
        {
            try
            {
                string mensajeEnviar = "";

                if (datos != null || datos.Count > 0)
                {
                    mensajeEnviar = "Los datos se recibieron correctamente";
                    //return ("Los datos se recibieron correctamente");
                }

                if(datos.Count == 0)
                {
                    mensajeEnviar = "No hay datos enciados";
                    //return ("No hay datos enciados");

                }

                return (mensajeEnviar);
            }

            catch (Exception ex)
            {
                return (ex.ToString());

            }

        }

        [Route("RecibirJsonNumeroYSalarioEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpPost]
        public string RecibirJsonNumeroYSalarioEmpleados([FromBody] EnvioJsonEmpleadosSalario datos)
        {
            try
            {
                string mensajeEnviar = "";

                if (datos != null )
                {
                    mensajeEnviar = "Los datos se recibieron correctamente";
                    //return ("Los datos se recibieron correctamente");
                }

                else
                {
                    mensajeEnviar = "No hay datos enciados";
                    //return ("No hay datos enciados");

                }

                return (mensajeEnviar);
            }

            catch (Exception ex)
            {
                return (ex.ToString());

            }

        }

        [Route("EditarEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpPost]
        public string EditarEmpleado([FromBody] EditarEmpleado datos)
        {
            try
            {

                using (var DB = new FisaPayEmpleadosDBEntities())
                {
                    if (datos != null && ModelState.IsValid)
                    {
                        DB.uspActualizarEmpleado(
                              datos.Id,
                              datos.Nombres,
                              datos.Apellidos,
                              datos.Sexo,
                              datos.FechaNacimiento,
                              datos.Salario,
                              datos.VacunadoCovid);
                        DB.SaveChanges();
                    }
                }


                return ("Los datos se guardaron correctamente");

            }

            catch (Exception ex)
            {
                return (ex.ToString());

            }

        }

        [Route("EliminarEmpleados")]
        [Route("GetAllAuthor")]
        [Route("Access-Control-Allow-Methods")]
        [Route("Access-Control-Allow-Origin")]
        [HttpDelete]
        //public string EliminarEmpleado([FromBody] EliminarEmpleado datos)
        public string EliminarEmpleado(int id)
        {
            try
            {

                using (var DB = new FisaPayEmpleadosDBEntities())
                {
                    if (id != null && ModelState.IsValid)
                    {
                        DB.uspEliminarEmpleado(id);
                        DB.SaveChanges();
                    }
                }


                return ("Los datos se eliminaron correctamente");

            }

            catch (Exception ex)
            {
                return (ex.ToString());

            }

        }
    }
}
