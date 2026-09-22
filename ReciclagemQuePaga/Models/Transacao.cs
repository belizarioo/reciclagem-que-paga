using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Models
{
    public class Transacao
    {
        [Key]
        public int transacao_id { get; set; }
        public int usuario_id { get; set; }
        public int material_id { get; set; }
        public DateTime data_hora_transacao { get; set; } = DateTime.Now;
        public decimal valor_transacao { get; set; } 
        public decimal peso_transacao { get; set; }

        public Transacao()
        {

        }

        public Transacao(int usuarioId, int materialId, decimal valorTransacao, decimal pesoTransacao, DateTime dataHoraTransacao)
        { 
            usuario_id = usuarioId;
            material_id = materialId;
            valor_transacao = valorTransacao;
            peso_transacao = pesoTransacao;
            data_hora_transacao = dataHoraTransacao;
        }
    }
}
