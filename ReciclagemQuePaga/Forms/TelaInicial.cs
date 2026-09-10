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
        public TelaInicial()
        {
            InitializeComponent();

            string usuarioLogado = "Guilherme";
            int saldo = 500;

            lbl_saldo.Text = $"R$ {saldo}";
            lbl_nU.Text = "Olá, " + usuarioLogado;
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
    }
}
