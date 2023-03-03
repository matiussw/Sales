using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sales.Shared.Entities
{
    public class Category
	{
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        [MaxLength(100, ErrorMessage = "El Campo {0} no puede tener mas de un {1} Caracteres")]

        public String Name { get; set; } = null!;
    }
}

