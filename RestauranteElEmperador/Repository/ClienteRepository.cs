using System;
using RestauranteElEmperador.Services;
using RestauranteElEmperador.Data;
using RestauranteElEmperador.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Repository
{
    public class ClienteRepository : ICliente
    {
        private ApplicationDbContext app;

        public ClienteRepository(ApplicationDbContext app)
        {
            this.app = app;
        }

        public void insertar(Cliente c)
        {
            app.Add(c);
            app.SaveChanges();
        }

        public void Delete(Cliente c)
        {
            app.clientes.Remove(c);
        }

        public void Buscar(Cliente c)
        {
            app.clientes.Find(c);
        }

        public ICollection<Cliente> listarcliente()
        {
            return app.clientes.ToList();
        }
    }
}
