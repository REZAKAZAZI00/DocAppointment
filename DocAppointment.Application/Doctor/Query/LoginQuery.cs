namespace DocAppointment.Application.Doctor.Query;
public class LoginQuery : IRequest<bool>
{
    public string Password { get; set; }
}
