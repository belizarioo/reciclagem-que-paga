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
using System.Linq;

namespace ReciclagemQuePaga.Forms
{
    public partial class CadastroForm : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;
        private readonly Usuario _usuarioLogado;

        public CadastroForm(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService, Usuario usuarioLogado)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _materialService = materialService;
            _transacaoService = transacaoService;
            _usuarioLogado = usuarioLogado;
        }


        private void CadastroForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            

            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is MaskedTextBox) && String.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }
                continue;
            }

            if (!msk_txb_cpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o CPF corretamente com todos os 11 dígitos!");
                return;
            }

            string nome = txb_nome.Text;
            string cpf = msk_txb_cpf.Text.Replace(".", "").Replace("-", "").Trim();
            string email = txb_email.Text;
            string senha = txb_senha.Text;

            if(txb_confirmar_senha.Text != senha)
            {
                MessageBox.Show("As senhas digitas não coincidem!");
                return;
            }

            try
            {
                string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

                _usuarioService.CadastroUsuario(new Usuario(nome, email, senhaHash, cpf));
                MessageBox.Show("Usuario Cadastrado com sucesso");

                LoginForm loginForm = new LoginForm(_usuarioService, _materialService, _transacaoService);
                loginForm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao realizar o cadastro: {ex.Message}");
            }
            
        }

        private void voltar_telalogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form1 = (LoginForm)Application.OpenForms["loginForm"];

            if (form1 == null)
            {
                form1 = new LoginForm(_usuarioService, _materialService, _transacaoService);
                form1.Name = "loginForm";
                form1.Show();
                this.Hide();


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
