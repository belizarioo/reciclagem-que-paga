using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Data
{
    public class UsuarioRepository
    {
        private readonly DataBaseConnection _context;
        public UsuarioRepository(DataBaseConnection context)
        {
            _context = context;
        }
        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario? BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
