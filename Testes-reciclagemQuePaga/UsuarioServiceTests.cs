using System;
using Moq;
using Xunit;
using ReciclagemQuePaga.Models;
using ReciclagemQuePaga.Data;
using ReciclagemQuePaga.Services;

namespace Testes_reciclagemQuePaga
{
    public class UsuarioServiceTests
    {
        private readonly Mock<UsuarioRepository> _usuarioRepoMock;
        private readonly UsuarioService _usuarioService;

        public UsuarioServiceTests()
        {
            _usuarioRepoMock = new Mock<UsuarioRepository>();

            _usuarioService = new UsuarioService(_usuarioRepoMock.Object);
        }

        [Fact]
        public void CamposVazios()
        {
            //Usuario
        }
    }
}