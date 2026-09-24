using ReciclagemQuePaga.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public void CadastroUsuario(Usuario usuario)
        {

            if (String.IsNullOrWhiteSpace(usuario.nome_usuario) || String.IsNullOrWhiteSpace(usuario.email_usuario) || String.IsNullOrWhiteSpace(usuario.senha_usuario))
            {
                throw new ArgumentException("Preencha todos os campos"); 
            }

            if(BuscarPorEmail(usuario.email_usuario) != null)
            {
                throw new InvalidOperationException("Email já cadastrado.");
            }

            usuario.senha_usuario = BCrypt.Net.BCrypt.HashPassword(usuario.senha_usuario);
            _repository.Cadastrar(usuario);
        }
        
        public Usuario? BuscarPorEmail(string email)
        {
            return _repository.BuscarPorEmail(email);
        }

        public Usuario? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _repository.AtualizarUsuario(usuario);
        }

    }

}
