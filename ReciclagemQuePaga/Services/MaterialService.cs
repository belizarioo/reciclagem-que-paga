using ReciclagemQuePaga.Data;
using ReciclagemQuePaga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclagemQuePaga.Services
{
    public class MaterialService
    {
        private readonly MaterialRepository _repository;

        public MaterialService(MaterialRepository repository)
        {
            _repository = repository;
        }

        public List<Material> ListarMateriais()
        {
            return _repository.ListarMateriais();
        }
    }
}
