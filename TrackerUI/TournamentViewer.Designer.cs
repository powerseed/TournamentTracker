namespace TrackerUI
{
	partial class tournamentViewer
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			headerLabel = new Label();
			tournamentName = new Label();
			roundLabel = new Label();
			comboBox1 = new ComboBox();
			unplayedOnlyCheckbox = new CheckBox();
			MatchupListbox = new ListBox();
			teamOneName = new Label();
			teamOneScoreLabel = new Label();
			teamOneScoreValue = new TextBox();
			teamTwoName = new Label();
			teamTwoScoreLabel = new Label();
			teamTwoScoreValue = new TextBox();
			versusLabel = new Label();
			scoreButton = new Button();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
			headerLabel.Location = new Point(56, 31);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(290, 65);
			headerLabel.TabIndex = 0;
			headerLabel.Text = "Tournament:";
			// 
			// tournamentName
			// 
			tournamentName.AutoSize = true;
			tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
			tournamentName.Location = new Point(340, 31);
			tournamentName.Name = "tournamentName";
			tournamentName.Size = new Size(201, 65);
			tournamentName.TabIndex = 0;
			tournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			roundLabel.AutoSize = true;
			roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
			roundLabel.Location = new Point(56, 120);
			roundLabel.Name = "roundLabel";
			roundLabel.Size = new Size(166, 65);
			roundLabel.TabIndex = 1;
			roundLabel.Text = "Round";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(228, 112);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(360, 73);
			comboBox1.TabIndex = 2;
			// 
			// unplayedOnlyCheckbox
			// 
			unplayedOnlyCheckbox.AutoSize = true;
			unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
			unplayedOnlyCheckbox.ForeColor = Color.FromArgb(51, 135, 255);
			unplayedOnlyCheckbox.Location = new Point(228, 191);
			unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			unplayedOnlyCheckbox.Size = new Size(368, 69);
			unplayedOnlyCheckbox.TabIndex = 3;
			unplayedOnlyCheckbox.Text = "Unplayed Only";
			unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// MatchupListbox
			// 
			MatchupListbox.FormattingEnabled = true;
			MatchupListbox.ItemHeight = 65;
			MatchupListbox.Location = new Point(56, 290);
			MatchupListbox.Name = "MatchupListbox";
			MatchupListbox.Size = new Size(532, 459);
			MatchupListbox.TabIndex = 4;
			// 
			// teamOneName
			// 
			teamOneName.AutoSize = true;
			teamOneName.ForeColor = Color.FromArgb(51, 153, 255);
			teamOneName.Location = new Point(726, 290);
			teamOneName.Name = "teamOneName";
			teamOneName.Size = new Size(293, 65);
			teamOneName.TabIndex = 1;
			teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			teamOneScoreLabel.AutoSize = true;
			teamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
			teamOneScoreLabel.Location = new Point(726, 371);
			teamOneScoreLabel.Name = "teamOneScoreLabel";
			teamOneScoreLabel.Size = new Size(146, 65);
			teamOneScoreLabel.TabIndex = 1;
			teamOneScoreLabel.Text = "Score";
			// 
			// teamOneScoreValue
			// 
			teamOneScoreValue.Location = new Point(878, 371);
			teamOneScoreValue.Name = "teamOneScoreValue";
			teamOneScoreValue.Size = new Size(225, 71);
			teamOneScoreValue.TabIndex = 5;
			// 
			// teamTwoName
			// 
			teamTwoName.AutoSize = true;
			teamTwoName.ForeColor = Color.FromArgb(51, 153, 255);
			teamTwoName.Location = new Point(726, 573);
			teamTwoName.Name = "teamTwoName";
			teamTwoName.Size = new Size(293, 65);
			teamTwoName.TabIndex = 1;
			teamTwoName.Text = "<team one>";
			// 
			// teamTwoScoreLabel
			// 
			teamTwoScoreLabel.AutoSize = true;
			teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
			teamTwoScoreLabel.Location = new Point(726, 654);
			teamTwoScoreLabel.Name = "teamTwoScoreLabel";
			teamTwoScoreLabel.Size = new Size(146, 65);
			teamTwoScoreLabel.TabIndex = 1;
			teamTwoScoreLabel.Text = "Score";
			// 
			// teamTwoScoreValue
			// 
			teamTwoScoreValue.Location = new Point(878, 654);
			teamTwoScoreValue.Name = "teamTwoScoreValue";
			teamTwoScoreValue.Size = new Size(225, 71);
			teamTwoScoreValue.TabIndex = 5;
			// 
			// versusLabel
			// 
			versusLabel.AutoSize = true;
			versusLabel.ForeColor = Color.FromArgb(51, 153, 255);
			versusLabel.Location = new Point(863, 485);
			versusLabel.Name = "versusLabel";
			versusLabel.Size = new Size(122, 65);
			versusLabel.TabIndex = 1;
			versusLabel.Text = "-VS-";
			// 
			// scoreButton
			// 
			scoreButton.FlatAppearance.BorderColor = Color.Silver;
			scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			scoreButton.FlatStyle = FlatStyle.Flat;
			scoreButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
			scoreButton.Location = new Point(1156, 478);
			scoreButton.Name = "scoreButton";
			scoreButton.Size = new Size(169, 72);
			scoreButton.TabIndex = 6;
			scoreButton.Text = "Score";
			scoreButton.UseVisualStyleBackColor = true;
			// 
			// tournamentViewer
			// 
			AutoScaleDimensions = new SizeF(27F, 65F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1546, 836);
			Controls.Add(scoreButton);
			Controls.Add(teamTwoScoreValue);
			Controls.Add(teamOneScoreValue);
			Controls.Add(MatchupListbox);
			Controls.Add(unplayedOnlyCheckbox);
			Controls.Add(teamTwoScoreLabel);
			Controls.Add(comboBox1);
			Controls.Add(teamTwoName);
			Controls.Add(versusLabel);
			Controls.Add(teamOneScoreLabel);
			Controls.Add(teamOneName);
			Controls.Add(roundLabel);
			Controls.Add(tournamentName);
			Controls.Add(headerLabel);
			Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5, 6, 5, 6);
			Name = "tournamentViewer";
			Text = "<none>";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label headerLabel;
		private Label tournamentName;
		private Label roundLabel;
		private ComboBox comboBox1;
		private CheckBox unplayedOnlyCheckbox;
		private ListBox MatchupListbox;
		private Label teamOneName;
		private Label teamOneScoreLabel;
		private TextBox teamOneScoreValue;
		private Label teamTwoName;
		private Label teamTwoScoreLabel;
		private TextBox teamTwoScoreValue;
		private Label versusLabel;
		private Button scoreButton;
	}
}
