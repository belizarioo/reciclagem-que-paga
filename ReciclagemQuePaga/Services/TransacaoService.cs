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

        public TransacaoService(TransacaoRepository repository, MaterialRepository materialRepository)
        {
            _repository = repository;
            _materialRepository = materialRepository;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            Material? material = _materialRepository.BuscarPorId(transacao.material_id);

            if (material != null)
            {

                decimal valorTransacao = material.preco_material_por_kilo * transacao.peso_transacao;
                transacao.valor_transacao = valorTransacao;

                
                _repository.RegistrarTransacao(transacao);  
            }
            else
            {
                throw new InvalidOperationException("Nenhum material encontrado");
            }

        }
    }
}
