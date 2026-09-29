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
    public partial class TelaInicial : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;
        private readonly Usuario _usuarioLogado;

        bool logoutEmAndamento = false;

        public TelaInicial(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService, Usuario usuarioLogado)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _materialService = materialService;
            _transacaoService = transacaoService;
            _usuarioLogado = usuarioLogado;

            lbl_nU.Text = $"Olá, {_usuarioLogado.nome_usuario}!";
        }


        bool menuAberto = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                menu_lateral.Width += 10;

                if (menu_lateral.Width >= 152)
                {
                    timer1.Stop();
                }
            }
            else
            {
                menu_lateral.Width -= 10;

                if (menu_lateral.Width <= 0)
                {
                    timer1.Stop();
                }


            }
        }



        private void btn_ham_Click(object sender, EventArgs e)
        {
            menuAberto = !menuAberto;
            timer1.Start();
        }



        private void TelaInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logoutEmAndamento)
            {
                Application.Exit();
            }
        }


        private void menu_lateral_Paint(object sender, PaintEventArgs e)
        {
            menu_lateral.Dock = DockStyle.Left;
        }

        private void painel_principal_Paint(object sender, PaintEventArgs e)
        {

            painel_principal.Dock = DockStyle.Fill;
        }



        private void btn_maquina_Click(object sender, EventArgs e)
        {

            Maquina form = (Maquina)Application.OpenForms["maquina"];



            if (form == null)
            {
                form = new Maquina(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "maquina";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {


            Historico form = (Historico)Application.OpenForms["historico"];



            if (form == null)
            {
                form = new Historico(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "historico";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {


            Saldo form = (Saldo)Application.OpenForms["saldo"];



            if (form == null)
            {
                form = new Saldo(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "saldo";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            logoutEmAndamento = true;

            string[] telasParaFechar = ["maquina", "saldo", "historico"];

            foreach (string nomeTela in telasParaFechar)
            {
                Form? tela = Application.OpenForms[nomeTela];

                if (tela != null)
                {
                    tela.Close();
                }

            }


            LoginForm loginForm = (LoginForm)Application.OpenForms["loginForm"];

            if (loginForm == null)
            {
                loginForm = new LoginForm(_usuarioService, _materialService, _transacaoService);
                loginForm.Name = "loginForm";
            }

            loginForm.LimparCampos();
            loginForm.Show();
            loginForm.BringToFront();
            loginForm.Activate();

            this.Close();

        }

        private void btn_maquina2_Click(object sender, EventArgs e)
        {

            Maquina? form = (Maquina)Application.OpenForms["maquina"];



            if (form == null)
            {
                form = new Maquina(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "maquina";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void btn_historico2_Click(object sender, EventArgs e)
        {
            Historico? form = (Historico)Application.OpenForms["historico"];



            if (form == null)
            {
                form = new Historico(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "historico";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void btn_saldo2_Click(object sender, EventArgs e)
        {
            Saldo form = (Saldo)Application.OpenForms["saldo"];



            if (form == null)
            {
                form = new Saldo(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
                form.Name = "saldo";
                form.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
                form.Activate();
            }

            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Controls.Add(label5);
            label5.BringToFront();

            label5.AutoSize = true;

           
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

           
            label5.Left = this.ClientSize.Width - label5.Width - 15;
            label5.Top = this.ClientSize.Height - label5.Height - 15;
        }
    }

}
