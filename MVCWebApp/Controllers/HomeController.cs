using AzureStorageLibrary.Models;
using AzureStorageLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;
using System.Diagnostics;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoSqlStorage<Player> _noSqlStorage;

        public HomeController(INoSqlStorage<Player> noSqlStorage)
        {
            _noSqlStorage = noSqlStorage;
        }

        public async Task<IActionResult> Index()
        {
            var player = new Player("player", "playerov", new DateOnly(2005, 05, 05).ToString(), 1000, 12, "Players");
            await _noSqlStorage.Add(player);
            ViewBag.players = (await _noSqlStorage.All()).ToList();
            return View();
        }
    }
}
