namespace Lab3B
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
			this.hairdresserGB = new System.Windows.Forms.GroupBox();
			this.hairdresserCB = new System.Windows.Forms.ComboBox();
			this.serviceGB = new System.Windows.Forms.GroupBox();
			this.serviceLB = new System.Windows.Forms.ListBox();
			this.itemsGB = new System.Windows.Forms.GroupBox();
			this.itemsLB = new System.Windows.Forms.ListBox();
			this.priceGB = new System.Windows.Forms.GroupBox();
			this.priceLB = new System.Windows.Forms.ListBox();
			this.totalpriceLB = new System.Windows.Forms.Label();
			this.exitBTN = new System.Windows.Forms.Button();
			this.resetBTN = new System.Windows.Forms.Button();
			this.calculatetotalpriceBTN = new System.Windows.Forms.Button();
			this.addserviceBTN = new System.Windows.Forms.Button();
			this.priceTB = new System.Windows.Forms.TextBox();
			this.hairdresserGB.SuspendLayout();
			this.serviceGB.SuspendLayout();
			this.itemsGB.SuspendLayout();
			this.priceGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// hairdresserGB
			// 
			this.hairdresserGB.Controls.Add(this.hairdresserCB);
			this.hairdresserGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hairdresserGB.Location = new System.Drawing.Point(12, 12);
			this.hairdresserGB.Name = "hairdresserGB";
			this.hairdresserGB.Size = new System.Drawing.Size(224, 242);
			this.hairdresserGB.TabIndex = 0;
			this.hairdresserGB.TabStop = false;
			this.hairdresserGB.Text = "Select a Hairdresser:";
			// 
			// hairdresserCB
			// 
			this.hairdresserCB.FormattingEnabled = true;
			this.hairdresserCB.Location = new System.Drawing.Point(6, 28);
			this.hairdresserCB.Name = "hairdresserCB";
			this.hairdresserCB.Size = new System.Drawing.Size(212, 28);
			this.hairdresserCB.TabIndex = 0;
			this.hairdresserCB.Text = "Jane Samley";
			// 
			// serviceGB
			// 
			this.serviceGB.Controls.Add(this.serviceLB);
			this.serviceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceGB.Location = new System.Drawing.Point(242, 12);
			this.serviceGB.Name = "serviceGB";
			this.serviceGB.Size = new System.Drawing.Size(264, 242);
			this.serviceGB.TabIndex = 1;
			this.serviceGB.TabStop = false;
			this.serviceGB.Text = "Select a Service:";
			// 
			// serviceLB
			// 
			this.serviceLB.FormattingEnabled = true;
			this.serviceLB.ItemHeight = 20;
			this.serviceLB.Location = new System.Drawing.Point(6, 28);
			this.serviceLB.Name = "serviceLB";
			this.serviceLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.serviceLB.Size = new System.Drawing.Size(252, 204);
			this.serviceLB.TabIndex = 0;
			this.serviceLB.SelectedIndexChanged += new System.EventHandler(this.serviceLB_SelectedIndexChanged);
			// 
			// itemsGB
			// 
			this.itemsGB.Controls.Add(this.itemsLB);
			this.itemsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemsGB.Location = new System.Drawing.Point(512, 12);
			this.itemsGB.Name = "itemsGB";
			this.itemsGB.Size = new System.Drawing.Size(264, 242);
			this.itemsGB.TabIndex = 1;
			this.itemsGB.TabStop = false;
			this.itemsGB.Text = "Charged Items:";
			// 
			// itemsLB
			// 
			this.itemsLB.Enabled = false;
			this.itemsLB.FormattingEnabled = true;
			this.itemsLB.ItemHeight = 20;
			this.itemsLB.Location = new System.Drawing.Point(6, 28);
			this.itemsLB.Name = "itemsLB";
			this.itemsLB.Size = new System.Drawing.Size(252, 204);
			this.itemsLB.TabIndex = 1;
			// 
			// priceGB
			// 
			this.priceGB.Controls.Add(this.priceLB);
			this.priceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceGB.Location = new System.Drawing.Point(782, 12);
			this.priceGB.Name = "priceGB";
			this.priceGB.Size = new System.Drawing.Size(128, 242);
			this.priceGB.TabIndex = 1;
			this.priceGB.TabStop = false;
			this.priceGB.Text = "Price";
			// 
			// priceLB
			// 
			this.priceLB.Enabled = false;
			this.priceLB.FormattingEnabled = true;
			this.priceLB.ItemHeight = 20;
			this.priceLB.Location = new System.Drawing.Point(6, 26);
			this.priceLB.Name = "priceLB";
			this.priceLB.Size = new System.Drawing.Size(116, 204);
			this.priceLB.TabIndex = 1;
			// 
			// totalpriceLB
			// 
			this.totalpriceLB.AutoSize = true;
			this.totalpriceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalpriceLB.Location = new System.Drawing.Point(668, 273);
			this.totalpriceLB.Name = "totalpriceLB";
			this.totalpriceLB.Size = new System.Drawing.Size(102, 22);
			this.totalpriceLB.TabIndex = 2;
			this.totalpriceLB.Text = "Total Price:";
			// 
			// exitBTN
			// 
			this.exitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBTN.Location = new System.Drawing.Point(725, 308);
			this.exitBTN.Name = "exitBTN";
			this.exitBTN.Size = new System.Drawing.Size(189, 36);
			this.exitBTN.TabIndex = 4;
			this.exitBTN.Text = "Exit";
			this.exitBTN.UseVisualStyleBackColor = true;
			this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
			// 
			// resetBTN
			// 
			this.resetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBTN.Location = new System.Drawing.Point(527, 308);
			this.resetBTN.Name = "resetBTN";
			this.resetBTN.Size = new System.Drawing.Size(189, 36);
			this.resetBTN.TabIndex = 5;
			this.resetBTN.Text = "Reset";
			this.resetBTN.UseVisualStyleBackColor = true;
			this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
			// 
			// calculatetotalpriceBTN
			// 
			this.calculatetotalpriceBTN.Enabled = false;
			this.calculatetotalpriceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculatetotalpriceBTN.Location = new System.Drawing.Point(329, 308);
			this.calculatetotalpriceBTN.Name = "calculatetotalpriceBTN";
			this.calculatetotalpriceBTN.Size = new System.Drawing.Size(189, 36);
			this.calculatetotalpriceBTN.TabIndex = 6;
			this.calculatetotalpriceBTN.Text = "Calculate Total Price";
			this.calculatetotalpriceBTN.UseVisualStyleBackColor = true;
			this.calculatetotalpriceBTN.Click += new System.EventHandler(this.calculatetotalpriceBTN_Click);
			// 
			// addserviceBTN
			// 
			this.addserviceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addserviceBTN.Location = new System.Drawing.Point(131, 307);
			this.addserviceBTN.Name = "addserviceBTN";
			this.addserviceBTN.Size = new System.Drawing.Size(189, 36);
			this.addserviceBTN.TabIndex = 7;
			this.addserviceBTN.Text = "Add Service";
			this.addserviceBTN.UseVisualStyleBackColor = true;
			this.addserviceBTN.Click += new System.EventHandler(this.addserviceBTN_Click);
			// 
			// priceTB
			// 
			this.priceTB.BackColor = System.Drawing.SystemColors.Menu;
			this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceTB.Location = new System.Drawing.Point(782, 270);
			this.priceTB.Name = "priceTB";
			this.priceTB.Size = new System.Drawing.Size(128, 26);
			this.priceTB.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 356);
			this.Controls.Add(this.addserviceBTN);
			this.Controls.Add(this.calculatetotalpriceBTN);
			this.Controls.Add(this.resetBTN);
			this.Controls.Add(this.exitBTN);
			this.Controls.Add(this.priceTB);
			this.Controls.Add(this.totalpriceLB);
			this.Controls.Add(this.priceGB);
			this.Controls.Add(this.itemsGB);
			this.Controls.Add(this.serviceGB);
			this.Controls.Add(this.hairdresserGB);
			this.Name = "Form1";
			this.Text = "Perfect Hair Cut Salon";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.hairdresserGB.ResumeLayout(false);
			this.serviceGB.ResumeLayout(false);
			this.itemsGB.ResumeLayout(false);
			this.priceGB.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox hairdresserGB;
		private System.Windows.Forms.ComboBox hairdresserCB;
		private System.Windows.Forms.GroupBox serviceGB;
		private System.Windows.Forms.GroupBox itemsGB;
		private System.Windows.Forms.GroupBox priceGB;
		private System.Windows.Forms.Label totalpriceLB;
		private System.Windows.Forms.Button exitBTN;
		private System.Windows.Forms.Button resetBTN;
		private System.Windows.Forms.Button calculatetotalpriceBTN;
		private System.Windows.Forms.Button addserviceBTN;
		private System.Windows.Forms.ListBox serviceLB;
		private System.Windows.Forms.ListBox itemsLB;
		private System.Windows.Forms.ListBox priceLB;
		private System.Windows.Forms.TextBox priceTB;
	}
}

