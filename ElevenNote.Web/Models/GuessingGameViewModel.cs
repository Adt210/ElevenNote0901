using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenNote.Web.Models
{
    public class GuessingGameViewModel
    {
        [Required(ErrorMessage ="Required")]
        [MinLength(2)]
        [MaxLength(20)]
        [Display(Name = "Your Name")]
        public String Name { get; set; }
        
        [Required(ErrorMessage ="Required")]
        [Range(1,10)]
        [Display(Name = "Your Guess")]
        public int Guess { get; set;}                 
    }
}