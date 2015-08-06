namespace ZebraPuma.NetIPConfig
{
    partial class MainForm
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblSubNet = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.mtxtIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSubNet = new System.Windows.Forms.MaskedTextBox();
            this.mtxtGateway = new System.Windows.Forms.MaskedTextBox();
            this.gIPInfo = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.pbWindows = new System.Windows.Forms.PictureBox();
            this.pbLinux = new System.Windows.Forms.PictureBox();
            this.pbMacOSX = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gIPInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMacOSX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(13, 13);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(570, 324);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.TabStop = false;
            this.txtInfo.WordWrap = false;
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIP.Location = new System.Drawing.Point(6, 18);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(95, 23);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IPv4 Address :";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubNet
            // 
            this.lblSubNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSubNet.Location = new System.Drawing.Point(6, 49);
            this.lblSubNet.Name = "lblSubNet";
            this.lblSubNet.Size = new System.Drawing.Size(95, 23);
            this.lblSubNet.TabIndex = 2;
            this.lblSubNet.Text = "Subnet Mask :";
            this.lblSubNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGateway
            // 
            this.lblGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblGateway.Location = new System.Drawing.Point(6, 80);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(95, 23);
            this.lblGateway.TabIndex = 4;
            this.lblGateway.Text = "Default Gateway :";
            this.lblGateway.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxtIPAddress
            // 
            this.mtxtIPAddress.BackColor = System.Drawing.Color.White;
            this.mtxtIPAddress.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtxtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxtIPAddress.Location = new System.Drawing.Point(104, 19);
            this.mtxtIPAddress.Mask = "##0.##0.##0.##0";
            this.mtxtIPAddress.Name = "mtxtIPAddress";
            this.mtxtIPAddress.PromptChar = ' ';
            this.mtxtIPAddress.ReadOnly = true;
            this.mtxtIPAddress.Size = new System.Drawing.Size(119, 20);
            this.mtxtIPAddress.TabIndex = 1;
            this.mtxtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtSubNet
            // 
            this.mtxtSubNet.BackColor = System.Drawing.Color.White;
            this.mtxtSubNet.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtxtSubNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxtSubNet.Location = new System.Drawing.Point(104, 50);
            this.mtxtSubNet.Mask = "##0.##0.##0.##0";
            this.mtxtSubNet.Name = "mtxtSubNet";
            this.mtxtSubNet.PromptChar = ' ';
            this.mtxtSubNet.ReadOnly = true;
            this.mtxtSubNet.Size = new System.Drawing.Size(119, 20);
            this.mtxtSubNet.TabIndex = 3;
            this.mtxtSubNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtGateway
            // 
            this.mtxtGateway.BackColor = System.Drawing.Color.White;
            this.mtxtGateway.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtxtGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtxtGateway.Location = new System.Drawing.Point(104, 81);
            this.mtxtGateway.Mask = "##0.##0.##0.##0";
            this.mtxtGateway.Name = "mtxtGateway";
            this.mtxtGateway.PromptChar = ' ';
            this.mtxtGateway.ReadOnly = true;
            this.mtxtGateway.Size = new System.Drawing.Size(119, 20);
            this.mtxtGateway.TabIndex = 5;
            this.mtxtGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gIPInfo
            // 
            this.gIPInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gIPInfo.Controls.Add(this.btRefresh);
            this.gIPInfo.Controls.Add(this.pbWindows);
            this.gIPInfo.Controls.Add(this.pbLinux);
            this.gIPInfo.Controls.Add(this.pbMacOSX);
            this.gIPInfo.Controls.Add(this.lblSubNet);
            this.gIPInfo.Controls.Add(this.mtxtGateway);
            this.gIPInfo.Controls.Add(this.lblIP);
            this.gIPInfo.Controls.Add(this.mtxtSubNet);
            this.gIPInfo.Controls.Add(this.lblGateway);
            this.gIPInfo.Controls.Add(this.mtxtIPAddress);
            this.gIPInfo.Location = new System.Drawing.Point(13, 12);
            this.gIPInfo.Name = "gIPInfo";
            this.gIPInfo.Size = new System.Drawing.Size(599, 111);
            this.gIPInfo.TabIndex = 1;
            this.gIPInfo.TabStop = false;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefresh.Location = new System.Drawing.Point(505, 18);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(85, 85);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Refresh IP";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // pbWindows
            // 
            this.pbWindows.Location = new System.Drawing.Point(414, 18);
            this.pbWindows.Name = "pbWindows";
            this.pbWindows.Size = new System.Drawing.Size(85, 85);
            this.pbWindows.TabIndex = 10;
            this.pbWindows.TabStop = false;
            // 
            // pbLinux
            // 
            this.pbLinux.Location = new System.Drawing.Point(323, 18);
            this.pbLinux.Name = "pbLinux";
            this.pbLinux.Size = new System.Drawing.Size(85, 85);
            this.pbLinux.TabIndex = 9;
            this.pbLinux.TabStop = false;
            // 
            // pbMacOSX
            // 
            this.pbMacOSX.Enabled = false;
            this.pbMacOSX.Location = new System.Drawing.Point(232, 18);
            this.pbMacOSX.Name = "pbMacOSX";
            this.pbMacOSX.Size = new System.Drawing.Size(85, 85);
            this.pbMacOSX.TabIndex = 8;
            this.pbMacOSX.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtInfo);
            this.panel1.Location = new System.Drawing.Point(13, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 354);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gIPInfo);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gIPInfo.ResumeLayout(false);
            this.gIPInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMacOSX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblSubNet;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.MaskedTextBox mtxtIPAddress;
        private System.Windows.Forms.MaskedTextBox mtxtSubNet;
        private System.Windows.Forms.MaskedTextBox mtxtGateway;
        private System.Windows.Forms.GroupBox gIPInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbWindows;
        private System.Windows.Forms.PictureBox pbLinux;
        private System.Windows.Forms.PictureBox pbMacOSX;
        private System.Windows.Forms.Button btRefresh;
    }
}

