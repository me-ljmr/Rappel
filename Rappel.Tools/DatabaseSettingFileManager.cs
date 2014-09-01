using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rappel.Tools
{
    public class DatabaseSettingFileManager
    {
        private const string filename = "Rappel.Conn.sys";
        private string _provider = "";
        private string _username = "";
        private string _pwd = "";
        private string _source = "";
        private string _exception = "";
        public string Provider
        {
            get
            {
                return _provider;
            }
        }
        public string DBUser
        {
            get
            {
                return _username;
            }
        }
        public string UserPassword
        {
            get
            {
                return _pwd;
            }
        }
        public string DataSource
        {
            get
            {
                return _source;
            }
        }
        public string Exception
        {
            get
            {
                return _exception;
            }
        }
        public bool IsDBSettingsFileExists()
        {
            return File.Exists(filename);
        }
        public void FetchData()
        {
            try
            {
                // 
                FileStream fs = new FileStream(filename, FileMode.Open,FileAccess.Read,FileShare.Read);
                BinaryReader br = new BinaryReader(fs);
                int pos = 0;
                // 2A.
                // Use BaseStream.
                int length = (int)br.BaseStream.Length;
                int line=0;
                string temp="";
                while (pos < length)
                {
                    line = line + 1;
                    switch (line)
                    {
                        case (1): _provider = (br.ReadString()); break;
                        case (2): _source = (br.ReadString()); break;
                        case (3): _username = (br.ReadString()); break;
                        case (4): _pwd = (br.ReadString()); break;
                        default: goto Skip;
                    }
                    pos += sizeof(int);
                }
    Skip:
                
                br = null;
                fs.Close();
                fs.Dispose();
                fs = null;
            }
            catch (Exception ex)
            {
                _exception = ex.Message;
            }
        }

        public void SaveData(string providername, string username, string password, string datasource)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write((providername));
                br.Write((datasource));
                br.Write((username));
                br.Write((password));
                br = null;
                fs.Close();
                fs.Dispose();
                fs = null;
            }
            catch (Exception ex)
            {
                _exception = ex.Message;
            }

        }
    }
}