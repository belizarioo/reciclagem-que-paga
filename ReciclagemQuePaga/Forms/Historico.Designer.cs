namespace ReciclagemQuePaga.Forms
{
    partial class Historico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            dgw_historico = new DataGridView();
            btn_tI = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            dh = new DataGridViewTextBoxColumn();
            material = new DataGridViewTextBoxColumn();
            peso = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgw_historico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgw_historico
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 244);
            dgw_historico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgw_historico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_historico.BackgroundColor = Color.White;
            dgw_historico.BorderStyle = BorderStyle.None;
            dgw_historico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 77, 46);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgw_historico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgw_historico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_historico.Columns.AddRange(new DataGridViewColumn[] { dh, material, peso, valor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgw_historico.DefaultCellStyle = dataGridViewCellStyle3;
            dgw_historico.EnableHeadersVisualStyles = false;
            dgw_historico.Location = new Point(14, 159);
            dgw_historico.Margin = new Padding(3, 4, 3, 4);
            dgw_historico.Name = "dgw_historico";
            dgw_historico.RowHeadersVisible = false;
            dgw_historico.RowHeadersWidth = 51;
            dgw_historico.Size = new Size(887, 399);
            dgw_historico.TabIndex = 0;
            // 
            // btn_tI
            // 
            btn_tI.Font = new Font("Trebuchet MS", 9F);
            btn_tI.Location = new Point(815, 16);
            btn_tI.Margin = new Padding(3, 4, 3, 4);
            btn_tI.Name = "btn_tI";
            btn_tI.Size = new Size(86, 31);
            btn_tI.TabIndex = 9;
            btn_tI.Text = "Voltar";
            btn_tI.UseVisualStyleBackColor = true;
            btn_tI.Click += btn_tI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 25F);
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(424, 52);
            label1.TabIndex = 10;
            label1.Text = "Histórico de Entregas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10F);
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(320, 23);
            label2.TabIndex = 11;
            label2.Text = "Confira suas entregas realizadas abaixo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(493, 573);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(451, 20);
            label6.TabIndex = 17;
            label6.Text = "v1.0.0 | © 2026 Reciclagem que Paga. Todos os direitos reservados.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dh
            // 
            dh.DataPropertyName = "data_hora_transacao";
            dh.FillWeight = 140F;
            dh.HeaderText = "Data e hora";
            dh.MinimumWidth = 6;
            dh.Name = "dh";
            dh.ReadOnly = true;
            // 
            // material
            // 
            material.DataPropertyName = "tipo_material";
            material.HeaderText = "Material";
            material.MinimumWidth = 6;
            material.Name = "material";
            material.ReadOnly = true;
            // 
            // peso
            // 
            peso.DataPropertyName = "peso_transacao";
            peso.FillWeight = 80F;
            peso.HeaderText = "Peso";
            peso.MinimumWidth = 6;
            peso.Name = "peso";
            peso.ReadOnly = true;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor_transacao";
            valor.FillWeight = 80F;
            valor.HeaderText = "Valor";
            valor.MinimumWidth = 6;
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 212, 200);
            ClientSize = new Size(911, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_tI);
            Controls.Add(dgw_historico);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Historico";
            Text = "Histórico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_historico).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_historico;
        private Button btn_tI;
        private Label label1;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn dh;
        private DataGridViewTextBoxColumn material;
        private DataGridViewTextBoxColumn peso;
        private DataGridViewTextBoxColumn valor;
    }
}