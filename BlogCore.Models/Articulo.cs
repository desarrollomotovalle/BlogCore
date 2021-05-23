using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogCore.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [Display(Name = "Nombre del articulo")]
        public string Nombre { get; set; }

        
        [Display(Name = "Fecha de creación")]
        public string FechaCracion { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        [Required]
        public int categoriaId { get; set; }

        [ForeignKey("categoriaId")]
        public Categoria Categoria { get; set; }
    }
}
