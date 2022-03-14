using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainMaker {
	public partial class HelpForm : Form {
		public HelpForm() {
			InitializeComponent();

			AppManagerClass.WriteLogEntry("NULL", "==========================================================", "NULL");

			try {
				switch(AppManagerClass.Theme) {
					//--------------------------
					//			dark			
					//--------------------------
					case "dark":
						// form
						this.BackColor = Color.FromArgb(40, 40, 40);

						// menu strip
						help_menuStrip.BackColor = Color.FromArgb(64, 64, 64);
						help_menuStrip.ForeColor = Color.White;
						// main menu
						wheresWhatToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						wheresWhatToolStripMenuItem.ForeColor = Color.White;
						workingWithSkinsAndTheirComponentsToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						workingWithSkinsAndTheirComponentsToolStripMenuItem.ForeColor = Color.White;
						// component setup
						launcherSetupToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						launcherSetupToolStripMenuItem.ForeColor = Color.White;
						hardwareSetupToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						hardwareSetupToolStripMenuItem.ForeColor = Color.White;
						// image editor
						wheresWhatToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						wheresWhatToolStripMenuItem1.ForeColor = Color.White;
						transformToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64); ;
						transformToolStripMenuItem.ForeColor = Color.White;
						opacityToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						opacityToolStripMenuItem.ForeColor = Color.White;
						rotateToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						rotateToolStripMenuItem.ForeColor = Color.White;
						// settings
						settingsToolStripMenuItem.ForeColor = Color.White;
						break;
					//--------------------------
					//			light			
					//--------------------------
					case "light":
						// form
						this.BackColor = Color.White;

						// menu strip
						help_menuStrip.BackColor = Color.White;
						help_menuStrip.ForeColor = Color.Black;
						// main menu
						wheresWhatToolStripMenuItem.BackColor = Color.White;
						wheresWhatToolStripMenuItem.ForeColor = Color.Black;
						workingWithSkinsAndTheirComponentsToolStripMenuItem.BackColor = Color.White;
						workingWithSkinsAndTheirComponentsToolStripMenuItem.ForeColor = Color.Black;
						// component setup
						launcherSetupToolStripMenuItem.BackColor = Color.White;
						launcherSetupToolStripMenuItem.ForeColor = Color.Black;
						hardwareSetupToolStripMenuItem.BackColor = Color.White;
						hardwareSetupToolStripMenuItem.ForeColor = Color.Black;
						// image editor
						wheresWhatToolStripMenuItem1.BackColor = Color.White;
						wheresWhatToolStripMenuItem1.ForeColor = Color.Black;
						transformToolStripMenuItem.BackColor = Color.White; ;
						transformToolStripMenuItem.ForeColor = Color.Black;
						opacityToolStripMenuItem.BackColor = Color.White;
						opacityToolStripMenuItem.ForeColor = Color.Black;
						rotateToolStripMenuItem.BackColor = Color.White;
						rotateToolStripMenuItem.ForeColor = Color.Black;
						// settings
						settingsToolStripMenuItem.ForeColor = Color.Black;
						break;
					default:
						AppManagerClass.ErrorMsg();
						break;
				}

				help_pictureBox.Image = Image.FromFile(@"resources\menu1.png");

				AppManagerClass.WriteLogEntry("Help", "Loading theme", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("Help", "Loading theme", "Failed");
			}	
		}

		private void wheresWhatToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\menu1.png");
		}

		private void workingWithSkinsAndTheirComponentsToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\menu2.png");
		}

		private void launcherSetupToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\setup1.png");
		}

		private void hardwareSetupToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\setup2.png");
		}

		private void wheresWhatToolStripMenuItem1_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\imgEdit1.png");
		}

		private void transformToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\imgEdit2.png");
		}

		private void opacityToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\imgEdit3.png");
		}

		private void rotateToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\imgEdit4.png");
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
			help_pictureBox.Image = Image.FromFile(@"resources\settings1.png");
		}
	}
}
