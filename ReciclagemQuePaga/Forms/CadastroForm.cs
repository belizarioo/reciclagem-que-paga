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
    public partial class CadastroForm : Form
    {

        public CadastroForm()
        {
            InitializeComponent();
        }

        private void CadastroForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void voltar_telalogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form1 = (LoginForm)Application.OpenForms["loginForm"];

            if (form1 == null)
            {
                form1 = new LoginForm();
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

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {
        }
    }
}
