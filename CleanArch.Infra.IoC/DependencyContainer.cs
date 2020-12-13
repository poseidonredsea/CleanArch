using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repos;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {

            // Application layer

            service.AddScoped<ICourseService, CourseService>();

            // Data Infra Layer

            service.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
