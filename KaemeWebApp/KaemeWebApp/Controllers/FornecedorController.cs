using KaemeWebApp.Data;
using KaemeWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaemeWebApp.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FornecedorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Fornecedor> objFornecedorList = _db.Fornecedor;
            return View(objFornecedorList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] -- Implementar com AJAX
        public IActionResult Create(Fornecedor obj)
        {
            if (obj.RazaoSocial != null)
            {
                _db.Fornecedor.Add(obj);
                _db.SaveChanges();
                TempData["fornecedor_create"] = "Fornecedor cadastrado com sucesso";
                return Json(new { newUrl = Url.Action("Index", "Fornecedor") });
            }

            return View(obj);

        }

    }
}
