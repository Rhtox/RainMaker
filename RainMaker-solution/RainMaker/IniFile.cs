using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace RainMaker {
	class IniFile {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        //------------------------------------------
        //          creates new .ini file           
        //------------------------------------------
        public IniFile(string IniPath = null) {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        //--------------------------------------
        //          writes to .ini file         
        //--------------------------------------
        public void Write(string Key, string Value, string Section = null) {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }
    }
}
