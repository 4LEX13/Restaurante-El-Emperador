using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Dominio
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public int TelefonoCliente { get; set; }


        public ICollection<Plato> platos { get; set; }

    }
}

