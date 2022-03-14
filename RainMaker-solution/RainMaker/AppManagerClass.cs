using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RainMaker {
	static class AppManagerClass {
		private static string theme = null;
		private static string exportPath = @"Export\";
		private static bool isSuccessful = false;
		private static readonly string settingsPath = "settings.xml";
		private static readonly string skinListPath = "skinList.xml";
		private static readonly string logPath = "log.txt";

		public static string Theme {
			get { return theme; }
			set { theme = value; }
		}

		public static string ExportPath {
			get { return exportPath; }
			set { exportPath = value; }
		}

		public static bool IsSuccessful {
			get { return isSuccessful; }
			set { isSuccessful = value; }
		}

		public static string SettingsPath {
			get { return settingsPath; }
		}

		public static string SkinListPath {
			get { return skinListPath; }
		}

		public static string LogPath {
			get { return logPath; }
		}

		// if you see this function somewhere then it's there just so something happens
		public static void ErrorMsg(string msg = "Unknown Error.") {
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// writes new line to log file
		public static void WriteLogEntry(string type, string msg, string result) {
			File.AppendAllText(logPath, "[" + type + "] " + msg + " [" + result + "]\n");
		}
	}
}
