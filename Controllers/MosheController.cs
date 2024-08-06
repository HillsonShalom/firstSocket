using Microsoft.AspNetCore.Mvc;

namespace firstSocket.Controllers
{
    public class MosheController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
