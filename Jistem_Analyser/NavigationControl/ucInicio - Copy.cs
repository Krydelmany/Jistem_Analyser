using System;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using HidSharp;
using Microsoft.Win32;
using SharpDX.Direct3D12;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucInicio : UserControl
    {
        public ucInicio()
        {
            InitializeComponent();
            GetInformacoesInicio();
            GetOSInfo();
            GetDirectXVersion();
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

        private void GetOSInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string osName = queryObj["Caption"].ToString();
                    string osVersion = queryObj["Version"].ToString();
                    tbOS.Text = $"{osName}";
                    tbBuild.Text = "Build: " + queryObj["BuildNumber"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving OS information: " + ex.Message);
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
                directXVersion = "Desconhecido";
            }

            // Definir a versão do DirectX na caixa de texto tbDirectX
            tbDirectX.Text = directXVersion;

            return directXVersion;
        }

    }
}
