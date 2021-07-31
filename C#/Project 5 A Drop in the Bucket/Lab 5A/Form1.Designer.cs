
namespace Lab_5A
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.trackBar = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.changeColorBTN = new System.Windows.Forms.Button();
			this.closeBTN = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBar
			// 
			this.trackBar.Location = new System.Drawing.Point(55, 93);
			this.trackBar.Name = "trackBar";
			this.trackBar.Size = new System.Drawing.Size(104, 45);
			this.trackBar.TabIndex = 0;
			this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(55, 164);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 68);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// changeColorBTN
			// 
			this.changeColorBTN.BackColor = System.Drawing.Color.White;
			this.changeColorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changeColorBTN.Location = new System.Drawing.Point(55, 16);
			this.changeColorBTN.Name = "changeColorBTN";
			this.changeColorBTN.Size = new System.Drawing.Size(90, 25);
			this.changeColorBTN.TabIndex = 4;
			this.changeColorBTN.Text = "Colour";
			this.changeColorBTN.UseVisualStyleBackColor = false;
			this.changeColorBTN.Click += new System.EventHandler(this.changeColorBtn_Click);
			// 
			// closeBTN
			// 
			this.closeBTN.BackColor = System.Drawing.Color.White;
			this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeBTN.Location = new System.Drawing.Point(185, 17);
			this.closeBTN.Name = "closeBTN";
			this.closeBTN.Size = new System.Drawing.Size(90, 25);
			this.closeBTN.TabIndex = 5;
			this.closeBTN.Text = "Close";
			this.closeBTN.UseVisualStyleBackColor = false;
			this.closeBTN.Click += new System.EventHandler(this.exitBTN_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(352, 487);
			this.Controls.Add(this.closeBTN);
			this.Controls.Add(this.changeColorBTN);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.trackBar);
			this.Name = "Form1";
			this.Text = "A Drop in the Bucket";
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar trackBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button changeColorBTN;
		private System.Windows.Forms.Button closeBTN;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Timer timer1;
	}
}

