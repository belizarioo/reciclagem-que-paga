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

        public List<HistoricoTransacao> BuscarHistorico(int usuarioId)
        {
            //return (from t in _context.Transacoes
            //        join m in _context.Materiais
            //        on t.MaterialId equals m.MaterialId
            //        where t.UsuarioId == usuarioId
            //        select new HistoricoTransacao
            //        {
            //            DataHora = t.DataHoraTransacao,
            //            Material = m.TipoMaterial,
            //            Peso = t.PesoTransacao,
            //            Valor = t.ValorTransacao
            //        }).ToList();
            var transacoes = _context.Transacoes
        .Where(t => t.UsuarioId == usuarioId)
        .ToList();

            return transacoes.Select(t => new HistoricoTransacao
            {
                DataHora = t.DataHoraTransacao,
                Peso = t.PesoTransacao,
                Valor = t.ValorTransacao
            }).ToList();

        }
    }
}