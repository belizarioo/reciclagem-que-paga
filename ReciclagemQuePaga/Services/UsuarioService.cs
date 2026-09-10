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
            _repository.Cadastrar(usuario);
        }
        

    }

}
