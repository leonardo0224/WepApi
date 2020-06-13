using Biblioteca.Aplicacion.Contracts.ServicesContracts;
using Biblioteca.Aplicacion.Services;
using Biblioteca.DataAcces.Contracts.RepositoryContracts;
using Biblioteca.DataAcces.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Common.Registre
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services) 
        {
            AddRegisterRepositori(services);
            AddRegisterRServices(services);
            return services;
        }
        private static IServiceCollection AddRegisterRServices(IServiceCollection services) 
        {
            services.AddTransient<IAutorService, AutorServices>();
            services.AddTransient<ICategoriaService, CategoriaServices>();
            services.AddTransient<ILibroServices, LibrosServices>();
            return services;
        }
        
        private static IServiceCollection AddRegisterRepositori(IServiceCollection services) 
        {
            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ILibrosRepository, LibroRepository>();
            return services;
        }
    }
}
