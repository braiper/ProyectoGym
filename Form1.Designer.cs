namespace AppGym
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnRegister = new Button();
            btnAdmin = new Button();
            btnList = new Button();
            btnPay = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.Location = new Point(95, 221);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 43);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Alta de Socio";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(352, 324);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(159, 41);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrar Usuarios";
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(352, 221);
            btnList.Name = "btnList";
            btnList.Size = new Size(151, 43);
            btnList.TabIndex = 2;
            btnList.Text = "Listar Socios/Vencimientos";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(95, 324);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(151, 41);
            btnPay.TabIndex = 3;
            btnPay.Text = "Registrar Pago";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(505, 414);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 27);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(95, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 192);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(616, 462);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnPay);
            Controls.Add(btnList);
            Controls.Add(btnAdmin);
            Controls.Add(btnRegister);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnAdmin;
        private Button btnList;
        private Button btnPay;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}
