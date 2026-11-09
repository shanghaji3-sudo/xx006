namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTDisConnect = new System.Windows.Forms.Button();
            this.lbt8 = new System.Windows.Forms.Label();
            this.lbt7 = new System.Windows.Forms.Label();
            this.lbt6 = new System.Windows.Forms.Label();
            this.lbt5 = new System.Windows.Forms.Label();
            this.lbt4 = new System.Windows.Forms.Label();
            this.lbt3 = new System.Windows.Forms.Label();
            this.lbt2 = new System.Windows.Forms.Label();
            this.lbt1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStopbits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDatabits = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbr8 = new System.Windows.Forms.Label();
            this.lbr7 = new System.Windows.Forms.Label();
            this.lbr6 = new System.Windows.Forms.Label();
            this.lbr5 = new System.Windows.Forms.Label();
            this.lbr4 = new System.Windows.Forms.Label();
            this.lbr3 = new System.Windows.Forms.Label();
            this.lbr2 = new System.Windows.Forms.Label();
            this.lbr1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnRConnnect = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.btnRDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTConnect
            // 
            this.btnTConnect.Location = new System.Drawing.Point(26, 111);
            this.btnTConnect.Name = "btnTConnect";
            this.btnTConnect.Size = new System.Drawing.Size(75, 23);
            this.btnTConnect.TabIndex = 0;
            this.btnTConnect.Text = "连接";
            this.btnTConnect.UseVisualStyleBackColor = true;
            this.btnTConnect.Click += new System.EventHandler(this.BtnTConnnetc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ip";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(109, 28);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(151, 25);
            this.txtIp.TabIndex = 2;
            this.txtIp.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(109, 59);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(151, 25);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTDisConnect);
            this.groupBox1.Controls.Add(this.lbt8);
            this.groupBox1.Controls.Add(this.lbt7);
            this.groupBox1.Controls.Add(this.lbt6);
            this.groupBox1.Controls.Add(this.lbt5);
            this.groupBox1.Controls.Add(this.lbt4);
            this.groupBox1.Controls.Add(this.lbt3);
            this.groupBox1.Controls.Add(this.lbt2);
            this.groupBox1.Controls.Add(this.lbt1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTConnect);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ModbusTCP";
            // 
            // btnTDisConnect
            // 
            this.btnTDisConnect.Location = new System.Drawing.Point(118, 111);
            this.btnTDisConnect.Name = "btnTDisConnect";
            this.btnTDisConnect.Size = new System.Drawing.Size(75, 23);
            this.btnTDisConnect.TabIndex = 13;
            this.btnTDisConnect.Text = "断开";
            this.btnTDisConnect.UseVisualStyleBackColor = true;
            this.btnTDisConnect.Click += new System.EventHandler(this.BtnTDisConnnect_Click);
            // 
            // lbt8
            // 
            this.lbt8.AutoSize = true;
            this.lbt8.Location = new System.Drawing.Point(466, 67);
            this.lbt8.Name = "lbt8";
            this.lbt8.Size = new System.Drawing.Size(31, 15);
            this.lbt8.TabIndex = 12;
            this.lbt8.Text = "0.0";
            // 
            // lbt7
            // 
            this.lbt7.AutoSize = true;
            this.lbt7.Location = new System.Drawing.Point(406, 67);
            this.lbt7.Name = "lbt7";
            this.lbt7.Size = new System.Drawing.Size(31, 15);
            this.lbt7.TabIndex = 11;
            this.lbt7.Text = "0.0";
            // 
            // lbt6
            // 
            this.lbt6.AutoSize = true;
            this.lbt6.Location = new System.Drawing.Point(345, 67);
            this.lbt6.Name = "lbt6";
            this.lbt6.Size = new System.Drawing.Size(31, 15);
            this.lbt6.TabIndex = 10;
            this.lbt6.Text = "0.0";
            // 
            // lbt5
            // 
            this.lbt5.AutoSize = true;
            this.lbt5.Location = new System.Drawing.Point(289, 67);
            this.lbt5.Name = "lbt5";
            this.lbt5.Size = new System.Drawing.Size(31, 15);
            this.lbt5.TabIndex = 9;
            this.lbt5.Text = "0.0";
            // 
            // lbt4
            // 
            this.lbt4.AutoSize = true;
            this.lbt4.Location = new System.Drawing.Point(466, 33);
            this.lbt4.Name = "lbt4";
            this.lbt4.Size = new System.Drawing.Size(31, 15);
            this.lbt4.TabIndex = 8;
            this.lbt4.Text = "0.0";
            // 
            // lbt3
            // 
            this.lbt3.AutoSize = true;
            this.lbt3.Location = new System.Drawing.Point(406, 33);
            this.lbt3.Name = "lbt3";
            this.lbt3.Size = new System.Drawing.Size(31, 15);
            this.lbt3.TabIndex = 7;
            this.lbt3.Text = "0.0";
            // 
            // lbt2
            // 
            this.lbt2.AutoSize = true;
            this.lbt2.Location = new System.Drawing.Point(345, 33);
            this.lbt2.Name = "lbt2";
            this.lbt2.Size = new System.Drawing.Size(31, 15);
            this.lbt2.TabIndex = 6;
            this.lbt2.Text = "0.0";
            // 
            // lbt1
            // 
            this.lbt1.AutoSize = true;
            this.lbt1.Location = new System.Drawing.Point(289, 33);
            this.lbt1.Name = "lbt1";
            this.lbt1.Size = new System.Drawing.Size(31, 15);
            this.lbt1.TabIndex = 5;
            this.lbt1.Text = "0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRDisconnect);
            this.groupBox2.Controls.Add(this.cmbStopbits);
            this.groupBox2.Controls.Add(this.cmbParity);
            this.groupBox2.Controls.Add(this.cmbDatabits);
            this.groupBox2.Controls.Add(this.cmbBaudrate);
            this.groupBox2.Controls.Add(this.cmbPort);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lbr8);
            this.groupBox2.Controls.Add(this.lbr7);
            this.groupBox2.Controls.Add(this.lbr6);
            this.groupBox2.Controls.Add(this.lbr5);
            this.groupBox2.Controls.Add(this.lbr4);
            this.groupBox2.Controls.Add(this.lbr3);
            this.groupBox2.Controls.Add(this.lbr2);
            this.groupBox2.Controls.Add(this.lbr1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnRConnnect);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 280);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ModbusRTU";
            // 
            // cmbStopbits
            // 
            this.cmbStopbits.FormattingEnabled = true;
            this.cmbStopbits.Location = new System.Drawing.Point(109, 186);
            this.cmbStopbits.Name = "cmbStopbits";
            this.cmbStopbits.Size = new System.Drawing.Size(121, 23);
            this.cmbStopbits.TabIndex = 20;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(109, 150);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 23);
            this.cmbParity.TabIndex = 19;
            // 
            // cmbDatabits
            // 
            this.cmbDatabits.FormattingEnabled = true;
            this.cmbDatabits.Location = new System.Drawing.Point(109, 108);
            this.cmbDatabits.Name = "cmbDatabits";
            this.cmbDatabits.Size = new System.Drawing.Size(121, 23);
            this.cmbDatabits.TabIndex = 18;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Location = new System.Drawing.Point(109, 69);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(121, 23);
            this.cmbBaudrate.TabIndex = 17;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(109, 30);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 23);
            this.cmbPort.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 190);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 15);
            this.label23.TabIndex = 15;
            this.label23.Text = "停止位：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 15);
            this.label22.TabIndex = 14;
            this.label22.Text = "数据位：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 13;
            this.label21.Text = "校验位：";
            // 
            // lbr8
            // 
            this.lbr8.AutoSize = true;
            this.lbr8.Location = new System.Drawing.Point(466, 67);
            this.lbr8.Name = "lbr8";
            this.lbr8.Size = new System.Drawing.Size(31, 15);
            this.lbr8.TabIndex = 12;
            this.lbr8.Text = "0.0";
            // 
            // lbr7
            // 
            this.lbr7.AutoSize = true;
            this.lbr7.Location = new System.Drawing.Point(406, 67);
            this.lbr7.Name = "lbr7";
            this.lbr7.Size = new System.Drawing.Size(31, 15);
            this.lbr7.TabIndex = 11;
            this.lbr7.Text = "0.0";
            // 
            // lbr6
            // 
            this.lbr6.AutoSize = true;
            this.lbr6.Location = new System.Drawing.Point(345, 67);
            this.lbr6.Name = "lbr6";
            this.lbr6.Size = new System.Drawing.Size(31, 15);
            this.lbr6.TabIndex = 10;
            this.lbr6.Text = "0.0";
            // 
            // lbr5
            // 
            this.lbr5.AutoSize = true;
            this.lbr5.Location = new System.Drawing.Point(289, 67);
            this.lbr5.Name = "lbr5";
            this.lbr5.Size = new System.Drawing.Size(31, 15);
            this.lbr5.TabIndex = 9;
            this.lbr5.Text = "0.0";
            // 
            // lbr4
            // 
            this.lbr4.AutoSize = true;
            this.lbr4.Location = new System.Drawing.Point(466, 33);
            this.lbr4.Name = "lbr4";
            this.lbr4.Size = new System.Drawing.Size(31, 15);
            this.lbr4.TabIndex = 8;
            this.lbr4.Text = "0.0";
            // 
            // lbr3
            // 
            this.lbr3.AutoSize = true;
            this.lbr3.Location = new System.Drawing.Point(406, 33);
            this.lbr3.Name = "lbr3";
            this.lbr3.Size = new System.Drawing.Size(31, 15);
            this.lbr3.TabIndex = 7;
            this.lbr3.Text = "0.0";
            // 
            // lbr2
            // 
            this.lbr2.AutoSize = true;
            this.lbr2.Location = new System.Drawing.Point(345, 33);
            this.lbr2.Name = "lbr2";
            this.lbr2.Size = new System.Drawing.Size(31, 15);
            this.lbr2.TabIndex = 6;
            this.lbr2.Text = "0.0";
            // 
            // lbr1
            // 
            this.lbr1.AutoSize = true;
            this.lbr1.Location = new System.Drawing.Point(289, 33);
            this.lbr1.Name = "lbr1";
            this.lbr1.Size = new System.Drawing.Size(31, 15);
            this.lbr1.TabIndex = 5;
            this.lbr1.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "波特率：";
            // 
            // btnRConnnect
            // 
            this.btnRConnnect.Location = new System.Drawing.Point(26, 234);
            this.btnRConnnect.Name = "btnRConnnect";
            this.btnRConnnect.Size = new System.Drawing.Size(75, 23);
            this.btnRConnnect.TabIndex = 0;
            this.btnRConnnect.Text = "连接";
            this.btnRConnnect.UseVisualStyleBackColor = true;
            this.btnRConnnect.Click += new System.EventHandler(this.btnRConnnect_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "串口号:";
            // 
            // txtlog
            // 
            this.txtlog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlog.Enabled = false;
            this.txtlog.Location = new System.Drawing.Point(532, 22);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.Size = new System.Drawing.Size(201, 447);
            this.txtlog.TabIndex = 14;
            // 
            // btnRDisconnect
            // 
            this.btnRDisconnect.Location = new System.Drawing.Point(118, 234);
            this.btnRDisconnect.Name = "btnRDisconnect";
            this.btnRDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnRDisconnect.TabIndex = 14;
            this.btnRDisconnect.Text = "断开";
            this.btnRDisconnect.UseVisualStyleBackColor = true;
            this.btnRDisconnect.Click += new System.EventHandler(this.btnRDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 505);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbt8;
        private System.Windows.Forms.Label lbt7;
        private System.Windows.Forms.Label lbt6;
        private System.Windows.Forms.Label lbt5;
        private System.Windows.Forms.Label lbt4;
        private System.Windows.Forms.Label lbt3;
        private System.Windows.Forms.Label lbt2;
        private System.Windows.Forms.Label lbt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbr8;
        private System.Windows.Forms.Label lbr7;
        private System.Windows.Forms.Label lbr6;
        private System.Windows.Forms.Label lbr5;
        private System.Windows.Forms.Label lbr4;
        private System.Windows.Forms.Label lbr3;
        private System.Windows.Forms.Label lbr2;
        private System.Windows.Forms.Label lbr1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnRConnnect;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbStopbits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDatabits;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Button btnTDisConnect;
        private System.Windows.Forms.Button btnRDisconnect;
    }
}

