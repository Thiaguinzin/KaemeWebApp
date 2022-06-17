﻿using KaemeWebApp.Data;
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
    }
}