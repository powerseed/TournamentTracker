namespace TrackerUI
{
	partial class CreatePriceForm
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
			headerLabel = new Label();
			placeNumberValue = new TextBox();
			placeNumberLabel = new Label();
			placeNameValue = new TextBox();
			placeNameLabel = new Label();
			prizeAmountValue = new TextBox();
			prizeAmountLabel = new Label();
			prizePercentageValue = new TextBox();
			prizePercentageLabel = new Label();
			label1 = new Label();
			createPrizeButton = new Button();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
			headerLabel.Location = new Point(46, 40);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(281, 65);
			headerLabel.TabIndex = 2;
			headerLabel.Text = "Create Prize";
			// 
			// placeNumberValue
			// 
			placeNumberValue.Font = new Font("Segoe UI", 16F);
			placeNumberValue.Location = new Point(421, 160);
			placeNumberValue.Name = "placeNumberValue";
			placeNumberValue.Size = new Size(324, 71);
			placeNumberValue.TabIndex = 12;
			// 
			// placeNumberLabel
			// 
			placeNumberLabel.AutoSize = true;
			placeNumberLabel.Font = new Font("Segoe UI", 16F);
			placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
			placeNumberLabel.Location = new Point(46, 160);
			placeNumberLabel.Name = "placeNumberLabel";
			placeNumberLabel.Size = new Size(325, 65);
			placeNumberLabel.TabIndex = 11;
			placeNumberLabel.Text = "Place Number";
			// 
			// placeNameValue
			// 
			placeNameValue.Font = new Font("Segoe UI", 16F);
			placeNameValue.Location = new Point(421, 274);
			placeNameValue.Name = "placeNameValue";
			placeNameValue.Size = new Size(324, 71);
			placeNameValue.TabIndex = 14;
			// 
			// placeNameLabel
			// 
			placeNameLabel.AutoSize = true;
			placeNameLabel.Font = new Font("Segoe UI", 16F);
			placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
			placeNameLabel.Location = new Point(46, 274);
			placeNameLabel.Name = "placeNameLabel";
			placeNameLabel.Size = new Size(277, 65);
			placeNameLabel.TabIndex = 13;
			placeNameLabel.Text = "Place Name";
			// 
			// prizeAmountValue
			// 
			prizeAmountValue.Font = new Font("Segoe UI", 16F);
			prizeAmountValue.Location = new Point(421, 390);
			prizeAmountValue.Name = "prizeAmountValue";
			prizeAmountValue.Size = new Size(324, 71);
			prizeAmountValue.TabIndex = 16;
			// 
			// prizeAmountLabel
			// 
			prizeAmountLabel.AutoSize = true;
			prizeAmountLabel.Font = new Font("Segoe UI", 16F);
			prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
			prizeAmountLabel.Location = new Point(46, 390);
			prizeAmountLabel.Name = "prizeAmountLabel";
			prizeAmountLabel.Size = new Size(314, 65);
			prizeAmountLabel.TabIndex = 15;
			prizeAmountLabel.Text = "Prize Amount";
			// 
			// prizePercentageValue
			// 
			prizePercentageValue.Font = new Font("Segoe UI", 16F);
			prizePercentageValue.Location = new Point(421, 620);
			prizePercentageValue.Name = "prizePercentageValue";
			prizePercentageValue.Size = new Size(324, 71);
			prizePercentageValue.TabIndex = 18;
			// 
			// prizePercentageLabel
			// 
			prizePercentageLabel.AutoSize = true;
			prizePercentageLabel.Font = new Font("Segoe UI", 16F);
			prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
			prizePercentageLabel.Location = new Point(46, 620);
			prizePercentageLabel.Name = "prizePercentageLabel";
			prizePercentageLabel.Size = new Size(378, 65);
			prizePercentageLabel.TabIndex = 17;
			prizePercentageLabel.Text = "Prize Percentage";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.ForeColor = Color.FromArgb(51, 153, 255);
			label1.Location = new Point(350, 514);
			label1.Name = "label1";
			label1.Size = new Size(111, 65);
			label1.TabIndex = 15;
			label1.Text = "-or-";
			// 
			// createPrizeButton
			// 
			createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
			createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createPrizeButton.FlatStyle = FlatStyle.Flat;
			createPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
			createPrizeButton.Location = new Point(157, 746);
			createPrizeButton.Name = "createPrizeButton";
			createPrizeButton.Size = new Size(488, 106);
			createPrizeButton.TabIndex = 19;
			createPrizeButton.Text = "Create Prize";
			createPrizeButton.UseVisualStyleBackColor = true;
			createPrizeButton.Click += createPrizeButton_Click;
			// 
			// CreatePriceForm
			// 
			AutoScaleDimensions = new SizeF(16F, 35F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(835, 896);
			Controls.Add(createPrizeButton);
			Controls.Add(prizePercentageValue);
			Controls.Add(prizePercentageLabel);
			Controls.Add(prizeAmountValue);
			Controls.Add(label1);
			Controls.Add(prizeAmountLabel);
			Controls.Add(placeNameValue);
			Controls.Add(placeNameLabel);
			Controls.Add(placeNumberValue);
			Controls.Add(placeNumberLabel);
			Controls.Add(headerLabel);
			Name = "CreatePriceForm";
			Text = "Create Prize";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label headerLabel;
		private TextBox placeNumberValue;
		private Label placeNumberLabel;
		private TextBox placeNameValue;
		private Label placeNameLabel;
		private TextBox prizeAmountValue;
		private Label prizeAmountLabel;
		private TextBox prizePercentageValue;
		private Label prizePercentageLabel;
		private Label label1;
		private Button createPrizeButton;
	}
}