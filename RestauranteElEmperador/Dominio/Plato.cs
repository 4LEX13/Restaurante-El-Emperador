using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Dominio
{
    public class Plato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlatoId { get; set; }
        public int ClienteId { get; set; }
        public string PlatoNombre { get; set; }
        public int PrecioPalto { get; set; }


    }
}
