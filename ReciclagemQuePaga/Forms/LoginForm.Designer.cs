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
            txb_email = new TextBox();
            txb_senha = new TextBox();
            pictureBox1 = new PictureBox();
            btn_entrar = new Button();
            cb_senha = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txb_email
            // 
            txb_email.CausesValidation = false;
            txb_email.Font = new Font("Segoe UI", 18F);
            txb_email.Location = new Point(61, 130);
            txb_email.Name = "txb_email";
            txb_email.PlaceholderText = "email...";
            txb_email.Size = new Size(253, 39);
            txb_email.TabIndex = 0;
            // 
            // txb_senha
            // 
            txb_senha.Font = new Font("Segoe UI", 18F);
            txb_senha.Location = new Point(61, 225);
            txb_senha.Name = "txb_senha";
            txb_senha.PlaceholderText = "senha...";
            txb_senha.Size = new Size(253, 39);
            txb_senha.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(426, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 451);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(239, 291);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // cb_senha
            // 
            cb_senha.AutoSize = true;
            cb_senha.Location = new Point(61, 279);
            cb_senha.Name = "cb_senha";
            cb_senha.Size = new Size(109, 19);
            cb_senha.TabIndex = 4;
            cb_senha.Text = "Visualizar senha";
            cb_senha.UseVisualStyleBackColor = true;
            cb_senha.CheckedChanged += cb_senha_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_senha);
            Controls.Add(btn_entrar);
            Controls.Add(pictureBox1);
            Controls.Add(txb_senha);
            Controls.Add(txb_email);
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
    }
}
