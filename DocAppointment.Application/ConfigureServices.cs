using FluentValidation;
using System.Reflection;
using MediatR;
using DocAppointment.Application.Common.Behaviours;

namespace DocAppointment.Application;
public static class ConfigureServices
{
    public static IServiceCollection RegisterAppliactionServices(this IServiceCollection services)
    {

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,> ));

        });
        return services;
    }

}
