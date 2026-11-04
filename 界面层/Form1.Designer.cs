namespace Tpt_ht_Module
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmb_SlaveId = new ComboBox();
            groupBox1 = new GroupBox();
            txt_Port = new TextBox();
            txt_IPAddress = new TextBox();
            btn_Disconnect = new Button();
            btn_Connect = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            num_HumLow = new NumericUpDown();
            num_HumHigh = new NumericUpDown();
            num_TempLow = new NumericUpDown();
            num_TempHigh = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_TempValue = new TextBox();
            txt_HumValue = new TextBox();
            label9 = new Label();
            label10 = new Label();
            lbl_TempStatus = new Label();
            lbl_HumStatus = new Label();
            meter_Hum = new Sunny.UI.UIMeter();
            meter_Temp = new Sunny.UI.UIMeter();
            Timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_HumLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_HumHigh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_TempLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_TempHigh).BeginInit();
            SuspendLayout();
            // 
            // cmb_SlaveId
            // 
            cmb_SlaveId.FormattingEnabled = true;
            cmb_SlaveId.Location = new Point(142, 169);
            cmb_SlaveId.Name = "cmb_SlaveId";
            cmb_SlaveId.Size = new Size(182, 32);
            cmb_SlaveId.TabIndex = 4;
            cmb_SlaveId.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Port);
            groupBox1.Controls.Add(txt_IPAddress);
            groupBox1.Controls.Add(btn_Disconnect);
            groupBox1.Controls.Add(btn_Connect);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(num_HumLow);
            groupBox1.Controls.Add(num_HumHigh);
            groupBox1.Controls.Add(num_TempLow);
            groupBox1.Controls.Add(num_TempHigh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmb_SlaveId);
            groupBox1.Location = new Point(520, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 658);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "参数设置";
            // 
            // txt_Port
            // 
            txt_Port.Location = new Point(142, 58);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(182, 30);
            txt_Port.TabIndex = 20;
            // 
            // txt_IPAddress
            // 
            txt_IPAddress.Location = new Point(449, 58);
            txt_IPAddress.Name = "txt_IPAddress";
            txt_IPAddress.Size = new Size(180, 30);
            txt_IPAddress.TabIndex = 19;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Location = new Point(358, 443);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(138, 79);
            btn_Disconnect.TabIndex = 18;
            btn_Disconnect.Text = "断开连接";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(121, 443);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(135, 79);
            btn_Connect.TabIndex = 17;
            btn_Connect.Text = "开始连接";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 357);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 16;
            label8.Text = "湿度高低：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 351);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 15;
            label7.Text = "湿度高限：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 267);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 14;
            label6.Text = "温度低限：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 265);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 13;
            label5.Text = "温度高限：";
            // 
            // num_HumLow
            // 
            num_HumLow.Location = new Point(449, 349);
            num_HumLow.Name = "num_HumLow";
            num_HumLow.Size = new Size(180, 30);
            num_HumLow.TabIndex = 12;
            // 
            // num_HumHigh
            // 
            num_HumHigh.Location = new Point(142, 351);
            num_HumHigh.Name = "num_HumHigh";
            num_HumHigh.Size = new Size(180, 30);
            num_HumHigh.TabIndex = 11;
            // 
            // num_TempLow
            // 
            num_TempLow.Location = new Point(449, 265);
            num_TempLow.Name = "num_TempLow";
            num_TempLow.Size = new Size(180, 30);
            num_TempLow.TabIndex = 10;
            // 
            // num_TempHigh
            // 
            num_TempHigh.Location = new Point(142, 265);
            num_TempHigh.Name = "num_TempHigh";
            num_TempHigh.Size = new Size(180, 30);
            num_TempHigh.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 64);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 8;
            label4.Text = "ip地址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 175);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 7;
            label3.Text = "站地址：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 5;
            label1.Text = "端口：";
            // 
            // txt_TempValue
            // 
            txt_TempValue.Location = new Point(158, 348);
            txt_TempValue.Name = "txt_TempValue";
            txt_TempValue.Size = new Size(150, 30);
            txt_TempValue.TabIndex = 6;
            // 
            // txt_HumValue
            // 
            txt_HumValue.Location = new Point(148, 694);
            txt_HumValue.Name = "txt_HumValue";
            txt_HumValue.Size = new Size(150, 30);
            txt_HumValue.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 348);
            label9.Name = "label9";
            label9.Size = new Size(90, 24);
            label9.TabIndex = 8;
            label9.Text = "温度/℃：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 694);
            label10.Name = "label10";
            label10.Size = new Size(88, 24);
            label10.TabIndex = 9;
            label10.Text = "湿度/%：";
            // 
            // lbl_TempStatus
            // 
            lbl_TempStatus.AutoSize = true;
            lbl_TempStatus.Location = new Point(339, 354);
            lbl_TempStatus.Name = "lbl_TempStatus";
            lbl_TempStatus.Size = new Size(118, 24);
            lbl_TempStatus.TabIndex = 10;
            lbl_TempStatus.Text = "等待数据传入";
            // 
            // lbl_HumStatus
            // 
            lbl_HumStatus.AutoSize = true;
            lbl_HumStatus.Location = new Point(339, 697);
            lbl_HumStatus.Name = "lbl_HumStatus";
            lbl_HumStatus.Size = new Size(118, 24);
            lbl_HumStatus.TabIndex = 11;
            lbl_HumStatus.Text = "等待数据传入";
            // 
            // meter_Hum
            // 
            meter_Hum.ArcColor = Color.FromArgb(80, 160, 255);
            meter_Hum.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            meter_Hum.Location = new Point(83, 400);
            meter_Hum.MaxValue = 100F;
            meter_Hum.MinimumSize = new Size(1, 1);
            meter_Hum.MinValue = 0F;
            meter_Hum.Name = "meter_Hum";
            meter_Hum.NeedleColor = Color.FromArgb(80, 160, 255);
            meter_Hum.RectSides = ToolStripStatusLabelBorderSides.None;
            meter_Hum.ScaleDecimalPlaces = 0;
            meter_Hum.ScaleFont = new Font("宋体", 10.5F);
            meter_Hum.Size = new Size(298, 267);
            meter_Hum.StartPos = new Point(32, 32);
            meter_Hum.TabIndex = 13;
            meter_Hum.Text = "meter_Hum";
            meter_Hum.TextAlignment = ContentAlignment.MiddleCenter;
            meter_Hum.Unit = "";
            meter_Hum.Value = 0F;
            meter_Hum.ValueOffset = new Point(0, 0);
            // 
            // meter_Temp
            // 
            meter_Temp.ArcColor = Color.FromArgb(80, 160, 255);
            meter_Temp.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            meter_Temp.Location = new Point(95, 50);
            meter_Temp.MaxValue = 100F;
            meter_Temp.MinimumSize = new Size(1, 1);
            meter_Temp.MinValue = 0F;
            meter_Temp.Name = "meter_Temp";
            meter_Temp.NeedleColor = Color.FromArgb(80, 160, 255);
            meter_Temp.RectSides = ToolStripStatusLabelBorderSides.None;
            meter_Temp.ScaleDecimalPlaces = 0;
            meter_Temp.ScaleFont = new Font("宋体", 10.5F);
            meter_Temp.Size = new Size(298, 267);
            meter_Temp.StartPos = new Point(32, 32);
            meter_Temp.TabIndex = 14;
            meter_Temp.Text = "meter_Temp";
            meter_Temp.TextAlignment = ContentAlignment.MiddleCenter;
            meter_Temp.Unit = "";
            meter_Temp.Value = 0F;
            meter_Temp.ValueOffset = new Point(0, 0);
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 765);
            Controls.Add(meter_Temp);
            Controls.Add(meter_Hum);
            Controls.Add(lbl_HumStatus);
            Controls.Add(lbl_TempStatus);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_HumValue);
            Controls.Add(txt_TempValue);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "温湿度监控系统";
            FormClosing += Form1_FormClosing_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_HumLow).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_HumHigh).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_TempLow).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_TempHigh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmb_SlaveId;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private NumericUpDown num_TempHigh;
        private Label label5;
        private NumericUpDown num_HumLow;
        private NumericUpDown num_HumHigh;
        private NumericUpDown num_TempLow;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btn_Disconnect;
        private Button btn_Connect;
        private TextBox txt_TempValue;
        private TextBox txt_HumValue;
        private Label label9;
        private Label label10;
        private Label lbl_TempStatus;
        private Label lbl_HumStatus;
        private Sunny.UI.UIMeter meter_Hum;
        private Sunny.UI.UIMeter meter_Temp;
        private TextBox txt_IPAddress;
        private TextBox txt_Port;
        private System.Windows.Forms.Timer Timer;
    }
}
