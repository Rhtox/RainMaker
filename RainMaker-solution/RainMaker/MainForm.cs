using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace RainMaker {
	public partial class main_Form : Form {
		public main_Form() {
			InitializeComponent();

			AppManagerClass.WriteLogEntry("START", "==========================================================", "START");

			// deletes old log file
			try {
				if(File.Exists(AppManagerClass.LogPath) == true) {
					File.Delete(AppManagerClass.LogPath);
				}

				AppManagerClass.WriteLogEntry("System", "Removing old log file", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Removing old log file", "Failed");
			}

			// checks if settings file exists
			try {
				if(!File.Exists(AppManagerClass.SettingsPath)) {
					var xmlDoc = (new XElement("Settings",
							new XElement("Theme",
								new XAttribute("theme", "light")
								)
							)
						);
					// saves settings file
					xmlDoc.Save(AppManagerClass.SettingsPath);
				}

				AppManagerClass.WriteLogEntry("System", "Creating new settings file", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new settings file", "Failed");
			}

			// checks if skinList file exists
			try {
				if(!File.Exists(AppManagerClass.SkinListPath)) {
					var xmlDoc = (new XElement("RainMeter"));
					// saves skinList file
					xmlDoc.Save(AppManagerClass.SkinListPath);
				}

				AppManagerClass.WriteLogEntry("System", "Creating new skin list file", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new skin list file", "Failed");
			}
			
			// loads theme
			try {
				XmlDocument doc = new XmlDocument();
				doc.Load(AppManagerClass.SettingsPath);

				// gets theme
				AppManagerClass.Theme = doc.GetElementsByTagName("Theme")[0].Attributes["theme"].Value;

				// loads theme
				switch(AppManagerClass.Theme) {
					//--------------------------
					//			dark			
					//--------------------------
					case "dark":
						// form
						this.BackColor = Color.FromArgb(40, 40, 40);

						// skin treeview
						skin_treeView.BackColor = Color.FromArgb(64, 64, 64);
						skin_treeView.ForeColor = Color.White;

						// img edit button
						imgEdit_button.BackColor = Color.FromArgb(64, 64, 64);
						imgEdit_button.ForeColor = Color.White;
						imgEdit_button.FlatStyle = FlatStyle.Popup;

						// suite add contextstripmenu
						addToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						addToolStripMenuItem.ForeColor = Color.White;

						// suite control contextstripmenu
						addToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						addToolStripMenuItem1.ForeColor = Color.White;
						renameToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						renameToolStripMenuItem.ForeColor = Color.White;
						exportToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						exportToolStripMenuItem.ForeColor = Color.White;
						deleteToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						deleteToolStripMenuItem.ForeColor = Color.White;
						launcherToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						launcherToolStripMenuItem.ForeColor = Color.White;
						componentLoadToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						componentLoadToolStripMenuItem.ForeColor = Color.White;
						componentTempToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						componentTempToolStripMenuItem.ForeColor = Color.White;
						cPUToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						cPUToolStripMenuItem.ForeColor = Color.White;
						cPUToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						cPUToolStripMenuItem1.ForeColor = Color.White;
						gPUToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						gPUToolStripMenuItem.ForeColor = Color.White;
						gPUToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						gPUToolStripMenuItem1.ForeColor = Color.White;
						rAMToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						rAMToolStripMenuItem.ForeColor = Color.White;

						// skin control contextstripmenu
						editToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						editToolStripMenuItem.ForeColor = Color.White;
						deleteToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						deleteToolStripMenuItem1.ForeColor = Color.White;
						renameToolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
						renameToolStripMenuItem1.ForeColor = Color.White;
						break;
					//--------------------------
					//			light			
					//--------------------------
					case "light":
						// form
						this.BackColor = Color.White;

						// skin treeview
						skin_treeView.BackColor = Color.White;
						skin_treeView.ForeColor = Color.Black;

						// img edit button
						imgEdit_button.BackColor = Color.White;
						imgEdit_button.ForeColor = Color.Black;
						imgEdit_button.FlatStyle = FlatStyle.Standard;

						// skin add contextstripmenu
						addToolStripMenuItem.BackColor = Color.White;
						addToolStripMenuItem.ForeColor = Color.Black;

						// component add contextstripmenu
						addToolStripMenuItem1.BackColor = Color.White;
						addToolStripMenuItem1.ForeColor = Color.Black;
						renameToolStripMenuItem.BackColor = Color.White;
						renameToolStripMenuItem.ForeColor = Color.Black;
						exportToolStripMenuItem.BackColor = Color.White;
						exportToolStripMenuItem.ForeColor = Color.Black;
						deleteToolStripMenuItem.BackColor = Color.White;
						deleteToolStripMenuItem.ForeColor = Color.Black;
						launcherToolStripMenuItem.BackColor = Color.White;
						launcherToolStripMenuItem.ForeColor = Color.Black;
						componentLoadToolStripMenuItem.BackColor = Color.White;
						componentLoadToolStripMenuItem.ForeColor = Color.Black;
						componentTempToolStripMenuItem.BackColor = Color.White;
						componentTempToolStripMenuItem.ForeColor = Color.Black;
						cPUToolStripMenuItem.BackColor = Color.White;
						cPUToolStripMenuItem.ForeColor = Color.Black;
						cPUToolStripMenuItem1.BackColor = Color.White;
						cPUToolStripMenuItem1.ForeColor = Color.Black;
						gPUToolStripMenuItem.BackColor = Color.White;
						gPUToolStripMenuItem.ForeColor = Color.Black;
						gPUToolStripMenuItem1.BackColor = Color.White;
						gPUToolStripMenuItem1.ForeColor = Color.Black;
						rAMToolStripMenuItem.BackColor = Color.White;
						rAMToolStripMenuItem.ForeColor = Color.Black;

						// component control contextstripmenu
						editToolStripMenuItem.BackColor = Color.White;
						editToolStripMenuItem.ForeColor = Color.Black;
						deleteToolStripMenuItem1.BackColor = Color.White;
						deleteToolStripMenuItem1.ForeColor = Color.Black;
						renameToolStripMenuItem1.BackColor = Color.White;
						renameToolStripMenuItem1.ForeColor = Color.Black;
						break;
					default:
						AppManagerClass.ErrorMsg("Failed to load theme.");
						break;
				}

				AppManagerClass.WriteLogEntry("System", "Loading theme", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Loading theme", "Failed");
			}

			// loads tree view
			try {
				// treeview settings
				skin_treeView.ShowLines = false;
				skin_treeView.SelectedNode = null;
				skin_treeView.LabelEdit = true;
				skin_treeView.Scrollable = true;

				// clears treeview and begins update
				skin_treeView.Nodes.Clear();
				skin_treeView.BeginUpdate();

				// loops through xml file and gets node names
				for(int i = 0; i < SkinList.SuiteCount(); i++) {
					string[] nodeNames = SkinList.SuiteRead(i);
					TreeNode skinNode = new TreeNode(nodeNames[0]);
					skinNode.Tag = "suite";
					// adds skin node to treeview
					skin_treeView.Nodes.Add(skinNode);
					// add child nodes to skin
					for(int j = 1; j < nodeNames.Length; j++) {
						TreeNode componentNode = new TreeNode(nodeNames[j]);
						componentNode.Tag = "skin";
						skin_treeView.Nodes[i].Nodes.Add(componentNode);
					}
					// clears array
					Array.Clear(nodeNames, 0, nodeNames.Length);
				}
				// ends treeview update
				skin_treeView.EndUpdate();

				AppManagerClass.WriteLogEntry("System", "Setting TreeView", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Setting TreeView", "Failed");
			}
		}

		//------------------------------------------
		//			after selecting node			
		//------------------------------------------
		private void skin_treeView_AfterSelect(object sender, TreeViewEventArgs e) {
			try {
				SkinList.NodeType = Convert.ToString(skin_treeView.SelectedNode.Tag);
				// decides which level is selected
				switch(e.Node.Level) {
					// suite
					case 0:
						e.Node.ContextMenuStrip = node_contextMenuStrip;
						SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
						SkinList.SelectedNodeName = skin_treeView.SelectedNode.Text;

						preview_pictureBox.Image = null;
						break;
					// skin
					case 1:
						e.Node.ContextMenuStrip = childNode_contextMenuStrip;
						SkinList.SuiteIndex = skin_treeView.SelectedNode.Parent.Index;
						SkinList.SkinIndex = skin_treeView.SelectedNode.Index;
						SkinList.SelectedNodeName = skin_treeView.SelectedNode.Text;
						// gets skin settings
						SkinList.SkinRead();

						// loads preview
						if(SkinSettings.BackgroundPath != "") {
							preview_pictureBox.Image = Image.FromFile(SkinSettings.BackgroundPath);
						} else {
							preview_pictureBox.Image = null;
						}
						break;
					default:
						AppManagerClass.ErrorMsg("Unknown node level");
						break;
				}

				AppManagerClass.WriteLogEntry("System", "Selecting TreeView node", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Selecting TreeView node", "Failed");
			}
		}

		//--------------------------------------
		//			adds new launcher			
		//--------------------------------------
		private void launcherToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New launcher");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}
				
				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("launcher");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
							skin_treeView.BeginUpdate();
							skin_treeView.SelectedNode.Nodes.Add(newNode);
							skin_treeView.EndUpdate();
					}	
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new launcher skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new launcher skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//--------------------------------------
		//			adds new cpu load			
		//--------------------------------------
		private void cPUToolStripMenuItem1_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New CPU load");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("cpu", "load");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
						skin_treeView.BeginUpdate();
						skin_treeView.SelectedNode.Nodes.Add(newNode);
						skin_treeView.EndUpdate();
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new cpu load skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new cpu load skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//--------------------------------------
		//			adds new gpu load			
		//--------------------------------------
		private void gPUToolStripMenuItem1_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New GPU load");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("gpu", "load");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
						skin_treeView.BeginUpdate();
						skin_treeView.SelectedNode.Nodes.Add(newNode);
						skin_treeView.EndUpdate();
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new gpu load skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new gpu load skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//--------------------------------------
		//			adds new ram load			
		//--------------------------------------
		private void rAMToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New RAM load");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("ram");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
						skin_treeView.BeginUpdate();
						skin_treeView.SelectedNode.Nodes.Add(newNode);
						skin_treeView.EndUpdate();
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new ram load skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new ram load skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//--------------------------------------
		//			adds new cpu temp			
		//--------------------------------------
		private void cPUToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New CPU temp");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("cpu", "temp");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
						skin_treeView.BeginUpdate();
						skin_treeView.SelectedNode.Nodes.Add(newNode);
						skin_treeView.EndUpdate();
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new cpu temp skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new cpu temp skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//--------------------------------------
		//			adds new gpu temp					
		//--------------------------------------
		private void gPUToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New GPU temp");
				newNode.Tag = "skin";

				try {
					SkinList.ParentNodeName = skin_treeView.SelectedNode.Text;
					SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;
					SkinList.WriteType = "";
					SkinList.SelectedNodeName = newNode.Text;
					SkinList.WriteType = "write";

					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("System", "Setting new skin attributes", "Failed");
				}

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinSetupForm setupForm = new SkinSetupForm("gpu", "temp");
						setupForm.ShowDialog();

						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Opening skin setup", "Failed");
					}
					if(AppManagerClass.IsSuccessful == true) {
						skin_treeView.BeginUpdate();
						skin_treeView.SelectedNode.Nodes.Add(newNode);
						skin_treeView.EndUpdate();
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}

				AppManagerClass.WriteLogEntry("System", "Creating new gpu temp skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new gpu temp skin", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//----------------------------------
		//			deletes node			
		//----------------------------------
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				SkinList.RemoveNode("suite");
				skin_treeView.SelectedNode.Remove();

				AppManagerClass.WriteLogEntry("System", "Removing suite node", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Removing suite node", "Failed");
				AppManagerClass.ErrorMsg("Failed to remove suite.");
			}
		}

		//--------------------------------------
		//			deletes child node			
		//--------------------------------------
		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) {
			try {
				SkinList.RemoveNode("skin");
				skin_treeView.SelectedNode.Remove();

				AppManagerClass.WriteLogEntry("System", "Removing skin node", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Removing skin node", "Failed");
				AppManagerClass.ErrorMsg("Failed to remove skin."); 
			}
		}

		//----------------------------------
		//			adds new suite						
		//----------------------------------
		private void addToolStripMenuItem_Click_1(object sender, EventArgs e) {
			try {
				TreeNode newNode = new TreeNode("New suite");
				newNode.Tag = "suite";

				// name check
				if(SkinAlreadyExists(newNode.Text) == false) {
					try {
						SkinList.SuiteAdd(newNode.Text);

						skin_treeView.BeginUpdate();
						skin_treeView.Nodes.Add(newNode);
						skin_treeView.EndUpdate();

						AppManagerClass.WriteLogEntry("System", "Creating new suite node", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("System", "Creating new suite node", "Failed");
					}
				} else {
					AppManagerClass.ErrorMsg("Skin with this name already exists.");
					return;
				}
			} catch {
				AppManagerClass.WriteLogEntry("System", "Creating new suite node", "Failed");
				AppManagerClass.ErrorMsg();
			}
		}

		//------------------------------------------
		//			rename existing suite			
		//------------------------------------------
		private void renameToolStripMenuItem_Click(object sender, EventArgs e) {
			if(skin_treeView.SelectedNode != null) {
				skin_treeView.SelectedNode.BeginEdit();
			}
		}

		//------------------------------------------
		//			rename existing skin			
		//------------------------------------------
		private void renameToolStripMenuItem1_Click(object sender, EventArgs e) {
			if (skin_treeView.SelectedNode != null) {
				skin_treeView.SelectedNode.BeginEdit();
			}
		}

		private void skin_treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
			try {
				// if name didn't change
				if(e.Label != null) {
					// checks if new name fulfils conditions
					if(e.Label.Length > 0) {
						try {
							// checks for node name
							switch(skin_treeView.SelectedNode.Tag) {
								case "suite":
									if(SkinAlreadyExists(e.Label) == true) {
										AppManagerClass.ErrorMsg("Suite with this name already exists, please change name.");
										e.CancelEdit = true;
										AppManagerClass.ErrorMsg("Invalid name.");
										e.Node.BeginEdit();
										return;
									} else {
										SkinList.SuiteAdd(e.Label, true);
									}
									break;
								case "skin":
									if(SkinAlreadyExists(e.Label) == true) {
										AppManagerClass.ErrorMsg("Skin with this name already exists, please change name.");
										e.CancelEdit = true;
										e.Node.BeginEdit();
										return;
									} else {
										SkinList.NewName = e.Label;
										SkinList.SkinAdd("name");
									}
									break;
								default:
									AppManagerClass.ErrorMsg();
									break;
							}
							// stop editing without canceling the label change
							e.Node.EndEdit(false);

							AppManagerClass.WriteLogEntry("System", "Changing node name", "Successful");
						} catch {
							AppManagerClass.WriteLogEntry("System", "Changing node name", "Failed");
						}
					} else {
						// cancel label edit, inform the user and place the node in edit mode again.
						e.CancelEdit = true;
						AppManagerClass.ErrorMsg("Invalid name.");
						e.Node.BeginEdit();
					}
				}
			} catch { 
				AppManagerClass.ErrorMsg("Couldn't change name."); 
			}
		}

		//--------------------------------------
		//			edit skin component			
		//--------------------------------------
		private void editToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				SkinList.WriteType = "update";
				SkinSetupForm setupForm = new SkinSetupForm(SkinSettings.SkinType, SkinSettings.SkinSubType);
				setupForm.ShowDialog();

				AppManagerClass.WriteLogEntry("System", "Editing skin", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Editing skin", "Failed");
				AppManagerClass.ErrorMsg("Failed to open editing window.");
			}
		}

		//----------------------------------------------
		//			opens imagePreviewEditor			
		//----------------------------------------------
		private void imgEdit_button_Click(object sender, EventArgs e) {
			try {
				SkinList.WriteType = "update";
				if(skin_treeView.SelectedNode.Level == 1 && SkinSettings.BackgroundPath != "") {
					ImageEditorForm imageForm = new ImageEditorForm();
					imageForm.ShowDialog();

					AppManagerClass.WriteLogEntry("System", "Editing image", "Successful");
				}
			} catch {
				AppManagerClass.WriteLogEntry("System", "Editing image", "Failed");
				AppManagerClass.ErrorMsg("Failed to open image editor.");
			}
		}

		//--------------------------
		//			help			
		//--------------------------
		private void help_toolStripButton_Click(object sender, EventArgs e) {
			try {
				HelpForm helpForm = new HelpForm();
				helpForm.Show();

				AppManagerClass.WriteLogEntry("System", "Opening help", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Opening help", "Failed");	
				AppManagerClass.ErrorMsg("Failed to open help."); 
			}
		}

		//------------------------------
		//			settings			
		//------------------------------
		private void settings_toolStripButton_Click(object sender, EventArgs e) {
			try {
				SettingsForm settingsForm = new SettingsForm();
				settingsForm.ShowDialog();

				AppManagerClass.WriteLogEntry("System", "Opening settings", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("System", "Opening settings", "Failed");
				AppManagerClass.ErrorMsg("Failed to open settings."); 
			}
		}

		//------------------------------
		//			log file			
		//------------------------------
		private void log_toolStripButton_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(AppManagerClass.LogPath);
		}

		//--------------------------
		//			export			
		//--------------------------
		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				string exportSkinPath = AppManagerClass.ExportPath + skin_treeView.SelectedNode.Text;
				string componentPath = null;
				string measureName = null;

				try {
					if(Directory.Exists(exportSkinPath) == true) {
						DeleteDirectory(exportSkinPath);
					}
					Directory.CreateDirectory(exportSkinPath);

					AppManagerClass.WriteLogEntry("Export", "Making suite directory", "Successful");
				} catch {
					AppManagerClass.WriteLogEntry("Export", "Making suite directory", "Failed");
				} 

				SkinList.SuiteIndex = skin_treeView.SelectedNode.Index;

				for(int i = 0; i < skin_treeView.SelectedNode.Nodes.Count; i++) {
					// gets component index
					SkinList.SkinIndex = i;
					// gets component data
					SkinList.SkinRead();
					try {
						// creates directory for component
						componentPath = exportSkinPath + @"\" + SkinSettings.SkinComponentName;
						Directory.CreateDirectory(componentPath);

						AppManagerClass.WriteLogEntry("Export", "Making skin directory", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("Export", "Making skin directory", "Failed");
					}
					try {
						// makes ini file
						var iniFile = new IniFile(componentPath + @"\" + SkinSettings.SkinComponentName + ".ini");

						switch(SkinSettings.SkinType) {
							//------------------------------
							//			launcher			
							//------------------------------
							case "launcher":
								try {
									// update
									iniFile.Write("Update", "-1", "Rainmeter");

									AppManagerClass.WriteLogEntry("Export", "Rainmeter section", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Rainmeter section", "Failed");
								}
								try {
									// image
									iniFile.Write("Meter", "Image", "MeterLauncher");
									iniFile.Write("ImageRotate", Convert.ToString(SkinSettings.SkinRotation), "MeterLauncher");
									if(SkinSettings.SkinHorizontalFlip == true && SkinSettings.SkinVerticalFlip == true)
										iniFile.Write("ImageFlip", "Both", "MeterLauncher");
									else if(SkinSettings.SkinHorizontalFlip == true)
										iniFile.Write("ImageFlip", "Horizontal", "MeterLauncher");
									else if(SkinSettings.SkinVerticalFlip == true)
										iniFile.Write("ImageFlip", "Vertical", "MeterLauncher");
									iniFile.Write("W", Convert.ToString(SkinSettings.SkinWidth), "MeterLauncher");
									iniFile.Write("H", Convert.ToString(SkinSettings.SkinHeight), "MeterLauncher");
									iniFile.Write("ImageAlpha", Convert.ToString(SkinSettings.SkinOpacity), "MeterLauncher");
									iniFile.Write("ImageName", SkinSettings.BackgroundPath, "MeterLauncher");
									iniFile.Write("LeftMouseUpAction", "[\"" + SkinSettings.FilePath + "\"]", "MeterLauncher");

									AppManagerClass.WriteLogEntry("Export", "MeterLauncher section", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "MeterLauncher section", "Failed");
								}
								break;
							//------------------------------
							//			hardware			
							//------------------------------
							default:
								try {
									// update
									iniFile.Write("Update", "3000", "Rainmeter");
									// size
									iniFile.Write("SkinWidth", Convert.ToString(SkinSettings.SkinWidth), "Rainmeter");
									iniFile.Write("SkinHeight", Convert.ToString(SkinSettings.SkinHeight), "Rainmeter");
									// background 
									if(SkinSettings.BackgroundCheck == true) {
										iniFile.Write("Background", SkinSettings.BackgroundPath, "Rainmeter");
										iniFile.Write("ImageAlpha", Convert.ToString(SkinSettings.SkinOpacity), "Rainmeter");
										iniFile.Write("ImageRotate", Convert.ToString(SkinSettings.SkinRotation), "Rainmeter");
										if(SkinSettings.SkinHorizontalFlip == true && SkinSettings.SkinVerticalFlip == true)
											iniFile.Write("ImageFlip", "Both", "Rainmeter");
										else if(SkinSettings.SkinHorizontalFlip == true)
											iniFile.Write("ImageFlip", "Horizontal", "Rainmeter");
										else if(SkinSettings.SkinVerticalFlip == true)
											iniFile.Write("ImageFlip", "Vertical", "Rainmeter");
									}

									AppManagerClass.WriteLogEntry("Export", "Rainmeter section", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Rainmeter section", "Failed");
								}

								// hardware specifics
								switch(SkinSettings.SkinType) {
									//----------------------
									//			ram			
									//----------------------
									case "ram":
										measureName = "MeasureRAM";
										try {
											// ram measure
											iniFile.Write("Measure", "PhysicalMemory", measureName);

											AppManagerClass.WriteLogEntry("Export", "MeasureRAM section", "Successful");
										} catch {
											AppManagerClass.WriteLogEntry("Export", "MeasureRAM section", "Failed");
										}
										break;
									//----------------------
									//			cpu			
									//----------------------
									case "cpu":
										measureName = "MeasureCPU";
										// measure
										try {
											switch(SkinSettings.SkinSubType) {
												// load
												case "load":
													// cpu load
													iniFile.Write("Measure", "CPU", measureName);
													iniFile.Write("Procesor", "0", measureName);
													break;
												// temp
												case "temp":
													// cpu temp
													iniFile.Write("Measure", "Plugin", "MeasureTemp");
													iniFile.Write("Plugin", @"@Plugins\OpenHardwareMonitorPlugin.dll", "MeasureTemp");
													iniFile.Write("Hardware", SkinSettings.HardwareName, "MeasureTemp");
													iniFile.Write("Type", "Temperatures", "MeasureTemp");
													iniFile.Write("Sensor", "CPU Package", "MeasureTemp");
													// bar vlaue
													iniFile.Write("Measure", "Calc", measureName);
													iniFile.Write("Formula", "[MeasureTemp]", measureName);
													iniFile.Write("DynamicVariables", "1", measureName);
													iniFile.Write("MinValue", "0", measureName);
													iniFile.Write("MaxValue", "130", measureName);
													break;
												default:
													AppManagerClass.ErrorMsg();
													break;
											}

											AppManagerClass.WriteLogEntry("Export", "MeasureCPU section", "Successful");
										} catch {
											AppManagerClass.WriteLogEntry("Export", "MeasureCPU section", "Failed");
										}
										break;
									//----------------------
									//			gpu			
									//----------------------
									case "gpu":
										measureName = "MeasureGPU";
										try {
											// measure
											switch(SkinSettings.SkinSubType) {
												// load
												case "load":
													// gpu load
													iniFile.Write("Measure", "Plugin", "MeasureLoad");
													iniFile.Write("Plugin", @"@Plugins\OpenHardwareMonitorPlugin.dll", "MeasureLoad");
													iniFile.Write("Hardware", SkinSettings.HardwareName, "MeasureLoad");
													iniFile.Write("Type", "Load", "MeasureLoad");
													iniFile.Write("Sensor", "GPU Core", "MeasureLoad");
													// gpu load in percent
													iniFile.Write("Measure", "Calc", measureName);
													iniFile.Write("Formula", "[MeasureLoad]*100", measureName);
													iniFile.Write("DynamicVariables", "1", measureName);
													iniFile.Write("MinValue", "0", measureName);
													iniFile.Write("MaxValue", "100", measureName);
													break;
												// temp
												case "temp":
													// gpu temp
													iniFile.Write("Measure", "Plugin", "MeasureTemp");
													iniFile.Write("Plugin", @"@Plugins\OpenHardwareMonitorPlugin.dll", "MeasureTemp");
													iniFile.Write("Hardware", SkinSettings.HardwareName, "MeasureTemp");
													iniFile.Write("Type", "Temperatures", "MeasureTemp");
													iniFile.Write("Sensor", "GPU Core", "MeasureTemp");
													// bar vlaue
													iniFile.Write("Measure", "Calc", measureName);
													iniFile.Write("Formula", "[MeasureTemp]", measureName);
													iniFile.Write("DynamicVariables", "1", measureName);
													iniFile.Write("MinValue", "0", measureName);
													iniFile.Write("MaxValue", "130", measureName);
													break;
												default:
													AppManagerClass.ErrorMsg();
													break;
											}

											AppManagerClass.WriteLogEntry("Export", "MeasureGPU", "Successful");
										} catch {
											AppManagerClass.WriteLogEntry("Export", "MeasureGPU", "Failed");
										}
										break;
									default:
										AppManagerClass.ErrorMsg();
										break;
								}
								try {
									// bar
									if(SkinSettings.BarCheck == true) {
										Image barImg = Image.FromFile(SkinSettings.BarPath);
										float transformationMatrixWidth = barImg.Width;
										float transformationMatrixHeight = barImg.Height;

										//width
										if(transformationMatrixWidth > SkinSettings.SkinWidth) {
											transformationMatrixWidth = SkinSettings.SkinWidth / transformationMatrixWidth;
										} else {
											transformationMatrixWidth = SkinSettings.SkinWidth / transformationMatrixWidth;
										}
										// height
										if(transformationMatrixHeight > SkinSettings.SkinHeight) {
											transformationMatrixHeight = SkinSettings.SkinHeight / transformationMatrixHeight;
										} else {
											transformationMatrixHeight = SkinSettings.SkinHeight / transformationMatrixHeight;
										}

										string width = Convert.ToString(transformationMatrixWidth);
										string height = Convert.ToString(transformationMatrixHeight);

										width = width.Replace(",", ".");
										height = height.Replace(",", ".");

										iniFile.Write("Meter", "Bar", "MeterBar");
										iniFile.Write("MeasureName", measureName, "MeterBar");
										iniFile.Write("TransformationMatrix", width + ";0;0;" + height + ";0;0", "MeterBar");
										iniFile.Write("BarImage", SkinSettings.BarPath, "MeterBar");
										iniFile.Write("BarOrientation", "VERTICAL", "MeterBar");
									}

									AppManagerClass.WriteLogEntry("Export", "Bar section", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Bar section", "Failed");
								}
								break;
						}
						// text
						if(SkinSettings.TextCheck == true || SkinSettings.TextValueCheck == true) {
							try {
								// text style
								iniFile.Write("StringAlign", "CenterCenter", "StyleText");
								iniFile.Write("StringCase", "Upper", "StyleText");
								iniFile.Write("StringStyle", "Bold", "StyleText");
								iniFile.Write("StringEffect", "Shadow", "StyleText");
								iniFile.Write("StringEffectColor", "0,0,0,50", "StyleText");
								iniFile.Write("FontColor", SkinSettings.TextColor, "StyleText");
								iniFile.Write("FontFace", SkinSettings.TextFont, "StyleText");
								iniFile.Write("FontSize", Convert.ToString(SkinSettings.TextSize), "StyleText");
								iniFile.Write("AntiAlias", "1", "StyleText");
								iniFile.Write("ClipString", "1", "StyleText");

								AppManagerClass.WriteLogEntry("Export", "Text style section", "Successful");
							} catch {
								AppManagerClass.WriteLogEntry("Export", "Text style section", "Failed");
							}

							if(SkinSettings.TextCheck == true && SkinSettings.TextValueCheck == true) {
								try {
									iniFile.Write("Meter", "String", "MeterTitle");
									iniFile.Write("MeterStyle", "StyleText", "MeterTitle");
									iniFile.Write("MeasureName", measureName, "MeterTitle");
									iniFile.Write("X", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Y", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Text", SkinSettings.Text + "#CRLF#%1", "MeterTitle");

									AppManagerClass.WriteLogEntry("Export", "Text section - BOTH", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Text section - BOTH", "Failed");
								}

							} else if(SkinSettings.TextCheck == true) {
								try {
									iniFile.Write("Meter", "String", "MeterTitle");
									iniFile.Write("MeterStyle", "StyleText", "MeterTitle");
									iniFile.Write("X", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Y", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Text", SkinSettings.Text, "MeterTitle");

									AppManagerClass.WriteLogEntry("Export", "Text section - TEXT", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Text section - TEXT", "Failed");
								}

							} else if(SkinSettings.TextValueCheck == true) {
								try {
									iniFile.Write("Meter", "String", "MeterTitle");
									iniFile.Write("MeterStyle", "StyleText", "MeterTitle");
									iniFile.Write("MeasureName", measureName, "MeterTitle");
									iniFile.Write("X", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Y", Convert.ToString(SkinSettings.SkinWidth / 2), "MeterTitle");
									iniFile.Write("Text", "%1", "MeterTitle");

									AppManagerClass.WriteLogEntry("Export", "Text section - VALUE", "Successful");
								} catch {
									AppManagerClass.WriteLogEntry("Export", "Text section - VALUE", "Failed");
								}
							}

							if(SkinSettings.SkinType == "ram") {
								if(SkinSettings.TextValueCheck == true || SkinSettings.TextCheck == true) {
									iniFile.Write("Percentual", "1", "MeterTitle");
								}
							}
						}

						AppManagerClass.WriteLogEntry("Export", "Making skin file", "Successful");
					} catch {
						AppManagerClass.WriteLogEntry("Export", "Making skin file", "Failed");
					}
				}

				AppManagerClass.WriteLogEntry("Export", "Exporting suite", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("Export", "Exporting suite", "Failed");
				AppManagerClass.ErrorMsg("Failed to export skin.");
			}
		}

		//----------------------------------
		//			suite name check			
		//----------------------------------
		private bool SuiteAlreadyExists(string newName) {
			for(int i = 0; i < skin_treeView.Nodes.Count; i++) {
				if (newName == skin_treeView.Nodes[i].Text) {
					return true;
				}
			}

			return false;
		}

		//--------------------------------------
		//			skin name check			
		//--------------------------------------
		private bool SkinAlreadyExists(string newName) {
			if (skin_treeView.Nodes.Count == 0) {
				return false;
            }
			for(int i = 0; i < skin_treeView.Nodes[SkinList.SuiteIndex].Nodes.Count; i++) {
				if (newName == skin_treeView.Nodes[SkinList.SuiteIndex].Nodes[i].Text) {
					return true;
				}
			}

			return false;
		}

		//----------------------------------------------------------
		//			deletes directory and what is inside			
		//----------------------------------------------------------
		private void DeleteDirectory(string target_dir) {
			string[] files = Directory.GetFiles(target_dir);
			string[] dirs = Directory.GetDirectories(target_dir);

			foreach(string file in files) {
				File.SetAttributes(file, FileAttributes.Normal);
				File.Delete(file);
			}

			foreach(string dir in dirs) {
				DeleteDirectory(dir);
			}

			Directory.Delete(target_dir, false);
		}
    }
}