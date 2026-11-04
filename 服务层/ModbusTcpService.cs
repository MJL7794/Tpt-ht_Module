using System;
using System.Net.Sockets;
using NModbus;
using Tpt_ht_Module.实体层;
using Tpt_ht_Module.工具层; //  加上工具层引用

namespace Tpt_ht_Module.服务层
{
    public class ModbusTcpService
    {
        private TcpClient _tcpClient;
        private IModbusMaster _master;

        public bool Connect(string ip, int port)
        {
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.ReceiveTimeout = 1000;
                _tcpClient.SendTimeout = 1000;
                _tcpClient.Connect(ip, port);

                var factory = new ModbusFactory();
                _master = factory.CreateMaster(_tcpClient);

                LoggerHelper.WriteLog($"连接成功: {ip}:{port}"); // 记录日志
                return true;
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteLog($"网络连接失败: {ex.Message}"); //  记录错误日志
                throw new Exception("网络连接失败：" + ex.Message);
            }
        }

        public SensorData ReadData(byte slaveId)
        {
            try
            {
                ushort[] registers = _master.ReadHoldingRegisters(slaveId, 0, 2);
                return new SensorData
                {
                    Humidity = registers[0] / 10.0f,
                    Temperature = registers[1] / 10.0f
                };
            }
            catch (Exception ex)
            {
                LoggerHelper.WriteLog($"读取数据失败: {ex.Message}"); // 记录错误日志
                throw new Exception("读取数据失败：" + ex.Message);
            }
        }

        public void Disconnect()
        {
            _master?.Dispose();
            _tcpClient?.Close();
            _tcpClient?.Dispose();
            _master = null;
            _tcpClient = null;

            LoggerHelper.WriteLog("主动断开连接"); // 👈 记录日志
        }
    }
}