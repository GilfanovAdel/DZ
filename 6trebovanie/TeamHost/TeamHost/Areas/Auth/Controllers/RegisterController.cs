using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Web.Areas.Auth.Models;

namespace TeamHost.Web.Areas.Auth.Controllers;

[Area("Auth")]
[AllowAnonymous]
public class RegisterController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="userManager">Сервис работы с пользователем</param>
    /// <param name="signInManager">Сервис работы с аутентификацией</param>
    public RegisterController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }
        
    public IActionResult Index()
    {
        return View();
    }
        
    /// <summary>
    /// Регистрация
    /// </summary>
    /// <param name="model">Модель</param>
    /// <returns>-</returns>
    [HttpPost]
    public async Task<IActionResult> Index([FromForm] RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Copy data from RegisterViewModel to IdentityUser
            var user = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email
            };

            // Store user data in AspNetUsers database table
            var result = await _userManager.CreateAsync(user, model.Password);

            // If user is successfully created, sign-in the user using
            // SignInManager and redirect to index action of HomeController
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("index", "home", new
                {
                    Area = "",
                });
            }

            // If there are any errors, add them to the ModelState object
            // which will be displayed by the validation summary tag helper
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(model);
    }
}