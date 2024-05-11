using System.ComponentModel.DataAnnotations;

namespace TeamHost.Web.Areas.Auth.Models;

/// <summary>
/// Модель для регистрации
/// </summary>
public class RegisterViewModel
{
    /// <summary>
    /// Почта
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    /// <summary>
    /// Пароль
    /// </summary>
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    /// <summary>
    /// Имя пользоватля
    /// </summary>
    [Required]
    public string UserName { get; set; }

    /// <summary>
    /// Подтверждение пароля
    /// </summary>
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password",
        ErrorMessage = "Password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}