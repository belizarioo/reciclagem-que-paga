using ReciclagemQuePaga.Forms;
using ReciclagemQuePaga;
using ReciclagemQuePaga.Services;

namespace ReciclagemQuePaga
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;

        

        public LoginForm(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService)
        {
            InitializeComponent();
            this.Name = "loginForm";

            _usuarioService = usuarioService;
            _materialService = materialService;
            _transacaoService = transacaoService;
        }

        public LoginForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }


        public void LimparCampos()
        {
            txb_email.Clear();
            txb_senha.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //txb_senha.UseSystemPasswordChar = true;
            txb_senha.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Remove o foco inicial dos campos
            this.ActiveControl = null;
        }


        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string email = txb_email.Text;
            string senha = txb_senha.Text;

            Usuario? usuario = _usuarioService.BuscarPorEmail(email);

            if (usuario != null)
            {
                if (BCrypt.Net.BCrypt.Verify(senha, usuario.senha_usuario))
                {

                    TelaInicial form = new TelaInicial(_usuarioService, _materialService, _transacaoService, usuario);
                    form.Name = "telaInicial";
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                    txb_senha.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario não encontrado, tente um email diferente");
                LimparCampos();
            }
        }



        private void cb_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_senha.Checked)
            {
                txb_senha.PasswordChar = '\0';
            }
            else
            {
                txb_senha.PasswordChar = '●';
            }
        }

        private void link_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = txb_email.Text;

            Usuario? usuario = _usuarioService.BuscarPorEmail(email);

            CadastroForm form1 = (CadastroForm)Application.OpenForms["cadastroForm"];

            if (form1 == null)
            {
                form1 = new CadastroForm(_usuarioService, _materialService, _transacaoService, usuario);
                form1.Name = "cadastroForm";
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}

