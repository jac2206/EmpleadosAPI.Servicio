﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FisaPayEmpleadosDBEntities : DbContext
    {
        public FisaPayEmpleadosDBEntities()
            : base("name=FisaPayEmpleadosDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<uspObtenerEmpleados_Result> uspObtenerEmpleados()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspObtenerEmpleados_Result>("uspObtenerEmpleados");
        }
    
        public virtual int uspEliminarEmpleado(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspEliminarEmpleado", idParameter);
        }
    
        public virtual int uspActualizarEmpleado(Nullable<long> id, string nombres, string apellidos, string sexo, string fechaNacimiento, Nullable<long> salario, string vacunadoCovid)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var salarioParameter = salario.HasValue ?
                new ObjectParameter("Salario", salario) :
                new ObjectParameter("Salario", typeof(long));
    
            var vacunadoCovidParameter = vacunadoCovid != null ?
                new ObjectParameter("VacunadoCovid", vacunadoCovid) :
                new ObjectParameter("VacunadoCovid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspActualizarEmpleado", idParameter, nombresParameter, apellidosParameter, sexoParameter, fechaNacimientoParameter, salarioParameter, vacunadoCovidParameter);
        }
    
        public virtual int uspGuardarEmpleado(string nombres, string apellidos, string sexo, string fechaNacimiento, Nullable<long> salario, string vacunadoCovid)
        {
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var salarioParameter = salario.HasValue ?
                new ObjectParameter("Salario", salario) :
                new ObjectParameter("Salario", typeof(long));
    
            var vacunadoCovidParameter = vacunadoCovid != null ?
                new ObjectParameter("VacunadoCovid", vacunadoCovid) :
                new ObjectParameter("VacunadoCovid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspGuardarEmpleado", nombresParameter, apellidosParameter, sexoParameter, fechaNacimientoParameter, salarioParameter, vacunadoCovidParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> uspObtenerTotalSalario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("uspObtenerTotalSalario");
        }
    }
}