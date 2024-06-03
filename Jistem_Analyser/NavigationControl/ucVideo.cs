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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucVideo : UserControl
    {
        public ucVideo()
        {
            InitializeComponent();
            PopulateVideoControllers();
            UpdateGPUInfo();
            GetManufacturer();
            cbPlacaVideo.SelectedIndexChanged += comboBoxVideoControllers_SelectedIndexChanged;

            this.gbGPU.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
            this.gbMonitor.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
        }

        private void PopulateVideoControllers()
        {
            try
            {
                // Limpa os itens existentes do ComboBox
                cbPlacaVideo.Items.Clear();

                // Consulta para obter todas as placas de vídeo
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    foreach (ManagementObject item in searcher.Get())
                    {
                        string name = item["Name"]?.ToString();
                        string description = item["Description"]?.ToString();
                        string adapterRAM = item["AdapterRAM"] != null ? (Convert.ToUInt64(item["AdapterRAM"]) / (1024 * 1024)).ToString() + " MB" : "Unknown";
                        string videoprocessor = item["VideoProcessor"]?.ToString();

                        // Adiciona o item ao ComboBox com o ManagementObject associado
                        cbPlacaVideo.Items.Add(new ComboBoxItem { Name = name, ManagementObject = item });
                    }
                }

                // Define o primeiro item como selecionado por padrão, se houver itens no ComboBox
                if (cbPlacaVideo.Items.Count > 0)
                {
                    cbPlacaVideo.SelectedIndex = 0;
                    // Carrega as informações da primeira placa de vídeo
                    UpdateTextBoxes((ManagementObject)((ComboBoxItem)cbPlacaVideo.SelectedItem).ManagementObject);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("Erro ao recuperar informações das placas de vídeo: " + ex.Message);
            }
        }

        string GetManufacturer()
        {
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        tbFabricante.Text = queryObj["Manufacturer"].ToString(); 
                    }
                }
            }
            catch (Exception)
            {
            }
            return "Desconhecido";
        }

        private void comboBoxVideoControllers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlacaVideo.SelectedItem is ComboBoxItem selectedItem)
            {
                UpdateTextBoxes(selectedItem.ManagementObject);
            }
        }

        private void UpdateTextBoxes(ManagementObject videoController)
        {
            try
            {
                // Limpa os TextBoxes
                tbAdapterRAM.Clear();
                tbDriverVersion.Clear();
                tbDriverDate.Clear();
                tbVideoProcessor.Clear();
                tbBoardManufacturer.Clear(); // Adicionado


                // Atualiza os TextBoxes com as informações da placa de vídeo selecionada
                tbAdapterRAM.Text = videoController["AdapterRAM"] != null ? (Convert.ToUInt64(videoController["AdapterRAM"]) / (1024 * 1024)).ToString() + " MB" : "Unknown";
                tbDriverVersion.Text = videoController["DriverVersion"]?.ToString();
                tbDriverDate.Text = videoController["DriverDate"]?.ToString();
                tbVideoProcessor.Text = videoController["VideoProcessor"]?.ToString();
                tbBoardManufacturer.Text = videoController["AdapterCompatibility"]?.ToString(); // Supondo que Board Manufacturer seja AdapterCompatibility

                string manufacturer = videoController["Name"]?.ToString().ToLower();
                if (manufacturer.Contains("nvidia"))
                {
                    pbNVIDIA.Visible = true;
                    pbAMD.Visible = false;
                }
                else if (manufacturer.Contains("amd"))
                {
                    pbNVIDIA.Visible = false;
                    pbAMD.Visible = true;
                }
                else
                {
                    pbNVIDIA.Visible = false;
                    pbAMD.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar informações da placa de vídeo: " + ex.Message);
            }
        }

        public class ComboBoxItem
        {
            public string Name { get; set; }
            public ManagementObject ManagementObject { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void UpdateGPUInfo()
        {
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher($"SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher1.Get())
            {
                tbAvailability.Text = $"{queryObj["Availability"]}";

                if (queryObj["CurrentRefreshRate"] != null)
                {
                    tbHz.Text = $"{queryObj["CurrentRefreshRate"]} Hz"; ;
                }
                if (queryObj["CurrentHorizontalResolution"] != null)
                {
                    tbResolution.Text = $"{queryObj["CurrentHorizontalResolution"]}x";
                    tbResolution.Text += $"{queryObj["CurrentVerticalResolution"]}";
                }

                string archv = $"{queryObj["VideoArchitecture"]}";
                uint arVideoSwitch = Convert.ToUInt16(archv);

                switch (arVideoSwitch)
                {

                    case 1:
                        tbArVideo.Text = "Outros";
                        break;
                    case 2:
                        tbArVideo.Text = "Desconhecido";
                        break;
                    case 3:
                        tbArVideo.Text = "CGA";
                        break;
                    case 4:
                        tbArVideo.Text = "EGA";
                        break;
                    case 5:
                        tbArVideo.Text = "VGA";
                        break;
                    case 6:
                        tbArVideo.Text = "SVGA";
                        break;
                    case 7:
                        tbArVideo.Text = "MDA";
                        break;
                    case 8:
                        tbArVideo.Text = "HGC";
                        break;
                    case 9:
                        tbArVideo.Text = "MCGA";
                        break;
                    case 10:
                        tbArVideo.Text = "8514A";
                        break;
                    case 11:
                        tbArVideo.Text = "XGA";
                        break;
                    case 12:
                        tbArVideo.Text = "Buffer de Quadro Linear";
                        break;
                    case 160:
                        tbArVideo.Text = "PC-98";
                        break;
                    default:
                        tbArVideo.Text = "Indisponível";
                        break;
                }


                string Tipo = $"{queryObj["Availability"]}";
                uint avSwitch = Convert.ToUInt16(Tipo);

                switch (avSwitch)
                {

                    case 1:
                        tbAvailability.Text = "Outros";
                        break;
                    case 2:
                        tbAvailability.Text = "Desconhecido";
                        break;
                    case 3:
                        tbAvailability.Text = "Energia completa/Em execução";
                        break;
                    case 4:
                        tbAvailability.Text = "Aviso";
                        break;
                    case 5:
                        tbAvailability.Text = "Em Teste";
                        break;
                    case 6:
                        tbAvailability.Text = "Não Aplicável";
                        break;
                    case 7:
                        tbAvailability.Text = "Desligado";
                        break;
                    case 8:
                        tbAvailability.Text = "Offline";
                        break;
                    case 9:
                        tbAvailability.Text = "Desativado";
                        break;
                    case 10:
                        tbAvailability.Text = "Degradado";
                        break;
                    case 11:
                        tbAvailability.Text = "Não Instalado";
                        break;
                    case 12:
                        tbAvailability.Text = "Erro de Instalação";
                        break;
                    case 13:
                        tbAvailability.Text = "Economia de Energia / Desconhecido";
                        break;
                    default:
                        tbAvailability.Text = "Indisponível";
                        break;
                }
            }
        }

        private void gbDesignGB_Paint(object sender, PaintEventArgs e)
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
