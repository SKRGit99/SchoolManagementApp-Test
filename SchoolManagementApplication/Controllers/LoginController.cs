using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult GetLoginDetails()
        {
            return View();
        }
    }
}
