namespace DocAppointment.Infrastructure.Persistence.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    #region Doctor

    public DbSet<Doctor> Doctors { get; set; }


    #endregion



}

