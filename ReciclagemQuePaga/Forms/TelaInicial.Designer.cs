namespace ReciclagemQuePaga.Forms
{
    partial class TelaInicial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_ham = new PictureBox();
            menu_lateral = new FlowLayoutPanel();
            btn_inicio = new Button();
            btn_maquina = new Button();
            btn_historico = new Button();
            btn_saldo = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            painel_principal = new Panel();
            painel_Msaldo = new Panel();
            lbl_saldo = new Label();
            lbl_sL = new Label();
            lbl_nU = new Label();
            flow = new FlowLayoutPanel();
            painel_simula = new Panel();
            btn_maquina2 = new Button();
            painel_historico = new Panel();
            btn_historico2 = new Button();
            painel_saldo = new Panel();
            btn_saldo2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_ham).BeginInit();
            menu_lateral.SuspendLayout();
            painel_principal.SuspendLayout();
            painel_Msaldo.SuspendLayout();
            flow.SuspendLayout();
            painel_simula.SuspendLayout();
            painel_historico.SuspendLayout();
            painel_saldo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btn_ham);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 29);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_ham
            // 
            btn_ham.Image = (Image)resources.GetObject("btn_ham.Image");
            btn_ham.Location = new Point(3, 4);
            btn_ham.Name = "btn_ham";
            btn_ham.Size = new Size(35, 25);
            btn_ham.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_ham.TabIndex = 0;
            btn_ham.TabStop = false;
            btn_ham.Click += btn_ham_Click;
            // 
            // menu_lateral
            // 
            menu_lateral.BackColor = Color.DarkSeaGreen;
            menu_lateral.Controls.Add(btn_inicio);
            menu_lateral.Controls.Add(btn_maquina);
            menu_lateral.Controls.Add(btn_historico);
            menu_lateral.Controls.Add(btn_saldo);
            menu_lateral.Dock = DockStyle.Left;
            menu_lateral.Location = new Point(0, 29);
            menu_lateral.Name = "menu_lateral";
            menu_lateral.Size = new Size(156, 421);
            menu_lateral.TabIndex = 1;
            menu_lateral.Paint += menu_lateral_Paint;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.DarkSeaGreen;
            btn_inicio.Location = new Point(3, 3);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(153, 34);
            btn_inicio.TabIndex = 3;
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // btn_maquina
            // 
            btn_maquina.BackColor = Color.DarkSeaGreen;
            btn_maquina.Location = new Point(3, 43);
            btn_maquina.Name = "btn_maquina";
            btn_maquina.Size = new Size(153, 34);
            btn_maquina.TabIndex = 4;
            btn_maquina.UseVisualStyleBackColor = false;
            // 
            // btn_historico
            // 
            btn_historico.BackColor = Color.DarkSeaGreen;
            btn_historico.Location = new Point(3, 83);
            btn_historico.Name = "btn_historico";
            btn_historico.Size = new Size(153, 34);
            btn_historico.TabIndex = 5;
            btn_historico.UseVisualStyleBackColor = false;
            // 
            // btn_saldo
            // 
            btn_saldo.BackColor = Color.DarkSeaGreen;
            btn_saldo.Location = new Point(3, 123);
            btn_saldo.Name = "btn_saldo";
            btn_saldo.Size = new Size(153, 34);
            btn_saldo.TabIndex = 6;
            btn_saldo.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // painel_principal
            // 
            painel_principal.BackColor = SystemColors.Control;
            painel_principal.Controls.Add(painel_Msaldo);
            painel_principal.Controls.Add(lbl_nU);
            painel_principal.Controls.Add(flow);
            painel_principal.Location = new Point(156, 29);
            painel_principal.Name = "painel_principal";
            painel_principal.Size = new Size(636, 421);
            painel_principal.TabIndex = 2;
            painel_principal.Paint += painel_principal_Paint;
            // 
            // painel_Msaldo
            // 
            painel_Msaldo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            painel_Msaldo.Controls.Add(lbl_saldo);
            painel_Msaldo.Controls.Add(lbl_sL);
            painel_Msaldo.Location = new Point(461, 6);
            painel_Msaldo.Name = "painel_Msaldo";
            painel_Msaldo.Size = new Size(172, 52);
            painel_Msaldo.TabIndex = 2;
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Segoe UI", 12F);
            lbl_saldo.Location = new Point(20, 24);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(0, 21);
            lbl_saldo.TabIndex = 1;
            // 
            // lbl_sL
            // 
            lbl_sL.AutoSize = true;
            lbl_sL.Font = new Font("Segoe UI", 12F);
            lbl_sL.Location = new Point(14, 1);
            lbl_sL.Name = "lbl_sL";
            lbl_sL.Size = new Size(87, 21);
            lbl_sL.TabIndex = 0;
            lbl_sL.Text = "Saldo atual";
            // 
            // lbl_nU
            // 
            lbl_nU.AutoSize = true;
            lbl_nU.Font = new Font("Segoe UI", 14F);
            lbl_nU.Location = new Point(14, 13);
            lbl_nU.Name = "lbl_nU";
            lbl_nU.Size = new Size(0, 25);
            lbl_nU.TabIndex = 1;
            lbl_nU.Click += lbl_nU_Click;
            // 
            // flow
            // 
            flow.Anchor = AnchorStyles.None;
            flow.Controls.Add(painel_simula);
            flow.Controls.Add(painel_historico);
            flow.Controls.Add(painel_saldo);
            flow.Location = new Point(1, 94);
            flow.Margin = new Padding(14, 4, 14, 4);
            flow.Name = "flow";
            flow.RightToLeft = RightToLeft.No;
            flow.Size = new Size(635, 214);
            flow.TabIndex = 0;
            // 
            // painel_simula
            // 
            painel_simula.BackColor = Color.DarkSeaGreen;
            painel_simula.Controls.Add(btn_maquina2);
            painel_simula.Location = new Point(3, 3);
            painel_simula.Name = "painel_simula";
            painel_simula.Size = new Size(200, 178);
            painel_simula.TabIndex = 3;
            // 
            // btn_maquina2
            // 
            btn_maquina2.Location = new Point(13, 141);
            btn_maquina2.Name = "btn_maquina2";
            btn_maquina2.Size = new Size(75, 23);
            btn_maquina2.TabIndex = 0;
            btn_maquina2.Text = "acessar";
            btn_maquina2.UseVisualStyleBackColor = true;
            // 
            // painel_historico
            // 
            painel_historico.BackColor = Color.DarkSeaGreen;
            painel_historico.Controls.Add(btn_historico2);
            painel_historico.Location = new Point(209, 3);
            painel_historico.Name = "painel_historico";
            painel_historico.Size = new Size(200, 178);
            painel_historico.TabIndex = 2;
            // 
            // btn_historico2
            // 
            btn_historico2.Location = new Point(20, 141);
            btn_historico2.Name = "btn_historico2";
            btn_historico2.Size = new Size(75, 23);
            btn_historico2.TabIndex = 1;
            btn_historico2.Text = "acessar";
            btn_historico2.UseVisualStyleBackColor = true;
            // 
            // painel_saldo
            // 
            painel_saldo.BackColor = Color.DarkSeaGreen;
            painel_saldo.Controls.Add(btn_saldo2);
            painel_saldo.Location = new Point(415, 3);
            painel_saldo.Name = "painel_saldo";
            painel_saldo.Size = new Size(200, 178);
            painel_saldo.TabIndex = 4;
            // 
            // btn_saldo2
            // 
            btn_saldo2.Location = new Point(13, 141);
            btn_saldo2.Name = "btn_saldo2";
            btn_saldo2.Size = new Size(75, 23);
            btn_saldo2.TabIndex = 2;
            btn_saldo2.Text = "acessar";
            btn_saldo2.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(painel_principal);
            Controls.Add(menu_lateral);
            Controls.Add(panel1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            FormClosed += TelaInicial_FormClosed;
            Load += TelaInicial_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_ham).EndInit();
            menu_lateral.ResumeLayout(false);
            painel_principal.ResumeLayout(false);
            painel_principal.PerformLayout();
            painel_Msaldo.ResumeLayout(false);
            painel_Msaldo.PerformLayout();
            flow.ResumeLayout(false);
            painel_simula.ResumeLayout(false);
            painel_historico.ResumeLayout(false);
            painel_saldo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel menu_lateral;
        private Button btn_inicio;
        private Button btn_maquina;
        private Button btn_historico;
        private System.Windows.Forms.Timer timer1;
        private PictureBox btn_ham;
        private Button btn_saldo;
        private Panel painel_principal;
        private FlowLayoutPanel flow;
        private Panel painel_simula;
        private Button btn_maquina2;
        private Panel painel_historico;
        private Button btn_historico2;
        private Panel painel_saldo;
        private Button btn_saldo2;
        private Label lbl_nU;
        private Panel painel_Msaldo;
        private Label lbl_sL;
        private Label lbl_saldo;
    }
}