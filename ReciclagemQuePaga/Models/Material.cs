using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Models
{
    public class Material
    {
        [Key]
        public int material_id { get; set; }
        public string tipo_material { get; set; } = String.Empty;
        public decimal preco_material_por_kilo { get; set; }

        public Material()
        {

        }
    }
}
