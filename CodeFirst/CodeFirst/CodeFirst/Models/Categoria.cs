﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        //public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool? estado { get; set; }

        public virtual ICollection<Producto> productos { get; set; }
    }
}
