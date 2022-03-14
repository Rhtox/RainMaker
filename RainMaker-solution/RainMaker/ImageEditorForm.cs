using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace RainMaker {
	public partial class ImageEditorForm : Form {
		//----------------------------------------------
		//			declaring global variables			
		//----------------------------------------------
		private Image IMG = null;
		private Size MOD_IMG_SIZE;
		private int ROTATION_VALUE = 0;
		private bool SETTINGS_LOCK = true;
		private bool HORIZONTAL_FLIP = false;
		private bool VERTICAL_FLIP = false;

		public ImageEditorForm() {
			InitializeComponent();

			AppManagerClass.WriteLogEntry("NULL", "==========================================================", "NULL");

			// load theme
			try {
				switch(AppManagerClass.Theme) {
					//--------------------------
					//			dark			
					//--------------------------
					case "dark":
						// form
						this.BackColor = Color.FromArgb(40, 40, 40);

						// menu strip
						menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
						menuStrip1.ForeColor = Color.White;
						fileToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						fileToolStripMenuItem.ForeColor = Color.White;
						saveToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						saveToolStripMenuItem.ForeColor = Color.White;
						exitToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
						exitToolStripMenuItem.ForeColor = Color.White;

						// transform tabpage
						transform_tabPage.BackColor = Color.FromArgb(40, 40, 40);
						// scale label
						scale_label.ForeColor = Color.White;
						// scale numUpDown
						scale_numericUpDown.BackColor = Color.FromArgb(64, 64, 64);
						scale_numericUpDown.ForeColor = Color.White;
						// percent label
						percent_label.ForeColor = Color.White;
						// width label
						width_label.ForeColor = Color.White;
						// width numUpDown
						width_numericUpDown.BackColor = Color.FromArgb(64, 64, 64);
						width_numericUpDown.ForeColor = Color.White;
						// pixel label 1
						px_label1.ForeColor = Color.White;
						// height label
						height_label.ForeColor = Color.White;
						// height numUpDown
						height_numericUpDown.BackColor = Color.FromArgb(64, 64, 64);
						height_numericUpDown.ForeColor = Color.White;
						// pixel label 2
						px_label2.ForeColor = Color.White;
						// apply button
						applyTransform_button.BackColor = Color.FromArgb(64, 64, 64);
						applyTransform_button.ForeColor = Color.White;
						applyTransform_button.FlatStyle = FlatStyle.Popup;
						// cancel button
						resetTransform_button.BackColor = Color.FromArgb(64, 64, 64);
						resetTransform_button.ForeColor = Color.White;
						resetTransform_button.FlatStyle = FlatStyle.Popup;

						// opacity tabpage
						opacity_tabPage.BackColor = Color.FromArgb(40, 40, 40);
						// opacity label
						opacity_label.ForeColor = Color.White;
						// opacity numUpDown
						opacity_numericUpDown.BackColor = Color.FromArgb(64, 64, 64);
						opacity_numericUpDown.ForeColor = Color.White;
						// apply button
						applyOpacity_button.BackColor = Color.FromArgb(64, 64, 64);
						applyOpacity_button.ForeColor = Color.White;
						applyOpacity_button.FlatStyle = FlatStyle.Popup;
						// cancel button
						resetOpacity_button.BackColor = Color.FromArgb(64, 64, 64);
						resetOpacity_button.ForeColor = Color.White;
						resetOpacity_button.FlatStyle = FlatStyle.Popup;

						// rotate tabpage
						rotate_tabPage.BackColor = Color.FromArgb(40, 40, 40);
						// left button
						rotateLeft_button.BackColor = Color.FromArgb(64, 64, 64);
						rotateLeft_button.ForeColor = Color.White;
						rotateLeft_button.FlatStyle = FlatStyle.Popup;
						// right button
						rotateRight_button.BackColor = Color.FromArgb(64, 64, 64);
						rotateRight_button.ForeColor = Color.White;
						rotateRight_button.FlatStyle = FlatStyle.Popup;
						// horizontal button
						rotateHorizontal_button.BackColor = Color.FromArgb(64, 64, 64);
						rotateHorizontal_button.ForeColor = Color.White;
						rotateHorizontal_button.FlatStyle = FlatStyle.Popup;
						// vertical button
						rotateVertical_button.BackColor = Color.FromArgb(64, 64, 64);
						rotateVertical_button.ForeColor = Color.White;
						rotateVertical_button.FlatStyle = FlatStyle.Popup;
						break;
					//--------------------------
					//			light			
					//--------------------------
					case "light":
						// form
						this.BackColor = Color.White;

						// menu strip
						menuStrip1.BackColor = Color.White;
						menuStrip1.ForeColor = Color.Black;
						fileToolStripMenuItem.BackColor = Color.White;
						fileToolStripMenuItem.ForeColor = Color.Black;
						saveToolStripMenuItem.BackColor = Color.White;
						saveToolStripMenuItem.ForeColor = Color.Black;
						exitToolStripMenuItem.BackColor = Color.White;
						exitToolStripMenuItem.ForeColor = Color.Black;

						// transform tabpage
						transform_tabPage.BackColor = Color.White;
						// scale label
						scale_label.ForeColor = Color.Black;
						// scale numUpDown
						scale_numericUpDown.BackColor = Color.White;
						scale_numericUpDown.ForeColor = Color.Black;
						// percent label
						percent_label.ForeColor = Color.Black;
						// width label
						width_label.ForeColor = Color.Black;
						// width numUpDown
						width_numericUpDown.BackColor = Color.White;
						width_numericUpDown.ForeColor = Color.Black;
						// pixel label 1
						px_label1.ForeColor = Color.Black;
						// height label
						height_label.ForeColor = Color.Black;
						// height numUpDown
						height_numericUpDown.BackColor = Color.White;
						height_numericUpDown.ForeColor = Color.Black;
						// pixel label 2
						px_label2.ForeColor = Color.Black;
						// apply button
						applyTransform_button.BackColor = Color.White;
						applyTransform_button.ForeColor = Color.Black;
						applyTransform_button.FlatStyle = FlatStyle.System;
						// cancel button
						resetTransform_button.BackColor = Color.White;
						resetTransform_button.ForeColor = Color.Black;
						resetTransform_button.FlatStyle = FlatStyle.System;

						// opacity tabpage
						opacity_tabPage.BackColor = Color.White;
						// opacity label
						opacity_label.ForeColor = Color.Black;
						// opacity numUpDown
						opacity_numericUpDown.BackColor = Color.White;
						opacity_numericUpDown.ForeColor = Color.Black;
						// apply button
						applyOpacity_button.BackColor = Color.White;
						applyOpacity_button.ForeColor = Color.Black;
						applyOpacity_button.FlatStyle = FlatStyle.System;
						// cancel button
						resetOpacity_button.BackColor = Color.White;
						resetOpacity_button.ForeColor = Color.Black;
						resetOpacity_button.FlatStyle = FlatStyle.System;

						// rotate tabpage
						rotate_tabPage.BackColor = Color.White;
						// left button
						rotateLeft_button.BackColor = Color.White;
						rotateLeft_button.ForeColor = Color.Black;
						rotateLeft_button.FlatStyle = FlatStyle.System;
						// right button
						rotateRight_button.BackColor = Color.White;
						rotateRight_button.ForeColor = Color.Black;
						rotateRight_button.FlatStyle = FlatStyle.System;
						// horizontal button
						rotateHorizontal_button.BackColor = Color.White;
						rotateHorizontal_button.ForeColor = Color.Black;
						rotateHorizontal_button.FlatStyle = FlatStyle.System;
						// vertical button
						rotateVertical_button.BackColor = Color.White;
						rotateVertical_button.ForeColor = Color.Black;
						rotateVertical_button.FlatStyle = FlatStyle.System;
						break;
					default:
						AppManagerClass.ErrorMsg();
						break;
				}

				AppManagerClass.WriteLogEntry("ImageEdit", "Loading theme", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Loading theme", "Failed");
			}

			// tries to load background, if not selected tries to load bar
			try {
				if(SkinSettings.BackgroundCheck == true) {
					IMG = Image.FromFile(SkinSettings.BackgroundPath);
				} else if(SkinSettings.BarCheck == true) {
					IMG = Image.FromFile(SkinSettings.BarPath);
				}

				AppManagerClass.WriteLogEntry("ImageEdit", "Loading image", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Loading image", "Failed");
			}

			try {
				main_pictureBox.Width = IMG.Width;
				main_pictureBox.Height = IMG.Height;
				main_pictureBox.Image = IMG;
				opacity_pictureBox.BackgroundImage = IMG;

				scale_hScrollBar.Value = 100;
				scale_numericUpDown.Value = 100;
				width_numericUpDown.Value = IMG.Width;
				height_numericUpDown.Value = IMG.Height;
				opacity_hScrollBar.Value = 255;
				opacity_numericUpDown.Value = 255;

				ROTATION_VALUE = 0;

				SETTINGS_LOCK = false;
				SetAllTrue();

				AppManagerClass.WriteLogEntry("ImageEdit", "Setting form", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Setting form", "Failed");
			}
		}

		//------------------------------------------
		//			saves preview values			
		//------------------------------------------
		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				if(main_pictureBox.Image != null) {
					SkinSettings.SkinWidth = Convert.ToInt32(width_numericUpDown.Value);
					SkinSettings.SkinHeight = Convert.ToInt32(height_numericUpDown.Value);
					SkinSettings.SkinOpacity = Convert.ToInt32(opacity_numericUpDown.Value);
					SkinSettings.SkinRotation = ROTATION_VALUE;
					SkinSettings.SkinHorizontalFlip = HORIZONTAL_FLIP;
					SkinSettings.SkinVerticalFlip = VERTICAL_FLIP;

					SkinList.SkinAdd(SkinList.WriteType);

					AppManagerClass.WriteLogEntry("ImageEdit", "Saving changes", "Successful");
				}
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Saving changes", "Failed");
			}
		}

		//------------------------------------------------------
		//			scale hScrollBar and numUpDown sync			
		//------------------------------------------------------
		private void Scale_hScrollBar_Scroll(object sender, ScrollEventArgs e) {
			try {
				//syncs value
				scale_numericUpDown.Value = scale_hScrollBar.Value;

				// sets other controls off
				if(SETTINGS_LOCK == false) {
					SETTINGS_LOCK = true;

					width_numericUpDown.Enabled = false;
					height_numericUpDown.Enabled = false;

					rotateLeft_button.Enabled = false;
					rotateRight_button.Enabled = false;
					rotateHorizontal_button.Enabled = false;
					rotateVertical_button.Enabled = false;
				}
			} catch { 
				AppManagerClass.ErrorMsg("Failed to synchronize scale."); 
			}
		}

		//--------------------------------------------------------------
		//			alpha_ch hScrollBar and numUpDown sync			
		//--------------------------------------------------------------
		private void AlphaCh_hScrollBar_Scroll(object sender, ScrollEventArgs e) {
			try {
				// syncs value
				opacity_numericUpDown.Value = opacity_hScrollBar.Value;

				// sets other controls off
				if(SETTINGS_LOCK == false) {
					SETTINGS_LOCK = true;

					scale_hScrollBar.Enabled = false;

					scale_numericUpDown.Enabled = false;
					width_numericUpDown.Enabled = false;
					height_numericUpDown.Enabled = false;

					rotateLeft_button.Enabled = false;
					rotateRight_button.Enabled = false;
					rotateHorizontal_button.Enabled = false;
					rotateVertical_button.Enabled = false;
				}
			} catch { 
				AppManagerClass.ErrorMsg("Failed to synchronize opacity.");
			}
		}

		//--------------------------
		//			scaling			
		//--------------------------
		private void Scale_numericUpDown_ValueChanged(object sender, EventArgs e) {
			// sets other controls off
			if(SETTINGS_LOCK == false) {
				SETTINGS_LOCK = true;

				width_numericUpDown.Enabled = false;
				height_numericUpDown.Enabled = false;

				rotateLeft_button.Enabled = false;
				rotateRight_button.Enabled = false;
				rotateHorizontal_button.Enabled = false;
				rotateVertical_button.Enabled = false;
			}

			try {
				// sets new values to bitmap
				MOD_IMG_SIZE = new Size((Convert.ToInt32(width_numericUpDown.Value) * Convert.ToInt32(scale_numericUpDown.Value)) / 100, (Convert.ToInt32(height_numericUpDown.Value) * Convert.ToInt32(scale_numericUpDown.Value)) / 100);
			} catch { 
				AppManagerClass.ErrorMsg("Failed to change scale."); 
			}

		}

		//--------------------------
		//			width			
		//--------------------------
		private void Width_numericUpDown_ValueChanged(object sender, EventArgs e) {
			// sets other controls off
			if(SETTINGS_LOCK == false) {
				SETTINGS_LOCK = true;

				scale_hScrollBar.Enabled = false;

				scale_numericUpDown.Enabled = false;

				rotateLeft_button.Enabled = false;
				rotateRight_button.Enabled = false;
				rotateHorizontal_button.Enabled = false;
				rotateVertical_button.Enabled = false;
			}

			try {
				// sets new values to bitmap
				MOD_IMG_SIZE = new Size(Convert.ToInt32(width_numericUpDown.Value), Convert.ToInt32(height_numericUpDown.Value));
			} catch { 
				AppManagerClass.ErrorMsg("Failed to change width.");
			}
		}

		//--------------------------
		//			height			
		//--------------------------
		private void Height_numericUpDown_ValueChanged(object sender, EventArgs e) {
			// sets other controls off
			if(SETTINGS_LOCK == false) {
				SETTINGS_LOCK = true;

				scale_hScrollBar.Enabled = false;

				scale_numericUpDown.Enabled = false;

				rotateLeft_button.Enabled = false;
				rotateRight_button.Enabled = false;
				rotateHorizontal_button.Enabled = false;
				rotateVertical_button.Enabled = false;
			}

			try {
				// sets new values to bitmap
				MOD_IMG_SIZE = new Size(Convert.ToInt32(width_numericUpDown.Value), Convert.ToInt32(height_numericUpDown.Value));
			} catch { 
				AppManagerClass.ErrorMsg("Failed to change height."); 
			}
		}

		//------------------------------
		//			alpha_ch			
		//------------------------------
		private void AlphaCh_numericUpDown_ValueChanged(object sender, EventArgs e) {
			// sets other controls off
			if(SETTINGS_LOCK == false) {
				SETTINGS_LOCK = true;

				scale_hScrollBar.Enabled = false;

				width_numericUpDown.Enabled = false;
				height_numericUpDown.Enabled = false;
				scale_numericUpDown.Enabled = false;

				rotateLeft_button.Enabled = false;
				rotateRight_button.Enabled = false;
				rotateHorizontal_button.Enabled = false;
				rotateVertical_button.Enabled = false;
			}
		}

		//------------------------------------------
		//			apply TRANSFORM changes			
		//------------------------------------------
		private void ApplyTransform_button_Click(object sender, EventArgs e) {
			try {
				// bitmaps
				Bitmap bmSource = new Bitmap(main_pictureBox.Image);
				Bitmap bmDest = new Bitmap(Convert.ToInt32(MOD_IMG_SIZE.Width), Convert.ToInt32(MOD_IMG_SIZE.Height));
					
				// draws image
				Graphics grDest = Graphics.FromImage(bmDest);
				grDest.DrawImage(bmSource, 0, 0, bmDest.Width, bmDest.Height);

				// sets picturebox
				main_pictureBox.Image = bmDest;				
				main_pictureBox.Width = bmDest.Width;
				main_pictureBox.Height = bmDest.Height;

				// changes to new values
				width_numericUpDown.Value = bmDest.Width;
				height_numericUpDown.Value = bmDest.Height;

				// saves new values
				SkinSettings.SkinWidth = bmDest.Width;
				SkinSettings.SkinHeight = bmDest.Height;

				// resets values
				if(scale_numericUpDown.Value != 100) {
					scale_numericUpDown.Value = 100;
					scale_hScrollBar.Value = 100;
				}

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				AppManagerClass.WriteLogEntry("ImageEdit", "Applying transformation", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Applying transformation", "Failed");
				AppManagerClass.ErrorMsg("Failed to apply changes."); 
			} 
		}

		//----------------------------------------------
		//			apply ALPHA_CH changes			
		//----------------------------------------------
		private void ApplyAlphaCh_button_Click(object sender, EventArgs e) {
			try {
				// defines variables
				Bitmap bmSource = new Bitmap(IMG);
				Bitmap bmDest = new Bitmap(Convert.ToInt32(IMG.Width), Convert.ToInt32(IMG.Height));				
				Rectangle r = new Rectangle(0, 0, bmSource.Width, bmSource.Height);
				float alphaChValue = Convert.ToInt32(opacity_numericUpDown.Value) / 255f;
				float[][] colorMatrixElements = {
						new float[] {1, 0, 0, 0, 0},
						new float[] {0, 1, 0, 0, 0},
						new float[] {0, 0, 1, 0, 0},
						new float[] {0, 0, 0, alphaChValue, 0},
						new float[] {0, 0, 0, 0, 1}
				};
				ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
				ImageAttributes imageAttributes = new ImageAttributes();
				imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

				// draws image
				Graphics grDest = Graphics.FromImage(bmDest);
				grDest.DrawImage(bmSource, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAttributes);

				// changes image
				opacity_pictureBox.BackColor = Color.Transparent;
				opacity_pictureBox.BackgroundImage = bmDest;

				// saves AlphaCh value
				SkinSettings.SkinOpacity = Convert.ToInt32(opacity_numericUpDown.Value);

				// releases all resources from graphic
				grDest.Dispose();

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				AppManagerClass.WriteLogEntry("ImageEdit", "Applying opacity", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Applying opacity", "Failed");
				AppManagerClass.ErrorMsg("Failed to apply opacity."); 
			}
		}

		//----------------------------------------------------------------------
		//			resets TRANSFORM hScrollBar and numUpDown values			
		//----------------------------------------------------------------------
		private void ResetTransform_button_Click(object sender, EventArgs e) {
			try {
				// cancels changes
				width_numericUpDown.Value = MOD_IMG_SIZE.Width;
				height_numericUpDown.Value = MOD_IMG_SIZE.Height;

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				AppManagerClass.WriteLogEntry("ImageEdit", "Reseting transformation", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Reseting transformation", "Failed");
			}
		}

		//----------------------------------------------------------------------
		//			resets ALPHA_CH hScrollBar and numUpDown values			
		//----------------------------------------------------------------------
		private void ResetAlphaCh_button_Click(object sender, EventArgs e) {
			try {
				// cancels changes
				if(main_pictureBox.Image == null) {
					opacity_numericUpDown.Value = 255;
					opacity_hScrollBar.Value = 255;
				} else {
					opacity_numericUpDown.Value = SkinSettings.SkinOpacity;
					opacity_hScrollBar.Value = SkinSettings.SkinOpacity;
				}

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				AppManagerClass.WriteLogEntry("ImageEdit", "Reseting opacity", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Reseting opacity", "Failed");
			}
		}

		//--------------------------------------------------------------
		//			sets ALL hScrollBars and numUpDown to TRUE			
		//--------------------------------------------------------------
		private void SetAllTrue() {
			// hScrollBar
			scale_hScrollBar.Enabled = true;
			opacity_hScrollBar.Enabled = true;
			// numUpDown
			scale_numericUpDown.Enabled = true;
			width_numericUpDown.Enabled = true;
			height_numericUpDown.Enabled = true;
			opacity_numericUpDown.Enabled = true;
			// rotate buttons
			rotateLeft_button.Enabled = true;
			rotateRight_button.Enabled = true;
			rotateHorizontal_button.Enabled = true;
			rotateVertical_button.Enabled = true;
		}

		//------------------------------
		//			rotate LEFT			
		//------------------------------
		private void RotateLeft_button_Click(object sender, EventArgs e) {
			try {
				// rotates image in pictureBox1
				main_pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

				// inverts width and height
				int a = Convert.ToInt32(width_numericUpDown.Value);
				int b = Convert.ToInt32(height_numericUpDown.Value);

				a = a * b;
				b = a / b;
				a = a / b;

				width_numericUpDown.Value = a;
				height_numericUpDown.Value = b;

				// sets inverted values
				main_pictureBox.Width = a;
				main_pictureBox.Height = b;
				// refreshes picturebox
				main_pictureBox.Refresh();

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				// changes rotaion value and saves it
				ROTATION_VALUE -= 90;
				if(ROTATION_VALUE == -360)
					ROTATION_VALUE = 0;
				SkinSettings.SkinRotation = ROTATION_VALUE;

				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating left", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating left", "Failed");
				AppManagerClass.ErrorMsg("Failed to rotate left."); 
			}
		}

		//------------------------------
		//			rotate RIGHT			
		//------------------------------
		private void RotateRight_button_Click(object sender, EventArgs e) {
			try {
				// rotates image in pictureBox1
				main_pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

				// inverts width and height
				int a = Convert.ToInt32(width_numericUpDown.Value);
				int b = Convert.ToInt32(height_numericUpDown.Value);

				a = a * b;
				b = a / b;
				a = a / b;

				width_numericUpDown.Value = a;
				height_numericUpDown.Value = b;

				// sets inverted values
				main_pictureBox.Width = a;
				main_pictureBox.Height = b;
				// refreshes picturebox
				main_pictureBox.Refresh();

				// sets all controls on
				SETTINGS_LOCK = false;
				SetAllTrue();

				// changes rotaion value and saves it
				ROTATION_VALUE += 90;
				if(ROTATION_VALUE == 360)
					ROTATION_VALUE = 0;
				SkinSettings.SkinRotation = ROTATION_VALUE;

				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating right", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating right", "Failed");
				AppManagerClass.ErrorMsg("Failed to rotate right."); 
			}
		}

		//--------------------------------------
		//			rotate HORIZONTAL			
		//--------------------------------------
		private void RotateHorizontal_button_Click(object sender, EventArgs e) {
			try {
				// sets if image is fliped
				switch(HORIZONTAL_FLIP) {
					case true:
						HORIZONTAL_FLIP = false;
						break;
					case false:
						HORIZONTAL_FLIP = true;
						break;
				}

				// flips image and refreshes pictureBox1
				main_pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
				main_pictureBox.Refresh();

				// saves value
				SkinSettings.SkinHorizontalFlip = HORIZONTAL_FLIP;

				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating horizontaly", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating horizontaly", "Failed");
				AppManagerClass.ErrorMsg("Failed to flip horizontaly."); 
			}
		}

		//----------------------------------
		//			rotate VERTICAL			
		//----------------------------------
		private void RotateVertical_button_Click(object sender, EventArgs e) {
			try {
				// sets if image is flipped
				switch(VERTICAL_FLIP) {
					case true:
						VERTICAL_FLIP = false;
						break;
					case false:
						VERTICAL_FLIP = true;
						break;
				}

				// flips image and refreshes picturebox1
				main_pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
				main_pictureBox.Refresh();

				// saves value
				SkinSettings.SkinVerticalFlip = VERTICAL_FLIP;

				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating verticaly", "Successful");
			} catch {
				AppManagerClass.WriteLogEntry("ImageEdit", "Rotating verticaly", "Failed");
				AppManagerClass.ErrorMsg("Failed to flip verticaly."); 
			}
		}

		//----------------------------------
		//			closes window			
		//----------------------------------
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			AppManagerClass.WriteLogEntry("NULL", "==========================================================", "NULL");
			this.Close();
		}
    }
}
