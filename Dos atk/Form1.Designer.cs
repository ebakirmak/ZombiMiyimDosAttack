namespace Dos_atk
{
    partial class Form1
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
            this.urlTbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcpRadioBtn = new System.Windows.Forms.RadioButton();
            this.udpRadioBtn = new System.Windows.Forms.RadioButton();
            this.httpRadioBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.lenghtTbox = new System.Windows.Forms.TextBox();
            this.intervalTbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.portTbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.packet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.error = new System.Windows.Forms.ToolStripStatusLabel();
            this.udpPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlTbox
            // 
            this.urlTbox.Location = new System.Drawing.Point(9, 18);
            this.urlTbox.Name = "urlTbox";
            this.urlTbox.Size = new System.Drawing.Size(180, 20);
            this.urlTbox.TabIndex = 0;
            this.urlTbox.Text = "google.com";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.udpPort);
            this.groupBox1.Controls.Add(this.httpRadioBtn);
            this.groupBox1.Controls.Add(this.udpRadioBtn);
            this.groupBox1.Controls.Add(this.tcpRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // tcpRadioBtn
            // 
            this.tcpRadioBtn.AutoSize = true;
            this.tcpRadioBtn.Checked = true;
            this.tcpRadioBtn.Location = new System.Drawing.Point(7, 24);
            this.tcpRadioBtn.Name = "tcpRadioBtn";
            this.tcpRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.tcpRadioBtn.TabIndex = 0;
            this.tcpRadioBtn.Text = "TCP";
            this.tcpRadioBtn.UseVisualStyleBackColor = true;
            // 
            // udpRadioBtn
            // 
            this.udpRadioBtn.AutoSize = true;
            this.udpRadioBtn.Location = new System.Drawing.Point(7, 47);
            this.udpRadioBtn.Name = "udpRadioBtn";
            this.udpRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.udpRadioBtn.TabIndex = 1;
            this.udpRadioBtn.Text = "UDP";
            this.udpRadioBtn.UseVisualStyleBackColor = true;
            // 
            // httpRadioBtn
            // 
            this.httpRadioBtn.AutoSize = true;
            this.httpRadioBtn.Location = new System.Drawing.Point(7, 70);
            this.httpRadioBtn.Name = "httpRadioBtn";
            this.httpRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.httpRadioBtn.TabIndex = 2;
            this.httpRadioBtn.Text = "HTTP";
            this.httpRadioBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 160);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(260, 30);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // lenghtTbox
            // 
            this.lenghtTbox.Location = new System.Drawing.Point(6, 18);
            this.lenghtTbox.Name = "lenghtTbox";
            this.lenghtTbox.Size = new System.Drawing.Size(63, 20);
            this.lenghtTbox.TabIndex = 4;
            this.lenghtTbox.Text = "1024";
            // 
            // intervalTbox
            // 
            this.intervalTbox.Location = new System.Drawing.Point(6, 18);
            this.intervalTbox.Name = "intervalTbox";
            this.intervalTbox.Size = new System.Drawing.Size(63, 20);
            this.intervalTbox.TabIndex = 5;
            this.intervalTbox.Text = "100";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.intervalTbox);
            this.groupBox2.Location = new System.Drawing.Point(141, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interval";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lenghtTbox);
            this.groupBox3.Location = new System.Drawing.Point(141, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Packet Lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "byte";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.urlTbox);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 42);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "URL";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.portTbox);
            this.groupBox5.Location = new System.Drawing.Point(211, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(61, 42);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Port";
            // 
            // portTbox
            // 
            this.portTbox.Location = new System.Drawing.Point(8, 16);
            this.portTbox.Name = "portTbox";
            this.portTbox.Size = new System.Drawing.Size(47, 20);
            this.portTbox.TabIndex = 0;
            this.portTbox.Text = "80";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.packet,
            this.toolStripStatusLabel2,
            this.error});
            this.statusStrip1.Location = new System.Drawing.Point(0, 202);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Packet Sent:";
            // 
            // packet
            // 
            this.packet.Name = "packet";
            this.packet.Size = new System.Drawing.Size(13, 17);
            this.packet.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "Error:";
            // 
            // error
            // 
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(13, 17);
            this.error.Text = "0";
            // 
            // udpPort
            // 
            this.udpPort.Location = new System.Drawing.Point(93, 44);
            this.udpPort.Name = "udpPort";
            this.udpPort.Size = new System.Drawing.Size(24, 20);
            this.udpPort.TabIndex = 3;
            this.udpPort.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dos ATK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton httpRadioBtn;
        private System.Windows.Forms.RadioButton udpRadioBtn;
        private System.Windows.Forms.RadioButton tcpRadioBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox lenghtTbox;
        private System.Windows.Forms.TextBox intervalTbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox portTbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel packet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox udpPort;
    }
}

