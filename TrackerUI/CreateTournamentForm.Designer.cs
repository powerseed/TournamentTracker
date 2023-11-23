namespace TrackerUI
{
	partial class CreateTournamentForm
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
			tournamentNameLabel = new Label();
			entryFeeLabel = new Label();
			tournamentNameValue = new TextBox();
			entryFeeValue = new TextBox();
			selectTeamLabel = new Label();
			selectTeamComboBox = new ComboBox();
			createNewLink = new LinkLabel();
			addTeamButton = new Button();
			createPrizeButton = new Button();
			tournamentPlayersListBoxOne = new ListBox();
			teamPlayersLabelOne = new Label();
			DeleteSelectedButtonOne = new Button();
			createTournamentButton = new Button();
			teamPlayersLabelTwo = new Label();
			tournamentPlayersListBoxTwo = new ListBox();
			DeleteSelectedButtonTwo = new Button();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
			headerLabel.Location = new Point(60, 52);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(430, 65);
			headerLabel.TabIndex = 1;
			headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameLabel
			// 
			tournamentNameLabel.AutoSize = true;
			tournamentNameLabel.Font = new Font("Segoe UI", 16F);
			tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
			tournamentNameLabel.Location = new Point(60, 178);
			tournamentNameLabel.Name = "tournamentNameLabel";
			tournamentNameLabel.Size = new Size(419, 65);
			tournamentNameLabel.TabIndex = 2;
			tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeLabel
			// 
			entryFeeLabel.AutoSize = true;
			entryFeeLabel.Font = new Font("Segoe UI", 16F);
			entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
			entryFeeLabel.Location = new Point(60, 358);
			entryFeeLabel.Name = "entryFeeLabel";
			entryFeeLabel.Size = new Size(221, 65);
			entryFeeLabel.TabIndex = 2;
			entryFeeLabel.Text = "Entry Fee";
			// 
			// tournamentNameValue
			// 
			tournamentNameValue.Font = new Font("Segoe UI", 16F);
			tournamentNameValue.Location = new Point(60, 246);
			tournamentNameValue.Name = "tournamentNameValue";
			tournamentNameValue.Size = new Size(319, 71);
			tournamentNameValue.TabIndex = 6;
			// 
			// entryFeeValue
			// 
			entryFeeValue.Font = new Font("Segoe UI", 16F);
			entryFeeValue.Location = new Point(287, 358);
			entryFeeValue.Name = "entryFeeValue";
			entryFeeValue.Size = new Size(225, 71);
			entryFeeValue.TabIndex = 6;
			// 
			// selectTeamLabel
			// 
			selectTeamLabel.AutoSize = true;
			selectTeamLabel.Font = new Font("Segoe UI", 16F);
			selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
			selectTeamLabel.Location = new Point(60, 481);
			selectTeamLabel.Name = "selectTeamLabel";
			selectTeamLabel.Size = new Size(277, 65);
			selectTeamLabel.TabIndex = 2;
			selectTeamLabel.Text = "Select Team";
			// 
			// selectTeamComboBox
			// 
			selectTeamComboBox.Font = new Font("Segoe UI", 16F);
			selectTeamComboBox.FormattingEnabled = true;
			selectTeamComboBox.Location = new Point(60, 549);
			selectTeamComboBox.Name = "selectTeamComboBox";
			selectTeamComboBox.Size = new Size(452, 73);
			selectTeamComboBox.TabIndex = 7;
			// 
			// createNewLink
			// 
			createNewLink.AutoSize = true;
			createNewLink.Location = new Point(367, 505);
			createNewLink.Name = "createNewLink";
			createNewLink.Size = new Size(164, 35);
			createNewLink.TabIndex = 8;
			createNewLink.TabStop = true;
			createNewLink.Text = "Create New";
			// 
			// addTeamButton
			// 
			addTeamButton.FlatAppearance.BorderColor = Color.Silver;
			addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			addTeamButton.FlatStyle = FlatStyle.Flat;
			addTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
			addTeamButton.Location = new Point(110, 646);
			addTeamButton.Name = "addTeamButton";
			addTeamButton.Size = new Size(343, 106);
			addTeamButton.TabIndex = 9;
			addTeamButton.Text = "Add Team";
			addTeamButton.UseVisualStyleBackColor = true;
			// 
			// createPrizeButton
			// 
			createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
			createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createPrizeButton.FlatStyle = FlatStyle.Flat;
			createPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
			createPrizeButton.Location = new Point(110, 789);
			createPrizeButton.Name = "createPrizeButton";
			createPrizeButton.Size = new Size(343, 106);
			createPrizeButton.TabIndex = 10;
			createPrizeButton.Text = "Create Prize";
			createPrizeButton.UseVisualStyleBackColor = true;
			// 
			// tournamentPlayersListBoxOne
			// 
			tournamentPlayersListBoxOne.FormattingEnabled = true;
			tournamentPlayersListBoxOne.Location = new Point(698, 246);
			tournamentPlayersListBoxOne.Name = "tournamentPlayersListBoxOne";
			tournamentPlayersListBoxOne.Size = new Size(532, 249);
			tournamentPlayersListBoxOne.TabIndex = 11;
			// 
			// teamPlayersLabelOne
			// 
			teamPlayersLabelOne.AutoSize = true;
			teamPlayersLabelOne.Font = new Font("Segoe UI", 16F);
			teamPlayersLabelOne.ForeColor = Color.FromArgb(51, 153, 255);
			teamPlayersLabelOne.Location = new Point(698, 178);
			teamPlayersLabelOne.Name = "teamPlayersLabelOne";
			teamPlayersLabelOne.Size = new Size(351, 65);
			teamPlayersLabelOne.TabIndex = 12;
			teamPlayersLabelOne.Text = "Teams / Players";
			// 
			// DeleteSelectedButtonOne
			// 
			DeleteSelectedButtonOne.FlatAppearance.BorderColor = Color.Silver;
			DeleteSelectedButtonOne.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			DeleteSelectedButtonOne.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			DeleteSelectedButtonOne.FlatStyle = FlatStyle.Flat;
			DeleteSelectedButtonOne.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DeleteSelectedButtonOne.ForeColor = Color.FromArgb(51, 153, 255);
			DeleteSelectedButtonOne.Location = new Point(1256, 297);
			DeleteSelectedButtonOne.Name = "DeleteSelectedButtonOne";
			DeleteSelectedButtonOne.Size = new Size(343, 145);
			DeleteSelectedButtonOne.TabIndex = 9;
			DeleteSelectedButtonOne.Text = "Deleted Selected";
			DeleteSelectedButtonOne.UseVisualStyleBackColor = true;
			// 
			// createTournamentButton
			// 
			createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
			createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createTournamentButton.FlatStyle = FlatStyle.Flat;
			createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
			createTournamentButton.Location = new Point(561, 972);
			createTournamentButton.Name = "createTournamentButton";
			createTournamentButton.Size = new Size(488, 106);
			createTournamentButton.TabIndex = 13;
			createTournamentButton.Text = "Create Tournament";
			createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// teamPlayersLabelTwo
			// 
			teamPlayersLabelTwo.AutoSize = true;
			teamPlayersLabelTwo.Font = new Font("Segoe UI", 16F);
			teamPlayersLabelTwo.ForeColor = Color.FromArgb(51, 153, 255);
			teamPlayersLabelTwo.Location = new Point(698, 578);
			teamPlayersLabelTwo.Name = "teamPlayersLabelTwo";
			teamPlayersLabelTwo.Size = new Size(351, 65);
			teamPlayersLabelTwo.TabIndex = 16;
			teamPlayersLabelTwo.Text = "Teams / Players";
			// 
			// tournamentPlayersListBoxTwo
			// 
			tournamentPlayersListBoxTwo.FormattingEnabled = true;
			tournamentPlayersListBoxTwo.Location = new Point(698, 646);
			tournamentPlayersListBoxTwo.Name = "tournamentPlayersListBoxTwo";
			tournamentPlayersListBoxTwo.Size = new Size(532, 249);
			tournamentPlayersListBoxTwo.TabIndex = 15;
			// 
			// DeleteSelectedButtonTwo
			// 
			DeleteSelectedButtonTwo.FlatAppearance.BorderColor = Color.Silver;
			DeleteSelectedButtonTwo.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			DeleteSelectedButtonTwo.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			DeleteSelectedButtonTwo.FlatStyle = FlatStyle.Flat;
			DeleteSelectedButtonTwo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DeleteSelectedButtonTwo.ForeColor = Color.FromArgb(51, 153, 255);
			DeleteSelectedButtonTwo.Location = new Point(1256, 697);
			DeleteSelectedButtonTwo.Name = "DeleteSelectedButtonTwo";
			DeleteSelectedButtonTwo.Size = new Size(343, 145);
			DeleteSelectedButtonTwo.TabIndex = 14;
			DeleteSelectedButtonTwo.Text = "Deleted Selected";
			DeleteSelectedButtonTwo.UseVisualStyleBackColor = true;
			// 
			// CreateTournamentForm
			// 
			AutoScaleDimensions = new SizeF(16F, 35F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1625, 1124);
			Controls.Add(teamPlayersLabelTwo);
			Controls.Add(tournamentPlayersListBoxTwo);
			Controls.Add(DeleteSelectedButtonTwo);
			Controls.Add(createTournamentButton);
			Controls.Add(teamPlayersLabelOne);
			Controls.Add(tournamentPlayersListBoxOne);
			Controls.Add(createPrizeButton);
			Controls.Add(DeleteSelectedButtonOne);
			Controls.Add(addTeamButton);
			Controls.Add(createNewLink);
			Controls.Add(selectTeamComboBox);
			Controls.Add(entryFeeValue);
			Controls.Add(tournamentNameValue);
			Controls.Add(entryFeeLabel);
			Controls.Add(selectTeamLabel);
			Controls.Add(tournamentNameLabel);
			Controls.Add(headerLabel);
			Name = "CreateTournamentForm";
			Text = "Create Tournament";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label headerLabel;
		private Label tournamentNameLabel;
		private Label entryFeeLabel;
		private TextBox tournamentNameValue;
		private TextBox entryFeeValue;
		private Label selectTeamLabel;
		private ComboBox selectTeamComboBox;
		private LinkLabel createNewLink;
		private Button addTeamButton;
		private Button createPrizeButton;
		private ListBox tournamentPlayersListBoxOne;
		private Label teamPlayersLabelOne;
		private Button DeleteSelectedButtonOne;
		private Button createTournamentButton;
		private Label teamPlayersLabelTwo;
		private ListBox tournamentPlayersListBoxTwo;
		private Button DeleteSelectedButtonTwo;
	}
}