using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Features.Account.DTOs
{
    public class AccountDto
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
        /// Дата рождения
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Отчетсво
        /// </summary>
        public string? Patronimic { get; set; }

        /// <summary>
        /// Информация "Обо мне" 
        /// </summary>
        public string? About { get; set; }
    }
}
