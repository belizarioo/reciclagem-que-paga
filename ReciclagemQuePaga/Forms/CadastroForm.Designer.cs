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
            label1 = new Label();
            txb_email = new TextBox();
            txb_senha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_cadastrar = new Button();
            txb_confirmar_senha = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txb_nome = new TextBox();
            label6 = new Label();
            msk_txb_cpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(85, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 0;
            label1.Text = "Criar Conta";
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 13F);
            txb_email.Location = new Point(13, 194);
            txb_email.Multiline = true;
            txb_email.Name = "txb_email";
            txb_email.PlaceholderText = "Insira seu e-mail";
            txb_email.Size = new Size(271, 34);
            txb_email.TabIndex = 1;
            // 
            // txb_senha
            // 
            txb_senha.Font = new Font("Segoe UI", 13F);
            txb_senha.Location = new Point(13, 257);
            txb_senha.Multiline = true;
            txb_senha.Name = "txb_senha";
            txb_senha.PlaceholderText = "Insira sua senha";
            txb_senha.Size = new Size(271, 34);
            txb_senha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 176);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 239);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(407, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(184, 381);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(99, 23);
            btn_cadastrar.TabIndex = 6;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // txb_confirmar_senha
            // 
            txb_confirmar_senha.Font = new Font("Segoe UI", 13F);
            txb_confirmar_senha.Location = new Point(13, 330);
            txb_confirmar_senha.Multiline = true;
            txb_confirmar_senha.Name = "txb_confirmar_senha";
            txb_confirmar_senha.PlaceholderText = "Confirme sua senha";
            txb_confirmar_senha.Size = new Size(271, 34);
            txb_confirmar_senha.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 312);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "Confirmar Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 46);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 9;
            label5.Text = "Nome:";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 13F);
            txb_nome.Location = new Point(12, 64);
            txb_nome.Multiline = true;
            txb_nome.Name = "txb_nome";
            txb_nome.PlaceholderText = "Insira seu nome completo";
            txb_nome.Size = new Size(271, 34);
            txb_nome.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 108);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 11;
            label6.Text = "CPF:";
            // 
            // msk_txb_cpf
            // 
            msk_txb_cpf.Font = new Font("Segoe UI", 13F);
            msk_txb_cpf.Location = new Point(12, 126);
            msk_txb_cpf.Mask = "000,000,000,00";
            msk_txb_cpf.Name = "msk_txb_cpf";
            msk_txb_cpf.Size = new Size(271, 31);
            msk_txb_cpf.TabIndex = 12;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(808, 473);
            Controls.Add(msk_txb_cpf);
            Controls.Add(label6);
            Controls.Add(txb_nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txb_confirmar_senha);
            Controls.Add(btn_cadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_senha);
            Controls.Add(txb_email);
            Controls.Add(label1);
            Name = "CadastroForm";
            Text = "CadastroForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_email;
        private TextBox txb_senha;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_cadastrar;
        private TextBox txb_confirmar_senha;
        private Label label4;
        private Label label5;
        private TextBox txb_nome;
        private Label label6;
        private MaskedTextBox msk_txb_cpf;
    }
}