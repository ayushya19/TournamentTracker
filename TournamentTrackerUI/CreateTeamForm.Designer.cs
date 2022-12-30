namespace TournamentTrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellPhoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.CellPhoneNumberLabel = new System.Windows.Forms.Label();
            this.LastNameValueTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValueTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedTournamentPlayerButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(15, 9);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(272, 62);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Create Team";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(15, 71);
            this.TeamNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.TeamNameLabel.TabIndex = 11;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(15, 115);
            this.TeamNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(542, 43);
            this.TeamNameTextBox.TabIndex = 12;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(15, 178);
            this.SelectTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(277, 38);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team Member";
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberDropDown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(15, 219);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(542, 53);
            this.SelectTeamMemberDropDown.TabIndex = 16;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddMemberButton.Location = new System.Drawing.Point(172, 296);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(207, 49);
            this.AddMemberButton.TabIndex = 18;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailtextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.CellPhoneNumbertextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.CellPhoneNumberLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(15, 366);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(542, 396);
            this.AddNewMemberGroupBox.TabIndex = 26;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateMemberButton.Location = new System.Drawing.Point(247, 341);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(249, 49);
            this.CreateMemberButton.TabIndex = 27;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(221, 205);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(310, 51);
            this.EmailtextBox.TabIndex = 17;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(50, 210);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(83, 38);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // CellPhoneNumbertextBox
            // 
            this.CellPhoneNumbertextBox.Location = new System.Drawing.Point(221, 266);
            this.CellPhoneNumbertextBox.Name = "CellPhoneNumbertextBox";
            this.CellPhoneNumbertextBox.Size = new System.Drawing.Size(310, 51);
            this.CellPhoneNumbertextBox.TabIndex = 15;
            // 
            // CellPhoneNumberLabel
            // 
            this.CellPhoneNumberLabel.AutoSize = true;
            this.CellPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellPhoneNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CellPhoneNumberLabel.Location = new System.Drawing.Point(50, 271);
            this.CellPhoneNumberLabel.Name = "CellPhoneNumberLabel";
            this.CellPhoneNumberLabel.Size = new System.Drawing.Size(142, 38);
            this.CellPhoneNumberLabel.TabIndex = 14;
            this.CellPhoneNumberLabel.Text = "CellPhone";
            // 
            // LastNameValueTextBox
            // 
            this.LastNameValueTextBox.Location = new System.Drawing.Point(221, 143);
            this.LastNameValueTextBox.Name = "LastNameValueTextBox";
            this.LastNameValueTextBox.Size = new System.Drawing.Size(310, 51);
            this.LastNameValueTextBox.TabIndex = 13;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastNameLabel.Location = new System.Drawing.Point(50, 148);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 38);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameValueTextBox
            // 
            this.FirstNameValueTextBox.Location = new System.Drawing.Point(221, 86);
            this.FirstNameValueTextBox.Name = "FirstNameValueTextBox";
            this.FirstNameValueTextBox.Size = new System.Drawing.Size(310, 51);
            this.FirstNameValueTextBox.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameLabel.Location = new System.Drawing.Point(50, 91);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(151, 38);
            this.FirstNameLabel.TabIndex = 10;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // TournamentPlayerListBox
            // 
            this.TournamentPlayerListBox.FormattingEnabled = true;
            this.TournamentPlayerListBox.ItemHeight = 37;
            this.TournamentPlayerListBox.Location = new System.Drawing.Point(616, 96);
            this.TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            this.TournamentPlayerListBox.Size = new System.Drawing.Size(320, 670);
            this.TournamentPlayerListBox.TabIndex = 27;
            // 
            // DeleteSelectedTournamentPlayerButton
            // 
            this.DeleteSelectedTournamentPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteSelectedTournamentPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedTournamentPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedTournamentPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedTournamentPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedTournamentPlayerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedTournamentPlayerButton.Location = new System.Drawing.Point(942, 437);
            this.DeleteSelectedTournamentPlayerButton.Name = "DeleteSelectedTournamentPlayerButton";
            this.DeleteSelectedTournamentPlayerButton.Size = new System.Drawing.Size(154, 106);
            this.DeleteSelectedTournamentPlayerButton.TabIndex = 28;
            this.DeleteSelectedTournamentPlayerButton.Text = "Delete Selected";
            this.DeleteSelectedTournamentPlayerButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTeamButton.Location = new System.Drawing.Point(441, 783);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(304, 49);
            this.CreateTeamButton.TabIndex = 29;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 851);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedTournamentPlayerButton);
            this.Controls.Add(this.TournamentPlayerListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Label TeamNameLabel;
        private TextBox TeamNameTextBox;
        private Label SelectTeamLabel;
        private ComboBox SelectTeamMemberDropDown;
        private Button AddMemberButton;
        private GroupBox AddNewMemberGroupBox;
        private TextBox LastNameValueTextBox;
        private Label LastNameLabel;
        private TextBox FirstNameValueTextBox;
        private Label FirstNameLabel;
        private Button CreateMemberButton;
        private Label EmailLabel;
        private TextBox CellPhoneNumbertextBox;
        private Label CellPhoneNumberLabel;
        private ListBox TournamentPlayerListBox;
        private Button DeleteSelectedTournamentPlayerButton;
        private Button CreateTeamButton;
        private TextBox EmailtextBox;
    }
}