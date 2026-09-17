using ReciclagemQuePaga.Forms;
using ReciclagemQuePaga;
using ReciclagemQuePaga.Services;

namespace ReciclagemQuePaga
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService _service;
        
        //string email { get; set; }
        //string senha { get; set; }

        
        public LoginForm(UsuarioService service)
        {
            _service = service;
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txb_email.Clear();
            txb_senha.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txb_senha.UseSystemPasswordChar = true;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string email = txb_email.Text;
            string senha = txb_senha.Text;

            Usuario? usuario = _service.BuscarPorEmail(email);

            if (usuario != null)
            {
                if (senha == usuario.senha_usuario)
                {
                    TelaInicial form = (TelaInicial)Application.OpenForms["telaInicial"];

                    if (form == null)
                    {
                        form = new TelaInicial();
                        form.Name = "telaInicial";
                        form.Show();
                        this.Hide();

                    }
                    else
                    {
                        form.Activate();
                        //form.Show();
                    }
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
            if(cb_senha.Checked == true )
            {
                txb_senha.UseSystemPasswordChar = false;
            }
            else
            {
                txb_senha.UseSystemPasswordChar = true;
            }
            {

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

      
    }
}
