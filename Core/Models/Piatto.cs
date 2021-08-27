using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public enum Tipo
    {
        Primo,
        Secondo,
        Controno,
        Dolce
    }
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Tipo Tipologia { get; set; }
        public int Prezzo { get; set; }
    }
}
