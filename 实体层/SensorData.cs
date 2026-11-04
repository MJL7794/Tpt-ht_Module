using System;
using System.Collections.Generic;
using System.Text;

namespace Tpt_ht_Module.实体层
{
    // 这个类用来装温度和湿度数据
    public class SensorData
    {
        // 温度 (单位：℃)
        public float Temperature { get; set; }

        // 湿度 (单位：%RH)
        public float Humidity { get; set; }
    }
}