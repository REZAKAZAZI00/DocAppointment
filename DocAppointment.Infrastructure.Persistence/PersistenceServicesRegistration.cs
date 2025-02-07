namespace DocAppointment.Infrastructure.Persistence;
public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection")));


        #region Services

        
        #endregion



        #region Repository
        //services.AddScoped<IUserRepository, UserRepository>();

        #endregion



        return services;
    }
}
