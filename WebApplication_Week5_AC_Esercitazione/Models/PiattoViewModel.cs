using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PiattoViewModel
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Nome { get; set; }
        [Required, StringLength(100)]
        public string Descrizione { get; set; }
        [Required]
        public Tipo Tipologia { get; set; }

        [Required]
        public int Prezzo { get; set; }
    }
}
