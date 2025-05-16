using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace AppGym
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            SetButtonRegion(btnRegister);
            SetButtonRegion(btnList);
            SetButtonRegion(btnPay);
            SetButtonRegion(btnAdmin);
            SetButtonRegion(btnLogout);

            btnRegister.Paint += Button_Paint;
            btnList.Paint += Button_Paint;
            btnPay.Paint += Button_Paint;
            btnAdmin.Paint += Button_Paint;
            btnLogout.Paint += Button_Paint;
        }

        private void SetButtonRegion(Button btn)
        {
            int radius = 20; // Radio de los bordes
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void Button_Paint(object? sender, PaintEventArgs e) // Fix: Allow 'sender' to be nullable
        {
            if (sender is not Button btn) // Fix: Ensure 'sender' is a Button before proceeding
                return;

            Color color1 = Color.FromArgb(255, 49, 49);
            Color color2 = Color.FromArgb(255, 49, 49);

            using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, color1, color2, 90f))
            {
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            // Dibuja el borde redondeado
            int radius = 20;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                using (Pen pen = new Pen(SystemColors.ControlDarkDark, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, flags);

            if (btn.Focused)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, btn.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (frmAltaSocio altaSocio = new frmAltaSocio())
            {
                if(altaSocio.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Socio registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (altaSocio.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Registro cancelado.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
