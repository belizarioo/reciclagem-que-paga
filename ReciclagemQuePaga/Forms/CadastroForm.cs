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
            LoginForm form = (LoginForm)Application.OpenForms["loginForm"];

            if (form == null)
            {
                form = new LoginForm();
                form.Name = "loginForm";
                form.Show();
                this.Hide();


            }
            else
            {
                form.Activate();
                //form.Show();
            }
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {
        }
    }
}
