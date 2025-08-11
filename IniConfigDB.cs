using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ControleGastos
{
    internal class IniFile
    {
        private string path;

        public IniFile(string iniPath)
        {
            path = iniPath;
        }


        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def,
            StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileSectionNames(byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public string Read(string section, string key)
        {
            var ret = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", ret, 255, path);
            return ret.ToString();
        }

        public string[] GetSections()
        {
            byte[] buffer = new byte[2048];
            int len = GetPrivateProfileSectionNames(buffer, (int)buffer.Length, path);
            string allSections = Encoding.UTF8.GetString(buffer, 0, (int)len);
            return allSections.Split('\0', StringSplitOptions.RemoveEmptyEntries);
        }

        public void DeleteSection(string section)
        {
            WritePrivateProfileString(section, null, null, this.path);
        }

        public List<string> ReadSections()
        {
            const int maxBuffer = 32767; // Tamanho máximo do buffer
            byte[] buffer = new byte[maxBuffer];

            int bytesReturned = GetPrivateProfileSectionNames(buffer, maxBuffer, this.path);

            List<string> sections = new List<string>();

            if (bytesReturned > 0)
            {
                int start = 0;
                for (int i = 0; i < bytesReturned; i++)
                {
                    if (buffer[i] == 0)
                    {
                        string section = Encoding.Default.GetString(buffer, start, i - start);
                        if (!string.IsNullOrWhiteSpace(section))
                            sections.Add(section);
                        start = i + 1;
                    }
                }
            }

            return sections;
        }
    }
}
