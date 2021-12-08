using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Dominio
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public int TelefonoCliente { get; set; }


        public ICollection<Plato> platos { get; set; }

    }
}

