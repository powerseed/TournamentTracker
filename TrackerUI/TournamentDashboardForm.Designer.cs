namespace TrackerUI
{
	partial class TournamentDashboardForm
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
			loadExistingTournamentComboBox = new ComboBox();
			loadExistingTournamentLabel = new Label();
			loadTournamentButton = new Button();
			createTournamentButton = new Button();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
			headerLabel.Location = new Point(414, 133);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(523, 65);
			headerLabel.TabIndex = 3;
			headerLabel.Text = "Tournament Dashboard";
			// 
			// loadExistingTournamentComboBox
			// 
			loadExistingTournamentComboBox.Font = new Font("Segoe UI", 16F);
			loadExistingTournamentComboBox.FormattingEnabled = true;
			loadExistingTournamentComboBox.Location = new Point(353, 362);
			loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
			loadExistingTournamentComboBox.Size = new Size(644, 73);
			loadExistingTournamentComboBox.TabIndex = 13;
			// 
			// loadExistingTournamentLabel
			// 
			loadExistingTournamentLabel.AutoSize = true;
			loadExistingTournamentLabel.Font = new Font("Segoe UI", 16F);
			loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
			loadExistingTournamentLabel.Location = new Point(390, 294);
			loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
			loadExistingTournamentLabel.Size = new Size(570, 65);
			loadExistingTournamentLabel.TabIndex = 12;
			loadExistingTournamentLabel.Text = "Load Existing Tournament";
			// 
			// loadTournamentButton
			// 
			loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
			loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			loadTournamentButton.FlatStyle = FlatStyle.Flat;
			loadTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
			loadTournamentButton.Location = new Point(431, 503);
			loadTournamentButton.Name = "loadTournamentButton";
			loadTournamentButton.Size = new Size(488, 106);
			loadTournamentButton.TabIndex = 20;
			loadTournamentButton.Text = "Load Tournament";
			loadTournamentButton.UseVisualStyleBackColor = true;
			// 
			// createTournamentButton
			// 
			createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
			createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createTournamentButton.FlatStyle = FlatStyle.Flat;
			createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
			createTournamentButton.Location = new Point(431, 644);
			createTournamentButton.Name = "createTournamentButton";
			createTournamentButton.Size = new Size(488, 106);
			createTournamentButton.TabIndex = 21;
			createTournamentButton.Text = "Create Tournament";
			createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// TournamentDashboardForm
			// 
			AutoScaleDimensions = new SizeF(27F, 65F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1350, 836);
			Controls.Add(createTournamentButton);
			Controls.Add(loadTournamentButton);
			Controls.Add(loadExistingTournamentComboBox);
			Controls.Add(loadExistingTournamentLabel);
			Controls.Add(headerLabel);
			Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5, 6, 5, 6);
			Name = "TournamentDashboardForm";
			Text = "TournamentDashboardForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label headerLabel;
		private ComboBox loadExistingTournamentComboBox;
		private Label loadExistingTournamentLabel;
		private Button loadTournamentButton;
		private Button createTournamentButton;
	}
}