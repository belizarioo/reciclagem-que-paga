using ReciclagemQuePaga.Data;
using ReciclagemQuePaga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Services
{
    public class TransacaoService
    {
        private readonly TransacaoRepository _repository;
        private readonly MaterialRepository _materialRepository;
        private readonly UsuarioService _usuarioService;

        public TransacaoService(TransacaoRepository repository, MaterialRepository materialRepository, UsuarioService usuarioService)
        {
            _repository = repository;
            _materialRepository = materialRepository;
            _usuarioService = usuarioService;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            if(transacao.peso_transacao <= 0)
            {
                throw new ArgumentException("O peso deve ser maior do que Zero.");
            }

            Usuario? usuario = _usuarioService.BuscarPorId(transacao.usuario_id);

            if(usuario == null)
            {
                throw new ArgumentException("Usuario inexistente.");
            }

            Material? material = _materialRepository.BuscarPorId(transacao.material_id);

            if (material == null)
            {
                throw new InvalidOperationException("Nenhum material encontrado");

            }

            decimal valorTransacao = material.preco_material_por_kilo * transacao.peso_transacao;
            transacao.valor_transacao = valorTransacao;

            _repository.RegistrarTransacao(transacao);

            usuario.saldo_usuario += valorTransacao;

            _usuarioService.AtualizarUsuario(usuario);
        }

        public List<Transacao> ListarTransacoes(int usuarioId)
        {
            return _repository.ListarTransacoes(usuarioId);
        }
    }
}
