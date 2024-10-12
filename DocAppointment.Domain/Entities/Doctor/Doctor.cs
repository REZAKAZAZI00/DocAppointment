namespace DocAppointment.Domain.Entities.Doctor;
public class Doctor : BaseEntity<Guid>
{
    #region Properties


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public Address ClinicAddress { get; set; }
    #endregion
}
