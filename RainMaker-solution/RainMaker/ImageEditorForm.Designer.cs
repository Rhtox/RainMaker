
namespace RainMaker {
	partial class ImageEditorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.main_pictureBox = new System.Windows.Forms.PictureBox();
            this.ImgEdit_tabControl = new System.Windows.Forms.TabControl();
            this.transform_tabPage = new System.Windows.Forms.TabPage();
            this.resetTransform_button = new System.Windows.Forms.Button();
            this.applyTransform_button = new System.Windows.Forms.Button();
            this.px_label2 = new System.Windows.Forms.Label();
            this.px_label1 = new System.Windows.Forms.Label();
            this.percent_label = new System.Windows.Forms.Label();
            this.height_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.width_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scale_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.height_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.scale_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.scale_label = new System.Windows.Forms.Label();
            this.opacity_tabPage = new System.Windows.Forms.TabPage();
            this.opacity_pictureBox = new System.Windows.Forms.PictureBox();
            this.resetOpacity_button = new System.Windows.Forms.Button();
            this.opacity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyOpacity_button = new System.Windows.Forms.Button();
            this.opacity_label = new System.Windows.Forms.Label();
            this.opacity_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.rotate_tabPage = new System.Windows.Forms.TabPage();
            this.rotateVertical_button = new System.Windows.Forms.Button();
            this.rotateHorizontal_button = new System.Windows.Forms.Button();
            this.rotateRight_button = new System.Windows.Forms.Button();
            this.rotateLeft_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pictureBox)).BeginInit();
            this.ImgEdit_tabControl.SuspendLayout();
            this.transform_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_numericUpDown)).BeginInit();
            this.opacity_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_numericUpDown)).BeginInit();
            this.rotate_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1079, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fileToolStripMenuItem.Text = "Image";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.main_pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ImgEdit_tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 533);
            this.splitContainer1.SplitterDistance = 690;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // main_pictureBox
            // 
            this.main_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.main_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.main_pictureBox.Name = "main_pictureBox";
            this.main_pictureBox.Size = new System.Drawing.Size(512, 420);
            this.main_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.main_pictureBox.TabIndex = 0;
            this.main_pictureBox.TabStop = false;
            // 
            // ImgEdit_tabControl
            // 
            this.ImgEdit_tabControl.Controls.Add(this.transform_tabPage);
            this.ImgEdit_tabControl.Controls.Add(this.opacity_tabPage);
            this.ImgEdit_tabControl.Controls.Add(this.rotate_tabPage);
            this.ImgEdit_tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImgEdit_tabControl.Location = new System.Drawing.Point(17, 0);
            this.ImgEdit_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.ImgEdit_tabControl.Name = "ImgEdit_tabControl";
            this.ImgEdit_tabControl.SelectedIndex = 0;
            this.ImgEdit_tabControl.Size = new System.Drawing.Size(367, 533);
            this.ImgEdit_tabControl.TabIndex = 1;
            // 
            // transform_tabPage
            // 
            this.transform_tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transform_tabPage.Controls.Add(this.resetTransform_button);
            this.transform_tabPage.Controls.Add(this.applyTransform_button);
            this.transform_tabPage.Controls.Add(this.px_label2);
            this.transform_tabPage.Controls.Add(this.px_label1);
            this.transform_tabPage.Controls.Add(this.percent_label);
            this.transform_tabPage.Controls.Add(this.height_numericUpDown);
            this.transform_tabPage.Controls.Add(this.width_numericUpDown);
            this.transform_tabPage.Controls.Add(this.scale_numericUpDown);
            this.transform_tabPage.Controls.Add(this.height_label);
            this.transform_tabPage.Controls.Add(this.width_label);
            this.transform_tabPage.Controls.Add(this.scale_hScrollBar);
            this.transform_tabPage.Controls.Add(this.scale_label);
            this.transform_tabPage.Location = new System.Drawing.Point(4, 25);
            this.transform_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.transform_tabPage.Name = "transform_tabPage";
            this.transform_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.transform_tabPage.Size = new System.Drawing.Size(359, 504);
            this.transform_tabPage.TabIndex = 0;
            this.transform_tabPage.Text = "Transform";
            // 
            // resetTransform_button
            // 
            this.resetTransform_button.BackColor = System.Drawing.Color.DimGray;
            this.resetTransform_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetTransform_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetTransform_button.ForeColor = System.Drawing.SystemColors.Window;
            this.resetTransform_button.Location = new System.Drawing.Point(212, 438);
            this.resetTransform_button.Margin = new System.Windows.Forms.Padding(4);
            this.resetTransform_button.Name = "resetTransform_button";
            this.resetTransform_button.Size = new System.Drawing.Size(100, 28);
            this.resetTransform_button.TabIndex = 27;
            this.resetTransform_button.Text = "Cancel";
            this.resetTransform_button.UseVisualStyleBackColor = false;
            this.resetTransform_button.Click += new System.EventHandler(this.ResetTransform_button_Click);
            // 
            // applyTransform_button
            // 
            this.applyTransform_button.BackColor = System.Drawing.Color.DimGray;
            this.applyTransform_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyTransform_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyTransform_button.ForeColor = System.Drawing.SystemColors.Window;
            this.applyTransform_button.Location = new System.Drawing.Point(45, 438);
            this.applyTransform_button.Margin = new System.Windows.Forms.Padding(4);
            this.applyTransform_button.Name = "applyTransform_button";
            this.applyTransform_button.Size = new System.Drawing.Size(100, 28);
            this.applyTransform_button.TabIndex = 26;
            this.applyTransform_button.Text = "Apply";
            this.applyTransform_button.UseVisualStyleBackColor = false;
            this.applyTransform_button.Click += new System.EventHandler(this.ApplyTransform_button_Click);
            // 
            // px_label2
            // 
            this.px_label2.AutoSize = true;
            this.px_label2.ForeColor = System.Drawing.SystemColors.Window;
            this.px_label2.Location = new System.Drawing.Point(211, 288);
            this.px_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.px_label2.Name = "px_label2";
            this.px_label2.Size = new System.Drawing.Size(21, 16);
            this.px_label2.TabIndex = 24;
            this.px_label2.Text = "px";
            // 
            // px_label1
            // 
            this.px_label1.AutoSize = true;
            this.px_label1.ForeColor = System.Drawing.SystemColors.Window;
            this.px_label1.Location = new System.Drawing.Point(211, 220);
            this.px_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.px_label1.Name = "px_label1";
            this.px_label1.Size = new System.Drawing.Size(21, 16);
            this.px_label1.TabIndex = 23;
            this.px_label1.Text = "px";
            // 
            // percent_label
            // 
            this.percent_label.AutoSize = true;
            this.percent_label.ForeColor = System.Drawing.SystemColors.Window;
            this.percent_label.Location = new System.Drawing.Point(211, 92);
            this.percent_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percent_label.Name = "percent_label";
            this.percent_label.Size = new System.Drawing.Size(19, 16);
            this.percent_label.TabIndex = 22;
            this.percent_label.Text = "%";
            // 
            // height_numericUpDown
            // 
            this.height_numericUpDown.BackColor = System.Drawing.Color.DimGray;
            this.height_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height_numericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.height_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.height_numericUpDown.Location = new System.Drawing.Point(45, 286);
            this.height_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.height_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height_numericUpDown.Name = "height_numericUpDown";
            this.height_numericUpDown.Size = new System.Drawing.Size(160, 22);
            this.height_numericUpDown.TabIndex = 20;
            this.height_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height_numericUpDown.ValueChanged += new System.EventHandler(this.Height_numericUpDown_ValueChanged);
            // 
            // width_numericUpDown
            // 
            this.width_numericUpDown.BackColor = System.Drawing.Color.DimGray;
            this.width_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width_numericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.width_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.width_numericUpDown.Location = new System.Drawing.Point(45, 218);
            this.width_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.width_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_numericUpDown.Name = "width_numericUpDown";
            this.width_numericUpDown.Size = new System.Drawing.Size(160, 22);
            this.width_numericUpDown.TabIndex = 19;
            this.width_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_numericUpDown.ValueChanged += new System.EventHandler(this.Width_numericUpDown_ValueChanged);
            // 
            // scale_numericUpDown
            // 
            this.scale_numericUpDown.BackColor = System.Drawing.Color.DimGray;
            this.scale_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scale_numericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.scale_numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scale_numericUpDown.Location = new System.Drawing.Point(45, 90);
            this.scale_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.scale_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scale_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scale_numericUpDown.Name = "scale_numericUpDown";
            this.scale_numericUpDown.Size = new System.Drawing.Size(160, 22);
            this.scale_numericUpDown.TabIndex = 18;
            this.scale_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scale_numericUpDown.ValueChanged += new System.EventHandler(this.Scale_numericUpDown_ValueChanged);
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.ForeColor = System.Drawing.SystemColors.Window;
            this.height_label.Location = new System.Drawing.Point(41, 266);
            this.height_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(46, 16);
            this.height_label.TabIndex = 16;
            this.height_label.Text = "Height";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.ForeColor = System.Drawing.SystemColors.Window;
            this.width_label.Location = new System.Drawing.Point(41, 198);
            this.width_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(41, 16);
            this.width_label.TabIndex = 15;
            this.width_label.Text = "Width";
            // 
            // scale_hScrollBar
            // 
            this.scale_hScrollBar.Location = new System.Drawing.Point(45, 64);
            this.scale_hScrollBar.Maximum = 200;
            this.scale_hScrollBar.Minimum = 50;
            this.scale_hScrollBar.Name = "scale_hScrollBar";
            this.scale_hScrollBar.Size = new System.Drawing.Size(267, 17);
            this.scale_hScrollBar.SmallChange = 10;
            this.scale_hScrollBar.TabIndex = 11;
            this.scale_hScrollBar.Value = 100;
            this.scale_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scale_hScrollBar_Scroll);
            // 
            // scale_label
            // 
            this.scale_label.AutoSize = true;
            this.scale_label.ForeColor = System.Drawing.SystemColors.Window;
            this.scale_label.Location = new System.Drawing.Point(41, 48);
            this.scale_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scale_label.Name = "scale_label";
            this.scale_label.Size = new System.Drawing.Size(42, 16);
            this.scale_label.TabIndex = 10;
            this.scale_label.Text = "Scale";
            // 
            // opacity_tabPage
            // 
            this.opacity_tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opacity_tabPage.Controls.Add(this.opacity_pictureBox);
            this.opacity_tabPage.Controls.Add(this.resetOpacity_button);
            this.opacity_tabPage.Controls.Add(this.opacity_numericUpDown);
            this.opacity_tabPage.Controls.Add(this.applyOpacity_button);
            this.opacity_tabPage.Controls.Add(this.opacity_label);
            this.opacity_tabPage.Controls.Add(this.opacity_hScrollBar);
            this.opacity_tabPage.Location = new System.Drawing.Point(4, 25);
            this.opacity_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.opacity_tabPage.Name = "opacity_tabPage";
            this.opacity_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.opacity_tabPage.Size = new System.Drawing.Size(359, 500);
            this.opacity_tabPage.TabIndex = 2;
            this.opacity_tabPage.Text = "Opacity";
            // 
            // opacity_pictureBox
            // 
            this.opacity_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opacity_pictureBox.Location = new System.Drawing.Point(44, 174);
            this.opacity_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opacity_pictureBox.Name = "opacity_pictureBox";
            this.opacity_pictureBox.Size = new System.Drawing.Size(267, 190);
            this.opacity_pictureBox.TabIndex = 31;
            this.opacity_pictureBox.TabStop = false;
            // 
            // resetOpacity_button
            // 
            this.resetOpacity_button.BackColor = System.Drawing.Color.DimGray;
            this.resetOpacity_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetOpacity_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetOpacity_button.ForeColor = System.Drawing.SystemColors.Window;
            this.resetOpacity_button.Location = new System.Drawing.Point(211, 438);
            this.resetOpacity_button.Margin = new System.Windows.Forms.Padding(4);
            this.resetOpacity_button.Name = "resetOpacity_button";
            this.resetOpacity_button.Size = new System.Drawing.Size(100, 28);
            this.resetOpacity_button.TabIndex = 30;
            this.resetOpacity_button.Text = "Cancel";
            this.resetOpacity_button.UseVisualStyleBackColor = false;
            this.resetOpacity_button.Click += new System.EventHandler(this.ResetAlphaCh_button_Click);
            // 
            // opacity_numericUpDown
            // 
            this.opacity_numericUpDown.BackColor = System.Drawing.Color.DimGray;
            this.opacity_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opacity_numericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.opacity_numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.opacity_numericUpDown.Location = new System.Drawing.Point(48, 87);
            this.opacity_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.opacity_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacity_numericUpDown.Name = "opacity_numericUpDown";
            this.opacity_numericUpDown.Size = new System.Drawing.Size(160, 22);
            this.opacity_numericUpDown.TabIndex = 28;
            this.opacity_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacity_numericUpDown.ValueChanged += new System.EventHandler(this.AlphaCh_numericUpDown_ValueChanged);
            // 
            // applyOpacity_button
            // 
            this.applyOpacity_button.BackColor = System.Drawing.Color.DimGray;
            this.applyOpacity_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyOpacity_button.FlatAppearance.BorderSize = 0;
            this.applyOpacity_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyOpacity_button.ForeColor = System.Drawing.SystemColors.Window;
            this.applyOpacity_button.Location = new System.Drawing.Point(44, 438);
            this.applyOpacity_button.Margin = new System.Windows.Forms.Padding(4);
            this.applyOpacity_button.Name = "applyOpacity_button";
            this.applyOpacity_button.Size = new System.Drawing.Size(100, 28);
            this.applyOpacity_button.TabIndex = 27;
            this.applyOpacity_button.Text = "Apply";
            this.applyOpacity_button.UseVisualStyleBackColor = false;
            this.applyOpacity_button.Click += new System.EventHandler(this.ApplyAlphaCh_button_Click);
            // 
            // opacity_label
            // 
            this.opacity_label.AutoSize = true;
            this.opacity_label.ForeColor = System.Drawing.SystemColors.Window;
            this.opacity_label.Location = new System.Drawing.Point(44, 42);
            this.opacity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opacity_label.Name = "opacity_label";
            this.opacity_label.Size = new System.Drawing.Size(53, 16);
            this.opacity_label.TabIndex = 1;
            this.opacity_label.Text = "Opacity";
            // 
            // opacity_hScrollBar
            // 
            this.opacity_hScrollBar.Location = new System.Drawing.Point(44, 62);
            this.opacity_hScrollBar.Maximum = 255;
            this.opacity_hScrollBar.Name = "opacity_hScrollBar";
            this.opacity_hScrollBar.Size = new System.Drawing.Size(267, 17);
            this.opacity_hScrollBar.SmallChange = 10;
            this.opacity_hScrollBar.TabIndex = 0;
            this.opacity_hScrollBar.Value = 255;
            this.opacity_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AlphaCh_hScrollBar_Scroll);
            // 
            // rotate_tabPage
            // 
            this.rotate_tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rotate_tabPage.Controls.Add(this.rotateVertical_button);
            this.rotate_tabPage.Controls.Add(this.rotateHorizontal_button);
            this.rotate_tabPage.Controls.Add(this.rotateRight_button);
            this.rotate_tabPage.Controls.Add(this.rotateLeft_button);
            this.rotate_tabPage.Location = new System.Drawing.Point(4, 25);
            this.rotate_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.rotate_tabPage.Name = "rotate_tabPage";
            this.rotate_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.rotate_tabPage.Size = new System.Drawing.Size(359, 500);
            this.rotate_tabPage.TabIndex = 3;
            this.rotate_tabPage.Text = "Rotate";
            // 
            // rotateVertical_button
            // 
            this.rotateVertical_button.BackColor = System.Drawing.Color.DimGray;
            this.rotateVertical_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateVertical_button.ForeColor = System.Drawing.SystemColors.Window;
            this.rotateVertical_button.Location = new System.Drawing.Point(84, 318);
            this.rotateVertical_button.Margin = new System.Windows.Forms.Padding(4);
            this.rotateVertical_button.Name = "rotateVertical_button";
            this.rotateVertical_button.Size = new System.Drawing.Size(184, 28);
            this.rotateVertical_button.TabIndex = 3;
            this.rotateVertical_button.Text = "Flip vertical";
            this.rotateVertical_button.UseVisualStyleBackColor = false;
            this.rotateVertical_button.Click += new System.EventHandler(this.RotateVertical_button_Click);
            // 
            // rotateHorizontal_button
            // 
            this.rotateHorizontal_button.BackColor = System.Drawing.Color.DimGray;
            this.rotateHorizontal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateHorizontal_button.ForeColor = System.Drawing.SystemColors.Window;
            this.rotateHorizontal_button.Location = new System.Drawing.Point(84, 267);
            this.rotateHorizontal_button.Margin = new System.Windows.Forms.Padding(4);
            this.rotateHorizontal_button.Name = "rotateHorizontal_button";
            this.rotateHorizontal_button.Size = new System.Drawing.Size(184, 28);
            this.rotateHorizontal_button.TabIndex = 2;
            this.rotateHorizontal_button.Text = "Flip horizontal";
            this.rotateHorizontal_button.UseVisualStyleBackColor = false;
            this.rotateHorizontal_button.Click += new System.EventHandler(this.RotateHorizontal_button_Click);
            // 
            // rotateRight_button
            // 
            this.rotateRight_button.BackColor = System.Drawing.Color.DimGray;
            this.rotateRight_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateRight_button.ForeColor = System.Drawing.SystemColors.Window;
            this.rotateRight_button.Location = new System.Drawing.Point(84, 133);
            this.rotateRight_button.Margin = new System.Windows.Forms.Padding(4);
            this.rotateRight_button.Name = "rotateRight_button";
            this.rotateRight_button.Size = new System.Drawing.Size(184, 28);
            this.rotateRight_button.TabIndex = 1;
            this.rotateRight_button.Text = "Rotate right";
            this.rotateRight_button.UseVisualStyleBackColor = false;
            this.rotateRight_button.Click += new System.EventHandler(this.RotateRight_button_Click);
            // 
            // rotateLeft_button
            // 
            this.rotateLeft_button.BackColor = System.Drawing.Color.DimGray;
            this.rotateLeft_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateLeft_button.ForeColor = System.Drawing.SystemColors.Window;
            this.rotateLeft_button.Location = new System.Drawing.Point(84, 82);
            this.rotateLeft_button.Margin = new System.Windows.Forms.Padding(4);
            this.rotateLeft_button.Name = "rotateLeft_button";
            this.rotateLeft_button.Size = new System.Drawing.Size(184, 28);
            this.rotateLeft_button.TabIndex = 0;
            this.rotateLeft_button.Text = "Rotate left";
            this.rotateLeft_button.UseVisualStyleBackColor = false;
            this.rotateLeft_button.Click += new System.EventHandler(this.RotateLeft_button_Click);
            // 
            // ImageEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1079, 559);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageEditorForm";
            this.Text = "Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_pictureBox)).EndInit();
            this.ImgEdit_tabControl.ResumeLayout(false);
            this.transform_tabPage.ResumeLayout(false);
            this.transform_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_numericUpDown)).EndInit();
            this.opacity_tabPage.ResumeLayout(false);
            this.opacity_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_numericUpDown)).EndInit();
            this.rotate_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl ImgEdit_tabControl;
		private System.Windows.Forms.TabPage transform_tabPage;
		private System.Windows.Forms.TabPage opacity_tabPage;
		private System.Windows.Forms.Label height_label;
		private System.Windows.Forms.Label width_label;
		private System.Windows.Forms.HScrollBar scale_hScrollBar;
		private System.Windows.Forms.Label scale_label;
		private System.Windows.Forms.Label opacity_label;
		private System.Windows.Forms.HScrollBar opacity_hScrollBar;
		private System.Windows.Forms.Label px_label2;
		private System.Windows.Forms.Label px_label1;
		private System.Windows.Forms.Label percent_label;
		private System.Windows.Forms.NumericUpDown height_numericUpDown;
		private System.Windows.Forms.NumericUpDown width_numericUpDown;
		private System.Windows.Forms.NumericUpDown scale_numericUpDown;
		private System.Windows.Forms.Button applyTransform_button;
		private System.Windows.Forms.Button applyOpacity_button;
		private System.Windows.Forms.NumericUpDown opacity_numericUpDown;
		private System.Windows.Forms.Button resetTransform_button;
		private System.Windows.Forms.PictureBox main_pictureBox;
		private System.Windows.Forms.Button resetOpacity_button;
		private System.Windows.Forms.TabPage rotate_tabPage;
		private System.Windows.Forms.Button rotateVertical_button;
		private System.Windows.Forms.Button rotateHorizontal_button;
		private System.Windows.Forms.Button rotateRight_button;
		private System.Windows.Forms.Button rotateLeft_button;
		private System.Windows.Forms.PictureBox opacity_pictureBox;
	}
}