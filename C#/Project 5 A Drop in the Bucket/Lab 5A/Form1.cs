using System;
using System.Drawing;
using System.Windows.Forms;

/*
 * Prepared by : Atta UL Saboor
 * Date : December 11, 2020
 * 
 * Program Purpose: 
 * The purpose of this program is to display a graphics object to graphically display a
 * liquid filling a bucket and use a timmer control to display the bucket contents as it
 * fills furthermore use a trackbar control to adjust the flow rate of the liquid and 
 * use the color dialog control.
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, 000395780 certify that this material is my original work. No other 
 * person's work has been used without due acknowledgement.
 * 
 */

namespace Lab_5A
{
	public partial class Form1 : Form
	{
		public Color selectedColor;         //store selected color
		public int speed;                   //store speed of falling liquid
		public int fillPosition = 455;      //store position liquied in box
		public int dropPosition = 260;      //store position of droping liquid
		public bool newBox = false;         //new box 
		public const int fillLimit = 350;	//store max fill limit for box

		/// <summary>
		/// constructor
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			this.Paint += new PaintEventHandler(DrawBox);
			selectedColor = Color.SkyBlue;	//default selected color
		}

		/// <summary>
		/// Draw box on form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawBox(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Pen pen = new Pen(Color.White);

			//draw Box
			graphics.DrawLine(pen, 100, 455, 100, 340);
			graphics.DrawLine(pen, 320, 455, 100, 455);
			graphics.DrawLine(pen, 320, 340, 320, 455);
		}

		/// <summary>
		/// Change Color button is clicked  set tht user selected color 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeColorBtn_Click(object sender, EventArgs e)
		{
			//selected color
			if (colorDialog1.ShowDialog() == DialogResult.OK)
				selectedColor = colorDialog1.Color;
		}

		/// <summary>
		/// Exit button is clicked close the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitBTN_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);		//close application
		}

		/// <summary>
		/// Track bar value changes set the draw speed and reset application when box is full
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void trackBar_Scroll(object sender, EventArgs e)
		{
			if(trackBar.Value > 0)
			{
				if (!newBox)
				{
					//set speed for fill the box
					switch (trackBar.Value)
					{
						case 1: speed = 250; break;
						case 2: speed = 200; break;
						case 3: speed = 150; break;
						case 4: speed = 125; break;
						case 5: speed = 100; break;
						case 6: speed = 50; break;
						default: speed = 20; break;
					}

					//enable timer
					timer1.Interval = speed;
					timer1.Enabled = true;
				}
				else ResetApplication();
			}
			else //hide droping water from tab
			{
				speed = 0;
				timer1.Enabled = false;     //stop timer

				//dropping tab water with black water hide it
				Graphics graphics = base.CreateGraphics();
				graphics.FillRectangle(new SolidBrush(Color.Black), 125, 195, 14, dropPosition);
			}
		}

		/// <summary>
		/// Application reset when box is full and set value to default
		/// </summary>
		private void ResetApplication()
		{
			newBox = false;             // reset new box 

			//water position reset
			fillPosition = 455;     // water in box
			dropPosition = 260;     // falling water from tap

			Graphics graphics = base.CreateGraphics();
			Pen pen = new Pen(Color.White);

			graphics.Clear(Color.Black);    // clear previous graphics

			//draw box
			graphics.DrawLine(pen, 100, 455, 100, 340);
			graphics.DrawLine(pen, 320, 455, 100, 455);
			graphics.DrawLine(pen, 320, 340, 320, 455);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (fillPosition != fillLimit)
			{
				fillPosition--;				// water update in box position
				dropPosition--;             // water falling update from tab position

				Graphics graphics = base.CreateGraphics();
				Pen pen = new Pen(selectedColor);

				// water in box
				graphics.DrawLine(pen, 319, fillPosition, 101, fillPosition);

				// falling water from tab
				graphics.FillRectangle(new SolidBrush(selectedColor), 125, 195, 14, dropPosition);
			}
			else        //box is full
			{
				timer1.Enabled = false;
				newBox = true;
				trackBar.Value = 0;

				// hide falling water when box full
				Graphics graphics = base.CreateGraphics();
				graphics.FillRectangle(new SolidBrush(Color.Black), 125, 195, 14, dropPosition);
			}
		}
	}
}
