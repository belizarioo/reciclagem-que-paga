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
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;
        private readonly Usuario _usuarioLogado;

        public Historico(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService, Usuario usuarioLogado)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _materialService = materialService;
            _transacaoService = transacaoService;
            _usuarioLogado = usuarioLogado;
        }

        private void btn_tI_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = (TelaInicial)Application.OpenForms["telaInicial"];

            if (form1 == null)
            {
                form1 = new TelaInicial(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
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

        private void Historico_Load(object sender, EventArgs e)
        {
            int usuarioId = _usuarioLogado.usuario_id;
            dgw_historico.DataSource =  _transacaoService.ListarTransacoes(usuarioId);
        }
    }
}
