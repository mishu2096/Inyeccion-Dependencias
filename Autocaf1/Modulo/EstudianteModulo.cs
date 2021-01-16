using Autocaf1.IRepositorio;
using Autocaf1.Repositorio;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocaf1.Modulo
{
   public class EstudianteModulo :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EstudianteRepositorio>().As<IEstudianteRepositorio>();
            base.Load(builder);
        }
    }
}
