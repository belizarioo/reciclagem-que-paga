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
        public Saldo()
        {
            InitializeComponent();
        }

        private void btn_tI_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = (TelaInicial)Application.OpenForms["telaInicial"];

            if (form1 == null)
            {
                form1 = new TelaInicial();
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
                form1 = new Historico();
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
    }
}
