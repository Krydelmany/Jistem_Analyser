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
    public partial class ucPlacaMae : UserControl
    {
        public ucPlacaMae()
        {
            InitializeComponent();
            GetMotherboardInfo();
        }

        private void GetMotherboardInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    lblManufacturer.Text = "Manufacturer: " + queryObj["Manufacturer"].ToString();
                    lblProduct.Text = "Product: " + queryObj["Product"].ToString();
                    lblSerialNumber.Text = "Serial Number: " + queryObj["SerialNumber"].ToString();
                    lblVersion.Text = "Version: " + queryObj["Version"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        private void GetBIOSinfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    lblManufacturer.Text = "Manufacturer: " + queryObj["Manufacturer"].ToString();
                    lblProduct.Text = "Product: " + queryObj["Product"].ToString();
                    lblSerialNumber.Text = "Serial Number: " + queryObj["SerialNumber"].ToString();
                    lblVersion.Text = "Version: " + queryObj["Version"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }
    }
}
