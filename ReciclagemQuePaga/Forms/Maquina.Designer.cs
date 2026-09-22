namespace ReciclagemQuePaga.Forms
{
    partial class Maquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maquina));
            pic_img = new PictureBox();
            cmb_material = new ComboBox();
            txb_peso = new TextBox();
            panel_preco = new Panel();
            lbl_rs = new Label();
            label5 = new Label();
            lbl_preco = new Label();
            panel_RE = new Panel();
            lbl_rs2 = new Label();
            lbl_recompensa = new Label();
            lbl_material = new Label();
            lbl_peso = new Label();
            btn_confirmar = new Button();
            panel_confirmar = new Panel();
            label1 = new Label();
            panel_limpar = new Panel();
            label2 = new Label();
            btn_limp = new Button();
            btn_tI = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_img).BeginInit();
            panel_preco.SuspendLayout();
            panel_RE.SuspendLayout();
            panel_confirmar.SuspendLayout();
            panel_limpar.SuspendLayout();
            SuspendLayout();
            // 
            // pic_img
            // 
            pic_img.BackColor = Color.DarkSeaGreen;
            pic_img.Image = (Image)resources.GetObject("pic_img.Image");
            pic_img.Location = new Point(505, 125);
            pic_img.Name = "pic_img";
            pic_img.Size = new Size(230, 218);
            pic_img.SizeMode = PictureBoxSizeMode.Zoom;
            pic_img.TabIndex = 0;
            pic_img.TabStop = false;
            // 
            // cmb_material
            // 
            cmb_material.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_material.Font = new Font("Segoe UI", 15F);
            cmb_material.FormattingEnabled = true;
            cmb_material.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmb_material.Location = new Point(23, 148);
            cmb_material.Name = "cmb_material";
            cmb_material.Size = new Size(309, 36);
            cmb_material.TabIndex = 1;
            cmb_material.SelectedIndexChanged += cmb_material_SelectedIndexChanged;
            // 
            // txb_peso
            // 
            txb_peso.Font = new Font("Segoe UI", 15F);
            txb_peso.Location = new Point(23, 212);
            txb_peso.Name = "txb_peso";
            txb_peso.Size = new Size(309, 34);
            txb_peso.TabIndex = 2;
            txb_peso.TextChanged += txb_peso_TextChanged;
            // 
            // panel_preco
            // 
            panel_preco.BackColor = SystemColors.Window;
            panel_preco.Controls.Add(lbl_rs);
            panel_preco.Controls.Add(label5);
            panel_preco.Controls.Add(lbl_preco);
            panel_preco.Location = new Point(23, 252);
            panel_preco.Name = "panel_preco";
            panel_preco.Size = new Size(137, 61);
            panel_preco.TabIndex = 3;
            // 
            // lbl_rs
            // 
            lbl_rs.AutoSize = true;
            lbl_rs.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rs.Location = new Point(11, 31);
            lbl_rs.Name = "lbl_rs";
            lbl_rs.Size = new Size(0, 22);
            lbl_rs.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-350, -21);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label2";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.BackColor = SystemColors.Window;
            lbl_preco.Font = new Font("Trebuchet MS", 9F);
            lbl_preco.ForeColor = Color.Black;
            lbl_preco.Location = new Point(3, 3);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(83, 18);
            lbl_preco.TabIndex = 5;
            lbl_preco.Text = "Preço por kg:";
            // 
            // panel_RE
            // 
            panel_RE.BackColor = SystemColors.Window;
            panel_RE.Controls.Add(lbl_rs2);
            panel_RE.Controls.Add(lbl_recompensa);
            panel_RE.Location = new Point(195, 252);
            panel_RE.Name = "panel_RE";
            panel_RE.Size = new Size(137, 61);
            panel_RE.TabIndex = 4;
            // 
            // lbl_rs2
            // 
            lbl_rs2.AutoSize = true;
            lbl_rs2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rs2.Location = new Point(10, 30);
            lbl_rs2.Name = "lbl_rs2";
            lbl_rs2.Size = new Size(0, 22);
            lbl_rs2.TabIndex = 6;
            // 
            // lbl_recompensa
            // 
            lbl_recompensa.AutoSize = true;
            lbl_recompensa.Font = new Font("Trebuchet MS", 9F);
            lbl_recompensa.ForeColor = Color.Black;
            lbl_recompensa.Location = new Point(3, 3);
            lbl_recompensa.Name = "lbl_recompensa";
            lbl_recompensa.Size = new Size(81, 18);
            lbl_recompensa.TabIndex = 5;
            lbl_recompensa.Text = "Recompensa:";
            // 
            // lbl_material
            // 
            lbl_material.AutoSize = true;
            lbl_material.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold);
            lbl_material.ForeColor = Color.White;
            lbl_material.Location = new Point(23, 125);
            lbl_material.Name = "lbl_material";
            lbl_material.Size = new Size(72, 20);
            lbl_material.TabIndex = 0;
            lbl_material.Text = "Material:";
            // 
            // lbl_peso
            // 
            lbl_peso.AutoSize = true;
            lbl_peso.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbl_peso.ForeColor = Color.White;
            lbl_peso.Location = new Point(23, 187);
            lbl_peso.Name = "lbl_peso";
            lbl_peso.Size = new Size(50, 22);
            lbl_peso.TabIndex = 5;
            lbl_peso.Text = "Peso:";
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.DarkGreen;
            btn_confirmar.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_confirmar.FlatStyle = FlatStyle.Flat;
            btn_confirmar.Font = new Font("Trebuchet MS", 10F);
            btn_confirmar.ForeColor = Color.White;
            btn_confirmar.Image = (Image)resources.GetObject("btn_confirmar.Image");
            btn_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_confirmar.Location = new Point(0, 0);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(137, 44);
            btn_confirmar.TabIndex = 6;
            btn_confirmar.Text = "  Confirmar";
            btn_confirmar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // panel_confirmar
            // 
            panel_confirmar.Controls.Add(label1);
            panel_confirmar.Controls.Add(btn_confirmar);
            panel_confirmar.Location = new Point(23, 331);
            panel_confirmar.Name = "panel_confirmar";
            panel_confirmar.Size = new Size(137, 44);
            panel_confirmar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-350, -21);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label2";
            // 
            // panel_limpar
            // 
            panel_limpar.Controls.Add(label2);
            panel_limpar.Controls.Add(btn_limp);
            panel_limpar.Location = new Point(195, 331);
            panel_limpar.Name = "panel_limpar";
            panel_limpar.Size = new Size(137, 44);
            panel_limpar.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-350, -21);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // btn_limp
            // 
            btn_limp.BackColor = Color.Gray;
            btn_limp.FlatAppearance.BorderSize = 0;
            btn_limp.FlatAppearance.MouseDownBackColor = Color.White;
            btn_limp.FlatStyle = FlatStyle.Flat;
            btn_limp.Font = new Font("Trebuchet MS", 10F);
            btn_limp.ForeColor = SystemColors.Window;
            btn_limp.Image = (Image)resources.GetObject("btn_limp.Image");
            btn_limp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limp.Location = new Point(0, 0);
            btn_limp.Name = "btn_limp";
            btn_limp.Size = new Size(137, 44);
            btn_limp.TabIndex = 6;
            btn_limp.Text = "   Limpar";
            btn_limp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limp.UseVisualStyleBackColor = false;
            btn_limp.Click += btn_limp_Click;
            // 
            // btn_tI
            // 
            btn_tI.Location = new Point(713, 12);
            btn_tI.Name = "btn_tI";
            btn_tI.Size = new Size(75, 23);
            btn_tI.TabIndex = 8;
            btn_tI.Text = "Voltar";
            btn_tI.UseVisualStyleBackColor = true;
            btn_tI.Click += btn_tI_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16F);
            label3.Location = new Point(23, 37);
            label3.Name = "label3";
            label3.Size = new Size(232, 27);
            label3.TabIndex = 9;
            label3.Text = "Máquina de Simulação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 11F);
            label4.Location = new Point(23, 78);
            label4.Name = "label4";
            label4.Size = new Size(414, 20);
            label4.TabIndex = 10;
            label4.Text = "Informe os dados do material para calcular sua recompensa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(442, 430);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(357, 15);
            label6.TabIndex = 16;
            label6.Text = "v1.0.0 | © 2026 Reciclagem que Paga. Todos os direitos reservados.";
            // 
            // Maquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 445);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_tI);
            Controls.Add(panel_limpar);
            Controls.Add(panel_confirmar);
            Controls.Add(lbl_peso);
            Controls.Add(lbl_material);
            Controls.Add(panel_RE);
            Controls.Add(panel_preco);
            Controls.Add(txb_peso);
            Controls.Add(cmb_material);
            Controls.Add(pic_img);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Maquina";
            Text = "Máquina";
            Load += Máquina_Load;
            ((System.ComponentModel.ISupportInitialize)pic_img).EndInit();
            panel_preco.ResumeLayout(false);
            panel_preco.PerformLayout();
            panel_RE.ResumeLayout(false);
            panel_RE.PerformLayout();
            panel_confirmar.ResumeLayout(false);
            panel_confirmar.PerformLayout();
            panel_limpar.ResumeLayout(false);
            panel_limpar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_img;
        private ComboBox cmb_material;
        private TextBox txb_peso;
        private Panel panel_preco;
        private Panel panel_RE;
        private Label label5;
        private Label lbl_preco;
        private Label lbl_recompensa;
        private Label lbl_material;
        private Label lbl_peso;
        private Panel panel_confirmar;
        private Label label1;
        private Button btn_confirmar;
        private Label lbl_rs;
        private Panel panel_limpar;
        private Label label2;
        private Button btn_limp;
        private Label lbl_rs2;
        private Button btn_tI;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}