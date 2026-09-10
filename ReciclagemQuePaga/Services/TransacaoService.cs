using ReciclagemQuePaga.Data;
using ReciclagemQuePaga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Services
{
    public class TransacaoService
    {
        private readonly TransacaoRepository _repository;

        public TransacaoService(TransacaoRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            _repository.RegistrarTransacao(transacao);
        }
    }
}
