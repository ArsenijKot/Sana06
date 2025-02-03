using Microsoft.AspNetCore.Mvc;

namespace Sana06.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Contact()
        {
            ViewData["Title"] = "Контакти";
            ViewData["Message"] = "Зв'яжіться з нами за наступними контактами:";
            return View();
        }

        public IActionResult FAQ()
        {
            ViewData["Title"] = "Часті питання";
            return View();
        }
    }
}
