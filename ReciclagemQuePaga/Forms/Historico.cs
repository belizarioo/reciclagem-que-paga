using ReciclagemQuePaga.Models;
using ReciclagemQuePaga.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReciclagemQuePaga.Forms
{
    public partial class Historico : Form
    {
        private readonly TransacaoService _service;
        private readonly UsuarioService _usuarioService;

        public Historico(TransacaoService service, UsuarioService usuarioService)
        {
            _service = service;
            _usuarioService = usuarioService;
            InitializeComponent();

        }

        private void btn_tI_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = (TelaInicial)Application.OpenForms["telaInicial"];

            if (form1 == null)
            {
                form1 = new TelaInicial(_usuarioService, _service);
                form1.Name = "telaInicial";
                form1.Show();
            }
            else
            {
                form1.Show();
                form1.BringToFront();
                form1.Activate();
            }

            this.Hide();
        }

        private void dgw_historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            MessageBox.Show("CHEGOU NO LOAD");

            if (_service == null)
            {
                MessageBox.Show("SERVICE ESTÁ NULL");
                return;
            }

            MessageBox.Show("SERVICE OK");

            int usuarioId = 1;

            List<HistoricoTransacao> historico =
                _service.BuscarHistorico(usuarioId);

            MessageBox.Show("Quantidade: " + historico.Count);

            dgw_historico.DataSource = historico;
        }
    }
    
}
