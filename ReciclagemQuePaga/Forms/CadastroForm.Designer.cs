namespace ReciclagemQuePaga.Forms
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            lbl_cc = new Label();
            txb_email = new TextBox();
            txb_senha = new TextBox();
            lbl_email = new Label();
            lbl_senha = new Label();
            pictureBox1 = new PictureBox();
            btn_cadastrar = new Button();
            txb_confirmar_senha = new TextBox();
            lbl_csenha = new Label();
            lbl_nome = new Label();
            txb_nome = new TextBox();
            lbl_cpf = new Label();
            msk_txb_cpf = new MaskedTextBox();
            voltar_telalogin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_cc
            // 
            lbl_cc.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold);
            lbl_cc.Location = new Point(502, 9);
            lbl_cc.Name = "lbl_cc";
            lbl_cc.Size = new Size(180, 39);
            lbl_cc.TabIndex = 0;
            lbl_cc.Text = "Criar Conta";
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 13F);
            txb_email.Location = new Point(421, 206);
            txb_email.Multiline = true;
            txb_email.Name = "txb_email";
            txb_email.PlaceholderText = "Insira seu e-mail";
            txb_email.Size = new Size(338, 34);
            txb_email.TabIndex = 1;
            txb_email.TextChanged += txb_email_TextChanged;
            // 
            // txb_senha
            // 
            txb_senha.Font = new Font("Segoe UI", 13F);
            txb_senha.Location = new Point(421, 269);
            txb_senha.Multiline = true;
            txb_senha.Name = "txb_senha";
            txb_senha.PlaceholderText = "Insira sua senha";
            txb_senha.Size = new Size(338, 34);
            txb_senha.TabIndex = 2;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(421, 179);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(64, 24);
            lbl_email.TabIndex = 3;
            lbl_email.Text = "Email:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(421, 242);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(67, 24);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Green;
            btn_cadastrar.FlatAppearance.BorderColor = Color.Honeydew;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Trebuchet MS", 12F);
            btn_cadastrar.ForeColor = SystemColors.ButtonHighlight;
            btn_cadastrar.Location = new Point(659, 382);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(100, 29);
            btn_cadastrar.TabIndex = 6;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // txb_confirmar_senha
            // 
            txb_confirmar_senha.Font = new Font("Segoe UI", 13F);
            txb_confirmar_senha.Location = new Point(421, 342);
            txb_confirmar_senha.Multiline = true;
            txb_confirmar_senha.Name = "txb_confirmar_senha";
            txb_confirmar_senha.PlaceholderText = "Confirme sua senha";
            txb_confirmar_senha.Size = new Size(338, 34);
            txb_confirmar_senha.TabIndex = 7;
            // 
            // lbl_csenha
            // 
            lbl_csenha.AutoSize = true;
            lbl_csenha.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_csenha.Location = new Point(421, 315);
            lbl_csenha.Name = "lbl_csenha";
            lbl_csenha.Size = new Size(156, 24);
            lbl_csenha.TabIndex = 8;
            lbl_csenha.Text = "Confirmar Senha:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(421, 56);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(65, 24);
            lbl_nome.TabIndex = 9;
            lbl_nome.Text = "Nome:";
            lbl_nome.Click += lbl_nome_Click;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 13F);
            txb_nome.Location = new Point(420, 83);
            txb_nome.Multiline = true;
            txb_nome.Name = "txb_nome";
            txb_nome.PlaceholderText = "Insira seu nome completo";
            txb_nome.Size = new Size(338, 34);
            txb_nome.TabIndex = 10;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cpf.Location = new Point(420, 120);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(49, 24);
            lbl_cpf.TabIndex = 11;
            lbl_cpf.Text = "CPF:";
            // 
            // msk_txb_cpf
            // 
            msk_txb_cpf.Font = new Font("Segoe UI", 13F);
            msk_txb_cpf.Location = new Point(420, 147);
            msk_txb_cpf.Mask = "000,000,000,00";
            msk_txb_cpf.Name = "msk_txb_cpf";
            msk_txb_cpf.Size = new Size(338, 31);
            msk_txb_cpf.TabIndex = 12;
            // 
            // voltar_telalogin
            // 
            voltar_telalogin.AutoSize = true;
            voltar_telalogin.Font = new Font("Segoe UI", 8F);
            voltar_telalogin.Location = new Point(628, 428);
            voltar_telalogin.Name = "voltar_telalogin";
            voltar_telalogin.Size = new Size(131, 13);
            voltar_telalogin.TabIndex = 13;
            voltar_telalogin.TabStop = true;
            voltar_telalogin.Text = "Voltar para tela de login";
            voltar_telalogin.LinkClicked += voltar_telalogin_LinkClicked;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(808, 473);
            Controls.Add(voltar_telalogin);
            Controls.Add(msk_txb_cpf);
            Controls.Add(lbl_cpf);
            Controls.Add(txb_nome);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_csenha);
            Controls.Add(txb_confirmar_senha);
            Controls.Add(btn_cadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_email);
            Controls.Add(txb_senha);
            Controls.Add(txb_email);
            Controls.Add(lbl_cc);
            Name = "CadastroForm";
            Text = "Tela de Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cc;
        private TextBox txb_email;
        private TextBox txb_senha;
        private Label lbl_email;
        private Label lbl_senha;
        private PictureBox pictureBox1;
        private Button btn_cadastrar;
        private TextBox txb_confirmar_senha;
        private Label lbl_csenha;
        private Label lbl_nome;
        private TextBox txb_nome;
        private Label lbl_cpf;
        private MaskedTextBox msk_txb_cpf;
        private LinkLabel voltar_telalogin;
    }
}