using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Prepared by : Atta ul Saboor
 * Date : November 1, 2020
 * 
 * Program Purpose:
 * The purpose of this program is to make GUI interface that determines pricing for hair salon.
 * The user must Select one Hairdresser from combobox which has a different base rate and select
 * one or more services from listbox, which has a different rate.The add service button, calculate 
 * price button, reset button and total price label. 
 * 
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, certify that this material is  my original work. No ohter 
 * person's work has been used without acknowledgement.
 * 
 */

namespace Lab3B
{
	public partial class Form1 : Form
	{
		//Add hairdressers and services in listbox
		public Form1()
		{
			InitializeComponent();
			hairdresserCB.Items.Add("Jane Samley");
			hairdresserCB.Items.Add("Pat");
			hairdresserCB.Items.Add("Ron");
			hairdresserCB.Items.Add("Sue");
			hairdresserCB.Items.Add("Laurie");

			serviceLB.Items.Add("Cut");
			serviceLB.Items.Add("Wash, blow-dry, and style");
			serviceLB.Items.Add("Colour");
			serviceLB.Items.Add("Highlights");
			serviceLB.Items.Add("Extensions");
			serviceLB.Items.Add("Up-do");
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void exitBTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Clear the contents of the text box and list box
		/// </summary>
		/// <param name="sender">Default sender</param>
		/// <param name="e">Default event arguments</param>
		private void resetBTN_Click(object sender, EventArgs e)
		{
			serviceLB.ClearSelected();
			itemsLB.Items.Clear();
			priceLB.Items.Clear();
			priceTB.Clear();

			addserviceBTN.Enabled = true;
			calculatetotalpriceBTN.Enabled = false;
			hairdresserCB.Enabled = true;
		}
		/// <summary>
		/// Add services and hairdressers name and price
		/// </summary>
		/// <param name="sender">Default sender</param>
		/// <param name="e">Default event arguments</param>
		private void addserviceBTN_Click(object sender, EventArgs e)
		{
			addserviceBTN.Enabled = false;				// add service btn disable
			calculatetotalpriceBTN.Enabled = true;		// Calculate btn enable
			hairdresserCB.Enabled = false;				// hairdresser combo box disable

			if (hairdresserCB.Text != String.Empty)
			{// Add hairdresser price
				itemsLB.Items.Add(hairdresserCB.Text);
				if (hairdresserCB.Text == "Jane Samley") { priceLB.Items.Add("$30"); }
				if (hairdresserCB.Text == "Pat") { priceLB.Items.Add("$45"); }
				if (hairdresserCB.Text == "Ron") { priceLB.Items.Add("$40"); }
				if (hairdresserCB.Text == "Sue") { priceLB.Items.Add("$50"); }
				if (hairdresserCB.Text == "Laurie") { priceLB.Items.Add("$55"); }
			}
			if (serviceLB.Text != String.Empty)
			{
				foreach (int i in serviceLB.SelectedIndices)
				{//Add serives price
					itemsLB.Items.Add(serviceLB.Items[i]);
					if (serviceLB.Items[i].ToString() == "Cut") { priceLB.Items.Add("$30"); }
					if (serviceLB.Items[i].ToString() == "Wash, blow-dry, and style") { priceLB.Items.Add("$20"); }
					if (serviceLB.Items[i].ToString() == "Colour") { priceLB.Items.Add("$40"); }
					if (serviceLB.Items[i].ToString() == "Highlights") { priceLB.Items.Add("$50"); }
					if (serviceLB.Items[i].ToString() == "Extensions") { priceLB.Items.Add("$200"); }
					if (serviceLB.Items[i].ToString() == "Up-do") { priceLB.Items.Add("$60"); }
				}
			}
			else
			{
				MessageBox.Show("Please select the services");
			}
		}
		/// <summary>
		/// Calculate the sum in price list box
		/// </summary>
		/// <param name="sender">Default sender</param>
		/// <param name="e">Default event arguments</param>
		private void calculatetotalpriceBTN_Click(object sender, EventArgs e)
		{
			
			int total = 0;
			foreach (object item in priceLB.Items)
			{
				string price = item.ToString();
				price = price.Substring(1);
				total += Convert.ToInt32(price);
			}
			priceTB.Text = "$" + total.ToString();

		}

		private void serviceLB_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
