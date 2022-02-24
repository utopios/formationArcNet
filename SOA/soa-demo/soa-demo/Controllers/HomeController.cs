using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Message;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NServiceBus;
using soa_demo.Models;

namespace soa_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMessageSession _messageSession;
        public HomeController(ILogger<HomeController> logger, IMessageSession messageSession)
        {
            _messageSession = messageSession;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NewOrder()
        {
            Random r = new Random();
            var order = new NewOrder()
            {
                Id = r.Next(1000),
                Total = r.Next(1000, 2000)
            };
            order.ToExecute += ActionToExecute;
            await _messageSession.Send(order);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        private void ActionToExecute()
        {
            _logger.LogInformation("Action executed");
        }
    }
}