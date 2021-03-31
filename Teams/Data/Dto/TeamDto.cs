using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Data.Models
{
    /// <summary>
    /// Команда
    /// </summary>
    public class TeamDto
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя команды
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор вида спорта.
        /// </summary>
        public int? SportId { get; set; }

        /// <summary>
        /// Вид Спорта.
        /// </summary>
        public string SportName { get; set; }
    }
}
