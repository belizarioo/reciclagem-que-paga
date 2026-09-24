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
            catch (DbUpdateException ex)
            {
                var erroReal = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Erro do Banco: " + erroReal);
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

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }
    }
}
