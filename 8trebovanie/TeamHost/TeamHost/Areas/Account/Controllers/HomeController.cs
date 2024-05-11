using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TeamHost.Application.Features.Account.Commands;
using TeamHost.Application.Features.Account.Queries;

namespace TeamHost.Web.Areas.Account.Controllers;

/// <summary>
/// Контроллер профиля пользователя
/// </summary>
[Area("Account")]
[Authorize]
public class HomeController : Controller
{
    private readonly IMediator _mediator;

    public HomeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        var result = await _mediator.Send(new GetAccountByIdQuery() { Id = userId});
        return View(result);

        // Получаем Id текущего пользователя
        

        // Находим профиль текущего пользователя
        //var userProfile = _context.UserProfiles.FirstOrDefault(up => up.IdentityUserId == userId);

        //return View(userProfile);
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromForm] SaveProfile save)
    {
        save.IdentityUserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        var result = await _mediator.Send(save);

        return RedirectToAction("index", "home", new
        {
            Area = "Account",
        });
    }
}