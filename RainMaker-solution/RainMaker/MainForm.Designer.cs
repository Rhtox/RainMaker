
namespace RainMaker {
	partial class main_Form {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form));
            this.skin_treeView = new System.Windows.Forms.TreeView();
            this.addNode_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgEdit_button = new System.Windows.Forms.Button();
            this.preview_pictureBox = new System.Windows.Forms.PictureBox();
            this.node_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childNode_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu_toolStrip = new System.Windows.Forms.ToolStrip();
            this.help_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.settings_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.log_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addNode_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview_pictureBox)).BeginInit();
            this.node_contextMenuStrip.SuspendLayout();
            this.childNode_contextMenuStrip.SuspendLayout();
            this.menu_toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // skin_treeView
            // 
            this.skin_treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skin_treeView.ContextMenuStrip = this.addNode_contextMenuStrip;
            this.skin_treeView.ForeColor = System.Drawing.SystemColors.Window;
            this.skin_treeView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.skin_treeView.Indent = 25;
            this.skin_treeView.LabelEdit = true;
            this.skin_treeView.Location = new System.Drawing.Point(18, 31);
            this.skin_treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skin_treeView.Name = "skin_treeView";
            this.skin_treeView.Size = new System.Drawing.Size(314, 449);
            this.skin_treeView.TabIndex = 0;
            this.skin_treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.skin_treeView_AfterLabelEdit);
            this.skin_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.skin_treeView_AfterSelect);
            // 
            // addNode_contextMenuStrip
            // 
            this.addNode_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.addNode_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.addNode_contextMenuStrip.Name = "skinTreeView_contextMenuStrip";
            this.addNode_contextMenuStrip.Size = new System.Drawing.Size(144, 28);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.addToolStripMenuItem.Text = "Add Suite";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click_1);
            // 
            // imgEdit_button
            // 
            this.imgEdit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imgEdit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgEdit_button.FlatAppearance.BorderSize = 0;
            this.imgEdit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imgEdit_button.ForeColor = System.Drawing.SystemColors.Window;
            this.imgEdit_button.Location = new System.Drawing.Point(422, 415);
            this.imgEdit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgEdit_button.Name = "imgEdit_button";
            this.imgEdit_button.Size = new System.Drawing.Size(199, 46);
            this.imgEdit_button.TabIndex = 6;
            this.imgEdit_button.Text = "Edit image";
            this.imgEdit_button.UseVisualStyleBackColor = false;
            this.imgEdit_button.Click += new System.EventHandler(this.imgEdit_button_Click);
            // 
            // preview_pictureBox
            // 
            this.preview_pictureBox.Location = new System.Drawing.Point(397, 71);
            this.preview_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preview_pictureBox.Name = "preview_pictureBox";
            this.preview_pictureBox.Size = new System.Drawing.Size(248, 275);
            this.preview_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview_pictureBox.TabIndex = 7;
            this.preview_pictureBox.TabStop = false;
            // 
            // node_contextMenuStrip
            // 
            this.node_contextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.node_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.node_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.node_contextMenuStrip.Name = "nodeTV_contextMenuStrip";
            this.node_contextMenuStrip.Size = new System.Drawing.Size(133, 100);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launcherToolStripMenuItem,
            this.componentLoadToolStripMenuItem,
            this.componentTempToolStripMenuItem});
            this.addToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.addToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.launcherToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.launcherToolStripMenuItem.Text = "Launcher";
            this.launcherToolStripMenuItem.Click += new System.EventHandler(this.launcherToolStripMenuItem_Click);
            // 
            // componentLoadToolStripMenuItem
            // 
            this.componentLoadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.componentLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem1,
            this.gPUToolStripMenuItem1,
            this.rAMToolStripMenuItem});
            this.componentLoadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.componentLoadToolStripMenuItem.Name = "componentLoadToolStripMenuItem";
            this.componentLoadToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.componentLoadToolStripMenuItem.Text = "Component load";
            // 
            // cPUToolStripMenuItem1
            // 
            this.cPUToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPUToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.cPUToolStripMenuItem1.Name = "cPUToolStripMenuItem1";
            this.cPUToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.cPUToolStripMenuItem1.Text = "CPU";
            this.cPUToolStripMenuItem1.Click += new System.EventHandler(this.cPUToolStripMenuItem1_Click);
            // 
            // gPUToolStripMenuItem1
            // 
            this.gPUToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gPUToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.gPUToolStripMenuItem1.Name = "gPUToolStripMenuItem1";
            this.gPUToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.gPUToolStripMenuItem1.Text = "GPU";
            this.gPUToolStripMenuItem1.Click += new System.EventHandler(this.gPUToolStripMenuItem1_Click);
            // 
            // rAMToolStripMenuItem
            // 
            this.rAMToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rAMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            this.rAMToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.rAMToolStripMenuItem.Text = "RAM";
            this.rAMToolStripMenuItem.Click += new System.EventHandler(this.rAMToolStripMenuItem_Click);
            // 
            // componentTempToolStripMenuItem
            // 
            this.componentTempToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.componentTempToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem,
            this.gPUToolStripMenuItem});
            this.componentTempToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.componentTempToolStripMenuItem.Name = "componentTempToolStripMenuItem";
            this.componentTempToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.componentTempToolStripMenuItem.Text = "Component temperature";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPUToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.cPUToolStripMenuItem.Text = "CPU";
            this.cPUToolStripMenuItem.Click += new System.EventHandler(this.cPUToolStripMenuItem_Click);
            // 
            // gPUToolStripMenuItem
            // 
            this.gPUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gPUToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.gPUToolStripMenuItem.Name = "gPUToolStripMenuItem";
            this.gPUToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.gPUToolStripMenuItem.Text = "GPU";
            this.gPUToolStripMenuItem.Click += new System.EventHandler(this.gPUToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // childNode_contextMenuStrip
            // 
            this.childNode_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.childNode_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.childNode_contextMenuStrip.Name = "childNode_contextMenuStrip";
            this.childNode_contextMenuStrip.Size = new System.Drawing.Size(133, 76);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renameToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // menu_toolStrip
            // 
            this.menu_toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu_toolStrip.CanOverflow = false;
            this.menu_toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu_toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu_toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_toolStripButton,
            this.settings_toolStripButton,
            this.log_toolStripButton});
            this.menu_toolStrip.Location = new System.Drawing.Point(0, 524);
            this.menu_toolStrip.Name = "menu_toolStrip";
            this.menu_toolStrip.Size = new System.Drawing.Size(701, 27);
            this.menu_toolStrip.TabIndex = 8;
            this.menu_toolStrip.Text = "toolStrip1";
            // 
            // help_toolStripButton
            // 
            this.help_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.help_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.help_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("help_toolStripButton.Image")));
            this.help_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_toolStripButton.Name = "help_toolStripButton";
            this.help_toolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.help_toolStripButton.Size = new System.Drawing.Size(29, 24);
            this.help_toolStripButton.Text = "Help";
            this.help_toolStripButton.Click += new System.EventHandler(this.help_toolStripButton_Click);
            // 
            // settings_toolStripButton
            // 
            this.settings_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settings_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settings_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settings_toolStripButton.Image")));
            this.settings_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings_toolStripButton.Name = "settings_toolStripButton";
            this.settings_toolStripButton.Size = new System.Drawing.Size(29, 24);
            this.settings_toolStripButton.Text = "Settings";
            this.settings_toolStripButton.Click += new System.EventHandler(this.settings_toolStripButton_Click);
            // 
            // log_toolStripButton
            // 
            this.log_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.log_toolStripButton.ForeColor = System.Drawing.SystemColors.Window;
            this.log_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("log_toolStripButton.Image")));
            this.log_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.log_toolStripButton.Name = "log_toolStripButton";
            this.log_toolStripButton.Size = new System.Drawing.Size(38, 24);
            this.log_toolStripButton.Text = "Log";
            this.log_toolStripButton.Click += new System.EventHandler(this.log_toolStripButton_Click);
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(701, 551);
            this.Controls.Add(this.menu_toolStrip);
            this.Controls.Add(this.preview_pictureBox);
            this.Controls.Add(this.imgEdit_button);
            this.Controls.Add(this.skin_treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_Form";
            this.Text = "RainMaker";
            this.addNode_contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview_pictureBox)).EndInit();
            this.node_contextMenuStrip.ResumeLayout(false);
            this.childNode_contextMenuStrip.ResumeLayout(false);
            this.menu_toolStrip.ResumeLayout(false);
            this.menu_toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView skin_treeView;
		private System.Windows.Forms.Button imgEdit_button;
		private System.Windows.Forms.PictureBox preview_pictureBox;
		private System.Windows.Forms.ContextMenuStrip addNode_contextMenuStrip;
		private System.Windows.Forms.ContextMenuStrip node_contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip childNode_contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem launcherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem componentLoadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem gPUToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rAMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem componentTempToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gPUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStrip menu_toolStrip;
		private System.Windows.Forms.ToolStripButton help_toolStripButton;
		private System.Windows.Forms.ToolStripButton settings_toolStripButton;
		private System.Windows.Forms.ToolStripButton log_toolStripButton;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
    }
}

