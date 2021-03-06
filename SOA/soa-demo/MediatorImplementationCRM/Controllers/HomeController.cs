using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatorImplementationCRM.Handlers.Commands;
using MediatorImplementationCRM.Handlers.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatorImplementationCRM.Models;
using MediatR;

namespace MediatorImplementationCRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NewCustomer()
        {
             Customer customer = await _mediator.Send(new NewCustomerCommand()
            {
                Customer = new Customer()
                {
                    Id = 1,
                    FirstName = "ihab",
                    LastName = "abadi"
                }
            });
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GetCustomers()
        {
            List<Customer> customers = await _mediator.Send(new GetCustomersQuery()
            {
                Name = "toto"
            });
            return View("Index");
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
    }
}