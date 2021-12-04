using System;
using RestauranteElEmperador.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Services
{
    interface ICliente
    {
        void insertar(Plato p);

        void Delete(Plato p);


        void Buscar(Plato p);


        ICollection<Plato> listarPlato();




    }
}
