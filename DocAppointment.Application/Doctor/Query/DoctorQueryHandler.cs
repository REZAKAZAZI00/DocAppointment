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

   
    #endregion

    public async Task<bool> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var doctor=_doctorRepository.TableNoTracking.Any(d=> d.Email == request.Email);

        return doctor;
    }


}
