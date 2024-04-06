using FormulariosConRazor_HtmlHelper_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormulariosConRazor_HtmlHelper_1.Controllers
{
    public class UsuariosAltaController : Controller
    {
        private readonly usuariosDbContext _usuariosDbContext;

        public UsuariosAltaController(usuariosDbContext usuariosDbContext)
        {
            _usuariosDbContext = usuariosDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(usuarios nuevosUsuarios)
        {
            _usuariosDbContext.Add(nuevosUsuarios);
            _usuariosDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
