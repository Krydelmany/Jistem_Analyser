using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucCPU : UserControl
    {
        public ucCPU()
        {
            InitializeComponent();
            GetProcessorInfo();
            GetCPUinfo();

            tbL1.Text = GetCacheSize("3");
            tbL2.Text = GetCacheSize("4");
            tbL3.Text = GetCacheSize("5");

            this.gbGeral.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesign_Paint);
            this.gbArquitetura.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesign_Paint);
            this.gbCache.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesign_Paint);
        }

        private string GetCacheSize(string cacheLevel)
        {
            string cacheSize = "Unknown";

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_CacheMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Level"].ToString() == cacheLevel)
                    {
                        cacheSize = $"{queryObj["InstalledSize"]} KB";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção aqui, se necessário
                MessageBox.Show("An error occurred while querying cache memory: " + ex.Message);
            }

            return cacheSize;
        }

        private void GetCPUinfo()
        {
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2",
           "SELECT Architecture, Description, Family, Manufacturer, SocketDesignation, Name, " +
           "Caption, L2CacheSpeed, L3CacheSpeed, ThreadCount, NumberOfCores, NumberOfLogicalProcessors" +
           ", MaxClockSpeed, NumberOfEnabledCore FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher1.Get())
            {
                string arquitetura = $"{queryObj["Architecture"]}";
                int architecture = Convert.ToUInt16(arquitetura);
                switch (architecture)
                {
                    case 0:
                        tbArquitetura.Text = "x86";
                        break;
                    case 1:
                        tbArquitetura.Text = "x86";
                        break;
                    case 2:
                        tbArquitetura.Text = "MIPS";
                        break;
                    case 3:
                        tbArquitetura.Text = "PowerPC";
                        break;
                    case 5:
                        tbArquitetura.Text = "ARM";
                        break;
                    case 6:
                        tbArquitetura.Text = "Itanium-based systems";
                        break;
                    case 9:
                        tbArquitetura.Text = "x64";
                        break;
                    default:
                        tbArquitetura.Text = "Desconhecido";
                        break;
                }

                tbFabricante.Text = $"{queryObj["Manufacturer"]}";
                tbDescricao.Text = $"{queryObj["Description"]}";
                tbSoquete.Text = $"{queryObj["SocketDesignation"]}";
                tbSpeed2.Text = $"{queryObj["L2CacheSpeed"]}";
                tbSpeed3.Text = $"{queryObj["L3CacheSpeed"]}";
                tbThread.Text = $"{queryObj["ThreadCount"]}";
                tbNucleoF.Text = $"{queryObj["NumberOfCores"]}";
                tbNucleoL.Text = $"{queryObj["NumberOfLogicalProcessors"]}";
                tbFrequenciaMaxima.Text = $"{queryObj["MaxClockSpeed"]} Mhz";
                tbHabilitado.Text = $"{queryObj["NumberOfEnabledCore"]}";
            }
        }

        private void GetProcessorInfo()
        {
            // Caminho do registro para as informações do processador
            string registryPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";

            try
            {
                // Abra a chave de registro
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Leia os valores do registro
                         tbNome.Text = key.GetValue("ProcessorNameString")?.ToString();
                         tbDescricao.Text = key.GetValue("Identifier")?.ToString();
                         tbFabricante.Text = key.GetValue("VendorIdentifier")?.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving processor information: " + ex.Message);
            }
        }


        // Duas funções abaixo mudam as cores do gb -----------------------------------------
        private void gbDesign_Paint(object sender, PaintEventArgs e)
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
