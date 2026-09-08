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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_ham).BeginInit();
            menu_lateral.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btn_ham);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 32);
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
            menu_lateral.Controls.Add(button1);
            menu_lateral.Controls.Add(button2);
            menu_lateral.Controls.Add(button3);
            menu_lateral.Dock = DockStyle.Left;
            menu_lateral.Location = new Point(0, 32);
            menu_lateral.Name = "menu_lateral";
            menu_lateral.Size = new Size(156, 418);
            menu_lateral.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 43);
            button2.Name = "button2";
            button2.Size = new Size(153, 34);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 83);
            button3.Name = "button3";
            button3.Size = new Size(153, 34);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(menu_lateral);
            Controls.Add(panel1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            FormClosed += TelaInicial_FormClosed;
            Load += TelaInicial_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_ham).EndInit();
            menu_lateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel menu_lateral;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox btn_ham;
    }
}