using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Encriptar.Models
{   
    [Table("Crip")]
    public class crip
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MaxLength(255, ErrorMessage = "Maximo de 255 Caracter")]
        [Display(Name = "Texto: ")]
        public string Texto { get; set; }

    }
}