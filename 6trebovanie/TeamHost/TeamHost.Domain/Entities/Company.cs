using TeamHost.Domain.Common;

namespace TeamHost.Domain.Entities
{
    /// <summary>
    /// Разработчик
    /// </summary>
    public class Company : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public Country Country { get; set; }
    }
}
