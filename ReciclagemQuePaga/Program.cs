using ReciclagemQuePaga;
using ReciclagemQuePaga.Data;
using ReciclagemQuePaga.Forms;
using ReciclagemQuePaga.Services;
namespace ReciclagemQuePaga
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var context = new DataBaseConnection();

            var repositoryMaterial = new MaterialRepository(context);
            var repositoryTransacao = new TransacaoRepository(context);
            var repositoryUser = new UsuarioRepository(context);

            var serviceMaterial = new MaterialService(repositoryMaterial);
            var serviceTransacao = new TransacaoService(repositoryTransacao, repositoryMaterial);
            var serviceUser = new UsuarioService(repositoryUser);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(serviceUser, serviceMaterial, serviceTransacao));
        }
    }
}