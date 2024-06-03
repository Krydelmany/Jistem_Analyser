using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidSharp;
using Microsoft.Win32;
using SharpDX.Direct3D12;



namespace Jistem_Analyser.NavigationControl
{
    public partial class ucInicio : UserControl
    {

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        public ucInicio()
        {
            InitializeComponent();
            GetInformacoesInicio();
            GetOSInfo();
            GetUpdateVersion();
            GetDirectXVersion();
            GetNetworkInfo();
            GetWindowsVersionIMG();
            GetLastBootInfo();
            GetWindowsDetailedInfo();

            InitializePerformanceCounters();
            InitializeTextBoxes();
            InitializeToggleButton();


            uptimeTimer = new Timer();
            uptimeTimer.Interval = 1000; // Atualiza a cada 10 segundos
            uptimeTimer.Tick += new EventHandler(UpdateUptime);
            uptimeTimer.Start();


            this.gbInformacoes.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
            this.gbRede.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDesignGB_Paint);
        }

        private void GetInformacoesInicio()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbNomeMaquina.Text = queryObj["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }


        private void GetWindowsDetailedInfo()
        {
            try
            {
                // Obter informações do SO Windows
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    // Versão do SO
                    tbWindowsVersion.Text = queryObj["Version"].ToString();

                    // Data de instalação
                    DateTime installDate = ManagementDateTimeConverter.ToDateTime(queryObj["InstallDate"].ToString());
                    tbInstallDate.Text = installDate.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving Windows information: " + ex.Message);
            }
        }

        private string GetUpdateVersion()
        {
            try
            {
                string updateVersion = "";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("ReleaseId");
                        if (value != null)
                        {
                            updateVersion = value.ToString();
                        }
                    }
                }
                return updateVersion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving update version: " + ex.Message);
                return "Unknown";
            }
        }

        private void GetLastBootInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (var queryObj in searcher.Get())
            {
                DateTime lastBootUpTime = ManagementDateTimeConverter.ToDateTime(queryObj["LastBootUpTime"].ToString());
                tbLastBootUpTime.Text = lastBootUpTime.ToString("dd/MM/yyyy") + " às " + lastBootUpTime.ToString("HH:mm:ss");
            }
        }

        private void UpdateUptime(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        DateTime lastBootUpTime = ManagementDateTimeConverter.ToDateTime(queryObj["LastBootUpTime"].ToString());
                        TimeSpan uptime = DateTime.Now - lastBootUpTime;
                        string uptimeText = uptime.ToString(@"dd\.hh\:mm\:ss");

                        float cpuUsage = cpuCounter.NextValue();
                        float availableRam = ramCounter.NextValue();
                        float totalRam = GetTotalRamInMB();
                        float usedRam = totalRam - availableRam;

                        this.Invoke((Action)(() =>
                        {
                            pbConsumoCPU.Value = (int)cpuUsage;
                            pbConsumoRAM.Value = (int)((usedRam / totalRam) * 100);
                            lblCCPU.Text = Math.Round(cpuUsage).ToString() + "%";
                            lblCRAM.Text = Math.Round((usedRam / totalRam) * 100).ToString() + "%";
                            tbUptime.Text = uptimeText;
                        }));
                        break;
                    }
                });
            }
            catch (Exception ex)
            {
                // Log the exception or handle accordingly
                Console.WriteLine(ex.Message);
            }
        }

        float GetTotalRamInMB()
        {
            var computerInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            return computerInfo.TotalPhysicalMemory / (1024 * 1024);
        }

        void InitializePerformanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }
        private void GetOSInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string osName = queryObj["Caption"].ToString();
                    string osVersion = queryObj["Version"].ToString();
                    string osBootDevice = queryObj["SerialNumber"].ToString();
                    string osArquitetura = queryObj["OSArchitecture"]?.ToString();
                    string osManufacturer = queryObj["Manufacturer"]?.ToString();
                    string linguagemSO = CultureInfo.CurrentUICulture.DisplayName;
                    int productType = Convert.ToInt32(queryObj["ProductType"]);

                    uint numberOfUsers = (uint)(queryObj["NumberOfUsers"]);


                    tbQuantidadeUSR.Text = numberOfUsers.ToString();
                    string productTypeDesc = GetProductType(productType);


                    tbTipoProduto.Text = productTypeDesc;
                    tbIdiomaSO.Text = linguagemSO;
                    tbBootDevice.Text = osBootDevice;
                    tbOS.Text = $"{osName} ({osArquitetura})";
                    tbBuild.Text = "Build: " + queryObj["BuildNumber"].ToString();
                    tbFabricante.Text = osManufacturer;
                    break;
                }
            }
            catch (Exception)
            {
            }
        }

        private string GetProductType(int productType)
        {
            switch (productType)
            {
                case 1:
                    return "Workstation";
                case 2:
                    return "Domain Controller";
                case 3:
                    return "Server";
                default:
                    return "Outro";
            }
        }

        private void GetWindowsVersionIMG()
        {
            
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    // Converte o LastBootUpTime para DateTime
                    DateTime lastBootUpTime = ManagementDateTimeConverter.ToDateTime(queryObj["LastBootUpTime"].ToString());
                    TimeSpan uptime = DateTime.Now - lastBootUpTime;
                    // tbUptime.Text = uptime.ToString(@"dd\.hh\:mm\:ss");

                    string osName = queryObj["Caption"].ToString();
                    if (osName.Contains("Windows 10"))
                    {
                        pbWindows10.Visible = true; 
                        pbWindows11.Visible = false;
                        lblWindows11.Visible = false;
                        lblWindows10.Visible = true;
                    }
                    else if (osName.Contains("Windows 11"))
                    {
                        pbWindows11.Visible = true; 
                        pbWindows10.Visible = false;
                        lblWindows11.Visible = true;
                        lblWindows10.Visible = false;
                    }
                    else
                    {
                    pbWindows11.Visible = false;
                    pbWindows10.Visible = false;
                    lblWindows11.Visible = false;
                    lblWindows10.Visible = false;
                }
                    break;
            }
        }

        
        private string GetDirectXVersion()
        {
            string directXVersion = "Unknown";

            try
            {
                // Criação do dispositivo Direct3D 12
                using (var device = new SharpDX.Direct3D12.Device(null, SharpDX.Direct3D.FeatureLevel.Level_12_0))
                {
                    directXVersion = "DirectX 12";
                }
            }
            catch (Exception)
            {
                directXVersion = "Desconhecido/Outra Versão";
            }

            // Definir a versão do DirectX na caixa de texto tbDirectX
            tbDirectX.Text = directXVersion;

            return directXVersion;
        }

        private void GetNetworkInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    tbIPAddress.Text = ((string[])queryObj["IPAddress"])[0];
                    tbIPAddress2.Text = ((string[])queryObj["IPAddress"])[1];
                    tbMACAddress.Text = queryObj["MACAddress"].ToString();
                    tbNetworkName.Text = queryObj["Description"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving system information: " + ex.Message);
            }
        }


        // Rede Oculta
        private bool isPasswordHidden = true;
        private void InitializeTextBoxes()
        {
            // Configura os TextBoxes para exibir o texto como senha
            tbIPAddress.UseSystemPasswordChar = true;
            tbIPAddress2.UseSystemPasswordChar = true;
            tbMACAddress.UseSystemPasswordChar = true;
            tbNetworkName.UseSystemPasswordChar = true;
        }

        private void InitializeToggleButton()
        {
            // Adiciona o botão de alternância e o evento Click

            toggleButton.Click += ToggleButton_Click;
            
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade do texto nos TextBoxes
            isPasswordHidden = !isPasswordHidden;
            tbIPAddress.UseSystemPasswordChar = isPasswordHidden;
            tbIPAddress2.UseSystemPasswordChar = isPasswordHidden;
            tbMACAddress.UseSystemPasswordChar = isPasswordHidden;
            tbNetworkName.UseSystemPasswordChar = isPasswordHidden;

            Button toggleButton = sender as Button;
            if (toggleButton != null)
            {
                toggleButton.Text = isPasswordHidden ? "  Mostrar" : "  Ocultar";
            }
        }
    


        // Design GroupBox --------------------------------------------------------------------------------------------------------
        
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
