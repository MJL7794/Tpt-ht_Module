using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tpt_ht_Module.工具层
{
    public class LoggerHelper{
        // 日志文件存放路径（在程序运行目录下的 Logs 文件夹里）
        private static readonly string LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        public static void WriteLog(string message)
        {
            try
            {
                // 如果文件夹不存在，则创建
                if (!Directory.Exists(LogPath))
                {
                    Directory.CreateDirectory(LogPath);
                }

                // 每天生成一个日志文件，例如：2023-10-25.txt
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                string fullPath = Path.Combine(LogPath, fileName);

                // 拼接日志内容：时间 + 消息 + 换行
                string logContent = $"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}";

                // 追加写入文件
                File.AppendAllText(fullPath, logContent);
            }
            catch
            {
                // 日志写入失败就算了，不能因为写日志让程序崩溃
            }
        }





    }
}
