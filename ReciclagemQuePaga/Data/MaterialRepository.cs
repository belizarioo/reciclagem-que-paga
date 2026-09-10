using ReciclagemQuePaga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Data
{
    public class MaterialRepository
    {
        private readonly DataBaseConnection _context;

        public MaterialRepository(DataBaseConnection context)
        {
            _context = context;
        }

        public List<Material> ListarMateriais()
        {
            return _context.Materiais.ToList();
        }
    }
}
