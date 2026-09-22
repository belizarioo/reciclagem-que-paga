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
    public partial class Maquina : Form
    {
        private readonly UsuarioService _service;
        private readonly TransacaoService _transacaoService;

        public Maquina(UsuarioService service, TransacaoService transacaoService)
        {
            InitializeComponent();
            _service = service;
            _transacaoService = transacaoService;
        }

        private void limparCampos(object sender, EventArgs e)
        {
            cmb_material.SelectedIndex = -1;
            txb_peso.Clear();
            lbl_rs.Text = "R$ 0,00";
            lbl_rs2.Text = "R$ 0,00";
        }
        private void Máquina_Load(object sender, EventArgs e)
        {

        }

        private void btn_limp_Click(object sender, EventArgs e)
        {


            limparCampos(sender, e);

        }

        private void btn_tI_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = (TelaInicial)Application.OpenForms["telaInicial"];

            if (form1 == null)
            {
                form1 = new TelaInicial(_service, _transacaoService);
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

       
    }
}
