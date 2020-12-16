using CleanAech.App.Intefaces;
using CleanAech.App.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ICourseService, CourseService>();

            //Infra Data Layer
            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
