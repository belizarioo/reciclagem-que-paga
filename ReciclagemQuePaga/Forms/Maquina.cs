using ReciclagemQuePaga.Models;
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
        private readonly UsuarioService _usuarioService;
        private readonly MaterialService _materialService;
        private readonly TransacaoService _transacaoService;
        private readonly Usuario _usuarioLogado;
        public Maquina(UsuarioService usuarioService, MaterialService materialService, TransacaoService transacaoService, Usuario usuarioLogado)
        {
            _usuarioService = usuarioService;
            _materialService = materialService;
            _transacaoService = transacaoService;
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
        }

        private void CalcularTotal()
        {

            Material? materialEscolhido = cmb_material.SelectedItem as Material;


            bool deuCerto = decimal.TryParse(txb_peso.Text, out decimal peso);

            if (materialEscolhido != null && deuCerto && peso > 0)
            {
                decimal total = peso * materialEscolhido.preco_material_por_kilo;
                lbl_rs2.Text = $"R$ {total:N2}";
            }
            else
            {
                lbl_rs2.Text = "R$ 0,00";
            }


        }
        private void LimparCampos(object sender, EventArgs e)
        {
            cmb_material.SelectedIndex = -1;
            txb_peso.Clear();
            lbl_rs.Text = "R$ 0,00";
            lbl_rs2.Text = "R$ 0,00";
        }
        private void Máquina_Load(object sender, EventArgs e)
        {
            cmb_material.DataSource = _materialService.ListarMateriais();
            cmb_material.DisplayMember = "tipo_material";
            cmb_material.ValueMember = "material_id";
            cmb_material.SelectedIndex = -1;
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {


            LimparCampos(sender, e);

        }

        private void btn_tI_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = (TelaInicial)Application.OpenForms["telaInicial"];

            if (form1 == null)
            {
                form1 = new TelaInicial(_usuarioService, _materialService, _transacaoService, _usuarioLogado);
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

        private void cmb_material_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_material.SelectedItem is Material materialEscolhido)
            {
                lbl_rs.Text = $"R$ {materialEscolhido.preco_material_por_kilo:N2}";
                CalcularTotal();
            }
            else
            {
                lbl_rs.Text = "R$ 0,00";
                lbl_rs2.Text = "R$ 0,00";
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Material? materialEscolhido = cmb_material.SelectedItem as Material;
            bool deuCerto = decimal.TryParse(txb_peso.Text, out decimal peso);

            if (materialEscolhido != null && deuCerto && peso > 0)
            {
                decimal resultado = materialEscolhido.preco_material_por_kilo * peso;

                Transacao transacao = new Transacao(_usuarioLogado.usuario_id, materialEscolhido.material_id, resultado, peso, DateTime.Now);

                _usuarioLogado.saldo_usuario += resultado;
                _usuarioService.AtualizarUsuario(_usuarioLogado);

                _transacaoService.RegistrarTransacao(transacao);

                MessageBox.Show("Transação feita com sucesso");
                LimparCampos(sender, e);

            }
            else
            {
                MessageBox.Show("Selecione um material e digite um número valido");
                return;
            }

        }

        private void txb_peso_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
