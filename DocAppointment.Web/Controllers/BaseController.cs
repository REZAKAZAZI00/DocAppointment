namespace DocAppointment.Web.Controllers;
public class BaseController : Controller
{
    #region Feilds
    private ISender _MediatR;




    #endregion

    #region Constructor

    protected ISender mediatR =>  _MediatR ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    


    #endregion
}
