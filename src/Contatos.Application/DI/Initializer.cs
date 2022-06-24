using Contatos.Domain.Interfaces;
using Contatos.Domain.Models;
using Contatos.Infra.Context;
using Contatos.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Contatos.Application.DI {

    public class Initializer 
    {

        public static void Configure (IServiceCollection services, string conection) 
        {
            services.AddDbContext<AppDbContext> (options => options.UseSqlServer (conection));
            services.AddScoped (typeof (IRepository<Contato>), typeof (ContatoRepository));
            services.AddScoped (typeof (IRepository<>), typeof (Repository<>));
            services.AddScoped (typeof (ContatoService));
            services.AddScoped (typeof (IUnitOfWork), typeof (UnitOfWork));
        }
    }
}  