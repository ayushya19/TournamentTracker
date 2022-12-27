namespace TournamentTrackerUI
{
    partial class TournamentReviewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentReviewerForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoNameLabel = new System.Windows.Forms.Label();
            this.VsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(19, 15);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(271, 62);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentName.Location = new System.Drawing.Point(277, 15);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(197, 62);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<None>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundLabel.Location = new System.Drawing.Point(30, 97);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(97, 38);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundDropDown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(133, 90);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(151, 53);
            this.roundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(136, 168);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(218, 42);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.UnplayedOnlyCheckbox_CheckedChanged);
            // 
            // matchupListbox
            // 
            this.matchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.ItemHeight = 37;
            this.matchupListbox.Location = new System.Drawing.Point(30, 244);
            this.matchupListbox.Name = "matchupListbox";
            this.matchupListbox.Size = new System.Drawing.Size(444, 520);
            this.matchupListbox.TabIndex = 5;
            // 
            // TeamOneNameLabel
            // 
            this.TeamOneNameLabel.AutoSize = true;
            this.TeamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneNameLabel.Location = new System.Drawing.Point(624, 244);
            this.TeamOneNameLabel.Name = "TeamOneNameLabel";
            this.TeamOneNameLabel.Size = new System.Drawing.Size(180, 38);
            this.TeamOneNameLabel.TabIndex = 6;
            this.TeamOneNameLabel.Text = "<Team One>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(624, 305);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.TeamOneScoreLabel.TabIndex = 8;
            this.TeamOneScoreLabel.Text = "Score";
            this.TeamOneScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TeamOneScoreValueTextBox
            // 
            this.TeamOneScoreValueTextBox.Location = new System.Drawing.Point(730, 300);
            this.TeamOneScoreValueTextBox.Name = "TeamOneScoreValueTextBox";
            this.TeamOneScoreValueTextBox.Size = new System.Drawing.Size(125, 43);
            this.TeamOneScoreValueTextBox.TabIndex = 9;
            // 
            // TeamTwoScoreValueTextBox
            // 
            this.TeamTwoScoreValueTextBox.Location = new System.Drawing.Point(730, 522);
            this.TeamTwoScoreValueTextBox.Name = "TeamTwoScoreValueTextBox";
            this.TeamTwoScoreValueTextBox.Size = new System.Drawing.Size(125, 43);
            this.TeamTwoScoreValueTextBox.TabIndex = 12;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(624, 527);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.TeamTwoScoreLabel.TabIndex = 11;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoNameLabel
            // 
            this.TeamTwoNameLabel.AutoSize = true;
            this.TeamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoNameLabel.Location = new System.Drawing.Point(624, 466);
            this.TeamTwoNameLabel.Name = "TeamTwoNameLabel";
            this.TeamTwoNameLabel.Size = new System.Drawing.Size(177, 38);
            this.TeamTwoNameLabel.TabIndex = 10;
            this.TeamTwoNameLabel.Text = "<Team Two>";
            // 
            // VsLabel
            // 
            this.VsLabel.AutoSize = true;
            this.VsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VsLabel.Location = new System.Drawing.Point(624, 395);
            this.VsLabel.Name = "VsLabel";
            this.VsLabel.Size = new System.Drawing.Size(71, 38);
            this.VsLabel.TabIndex = 13;
            this.VsLabel.Text = "-VS-";
            this.VsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(902, 399);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(101, 49);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "c";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TournamentReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 785);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.VsLabel);
            this.Controls.Add(this.TeamTwoScoreValueTextBox);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoNameLabel);
            this.Controls.Add(this.TeamOneScoreValueTextBox);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneNameLabel);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentReviewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentReviewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox roundDropDown;
        private CheckBox UnplayedOnlyCheckbox;
        private ListBox matchupListbox;
        private Label TeamOneNameLabel;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValueTextBox;
        private TextBox TeamTwoScoreValueTextBox;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoNameLabel;
        private Label VsLabel;
        private Button scoreButton;
    }
}