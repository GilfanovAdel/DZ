using Microsoft.AspNetCore.Identity;
using TeamHost.Domain.Common;

namespace TeamHost.Domain.Entities;

/// <summary>
/// Профиль пользователя
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Отчетсво
    /// </summary>
    public string? Patronimic { get; set; }

    /// <summary>
    /// Информация "Обо мне" 
    /// </summary>
    public string? About { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Страна
    /// </summary>
    public Country? Country { get; set; }

    /// <summary>
    /// ID пользователя
    /// </summary>
    public string IdentityUserId { get; set; }
    
    /// <summary>
    /// Пользователь
    /// </summary>
    public IdentityUser IdentityUser { get; set; }

}
