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
            dgw_historico = new DataGridView();
            dh = new DataGridViewTextBoxColumn();
            material = new DataGridViewTextBoxColumn();
            peso = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            btn_tI = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_historico).BeginInit();
            SuspendLayout();
            // 
            // dgw_historico
            // 
            dgw_historico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_historico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_historico.Columns.AddRange(new DataGridViewColumn[] { dh, material, peso, valor });
            dgw_historico.Location = new Point(12, 79);
            dgw_historico.Name = "dgw_historico";
            dgw_historico.Size = new Size(776, 299);
            dgw_historico.TabIndex = 0;
            // 
            // dh
            // 
            dh.HeaderText = "Data e hora";
            dh.Name = "dh";
            // 
            // material
            // 
            material.HeaderText = "Material";
            material.Name = "material";
            // 
            // peso
            // 
            peso.HeaderText = "peso";
            peso.Name = "peso";
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            // 
            // btn_tI
            // 
            btn_tI.Location = new Point(713, 12);
            btn_tI.Name = "btn_tI";
            btn_tI.Size = new Size(75, 23);
            btn_tI.TabIndex = 9;
            btn_tI.Text = "Voltar..";
            btn_tI.UseVisualStyleBackColor = true;
            btn_tI.Click += btn_tI_Click;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_tI);
            Controls.Add(dgw_historico);
            Name = "Historico";
            Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)dgw_historico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw_historico;
        private DataGridViewTextBoxColumn dh;
        private DataGridViewTextBoxColumn material;
        private DataGridViewTextBoxColumn peso;
        private DataGridViewTextBoxColumn valor;
        private Button btn_tI;
    }
}