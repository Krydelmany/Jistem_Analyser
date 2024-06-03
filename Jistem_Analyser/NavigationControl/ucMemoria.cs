using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jistem_Analyser
{
    public partial class ucMemoria : UserControl
    {
        private Dictionary<string, ManagementObject> logicalToPhysicalMap;

        public ucMemoria()
        {
            InitializeComponent();
            logicalToPhysicalMap = new Dictionary<string, ManagementObject>(); // Inicializa o dicionário aqui
            InfosDisco(); // Chama InfosDisco após a inicialização do dicionário

            GetMemoryInfo();
            GetMemoryFrequency();
            DisplayDriveInfo();

            this.cbMemoriaAuxiliar.SelectedIndexChanged += new System.EventHandler(this.cbMemoriaAuxiliar_SelectedIndexChanged); // Assina o evento aqui

            this.gbMemoria.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
            this.gbMemoriaAuxiliar.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
        }

        private void DisplayDriveInfo()
        {
            listBox1.Items.Clear();

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    double totalSizeInGB = drive.TotalSize / (1024.0 * 1024.0 * 1024.0);
                    listBox1.Items.Add($"{drive.Name} - {totalSizeInGB:F2} GB");
                }
            }
        }

        private void GetMemoryInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

                ulong totalCapacity = 0;
                string memoryTypeString = string.Empty;
                int moduleCount = 0;
                int dataWidth = 0;

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    // Tipo da memória RAM (apenas uma vez, já que geralmente é o mesmo para todos os módulos)
                    if (string.IsNullOrEmpty(memoryTypeString))
                    {
                        ushort smbiosMemoryType = Convert.ToUInt16(queryObj["SMBIOSMemoryType"]);
                        memoryTypeString = GetMemoryType(smbiosMemoryType);
                    }

                    tbManufacturer.Text = queryObj["Manufacturer"]?.ToString();
                    tbSerialNumber.Text = queryObj["SerialNumber"]?.ToString();
                    tbFormFactor.Text = queryObj["FormFactor"]?.ToString();
                    tbMaxVoltage.Text = queryObj["MaxVoltage"]?.ToString();
                    tbMinVoltage.Text = queryObj["MinVoltage"]?.ToString();

                    // Tamanho da memória RAM (somando todos os módulos)
                    ulong capacity = Convert.ToUInt64(queryObj["Capacity"]);
                    totalCapacity += capacity;

                    // Contar os módulos de memória
                    moduleCount++;

                    // Largura de dados da memória
                    dataWidth = Convert.ToInt32(queryObj["DataWidth"]);
                }

                // Inferir o número de canais (muito simplificado, pois depende do controlador de memória)
                string memoryChannels = InferMemoryChannels(moduleCount, dataWidth);

                // Atualizando os TextBoxes com os dados coletados
                tbType.Text = memoryTypeString;
                tbSize.Text = (totalCapacity / (1024 * 1024 * 1024)).ToString() + " GBytes";
                tbChannels.Text = memoryChannels;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for memory data: " + ex.Message);
            }
        }

        private string GetMemoryType(ushort smbiosMemoryType)
        {
            switch (smbiosMemoryType)
            {
                case 20: return "DDR";
                case 21: return "DDR2";
                case 22: return "DDR2 FB-DIMM";
                case 24: return "DDR3";
                case 26: return "DDR4";
                case 27: return "DDR5";
                default: return "Unknown";
            }
        }

        private string InferMemoryChannels(int moduleCount, int dataWidth)
        {
            // Estimar os canais de memória baseado no número de módulos e a largura de dados
            return moduleCount + " x " + dataWidth + "-bit";
        }

        private void GetMemoryFrequency()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ulong speed = Convert.ToUInt64(queryObj["Speed"]);
                    tbFrequency.Text = speed.ToString() + " MHz";
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for memory frequency: " + e.Message);
            }
        }

        private void InfosDisco()
        {
            try
            {
                // Limpa os itens do ComboBox antes de adicionar novos itens
                cbMemoriaAuxiliar.Items.Clear();
                logicalToPhysicalMap.Clear();

                // Obter informações dos discos físicos
                ManagementObjectSearcher searcherPhysical = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject disk in searcherPhysical.Get())
                {
                    // Obter partições associadas
                    foreach (ManagementObject partition in disk.GetRelated("Win32_DiskPartition"))
                    {
                        // Obter discos lógicos associados
                        foreach (ManagementObject logical in partition.GetRelated("Win32_LogicalDisk"))
                        {
                            string driveName = logical["DeviceID"]?.ToString();
                            if (!string.IsNullOrEmpty(driveName))
                            {
                                cbMemoriaAuxiliar.Items.Add(driveName);
                                // Adiciona ao mapeamento apenas se ainda não estiver presente
                                if (!logicalToPhysicalMap.ContainsKey(driveName))
                                {
                                    logicalToPhysicalMap.Add(driveName, disk);
                                }
                            }
                        }
                    }
                }

                // Define o primeiro item como selecionado, se houver itens
                if (cbMemoriaAuxiliar.Items.Count > 0)
                {
                    cbMemoriaAuxiliar.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying disk information: " + ex.Message);
            }
        }



        private void cbMemoriaAuxiliar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaTB();
            if (cbMemoriaAuxiliar.SelectedItem != null)
            {
                try
                {
                    string selectedDrive = cbMemoriaAuxiliar.SelectedItem.ToString();

                    // Obter informações do disco lógico
                    ManagementObject logicalDisk = new ManagementObject($"Win32_LogicalDisk.DeviceID='{selectedDrive}'");
                    logicalDisk.Get();

                    // Preencher TextBoxes com informações do disco lógico
                    tbUnidade.Text = selectedDrive;
                    tbFormatacao.Text = logicalDisk["FileSystem"]?.ToString();
                    tbSerialM.Text = logicalDisk["VolumeSerialNumber"].ToString();

                    // Verifica se as informações de capacidade e espaço livre estão disponíveis
                    if (logicalDisk["Size"] != null)
                    {
                        ulong size = Convert.ToUInt64(logicalDisk["Size"]);
                        tbCapacidadeT.Text = $"{size / (1024 * 1024 * 1024)} GB";
                    }
                    if (logicalDisk["FreeSpace"] != null)
                    {
                        ulong freeSpace = Convert.ToUInt64(logicalDisk["FreeSpace"]);
                        tbEDisponivel.Text = $"{freeSpace / (1024 * 1024 * 1024)} GB";
                    }

                    // Obter o disco físico associado, se disponível
                    if (logicalToPhysicalMap.TryGetValue(selectedDrive, out ManagementObject physicalDisk))
                    {
                        tbBytesSetor.Text = physicalDisk["BytesPerSector"]?.ToString();
                        tbIdentificador.Text = physicalDisk["Name"]?.ToString();
                        tbFirmware.Text = physicalDisk["FirmwareRevision"]?.ToString();
                        tbInterface.Text = physicalDisk["InterfaceType"]?.ToString();
                        tbFabricante.Text = physicalDisk["Manufacturer"]?.ToString();
                        tbMidia.Text = physicalDisk["MediaType"]?.ToString();
                        tbSerial.Text = physicalDisk["SerialNumber"]?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while querying disk details: " + ex.Message);
                }
            }
        }



        private void LimpaTB()
        {
            tbBytesSetor.Clear();
            tbFormatacao.Clear();
            tbCapacidadeT.Clear();
            tbEDisponivel.Clear();
            tbUnidade.Clear();
            tbFabricante.Clear();
            tbFirmware.Clear();
            tbIdentificador.Clear();
            tbSerial.Clear();
            tbInterface.Clear();
            tbMidia.Clear();
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
