using RestauranteElEmperador.Data;
using RestauranteElEmperador.Dominio;
using RestauranteElEmperador.Services;
using System.Collections.Generic;
using System.Linq;

namespace RestauranteElEmperador.Repository
{
    public class ClienteRepository : ICliente
    {
        private ApplicationDbContext app;

        public ClienteRepository(ApplicationDbContext app)
        {
            this.app = app;
        }


        public void Buscar(Cliente c)
        {
            app.clientes.Find(c);
        }

        public void Delete(Cliente c)
        {
            app.clientes.Remove(c);
        }

        public void insertar(Cliente c)
        {
            app.Add(c);
            app.SaveChanges();
        }

   
        public ICollection<Cliente> listarcliente()
        {
            return app.clientes.ToList();
        }
    }
}
