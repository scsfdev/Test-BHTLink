namespace TestBHTLink
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendFile = new System.Windows.Forms.TextBox();
            this.lblSendFile = new System.Windows.Forms.Label();
            this.lblReceiveFile = new System.Windows.Forms.Label();
            this.txtReceiveFile = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtDeviceDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(705, 243);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 34);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendFile
            // 
            this.txtSendFile.Location = new System.Drawing.Point(221, 244);
            this.txtSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendFile.Name = "txtSendFile";
            this.txtSendFile.Size = new System.Drawing.Size(451, 27);
            this.txtSendFile.TabIndex = 1;
            this.txtSendFile.Text = "C:\\Test\\MyApp\\Master.csv";
            // 
            // lblSendFile
            // 
            this.lblSendFile.AutoSize = true;
            this.lblSendFile.Location = new System.Drawing.Point(92, 246);
            this.lblSendFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendFile.Name = "lblSendFile";
            this.lblSendFile.Size = new System.Drawing.Size(98, 19);
            this.lblSendFile.TabIndex = 2;
            this.lblSendFile.Text = "File to Send:";
            // 
            // lblReceiveFile
            // 
            this.lblReceiveFile.AutoSize = true;
            this.lblReceiveFile.Location = new System.Drawing.Point(67, 296);
            this.lblReceiveFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiveFile.Name = "lblReceiveFile";
            this.lblReceiveFile.Size = new System.Drawing.Size(116, 19);
            this.lblReceiveFile.TabIndex = 4;
            this.lblReceiveFile.Text = "File to Receive:";
            // 
            // txtReceiveFile
            // 
            this.txtReceiveFile.Location = new System.Drawing.Point(221, 294);
            this.txtReceiveFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiveFile.Name = "txtReceiveFile";
            this.txtReceiveFile.Size = new System.Drawing.Size(451, 27);
            this.txtReceiveFile.TabIndex = 3;
            this.txtReceiveFile.Text = "C:\\Test\\MyApp\\Receive.csv";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(705, 293);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(103, 34);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Device Status:";
            // 
            // pic
            // 
            this.pic.Image = global::TestBHTLink.Properties.Resources.gray;
            this.pic.Location = new System.Drawing.Point(221, 55);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(32, 32);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 8;
            this.pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Device SN:";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(221, 102);
            this.txtSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(451, 27);
            this.txtSN.TabIndex = 10;
            // 
            // txtDeviceDir
            // 
            this.txtDeviceDir.Location = new System.Drawing.Point(221, 155);
            this.txtDeviceDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeviceDir.Name = "txtDeviceDir";
            this.txtDeviceDir.ReadOnly = true;
            this.txtDeviceDir.Size = new System.Drawing.Size(451, 27);
            this.txtDeviceDir.TabIndex = 12;
            this.txtDeviceDir.Text = "Internal shared storage\\MyAppData";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Device Directory:";
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(282, 53);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(103, 34);
            this.btnRetry.TabIndex = 13;
            this.btnRetry.Text = "RETRY";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 383);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.txtDeviceDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceiveFile);
            this.Controls.Add(this.txtReceiveFile);
            this.Controls.Add(this.lblSendFile);
            this.Controls.Add(this.txtSendFile);
            this.Controls.Add(this.btnSend);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "BHT Link USB Server DLL Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendFile;
        private System.Windows.Forms.Label lblSendFile;
        private System.Windows.Forms.Label lblReceiveFile;
        private System.Windows.Forms.TextBox txtReceiveFile;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtDeviceDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetry;
    }
}

