namespace DocAppointment.Application.Doctor.Query;
public class DoctorQueryHandler : IRequestHandler<LoginQuery, bool>
{
    #region Feilds
    private readonly IDoctorRepository _doctorRepository;


    #endregion

    #region Constructor 
    public DoctorQueryHandler(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public async Task<bool> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        return false;
    }


    #endregion




}
