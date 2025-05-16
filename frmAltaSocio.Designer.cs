namespace AppGym
{
    partial class frmAltaSocio
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
            lblName = new Label();
            lblLastName = new Label();
            lblMail = new Label();
            lblTlf = new Label();
            lblID = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtID = new TextBox();
            txtTlf = new TextBox();
            txtMail = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(82, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(82, 101);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(51, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Apellido";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(28, 277);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(105, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Correo Electrónico";
            // 
            // lblTlf
            // 
            lblTlf.AutoSize = true;
            lblTlf.Location = new Point(81, 220);
            lblTlf.Name = "lblTlf";
            lblTlf.Size = new Size(52, 15);
            lblTlf.TabIndex = 3;
            lblTlf.Text = "Teléfono";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(63, 162);
            lblID.Name = "lblID";
            lblID.Size = new Size(70, 15);
            lblID.TabIndex = 4;
            lblID.Text = "Documento";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 23);
            txtName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(277, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 159);
            txtID.Name = "txtID";
            txtID.Size = new Size(277, 23);
            txtID.TabIndex = 7;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // txtTlf
            // 
            txtTlf.Location = new Point(150, 217);
            txtTlf.Name = "txtTlf";
            txtTlf.Size = new Size(277, 23);
            txtTlf.TabIndex = 8;
            txtTlf.KeyPress += txtTlf_KeyPress;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(150, 274);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(277, 23);
            txtMail.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Location = new Point(367, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(89, 27);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(476, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 27);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAltaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 407);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtMail);
            Controls.Add(txtTlf);
            Controls.Add(txtID);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblID);
            Controls.Add(lblTlf);
            Controls.Add(lblMail);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Name = "frmAltaSocio";
            Text = "frmAltaSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lblMail;
        private Label lblTlf;
        private Label lblID;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtID;
        private TextBox txtTlf;
        private TextBox txtMail;
        private Button btnRegister;
        private Button btnCancel;
    }
}