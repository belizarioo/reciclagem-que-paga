using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Models
{
    public class Transacao
    {
        public int TransacaoId { get; set; }
        public int UsuarioId { get; set; }
        public int MaterialId { get; set; }
        public DateTime DataHoraTransacao { get; set; } = DateTime.Now;
        public decimal ValorTransacao { get; set; } 
        public decimal PesoTransacao { get; set; }
    }
}
