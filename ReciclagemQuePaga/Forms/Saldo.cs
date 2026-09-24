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
    public partial class Saldo : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;
        private readonly Usuario _usuarioLogado;

        public Saldo(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService, Usuario usuarioLogado)
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

        private void btn_ver_Click(object sender, EventArgs e)
        {
            Historico form1 = (Historico)Application.OpenForms["historico"];

            if (form1 == null)
            {
                form1 = new Historico(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form1.Name = "historico";
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

        private void Saldo_Load(object sender, EventArgs e)
        {
            lbl_saldo.Text = $"R$ {_usuarioLogado.saldo_usuario:N2}";
        }

        private void btn_Resgatar_Click(object sender, EventArgs e)
        {
            if (_usuarioLogado.saldo_usuario <= 0)
            {
                MessageBox.Show("Saldo insuficiente para saque");
                return;
            }

                    DialogResult resultado = MessageBox.Show(
                    "Deseja realmente realizar esse Resgate",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (resultado == DialogResult.Yes)
                {
                decimal valorResgatado = _usuarioLogado.saldo_usuario;

                _usuarioLogado.saldo_usuario = 0;
                _usuarioService.AtualizarUsuario(_usuarioLogado);

                lbl_saldo.Text = "R$ 0,00";

                MessageBox.Show($"R$ {valorResgatado:N2} resgatado com sucesso!");
                 }


                else
                {

                return;

                }

        }

        private void Saldo_Activated(object sender, EventArgs e)
        {
            var usuarioAtualizado = _usuarioService.BuscarPorEmail(_usuarioLogado.email_usuario);

            if (usuarioAtualizado != null)
            {
                _usuarioLogado.saldo_usuario = usuarioAtualizado.saldo_usuario;
            }

            lbl_saldo.Text = $"R$ {_usuarioLogado.saldo_usuario:N2}";
        }
    
    }
}
