namespace ReciclagemQuePaga
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txb_email = new TextBox();
            txb_senha = new TextBox();
            pictureBox1 = new PictureBox();
            btn_entrar = new Button();
            cb_senha = new CheckBox();
            link_cadastro = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txb_email
            // 
            txb_email.BackColor = SystemColors.Window;
            txb_email.CausesValidation = false;
            txb_email.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_email.ForeColor = Color.Black;
            txb_email.Location = new Point(12, 155);
            txb_email.Margin = new Padding(4, 3, 4, 3);
            txb_email.Multiline = true;
            txb_email.Name = "txb_email";
            txb_email.PlaceholderText = "Insira seu E-mail";
            txb_email.Size = new Size(304, 31);
            txb_email.TabIndex = 4;
            // 
            // txb_senha
            // 
            txb_senha.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_senha.Location = new Point(12, 215);
            txb_senha.Margin = new Padding(4, 3, 4, 3);
            txb_senha.Multiline = true;
            txb_senha.Name = "txb_senha";
            txb_senha.PlaceholderText = "Insira sua senha";
            txb_senha.Size = new Size(304, 31);
            txb_senha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(120, 120, 120);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(405, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.Green;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_entrar.ForeColor = SystemColors.ButtonHighlight;
            btn_entrar.Location = new Point(186, 260);
            btn_entrar.Margin = new Padding(4, 3, 4, 3);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(130, 31);
            btn_entrar.TabIndex = 0;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // cb_senha
            // 
            cb_senha.AutoSize = true;
            cb_senha.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_senha.ForeColor = Color.FromArgb(0, 64, 0);
            cb_senha.Location = new Point(12, 252);
            cb_senha.Margin = new Padding(4, 3, 4, 3);
            cb_senha.Name = "cb_senha";
            cb_senha.Size = new Size(113, 22);
            cb_senha.TabIndex = 6;
            cb_senha.Text = "Visualizar senha";
            cb_senha.UseVisualStyleBackColor = true;
            cb_senha.CheckedChanged += cb_senha_CheckedChanged;
            // 
            // link_cadastro
            // 
            link_cadastro.ActiveLinkColor = Color.FromArgb(27, 77, 46);
            link_cadastro.BackColor = Color.DarkSeaGreen;
            link_cadastro.DisabledLinkColor = Color.FromArgb(27, 77, 46);
            link_cadastro.Font = new Font("Trebuchet MS", 8.25F);
            link_cadastro.ForeColor = Color.Black;
            link_cadastro.LinkColor = Color.FromArgb(27, 77, 46);
            link_cadastro.Location = new Point(234, 294);
            link_cadastro.Margin = new Padding(4, 0, 4, 0);
            link_cadastro.Name = "link_cadastro";
            link_cadastro.Size = new Size(80, 57);
            link_cadastro.TabIndex = 8;
            link_cadastro.TabStop = true;
            link_cadastro.Text = "Faça seu cadastro aqui!";
            link_cadastro.TextAlign = ContentAlignment.MiddleCenter;
            link_cadastro.VisitedLinkColor = Color.FromArgb(40, 40, 40);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13F);
            label2.Location = new Point(12, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13F);
            label3.Location = new Point(12, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(405, 29);
            label1.TabIndex = 13;
            label1.Text = "Bem-vindo à Reciclagem que paga!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 80);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(283, 22);
            label4.TabIndex = 2;
            label4.Text = "Insira seu Login abaixo para continuar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(0, 426);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(357, 15);
            label5.TabIndex = 14;
            label5.Text = "v1.0.0 | © 2026 Reciclagem que Paga. Todos os direitos reservados.";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(link_cadastro);
            Controls.Add(cb_senha);
            Controls.Add(btn_entrar);
            Controls.Add(pictureBox1);
            Controls.Add(txb_senha);
            Controls.Add(txb_email);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_email;
        private TextBox txb_senha;
        private PictureBox pictureBox1;
        private Button btn_entrar;
        private CheckBox cb_senha;
        private LinkLabel link_cadastro;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
