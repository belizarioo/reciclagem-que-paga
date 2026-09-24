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

        private void Historico_Activated(object sender, EventArgs e)
        {
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            dgw_historico.AutoGenerateColumns = false;

            dgw_historico.Columns[0].DataPropertyName = "data_hora_transacao";
            dgw_historico.Columns[1].DataPropertyName = "tipo_material";
            dgw_historico.Columns[2].DataPropertyName = "peso_transacao";
            dgw_historico.Columns[3].DataPropertyName = "valor_transacao";

            int usuarioId = _usuarioLogado.usuario_id;
            dgw_historico.DataSource = _transacaoService.ListarTransacoes(usuarioId).OrderByDescending(t => t.data_hora_transacao).ToList();
        }

        private void dgw_historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Historico_Paint(object sender, PaintEventArgs e)
        {
            Color corInicio = Color.FromArgb(120, 185, 130);  // Verde claro (topo)
            Color corFim = Color.FromArgb(45, 95, 60);       // Verde escuro (base)

            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    this.ClientRectangle,
                    corInicio,
                    corFim,
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
