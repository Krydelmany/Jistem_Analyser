using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jistem_Analyser.NavigationControl
{
    public partial class ucPlacaMae : UserControl
    {
        public ucPlacaMae()
        {
            InitializeComponent();
            GetMotherboardInfo();
            GetPCIExpressInfo();
            this.gbPlacaMae.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPlacaMae_Paint);
        }


        private void GetMotherboardInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbFabricante.Text = queryObj["Manufacturer"].ToString();
                    tbModelo.Text = queryObj["Product"].ToString();
                    tbVersao.Text = queryObj["Version"].ToString();
                    //lblSerialNumber.Text = queryObj["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        private void GetBIOSInfo()
        {
            try
            {   
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbFabricante.Text = queryObj["Manufacturer"].ToString();
                    tbModelo.Text = queryObj["Product"].ToString();
                    tbVersao.Text = queryObj["Version"].ToString();
                    //lblSerialNumber.Text = queryObj["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        private void GetPCIExpressInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%VEN_&DEV_&SUBSYS_%'");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string description = queryObj["Description"].ToString();
                    if (description.Contains("Express Root Port")) // Verificar se é uma porta PCI Express
                    {
                        // Recuperar informações relevantes do dispositivo
                        string manufacturer = queryObj["Manufacturer"]?.ToString();
                        string caption = queryObj["Caption"]?.ToString();
                        string deviceID = queryObj["DeviceID"]?.ToString();

                        // Exibir informações relevantes em algum lugar (como TextBoxes)
                        tbSerialNumber.Text = manufacturer; // Ajuste conforme a propriedade correta que contenha o chipset
                        tbSouthbridge.Text = caption; // Ajuste conforme a propriedade correta que contenha o número do barramento
                        break; // Sair do loop após encontrar o primeiro dispositivo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }




        // Duas funções abaixo mudam as cores do gbPlacaMae -----------------------------------------
        private void gbPlacaMae_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.FromArgb(202, 194, 197), Color.FromArgb(0, 198, 243), Color.FromArgb(28, 28, 28));
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Color backgroundColor)
        {
            if (box != null)
            {
                // Define the brushes and pens
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                Brush backgroundBrush = new SolidBrush(backgroundColor);

                // Measure the size of the text
                SizeF strSize = g.MeasureString(box.Text, box.Font);

                // Define the rectangle for the border
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear the area for the GroupBox background
                g.FillRectangle(backgroundBrush, box.ClientRectangle);

                // Draw the background rectangle (except the top portion where the text is)
                g.FillRectangle(backgroundBrush, rect);

                // Draw the text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Draw the border
                // Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                // Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                // Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                // Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                // Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
