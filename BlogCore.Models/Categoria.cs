using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [Display(Name = "Nombre categoría")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de visualización")]
        public int Orden { get; set; }


    }
}
