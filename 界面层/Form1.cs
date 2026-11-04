using System;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;
using Tpt_ht_Module.实体层;  
using Tpt_ht_Module.服务层;  
using Tpt_ht_Module.工具层;
using System.IO;
namespace Tpt_ht_Module
{
    public partial class Form1 : Form
    {
        private ModbusTcpService _modbusService;
        private WinFormsTimer _timer; // 定时器
        private byte _currentSlaveId = 1; // 默认站地址
        private string configPath = Path.Combine(Application.StartupPath, "config.ini");
        public Form1()
        {
            InitializeComponent();
            LoadConfig();

            _modbusService = new ModbusTcpService();

            // 初始化定时器（每 1 秒执行一次）
            _timer = new WinFormsTimer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick; // 绑定事件

            // 初始化界面默认值
            txt_Port.Text = "502";
            cmb_SlaveId.Items.Add("1");
            cmb_SlaveId.SelectedIndex = 0;

            // 设置仪表盘最大值（温度一般不会超过100，设成100好看）
            meter_Temp.MaxValue = 100;
            meter_Temp.MinValue = 0;
            meter_Hum.MaxValue = 100;
            meter_Hum.MinValue = 0;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txt_IPAddress.Text.Trim();
                int port = int.Parse(txt_Port.Text.Trim());
                _currentSlaveId = byte.Parse(cmb_SlaveId.Text);

                // 1. 连接设备
                _modbusService.Connect(ip, port);

                // 2. 启动定时器，开始轮询
                _timer.Start();

                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;

                lbl_TempStatus.Text = "连接成功，正在读取...";
                lbl_HumStatus.Text = "连接成功，正在读取...";
                LoggerHelper.WriteLog("用户点击了【开始连接】按钮");
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteLog("连接异常: " + ex.Message);
                MessageBox.Show(ex.Message, "连接错误");
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            StopConnection();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // 1. 去底层读数据
                SensorData data = _modbusService.ReadData(_currentSlaveId);

                // 2. 更新界面文本框
                txt_TempValue.Text = data.Temperature.ToString("F1");
                txt_HumValue.Text = data.Humidity.ToString("F1");

                // 3. 让仪表盘指针动起来
                meter_Temp.Value = (float)data.Temperature;
                meter_Hum.Value = (float)data.Humidity;

                // 4. 判断报警状态
                CheckAlarm(data);
            }
            catch (Exception ex)
            {
                // 如果读取失败（比如网线断了），断开连接并提示
                LoggerHelper.WriteLog("定时器通信异常: " + ex.Message);
                MessageBox.Show("通信异常，已断开：" + ex.Message, "错误");
                StopConnection();
            }
        }

        private void CheckAlarm(SensorData data)
        {
            // 温度判断
            if (data.Temperature > (float)num_TempHigh.Value)
            {
                lbl_TempStatus.Text = "温度过高报警！";
                lbl_TempStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (data.Temperature < (float)num_TempLow.Value)
            {
                lbl_TempStatus.Text = "温度过低报警！";
                lbl_TempStatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_TempStatus.Text = "温度正常";
                lbl_TempStatus.ForeColor = System.Drawing.Color.Green;
            }

            // 湿度判断
            if (data.Humidity > (float)num_HumHigh.Value)
            {
                lbl_HumStatus.Text = "湿度过高报警！";
                lbl_HumStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (data.Humidity < (float)num_HumLow.Value)
            {
                lbl_HumStatus.Text = "湿度过低报警！";
                lbl_HumStatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_HumStatus.Text = "湿度正常";
                lbl_HumStatus.ForeColor = System.Drawing.Color.Green;
            }
        }
        private void StopConnection()
        {
            _timer.Stop();
            _modbusService.Disconnect();

            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;

            lbl_TempStatus.Text = "等待数据传入";
            lbl_HumStatus.Text = "等待数据传入";
            lbl_TempStatus.ForeColor = System.Drawing.Color.Black;
            lbl_HumStatus.ForeColor = System.Drawing.Color.Black;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopConnection();
        }
        private void LoadConfig()
        {
            // 如果文件不存在，就使用默认值（不影响程序运行）
            if (!File.Exists(configPath)) return;

            // 读取并填入界面控件
            // 1. 读取 IP 和端口
            txt_IPAddress.Text = IniConfigHelper.ReadIniData("Network", "IP", "192.168.0.7", configPath);
            txt_Port.Text = IniConfigHelper.ReadIniData("Network", "Port", "502", configPath);

            // 2. 读取报警阈值（读取出来是字符串，需要转成 Decimal 给 NumericUpDown）
            num_TempHigh.Value = decimal.Parse(IniConfigHelper.ReadIniData("Alarm", "TempHigh", "50", configPath));
            num_TempLow.Value = decimal.Parse(IniConfigHelper.ReadIniData("Alarm", "TempLow", "0", configPath));
            num_HumHigh.Value = decimal.Parse(IniConfigHelper.ReadIniData("Alarm", "HumHigh", "50", configPath));
            num_HumLow.Value = decimal.Parse(IniConfigHelper.ReadIniData("Alarm", "HumLow", "0", configPath));
        }
        private void SaveConfig()
        {
            // 把界面上的值写进 ini 文件里
            IniConfigHelper.WriteIniData("Network", "IP", txt_IPAddress.Text.Trim(), configPath);
            IniConfigHelper.WriteIniData("Network", "Port", txt_Port.Text.Trim(), configPath);

            // 把 NumericUpDown 的值转成字符串写进去
            IniConfigHelper.WriteIniData("Alarm", "TempHigh", num_TempHigh.Value.ToString(), configPath);
            IniConfigHelper.WriteIniData("Alarm", "TempLow", num_TempLow.Value.ToString(), configPath);
            IniConfigHelper.WriteIniData("Alarm", "HumHigh", num_HumHigh.Value.ToString(), configPath);
            IniConfigHelper.WriteIniData("Alarm", "HumLow", num_HumLow.Value.ToString(), configPath);

            LoggerHelper.WriteLog("配置参数已保存。");
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            StopConnection();

            // 退出前保存配置
            SaveConfig();
        }
    }
}
