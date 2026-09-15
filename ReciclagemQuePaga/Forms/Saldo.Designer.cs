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
            label1 = new Label();
            label2 = new Label();
            btn_tI = new Button();
            panel1 = new Panel();
            pic_carteira = new PictureBox();
            lbl_S = new Label();
            lbl_saldo = new Label();
            panel4 = new Panel();
            label3 = new Label();
            btn_Resgatar = new Button();
            pic_sal = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            btn_ver = new Button();
            pic_ex = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_carteira).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_sal).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ex).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Meu saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(240, 15);
            label2.TabIndex = 1;
            label2.Text = "Acompanhe seus ganhos e saldo disponivel.";
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
            panel1.Controls.Add(lbl_saldo);
            panel1.Controls.Add(lbl_S);
            panel1.Controls.Add(pic_carteira);
            panel1.Location = new Point(30, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 115);
            panel1.TabIndex = 10;
            // 
            // pic_carteira
            // 
            pic_carteira.BackColor = Color.DarkSeaGreen;
            pic_carteira.Location = new Point(598, -12);
            pic_carteira.Name = "pic_carteira";
            pic_carteira.Size = new Size(127, 111);
            pic_carteira.TabIndex = 0;
            pic_carteira.TabStop = false;
            // 
            // lbl_S
            // 
            lbl_S.AutoSize = true;
            lbl_S.Font = new Font("Segoe UI", 15F);
            lbl_S.Location = new Point(23, 13);
            lbl_S.Name = "lbl_S";
            lbl_S.Size = new Size(161, 28);
            lbl_S.TabIndex = 1;
            lbl_S.Text = "Saldo disponivel:";
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Segoe UI", 15F);
            lbl_saldo.Location = new Point(23, 55);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(0, 28);
            lbl_saldo.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_Resgatar);
            panel4.Controls.Add(pic_sal);
            panel4.Location = new Point(77, 410);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 28);
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
            btn_Resgatar.Location = new Point(3, 1);
            btn_Resgatar.Name = "btn_Resgatar";
            btn_Resgatar.Size = new Size(134, 24);
            btn_Resgatar.TabIndex = 6;
            btn_Resgatar.Text = "Resgatar Saldo";
            btn_Resgatar.UseVisualStyleBackColor = true;
            // 
            // pic_sal
            // 
            pic_sal.BackColor = Color.DarkSeaGreen;
            pic_sal.Location = new Point(170, 1);
            pic_sal.Name = "pic_sal";
            pic_sal.Size = new Size(47, 27);
            pic_sal.TabIndex = 0;
            pic_sal.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btn_ver);
            panel2.Controls.Add(pic_ex);
            panel2.Location = new Point(461, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 28);
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
            btn_ver.Location = new Point(96, 1);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(134, 24);
            btn_ver.TabIndex = 6;
            btn_ver.Text = "Ver extrato";
            btn_ver.UseVisualStyleBackColor = true;
            // 
            // pic_ex
            // 
            pic_ex.BackColor = Color.DarkSeaGreen;
            pic_ex.Location = new Point(16, 3);
            pic_ex.Name = "pic_ex";
            pic_ex.Size = new Size(47, 27);
            pic_ex.TabIndex = 0;
            pic_ex.TabStop = false;
            // 
            // Saldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btn_tI);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Saldo";
            Text = "Saldo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_carteira).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_sal).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ex).EndInit();
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
        private PictureBox pic_sal;
        private Panel panel2;
        private Label label4;
        private Button btn_ver;
        private PictureBox pic_ex;
    }
}