using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;
using Jistem_Analyser.NavigationControl;

namespace Jistem_Analyser
{
    public partial class JystemAnalytics : Form
    {
        public JystemAnalytics()
        {
            InitializeComponent();
            AtualizarNomeSistema();

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); // deixa a borda arredondada
            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;
            ucInicio.Visible = true;
            ucMemoria.Visible = false;
            ucPlacaMae.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = false;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRec, int nRightRect, int nBottomRect, int nWidthE11ipse, int nHeightE11ipse);


        private void AtualizarNomeSistema()
        {
            string nomeSistema = Environment.UserName;
            lbNomeSistema.Text = nomeSistema;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // Design --------------------------------------------------------------------------------------------------------


        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 17, 35); // Altera a cor de fundo quando o mouse entra
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(22, 22, 22); // Restaura a cor de fundo quando o mouse sai
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucInicio.Visible = true;
            ucMemoria.Visible = false;
            ucPlacaMae.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = false;

            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnPlacaMae_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = true;
            ucInicio.Visible = false;
            ucMemoria.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = false;

            pnlNav.Height = btnPlacaMae.Height;
            pnlNav.Top = btnPlacaMae.Top;
            pnlNav.Left = btnPlacaMae.Left; // Certifique-se de mover o pnlNav
            btnPlacaMae.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = false;
            ucInicio.Visible = false;
            ucMemoria.Visible = true;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = false;

            pnlNav.Height = btnMemoria.Height;
            pnlNav.Top = btnMemoria.Top;
            pnlNav.Left = btnMemoria.Left; // Certifique-se de mover o pnlNav
            btnMemoria.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = false;
            ucInicio.Visible = false;
            ucMemoria.Visible = false;
            ucVideo.Visible = true;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = false;

            pnlNav.Height = btnVideo.Height;
            pnlNav.Top = btnVideo.Top;
            pnlNav.Left = btnVideo.Left; // Certifique-se de mover o pnlNav
            btnVideo.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = false;
            ucInicio.Visible = false;
            ucMemoria.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = false;
            ucSobre.Visible = true;

            pnlNav.Height = btnSobre.Height;
            pnlNav.Top = btnSobre.Top;
            pnlNav.Left = btnSobre.Left; // Certifique-se de mover o pnlNav
            btnSobre.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = false;
            ucInicio.Visible = false;
            ucMemoria.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = true;
            ucTeste.Visible = false;
            ucSobre.Visible = false;

            pnlNav.Height = btnCPU.Height;
            pnlNav.Top = btnCPU.Top;
            pnlNav.Left = btnCPU.Left; // Certifique-se de mover o pnlNav
            btnCPU.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            ucPlacaMae.Visible = false;
            ucInicio.Visible = false;
            ucMemoria.Visible = false;
            ucVideo.Visible = false;
            ucCPU.Visible = false;
            ucTeste.Visible = true;
            ucSobre.Visible = false;

            pnlNav.Height = btnTeste.Height;
            pnlNav.Top = btnTeste.Top;
            pnlNav.Left = btnTeste.Left; // Certifique-se de mover o pnlNav
            btnTeste.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnPlacaMae_Leave(object sender, EventArgs e)
        {
            btnPlacaMae.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnMemoria_Leave(object sender, EventArgs e)
        {
            btnMemoria.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnVideo_Leave(object sender, EventArgs e)
        {
            btnVideo.BackColor = Color.FromArgb(22, 22, 22);
        }
        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnSobre.BackColor = Color.FromArgb(22, 22, 22);
        }
        private void btnCPU_Leave(object sender, EventArgs e)
        {
            btnCPU.BackColor = Color.FromArgb(22, 22, 22);
        }
        private void btnTeste_Leave(object sender, EventArgs e)
        {
            btnTeste.BackColor = Color.FromArgb(22, 22, 22);
        }
    }
}
