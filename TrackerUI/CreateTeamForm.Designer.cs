namespace TrackerUI
{
	partial class CreateTeamForm
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
			teamNameValue = new TextBox();
			teamNameLabel = new Label();
			headerLabel = new Label();
			addTeamButton = new Button();
			selectTeamMemberComboBox = new ComboBox();
			selectTeamMemberLabel = new Label();
			addNewMemberGroup = new GroupBox();
			FirstNameLabel = new Label();
			textBox1 = new TextBox();
			cellphoneLabel = new Label();
			emailLabel = new Label();
			lastNameLabel = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			createMemberButton = new Button();
			teamMembersListBox = new ListBox();
			DeleteSelectedButtonOne = new Button();
			createTeamButton = new Button();
			addNewMemberGroup.SuspendLayout();
			SuspendLayout();
			// 
			// teamNameValue
			// 
			teamNameValue.Font = new Font("Segoe UI", 16F);
			teamNameValue.Location = new Point(58, 247);
			teamNameValue.Name = "teamNameValue";
			teamNameValue.Size = new Size(644, 71);
			teamNameValue.TabIndex = 9;
			// 
			// teamNameLabel
			// 
			teamNameLabel.AutoSize = true;
			teamNameLabel.Font = new Font("Segoe UI", 16F);
			teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
			teamNameLabel.Location = new Point(58, 179);
			teamNameLabel.Name = "teamNameLabel";
			teamNameLabel.Size = new Size(277, 65);
			teamNameLabel.TabIndex = 8;
			teamNameLabel.Text = "Team Name";
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
			headerLabel.Location = new Point(58, 53);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new Size(288, 65);
			headerLabel.TabIndex = 7;
			headerLabel.Text = "Create Team";
			// 
			// addTeamButton
			// 
			addTeamButton.FlatAppearance.BorderColor = Color.Silver;
			addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			addTeamButton.FlatStyle = FlatStyle.Flat;
			addTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
			addTeamButton.Location = new Point(184, 532);
			addTeamButton.Name = "addTeamButton";
			addTeamButton.Size = new Size(343, 106);
			addTeamButton.TabIndex = 12;
			addTeamButton.Text = "Add Member";
			addTeamButton.UseVisualStyleBackColor = true;
			// 
			// selectTeamMemberComboBox
			// 
			selectTeamMemberComboBox.Font = new Font("Segoe UI", 16F);
			selectTeamMemberComboBox.FormattingEnabled = true;
			selectTeamMemberComboBox.Location = new Point(58, 433);
			selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
			selectTeamMemberComboBox.Size = new Size(644, 73);
			selectTeamMemberComboBox.TabIndex = 11;
			// 
			// selectTeamMemberLabel
			// 
			selectTeamMemberLabel.AutoSize = true;
			selectTeamMemberLabel.Font = new Font("Segoe UI", 16F);
			selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
			selectTeamMemberLabel.Location = new Point(58, 365);
			selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			selectTeamMemberLabel.Size = new Size(469, 65);
			selectTeamMemberLabel.TabIndex = 10;
			selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberGroup
			// 
			addNewMemberGroup.Controls.Add(textBox4);
			addNewMemberGroup.Controls.Add(textBox3);
			addNewMemberGroup.Controls.Add(createMemberButton);
			addNewMemberGroup.Controls.Add(textBox1);
			addNewMemberGroup.Controls.Add(textBox2);
			addNewMemberGroup.Controls.Add(lastNameLabel);
			addNewMemberGroup.Controls.Add(emailLabel);
			addNewMemberGroup.Controls.Add(cellphoneLabel);
			addNewMemberGroup.Controls.Add(FirstNameLabel);
			addNewMemberGroup.Location = new Point(58, 691);
			addNewMemberGroup.Name = "addNewMemberGroup";
			addNewMemberGroup.Size = new Size(644, 559);
			addNewMemberGroup.TabIndex = 13;
			addNewMemberGroup.TabStop = false;
			addNewMemberGroup.Text = "Add New Member";
			// 
			// FirstNameLabel
			// 
			FirstNameLabel.AutoSize = true;
			FirstNameLabel.Font = new Font("Segoe UI", 16F);
			FirstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
			FirstNameLabel.Location = new Point(11, 89);
			FirstNameLabel.Name = "FirstNameLabel";
			FirstNameLabel.Size = new Size(255, 65);
			FirstNameLabel.TabIndex = 9;
			FirstNameLabel.Text = "First Name";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 16F);
			textBox1.Location = new Point(294, 89);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(324, 71);
			textBox1.TabIndex = 10;
			// 
			// cellphoneLabel
			// 
			cellphoneLabel.AutoSize = true;
			cellphoneLabel.Font = new Font("Segoe UI", 16F);
			cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
			cellphoneLabel.Location = new Point(11, 335);
			cellphoneLabel.Name = "cellphoneLabel";
			cellphoneLabel.Size = new Size(242, 65);
			cellphoneLabel.TabIndex = 11;
			cellphoneLabel.Text = "Cellphone";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new Font("Segoe UI", 16F);
			emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
			emailLabel.Location = new Point(11, 253);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(141, 65);
			emailLabel.TabIndex = 12;
			emailLabel.Text = "Email";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new Font("Segoe UI", 16F);
			lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
			lastNameLabel.Location = new Point(11, 171);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(250, 65);
			lastNameLabel.TabIndex = 13;
			lastNameLabel.Text = "Last Name";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 16F);
			textBox2.Location = new Point(294, 171);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(324, 71);
			textBox2.TabIndex = 10;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 16F);
			textBox3.Location = new Point(294, 253);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(324, 71);
			textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 16F);
			textBox4.Location = new Point(294, 335);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(324, 71);
			textBox4.TabIndex = 10;
			// 
			// createMemberButton
			// 
			createMemberButton.FlatAppearance.BorderColor = Color.Silver;
			createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createMemberButton.FlatStyle = FlatStyle.Flat;
			createMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
			createMemberButton.Location = new Point(126, 434);
			createMemberButton.Name = "createMemberButton";
			createMemberButton.Size = new Size(404, 106);
			createMemberButton.TabIndex = 12;
			createMemberButton.Text = "Create Member";
			createMemberButton.UseVisualStyleBackColor = true;
			// 
			// teamMembersListBox
			// 
			teamMembersListBox.FormattingEnabled = true;
			teamMembersListBox.ItemHeight = 65;
			teamMembersListBox.Location = new Point(810, 247);
			teamMembersListBox.Name = "teamMembersListBox";
			teamMembersListBox.Size = new Size(712, 979);
			teamMembersListBox.TabIndex = 14;
			// 
			// DeleteSelectedButtonOne
			// 
			DeleteSelectedButtonOne.FlatAppearance.BorderColor = Color.Silver;
			DeleteSelectedButtonOne.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			DeleteSelectedButtonOne.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			DeleteSelectedButtonOne.FlatStyle = FlatStyle.Flat;
			DeleteSelectedButtonOne.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DeleteSelectedButtonOne.ForeColor = Color.FromArgb(51, 153, 255);
			DeleteSelectedButtonOne.Location = new Point(1558, 625);
			DeleteSelectedButtonOne.Name = "DeleteSelectedButtonOne";
			DeleteSelectedButtonOne.Size = new Size(343, 145);
			DeleteSelectedButtonOne.TabIndex = 15;
			DeleteSelectedButtonOne.Text = "Deleted Selected";
			DeleteSelectedButtonOne.UseVisualStyleBackColor = true;
			// 
			// createTeamButton
			// 
			createTeamButton.FlatAppearance.BorderColor = Color.Silver;
			createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			createTeamButton.FlatStyle = FlatStyle.Flat;
			createTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
			createTeamButton.Location = new Point(707, 1308);
			createTeamButton.Name = "createTeamButton";
			createTeamButton.Size = new Size(488, 106);
			createTeamButton.TabIndex = 16;
			createTeamButton.Text = "Create Team";
			createTeamButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			AutoScaleDimensions = new SizeF(27F, 65F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1929, 1477);
			Controls.Add(createTeamButton);
			Controls.Add(DeleteSelectedButtonOne);
			Controls.Add(teamMembersListBox);
			Controls.Add(addNewMemberGroup);
			Controls.Add(addTeamButton);
			Controls.Add(selectTeamMemberComboBox);
			Controls.Add(selectTeamMemberLabel);
			Controls.Add(teamNameValue);
			Controls.Add(teamNameLabel);
			Controls.Add(headerLabel);
			Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5, 6, 5, 6);
			Name = "CreateTeamForm";
			Text = "Create Team";
			addNewMemberGroup.ResumeLayout(false);
			addNewMemberGroup.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox teamNameValue;
		private Label teamNameLabel;
		private Label headerLabel;
		private Button addTeamButton;
		private ComboBox selectTeamMemberComboBox;
		private Label selectTeamMemberLabel;
		private GroupBox addNewMemberGroup;
		private Label FirstNameLabel;
		private TextBox textBox1;
		private TextBox textBox4;
		private TextBox textBox3;
		private Button createMemberButton;
		private TextBox textBox2;
		private Label lastNameLabel;
		private Label emailLabel;
		private Label cellphoneLabel;
		private ListBox teamMembersListBox;
		private Button DeleteSelectedButtonOne;
		private Button createTeamButton;
	}
}