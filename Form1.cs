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

            btnRegister.Paint += Button_Paint;
            btnList.Paint += Button_Paint;
            btnPay.Paint += Button_Paint;
            btnAdmin.Paint += Button_Paint;
            btnLogout.Paint += Button_Paint;
        }

        private void Button_Paint(object? sender, PaintEventArgs e) // Fix: Allow 'sender' to be nullable
        {
            if (sender is not Button btn) // Fix: Ensure 'sender' is a Button before proceeding
                return;

            Color color1 = Color.FromArgb(255, 49, 49);
            Color color2 = Color.FromArgb(255, 145, 77);

            using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, color1, color2, 90f))
            {
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle, SystemColors.ControlDarkDark, ButtonBorderStyle.Solid);

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
    }
}
