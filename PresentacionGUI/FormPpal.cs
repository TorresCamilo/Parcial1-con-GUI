using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuLateral.Width == 250)
                MenuLateral.Width = 70;
            else
                MenuLateral.Width = 250;
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PctMaximar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.PctMaximar.Visible = false;
            this.PctRestaurar.Visible = true;

        }

        private void PctRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.PctMaximar.Visible = true;
            this.PctRestaurar.Visible = false;
        }

        private void PctMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
