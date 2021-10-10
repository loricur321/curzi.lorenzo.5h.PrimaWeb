using System;
using System.ComponentModel.DataAnnotations;

namespace curzi.lorenzo._5h.PrimaWeb.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Inserisci una mail valida")]
        [EmailAddress]
        public string Email{get;set;}
    }
}
