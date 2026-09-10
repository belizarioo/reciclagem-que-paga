using ReciclagemQuePaga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Data
{
    public class TransacaoRepository
    {
        private readonly DataBaseConnection _context;

        public TransacaoRepository(DataBaseConnection context) 
        {
            _context = context;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            _context.Transacoes.Add(transacao);
            _context.SaveChanges();
        }
    }
}
