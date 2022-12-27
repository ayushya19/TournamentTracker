namespace TournamentTrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewlinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.AddPrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListbox = new System.Windows.Forms.ListBox();
            this.PlayersListBoxLabel = new System.Windows.Forms.Label();
            this.DeleteTeamButton = new System.Windows.Forms.Button();
            this.DeletePrizeButton = new System.Windows.Forms.Button();
            this.PrizesListLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 41);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(403, 62);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameTextBox
            // 
            this.TournamentNameTextBox.Location = new System.Drawing.Point(36, 205);
            this.TournamentNameTextBox.Name = "TournamentNameTextBox";
            this.TournamentNameTextBox.Size = new System.Drawing.Size(403, 43);
            this.TournamentNameTextBox.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentNameLabel.Location = new System.Drawing.Point(36, 139);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.TournamentNameLabel.TabIndex = 10;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Location = new System.Drawing.Point(174, 306);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(125, 43);
            this.EntryFeeTextBox.TabIndex = 13;
            this.EntryFeeTextBox.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(36, 311);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(132, 38);
            this.EntryFeeLabel.TabIndex = 12;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamDropDown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(36, 455);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(403, 53);
            this.SelectTeamDropDown.TabIndex = 15;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(36, 414);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.SelectTeamLabel.TabIndex = 14;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // CreateNewlinkLabel
            // 
            this.CreateNewlinkLabel.AutoSize = true;
            this.CreateNewlinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewlinkLabel.Location = new System.Drawing.Point(327, 421);
            this.CreateNewlinkLabel.Name = "CreateNewlinkLabel";
            this.CreateNewlinkLabel.Size = new System.Drawing.Size(112, 28);
            this.CreateNewlinkLabel.TabIndex = 16;
            this.CreateNewlinkLabel.TabStop = true;
            this.CreateNewlinkLabel.Text = "Create New";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTeamButton.Location = new System.Drawing.Point(130, 527);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(190, 49);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // AddPrizeButton
            // 
            this.AddPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddPrizeButton.Location = new System.Drawing.Point(130, 594);
            this.AddPrizeButton.Name = "AddPrizeButton";
            this.AddPrizeButton.Size = new System.Drawing.Size(190, 49);
            this.AddPrizeButton.TabIndex = 18;
            this.AddPrizeButton.Text = "Create Prize";
            this.AddPrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListbox
            // 
            this.TournamentPlayersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListbox.FormattingEnabled = true;
            this.TournamentPlayersListbox.ItemHeight = 37;
            this.TournamentPlayersListbox.Location = new System.Drawing.Point(480, 152);
            this.TournamentPlayersListbox.Name = "TournamentPlayersListbox";
            this.TournamentPlayersListbox.Size = new System.Drawing.Size(348, 187);
            this.TournamentPlayersListbox.TabIndex = 19;
            // 
            // PlayersListBoxLabel
            // 
            this.PlayersListBoxLabel.AutoSize = true;
            this.PlayersListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayersListBoxLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayersListBoxLabel.Location = new System.Drawing.Point(480, 93);
            this.PlayersListBoxLabel.Name = "PlayersListBoxLabel";
            this.PlayersListBoxLabel.Size = new System.Drawing.Size(193, 38);
            this.PlayersListBoxLabel.TabIndex = 20;
            this.PlayersListBoxLabel.Text = "Teams/Players";
            // 
            // DeleteTeamButton
            // 
            this.DeleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteTeamButton.Location = new System.Drawing.Point(849, 202);
            this.DeleteTeamButton.Name = "DeleteTeamButton";
            this.DeleteTeamButton.Size = new System.Drawing.Size(229, 49);
            this.DeleteTeamButton.TabIndex = 21;
            this.DeleteTeamButton.Text = "Delete Selected";
            this.DeleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // DeletePrizeButton
            // 
            this.DeletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeletePrizeButton.Location = new System.Drawing.Point(849, 505);
            this.DeletePrizeButton.Name = "DeletePrizeButton";
            this.DeletePrizeButton.Size = new System.Drawing.Size(229, 49);
            this.DeletePrizeButton.TabIndex = 24;
            this.DeletePrizeButton.Text = "Delete Selected";
            this.DeletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesListLabel
            // 
            this.PrizesListLabel.AutoSize = true;
            this.PrizesListLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesListLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizesListLabel.Location = new System.Drawing.Point(480, 396);
            this.PrizesListLabel.Name = "PrizesListLabel";
            this.PrizesListLabel.Size = new System.Drawing.Size(90, 38);
            this.PrizesListLabel.TabIndex = 23;
            this.PrizesListLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 37;
            this.PrizesListBox.Location = new System.Drawing.Point(480, 455);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(348, 187);
            this.PrizesListBox.TabIndex = 22;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(369, 683);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(304, 49);
            this.CreateTournamentButton.TabIndex = 25;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 768);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeletePrizeButton);
            this.Controls.Add(this.PrizesListLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteTeamButton);
            this.Controls.Add(this.PlayersListBoxLabel);
            this.Controls.Add(this.TournamentPlayersListbox);
            this.Controls.Add(this.AddPrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewlinkLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameTextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private TextBox TournamentNameTextBox;
        private Label TournamentNameLabel;
        private TextBox EntryFeeTextBox;
        private Label EntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewlinkLabel;
        private Button AddTeamButton;
        private Button AddPrizeButton;
        private ListBox TournamentPlayersListbox;
        private Label PlayersListBoxLabel;
        private Button DeleteTeamButton;
        private Button DeletePrizeButton;
        private Label PrizesListLabel;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}