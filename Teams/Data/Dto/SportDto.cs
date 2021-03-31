using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Data.Models
{
    public class SportDto
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
