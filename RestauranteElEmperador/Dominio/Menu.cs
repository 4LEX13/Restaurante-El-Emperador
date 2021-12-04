using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Dominio
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int PlatoId { get; set; }
        public string Imagen { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }


        public ICollection<Plato> platos { get; set; }

    }



}

