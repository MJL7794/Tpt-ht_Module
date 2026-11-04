using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Tpt_ht_Module.工具层;

namespace Tpt_ht_Module.工具层
{
    public class IniConfigHelper
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);//向 INI 文件中写入字符串。

        // 明确指定 Unicode
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);//向 INI 文件中读字符串。

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        private static extern uint GetPrivateProfileStringA(string section, string key, string def, byte[] retVal, uint size, string filePath); //读取字符串的 API，但指定了 CharSet = CharSet.Ansi，读取所有的节名（Sections）和所有的键名（Keys）
        public static List<string> ReadSections(string iniFilename)//读取 INI 文件中的所有节（Section）名称
        {
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileStringA(null, null, null, buf, (uint)buf.Length, iniFilename);
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (buf[i] == 0)
                {

                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }
            return result;
        }
        public static List<string> ReadKeys(string SectionName, string inifilename)//读取 INI 文件中指定节（Section）下的所有键（Key）名称。
        {
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileStringA(SectionName, null, null, buf, (uint)buf.Length, inifilename);
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (buf[i] == 0)
                {
                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }
            return result;


        }
        public static string ReadIniData(string Section, string Key, string DefaultValue, string iniFilePath)//读取指定节、指定键的值（读取具体的配置值）。
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, DefaultValue, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            return string.Empty;
        }
        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)//向 INI 文件写入数据
        {
            long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
            if (OpStation == 0)
            {
                return false;
            }
            return true;
        }


    }
}
