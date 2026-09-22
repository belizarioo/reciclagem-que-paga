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
        private readonly UsuarioService _service;

        public TelaInicial(UsuarioService service)
        {
            InitializeComponent();
            _service = service;
        }
        public TelaInicial()
        {
            InitializeComponent();

            string usuarioLogado = "Guilherme";
            int saldo = 500;

            
            lbl_nU.Text = "Olá, " + usuarioLogado + "!";
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

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void TelaInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

        }

        private void menu_lateral_Paint(object sender, PaintEventArgs e)
        {
            menu_lateral.Dock = DockStyle.Left;
        }

        private void painel_principal_Paint(object sender, PaintEventArgs e)
        {
            painel_principal.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void painel_maquina_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_nU_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_maquina_Click(object sender, EventArgs e)
        {

            Maquina form = (Maquina)Application.OpenForms["maquina"];



            if (form == null)
            {
                form = new Maquina();
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
                form = new Historico();
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
                form = new Saldo();
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

            LoginForm form1 = (LoginForm)Application.OpenForms["loginForm"];

            if (form1 == null)
            {
                form1 = new LoginForm(_service);
                form1.Name = "loginForm";
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

        private void btn_maquina2_Click(object sender, EventArgs e)
        {

            Maquina form = (Maquina)Application.OpenForms["maquina"];



            if (form == null)
            {
                form = new Maquina();
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
            Historico form = (Historico)Application.OpenForms["historico"];



            if (form == null)
            {
                form = new Historico();
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
                form = new Saldo();
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

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
