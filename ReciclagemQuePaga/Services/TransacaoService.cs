using Microsoft.EntityFrameworkCore;
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
        private readonly DataBaseConnection _context;
        private TransacaoRepository repositoryTransacao;

        public TransacaoService(TransacaoRepository transacaoRepository,MaterialRepository materialRepository, DataBaseConnection context)
        {
            _repository = transacaoRepository;
            _materialRepository = materialRepository;
            _context = context;
        }

        public TransacaoService(TransacaoRepository repositoryTransacao)
        {
            this.repositoryTransacao = repositoryTransacao;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            Material material = _materialRepository.BuscarPorId(transacao.MaterialId);

            if (material != null)
            {

                decimal valorTransacao = material.PrecoMaterialPorKilo * transacao.PesoTransacao;
                transacao.ValorTransacao = valorTransacao;

                
                _repository.RegistrarTransacao(transacao);  
            }
            else
            {
                throw new InvalidOperationException("Nenhum material encontrado");
            }

        }


        public List<HistoricoTransacao> BuscarHistorico(int usuarioId)
        {
            return _repository.BuscarHistorico(usuarioId);
        }
    }
}
