using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad.API.Models
{
    public class Employees
    {
        [Key]
        
        public int Id { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        public string position { get; set; }

        public DateTime Dateentry { get; set; } = DateTime.Now;
    }
}
