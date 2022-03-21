using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        
        [Required(ErrorMessage ="Ingrese un nombre")]
        [StringLength(50,MinimumLength =3,ErrorMessage = "El nombre no debe rener más de 50 caracteres, ni menos de 3")]
        public string nombre { get; set; }
        
        [StringLength(255,ErrorMessage ="la descripción no debe tener más de 255 caracteres")]
        public string descripcion { get; set; }
        public bool? estado { get; set; }

        public virtual ICollection<Producto> productos { get; set; }
    }
}
