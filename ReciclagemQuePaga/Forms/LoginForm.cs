using ReciclagemQuePaga.Forms;

namespace ReciclagemQuePaga
{
    public partial class LoginForm : Form
    {

        //string email { get; set; }
        //string senha { get; set; }

        string email = "Gui";
        string senha = "123";
        public LoginForm()
        {
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
            //email = txb_email.Text;
            //senha = txb_senha.Text;


            if (email == "Gui" && senha == "123")
            {
                txb_email.Text = email;
                txb_senha.Text = senha;

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
                }
            }

            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
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
    }
}
