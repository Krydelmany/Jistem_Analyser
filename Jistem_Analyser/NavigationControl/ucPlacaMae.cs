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
using LibreHardwareMonitor.Hardware.Motherboard;
using System.Xml.Linq;
using Microsoft.Win32;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucPlacaMae : UserControl
    {
        public ucPlacaMae()
        {
            InitializeComponent();
            GetMotherboardInfo();
            GetMotherboardDevice();
            GetBIOSInfoKEY();
            GetBiosInfo();

            this.gbBIOS.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPlacaMae_Paint);
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
                    tbSerialNumber.Text = queryObj["SerialNumber"]?.ToString();
                    tbDescricao.Text = queryObj["Description"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for hardware data: " + ex.Message);
            }
        }

        private void GetMotherboardDevice()
        {
            try
            {
                // WMI para obter informações básicas da placa-mãe
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_MotherboardDevice");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbPrimaryBus.Text = queryObj["PrimaryBusType"]?.ToString();
                    tbSecondaryBus.Text = queryObj["SecondaryBusType"]?.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void GetBiosInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

                ManagementObjectCollection biosCollection = searcher.Get();
                ManagementObject bios = biosCollection.Cast<ManagementObject>().FirstOrDefault();

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    // Nome da BIOS
                    tbBiosName1.Text = queryObj["Name"] != null ? queryObj["Name"].ToString() : "N/A";

                    // Versão da BIOS
                    if (queryObj["BIOSVersion"] != null)
                    {
                        string versaoBios = bios["Version"]?.ToString();
                        tbBiosName0.Text = versaoBios;
                    }
                    else
                    {
                        tbBiosName0.Text = "N/A";
                    }

                    // Fabricante da BIOS
                    tbBiosManufacturer.Text = queryObj["Manufacturer"] != null ? queryObj["Manufacturer"].ToString() : "N/A";

                    // Data de Liberação da BIOS
                    if (queryObj["ReleaseDate"] != null)
                    {
                        DateTime releaseDate = ManagementDateTimeConverter.ToDateTime(queryObj["ReleaseDate"].ToString());
                        tbBiosReleaseDate.Text = releaseDate.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        tbBiosReleaseDate.Text = "N/A";
                    }

                    // Número de Série da BIOS
                    tbBiosSerialNumber.Text = queryObj["SerialNumber"] != null ? queryObj["SerialNumber"].ToString() : "N/A";

                    // Versão do SMBIOS
                    tbSmbiosVersion.Text = queryObj["SMBIOSBIOSVersion"] != null ? queryObj["SMBIOSBIOSVersion"].ToString() : "N/A";

                    // Versão do Sistema BIOS
                    if (queryObj["SMBIOSMajorVersion"] != null && queryObj["SMBIOSMinorVersion"] != null)
                    {
                        tbSystemBiosVersion.Text = $"{queryObj["SMBIOSMajorVersion"]}.{queryObj["SMBIOSMinorVersion"]}";
                    }
                    else
                    {
                        tbSystemBiosVersion.Text = "N/A";
                    }

                    // Características da BIOS
                    if (queryObj["BiosCharacteristics"] != null)
                    {
                        tbBiosCharacteristics.Text = string.Join(", ", (ushort[])queryObj["BiosCharacteristics"]);
                    }
                    else
                    {
                        tbBiosCharacteristics.Text = "N/A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving BIOS information: " + ex.Message);
            }
        }

        private void GetBIOSInfoKEY()
        {
            // Caminho do registro para as informações do processador
            string registryPath = @"HARDWARE\DESCRIPTION\System\BIOS";

            try
            {
                // Abra a chave de registro
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Leia os valores do registro
                        tbNomeProduto.Text = key.GetValue("SystemProductName")?.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving processor information: " + ex.Message);
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
