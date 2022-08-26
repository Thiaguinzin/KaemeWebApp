﻿using KaemeWebApp.Data;
using KaemeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaemeWebApp.Controllers
{
    public class FreteStatusController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FreteStatusController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<FreteStatus> objFreteStatusList = _db.FreteStatus;
            return View(objFreteStatusList);
        }
    }
}
