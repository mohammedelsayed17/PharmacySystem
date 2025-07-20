using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PharmacySystem.Controllers
{
    public class CookieController : Controller
    {
        // These methods are not used

        public IActionResult SetCookie()
        {
            Response.Cookies.Append("DemoCookie", "Value123", new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(7)
            });
            return Content("Cookie set!");
        }

        public IActionResult GetCookie()
        {
            var value = Request.Cookies["DemoCookie"];
            return Content("Cookie value: " + value);
        }

        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("DemoCookie");
            return Content("Cookie deleted.");
        }
    }
}
