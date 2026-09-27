using Microsoft.EntityFrameworkCore;
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
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                _context.Entry(usuario).State = EntityState.Detached;
                throw;
            }
        }
        

        public Usuario? BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public Usuario? BuscarPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(u => u.email_usuario == email);
        }

        public Usuario? BuscarPorCpf(string cpf)
        {
            return _context.Usuarios.FirstOrDefault(u => u.cpf_usuario == cpf);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }
    }
}
