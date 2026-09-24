namespace ReciclagemQuePaga.Forms
{
    partial class Saldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saldo));
            label1 = new Label();
            label2 = new Label();
            btn_tI = new Button();
            panel1 = new Panel();
            lbl_saldo = new Label();
            lbl_S = new Label();
            pic_carteira = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            btn_Resgatar = new Button();
            panel2 = new Panel();
            label4 = new Label();
            btn_ver = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_carteira).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 43);
            label1.TabIndex = 0;
            label1.Text = "Meu Saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(318, 22);
            label2.TabIndex = 1;
            label2.Text = "Acompanhe seus ganhos e saldo disponível.";
            // 
            // btn_tI
            // 
            btn_tI.Location = new Point(704, 12);
            btn_tI.Name = "btn_tI";
            btn_tI.Size = new Size(75, 23);
            btn_tI.TabIndex = 9;
            btn_tI.Text = "Voltar..";
            btn_tI.UseVisualStyleBackColor = true;
            btn_tI.Click += btn_tI_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(lbl_saldo);
            panel1.Controls.Add(lbl_S);
            panel1.Controls.Add(pic_carteira);
            panel1.Location = new Point(30, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 115);
            panel1.TabIndex = 10;
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.BackColor = Color.Transparent;
            lbl_saldo.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldo.ForeColor = Color.White;
            lbl_saldo.Location = new Point(23, 55);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(0, 40);
            lbl_saldo.TabIndex = 2;
            // 
            // lbl_S
            // 
            lbl_S.AutoSize = true;
            lbl_S.BackColor = Color.Transparent;
            lbl_S.Font = new Font("Trebuchet MS", 15F);
            lbl_S.ForeColor = Color.White;
            lbl_S.Location = new Point(3, 1);
            lbl_S.Name = "lbl_S";
            lbl_S.Size = new Size(166, 26);
            lbl_S.TabIndex = 1;
            lbl_S.Text = "Saldo disponível:";
            // 
            // pic_carteira
            // 
            pic_carteira.BackColor = Color.Transparent;
            pic_carteira.Image = (Image)resources.GetObject("pic_carteira.Image");
            pic_carteira.Location = new Point(569, 3);
            pic_carteira.Name = "pic_carteira";
            pic_carteira.Size = new Size(119, 109);
            pic_carteira.SizeMode = PictureBoxSizeMode.Zoom;
            pic_carteira.TabIndex = 0;
            pic_carteira.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_Resgatar);
            panel4.Location = new Point(88, 378);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 41);
            panel4.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-350, -21);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // btn_Resgatar
            // 
            btn_Resgatar.BackColor = Color.Green;
            btn_Resgatar.FlatAppearance.BorderSize = 0;
            btn_Resgatar.FlatStyle = FlatStyle.Flat;
            btn_Resgatar.ForeColor = Color.White;
            btn_Resgatar.Image = (Image)resources.GetObject("btn_Resgatar.Image");
            btn_Resgatar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Resgatar.Location = new Point(0, 0);
            btn_Resgatar.Name = "btn_Resgatar";
            btn_Resgatar.Size = new Size(233, 43);
            btn_Resgatar.TabIndex = 6;
            btn_Resgatar.Text = "              Resgatar Saldo";
            btn_Resgatar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Resgatar.UseVisualStyleBackColor = false;
            btn_Resgatar.Click += btn_Resgatar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btn_ver);
            panel2.Location = new Point(485, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 41);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-350, -21);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // btn_ver
            // 
            btn_ver.BackColor = Color.LightGray;
            btn_ver.FlatAppearance.BorderSize = 0;
            btn_ver.FlatStyle = FlatStyle.Flat;
            btn_ver.ForeColor = Color.FromArgb(27, 77, 46);
            btn_ver.Image = (Image)resources.GetObject("btn_ver.Image");
            btn_ver.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ver.Location = new Point(0, 0);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(233, 41);
            btn_ver.TabIndex = 6;
            btn_ver.Text = "               Ver Extrato";
            btn_ver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ver.UseVisualStyleBackColor = false;
            btn_ver.Click += btn_ver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(440, 436);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(357, 15);
            label5.TabIndex = 16;
            label5.Text = "v1.0.0 | © 2026 Reciclagem que Paga. Todos os direitos reservados.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Saldo
            // 
            AcceptButton = btn_Resgatar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 212, 200);
            CancelButton = btn_tI;
            ClientSize = new Size(800, 454);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btn_tI);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Saldo";
            Text = "Saldo";
            Activated += Saldo_Activated;
            Load += Saldo_Load;
            Paint += Saldo_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_carteira).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_tI;
        private Panel panel1;
        private PictureBox pic_carteira;
        private Label lbl_saldo;
        private Label lbl_S;
        private Panel panel4;
        private Label label3;
        private Button btn_Resgatar;
        private Panel panel2;
        private Label label4;
        private Button btn_ver;
        private Label label5;
        private PictureBox pictureBox1;
    }
}