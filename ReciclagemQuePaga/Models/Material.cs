using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string TipoMaterial { get; set; } = String.Empty;
        public decimal PrecoMaterialPorKilo { get; set; }
    }
}
