namespace DocAppointment.Application.Doctor.Query;
public class LoginQuery : IRequest<bool>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
