using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string superheroName { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        [Display(Name ="Catch Phrase")]
        public string catchPhrase { get; set; }
    }
}