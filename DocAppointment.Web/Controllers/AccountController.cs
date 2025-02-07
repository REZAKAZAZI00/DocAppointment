
namespace DocAppointment.Web.Controllers;

public class AccountController : BaseController
{
    #region fields
    
    #endregion

    #region Constructor

    #endregion

    #region Actions

    #region Login

    public async Task<IActionResult> Login(string returnUrl)
    {
        
        return View();
    }

    #endregion

    #region Register
    public  async Task<IActionResult> Register(DoctorRegisterCommand model)
    {
       await mediatR.Send(model);
        return View(model);
    }
    #endregion
    #endregion
}
