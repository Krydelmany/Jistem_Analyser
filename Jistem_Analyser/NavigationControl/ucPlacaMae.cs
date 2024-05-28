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
using LibreHardwareMonitor.Hardware;
using System.Windows.Forms;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucPlacaMae : UserControl
    {
        private Computer _computer;

        public ucPlacaMae()
        {
            InitializeComponent();
            GetMotherboardInfo();
            this.gbPlacaMae.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPlacaMae_Paint);
        }

        private void GetMotherboardInfo()
        {
            try
            {
                // WMI para obter informações básicas da placa-mãe
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbFabricante.Text = queryObj["Manufacturer"]?.ToString();
                    tbModelo.Text = queryObj["Product"]?.ToString();
                    tbVersao.Text = queryObj["Version"]?.ToString();
                    tbBusSpecs.Text = queryObj["Name"]?.ToString();
                    tbChipset.Text = queryObj["SerialNumber"]?.ToString();
                }
                

                // LibreHardwareMonitor para obter informações detalhadas do chipset
                _computer = new Computer
                {
                    IsMotherboardEnabled = true,
                    IsCpuEnabled = true
                };
                _computer.Open();

                foreach (var hardwareItem in _computer.Hardware)
                {
                    if (hardwareItem.HardwareType == HardwareType.GpuAmd)
                    {
                        hardwareItem.Update();
                        tbChipset.Text = hardwareItem.Name;

                        foreach (var subHardware in hardwareItem.SubHardware)
                        {
                            subHardware.Update();
                            // Exibir mais detalhes do subHardware se necessário
                        }
                    }

                    if (hardwareItem.HardwareType == HardwareType.Cpu)
                    {
                        tbCpu.Text = hardwareItem.Name;
                    }
                }

                _computer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for hardware data: " + ex.Message);
            }
        }

        private void GetBIOSInfo()
        {
            try
            {
                // WMI para obter informações básicas da placa-mãe
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Bus");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbBusSpecs.Text = queryObj["Name"]?.ToString();
                    tbChipset.Text = queryObj["SerialNumber"]?.ToString();
                }
                catch (Exception ex) 
            {
                MessageBox.Show("An error occurred while querying for hardware data: " + ex.Message);
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
