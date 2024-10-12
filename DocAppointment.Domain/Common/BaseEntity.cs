namespace DocAppointment.Domain.Common;
public class BaseEntity<T>
{
    [Key]
    public T Id { get; set; }

    public DateTime CreateDate { get; set; } = DateTime.Now;

}
