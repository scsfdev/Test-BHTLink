using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBHTLink
{
    public partial class frmMain : Form
    {
        // Declare the necessary BHT Link USB dll objects.
        BhtMtpLibrary.Transfer bhtMtp = new BhtMtpLibrary.Transfer();
        BhtMtpLibrary.Transfer.Device device = new BhtMtpLibrary.Transfer.Device();

        // Total Expected number of devices connected to the PC (at the same time).
        int expectedNoOfDevice = 1;

        // Return error int number from BHT Link USB dll.
        int returnErr = -1;

        // Return error message from BHT Link USB dll.
        string returnStrErr = "";

        // mbox title.
        string title = "BHT Link USB Server DLL Tester";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Assign the access code for BHT Link USB Server dll.
            bhtMtp.AccessKey = Properties.Settings.Default.AccessCode;

            // Load device.
            LoadDevice();
        }

        private void LoadDevice()
        {
            // Reset icon and SN.
            pic.Image = Properties.Resources.gray;
            txtSN.Text = "";

            // Expected Device.
            int expectedDevice = 1;

            // Clear data.
            returnErr = -1;
            returnStrErr = "";

            BhtMtpLibrary.Transfer.Device[] devices = new BhtMtpLibrary.Transfer.Device[expectedNoOfDevice];
            bool bOk = bhtMtp.GetDevices(devices, ref expectedDevice, ref returnErr, ref returnStrErr);

            if (bOk)
            {
                if (!string.IsNullOrEmpty(returnStrErr))
                {
                    MessageBox.Show("Fail to get devices." + Environment.NewLine + "Error: " + returnStrErr, title,
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                foreach (BhtMtpLibrary.Transfer.Device device in (devices as BhtMtpLibrary.Transfer.Device[]))
                {
                    if (device.Id != null || !string.IsNullOrEmpty(device.Id))
                    {
                        // Once  we successfully get the device info, we retrieve the SN and show on screen (just an example).
                        this.device = device;
                        txtSN.Text = device.SerialNo;
                    }
                }
            }
            else
                MessageBox.Show("Fail to load BHT Link USB dll." + Environment.NewLine + "Error: " + returnStrErr, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (device.Id != null)
                pic.Image = Properties.Resources.green;
            else
                pic.Image = Properties.Resources.gray;
        }
        
        private void btnRetry_Click(object sender, EventArgs e)
        {
            LoadDevice();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Clear data.
            returnErr = -1;
            returnStrErr = "";

            string deviceFile = Path.Combine(txtDeviceDir.Text, Path.GetFileName(txtSendFile.Text));

            bool bOk = bhtMtp.SendFile(device.Id, txtSendFile.Text, deviceFile, ref returnErr, ref returnStrErr);

            if(bOk)
            {
                if(string.IsNullOrEmpty(returnStrErr))
                    MessageBox.Show("Successfully push out the master file.", title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Fail to send file to device." + Environment.NewLine + "Error: " + returnStrErr, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(returnErr == 705)
                    MessageBox.Show("Please change device connectivity to 'File Transfer'." + Environment.NewLine +
                                    "And make sure device location and file name are correct.", title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Fail to load BHT Link USB dll." + Environment.NewLine + "Error: " + returnStrErr, title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            // Clear data.
            returnErr = -1;
            returnStrErr = "";

            string deviceFile = Path.Combine(txtDeviceDir.Text, Path.GetFileName(txtReceiveFile.Text));

            bool bOk = bhtMtp.ReceiveFile(device.Id, deviceFile,txtReceiveFile.Text, ref returnErr, ref returnStrErr);

            if (bOk)
            {
                if (string.IsNullOrEmpty(returnStrErr))
                    MessageBox.Show("Successfully received file from device.", title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Fail to receive file from device." + Environment.NewLine + "Error: " + returnStrErr, title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (returnErr == 705)
                    MessageBox.Show("Please change device connectivity to 'File Transfer'." + Environment.NewLine +
                                    "And make sure device location and file name are correct.", title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Fail to load BHT Link USB dll." + Environment.NewLine + "Error: " + returnStrErr, title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
