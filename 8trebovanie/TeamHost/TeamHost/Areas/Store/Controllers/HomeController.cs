using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Application.Features.Games.Queries;
using TeamHost.Domain.Entities;

namespace TeamHost.Web.Areas.Store.Controllers
{
    [Area("Store")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(GetAllGamesQuery query)
        {
            var result = await _mediator.Send(query);
            return View(result);
        }
    }

}
