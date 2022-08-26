using KaemeWebApp.Data;
using KaemeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaemeWebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> objClienteList = _db.Cliente;
            return View(objClienteList);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var clienteDb = _db.Cliente.Find(id);
            if (clienteDb == null)
            {
                return NotFound();
            }

            return View(clienteDb);
        }

        public IActionResult View(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var clienteDb = _db.Cliente.Find(id);
            if (clienteDb == null)
            {
                return NotFound();
            }

            return View(clienteDb);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] -- Implementar com AJAX
        public IActionResult Create(Cliente obj)
        {
            if (obj.Nome != null)
            {
                _db.Cliente.Add(obj);
                _db.SaveChanges();
                TempData["cliente_create"] = "Cliente cadastrado com sucesso";
                return Json(new { newUrl = Url.Action("Index", "Cliente") });
            }

            return View(obj);

        }

        [HttpPost]
        //[ValidateAntiForgeryToken] -- Implementar com AJAX
        public IActionResult Edit(Cliente obj)
        {
            if (obj.Nome != null)
            {
                _db.Cliente.Update(obj);
                _db.SaveChanges();
                TempData["cliente_edit"] = "Cliente editado com sucesso";
                return Json(new { newUrl = Url.Action("Index", "Cliente") });
            }

            return View(obj);

        }

        [HttpPost]
        //[ValidateAntiForgeryToken] -- Implementar com AJAX
        public IActionResult Delete(int? id)
        {
            var obj = _db.Cliente.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Cliente.Remove(obj);
            _db.SaveChanges();
            return Json(new { status = "Success" });

        }
    }
}
