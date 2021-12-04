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
        private ClienteRepository app;

        public ClienteRepository(ApplicationDbContext app)
        {
            this.app = app;

        }

        public void Buscar(Plato p)
        {
            app.platos.Find(p);
        }

        public void insertar(Plato p)
        {
            app.Add(p);
            app.SaveChanges();
        }

        public void Delete(Plato p)
        {
            app.platos.Remove(p);

        }

        public ICollection<Plato> listarPlato()
        {
            return app.platos.ToList();
        }
    }
}
