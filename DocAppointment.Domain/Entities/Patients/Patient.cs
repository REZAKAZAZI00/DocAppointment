namespace DocAppointment.Domain.Entities.Patients;
public class Patient:BaseEntity<Guid>
{

    #region Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public Address Address { get; set; }
    #endregion


}
