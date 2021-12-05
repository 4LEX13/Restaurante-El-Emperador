using System;
using RestauranteElEmperador.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Services
{
    interface ICliente
    {
        void insertar(Cliente c);

        void Delete(Cliente c);


        void Buscar(Cliente c);


        ICollection<Cliente> listarcliente();




    }
}
