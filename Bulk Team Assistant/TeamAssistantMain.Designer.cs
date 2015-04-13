namespace Bulk_Team_Assistant
{
    partial class TeamAssistantMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnUserBU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamAssistantMain));
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.columnHeaderTeamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBUName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedTeams = new System.Windows.Forms.Label();
            this.noTeamsLabel = new System.Windows.Forms.Label();
            this.labelTeamType = new System.Windows.Forms.Label();
            this.teamTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectedUsers = new System.Windows.Forms.Label();
            this.labelUsersViews = new System.Windows.Forms.Label();
            this.comboBoxUsersViews = new System.Windows.Forms.ComboBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadTeamsAndUsersButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripAddSelectedUsersToTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            columnUserBU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnUserBU
            // 
            columnUserBU.Text = "Business Unit";
            columnUserBU.Width = 120;
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "TeamIcon.png");
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(708, 491);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.70629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 26);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewTeams);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.listViewUsers);
            this.splitContainer1.Size = new System.Drawing.Size(706, 379);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 6;
            // 
            // listViewTeams
            // 
            this.listViewTeams.AllowColumnReorder = true;
            this.listViewTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTeams.CheckBoxes = true;
            this.listViewTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTeamName,
            this.columnHeaderBUName});
            this.listViewTeams.FullRowSelect = true;
            this.listViewTeams.Location = new System.Drawing.Point(2, 30);
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(327, 349);
            this.listViewTeams.TabIndex = 1;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            this.listViewTeams.View = System.Windows.Forms.View.Details;
            this.listViewTeams.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewTeams_ItemChecked);
            // 
            // columnHeaderTeamName
            // 
            this.columnHeaderTeamName.Text = "Team Name";
            this.columnHeaderTeamName.Width = 170;
            // 
            // columnHeaderBUName
            // 
            this.columnHeaderBUName.Text = "Business Unit Name";
            this.columnHeaderBUName.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblSelectedTeams);
            this.panel1.Controls.Add(this.noTeamsLabel);
            this.panel1.Controls.Add(this.labelTeamType);
            this.panel1.Controls.Add(this.teamTypeComboBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 23);
            this.panel1.TabIndex = 0;
            // 
            // lblSelectedTeams
            // 
            this.lblSelectedTeams.AutoSize = true;
            this.lblSelectedTeams.Location = new System.Drawing.Point(121, 4);
            this.lblSelectedTeams.Name = "lblSelectedTeams";
            this.lblSelectedTeams.Size = new System.Drawing.Size(49, 13);
            this.lblSelectedTeams.TabIndex = 3;
            this.lblSelectedTeams.Text = "Selected";
            // 
            // noTeamsLabel
            // 
            this.noTeamsLabel.AutoSize = true;
            this.noTeamsLabel.Location = new System.Drawing.Point(3, 4);
            this.noTeamsLabel.Name = "noTeamsLabel";
            this.noTeamsLabel.Size = new System.Drawing.Size(112, 13);
            this.noTeamsLabel.TabIndex = 2;
            this.noTeamsLabel.Text = "Total number of teams";
            // 
            // labelTeamType
            // 
            this.labelTeamType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTeamType.AutoSize = true;
            this.labelTeamType.Location = new System.Drawing.Point(182, 4);
            this.labelTeamType.Name = "labelTeamType";
            this.labelTeamType.Size = new System.Drawing.Size(61, 13);
            this.labelTeamType.TabIndex = 1;
            this.labelTeamType.Text = "Team Type";
            // 
            // teamTypeComboBox
            // 
            this.teamTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.teamTypeComboBox.FormattingEnabled = true;
            this.teamTypeComboBox.Items.AddRange(new object[] {
            "Owner",
            "Access"});
            this.teamTypeComboBox.Location = new System.Drawing.Point(249, 0);
            this.teamTypeComboBox.Name = "teamTypeComboBox";
            this.teamTypeComboBox.Size = new System.Drawing.Size(68, 21);
            this.teamTypeComboBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblSelectedUsers);
            this.panel2.Controls.Add(this.labelUsersViews);
            this.panel2.Controls.Add(this.comboBoxUsersViews);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 23);
            this.panel2.TabIndex = 1;
            // 
            // lblSelectedUsers
            // 
            this.lblSelectedUsers.AutoSize = true;
            this.lblSelectedUsers.Location = new System.Drawing.Point(13, 3);
            this.lblSelectedUsers.Name = "lblSelectedUsers";
            this.lblSelectedUsers.Size = new System.Drawing.Size(49, 13);
            this.lblSelectedUsers.TabIndex = 2;
            this.lblSelectedUsers.Text = "Selected";
            // 
            // labelUsersViews
            // 
            this.labelUsersViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsersViews.AutoSize = true;
            this.labelUsersViews.Location = new System.Drawing.Point(161, 4);
            this.labelUsersViews.Name = "labelUsersViews";
            this.labelUsersViews.Size = new System.Drawing.Size(60, 13);
            this.labelUsersViews.TabIndex = 1;
            this.labelUsersViews.Text = "Users View";
            this.labelUsersViews.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxUsersViews
            // 
            this.comboBoxUsersViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUsersViews.Enabled = false;
            this.comboBoxUsersViews.FormattingEnabled = true;
            this.comboBoxUsersViews.Items.AddRange(new object[] {
            "Active Users"});
            this.comboBoxUsersViews.Location = new System.Drawing.Point(245, 0);
            this.comboBoxUsersViews.Name = "comboBoxUsersViews";
            this.comboBoxUsersViews.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsersViews.TabIndex = 0;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUsers.CheckBoxes = true;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUserName,
            columnUserBU});
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.Location = new System.Drawing.Point(2, 32);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(368, 344);
            this.listViewUsers.TabIndex = 2;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.userslistView_ItemChecked);
            this.listViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewUsers_KeyDown);
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "Full Name";
            this.columnHeaderUserName.Width = 180;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeButton,
            this.toolStripSeparator2,
            this.loadTeamsAndUsersButton,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(286, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "MainMenuStrip";
            // 
            // closeButton
            // 
            this.closeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeButton.Image = global::Bulk_Team_Assistant.Properties.Resources.Close1;
            this.closeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 22);
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // loadTeamsAndUsersButton
            // 
            this.loadTeamsAndUsersButton.Image = global::Bulk_Team_Assistant.Properties.Resources.LoadTeams;
            this.loadTeamsAndUsersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadTeamsAndUsersButton.Name = "loadTeamsAndUsersButton";
            this.loadTeamsAndUsersButton.Size = new System.Drawing.Size(158, 22);
            this.loadTeamsAndUsersButton.Text = "Load Users  and  Teams ";
            this.loadTeamsAndUsersButton.Click += new System.EventHandler(this.loadTeamsAndUsersButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddSelectedUsersToTeams,
            this.toolStripSeparator3,
            this.removeSelectedUsersMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripDropDownButton1.Text = "Actions";
            // 
            // toolStripAddSelectedUsersToTeams
            // 
            this.toolStripAddSelectedUsersToTeams.Name = "toolStripAddSelectedUsersToTeams";
            this.toolStripAddSelectedUsersToTeams.Size = new System.Drawing.Size(303, 22);
            this.toolStripAddSelectedUsersToTeams.Text = "Add  selected users to selected teams";
            this.toolStripAddSelectedUsersToTeams.Click += new System.EventHandler(this.toolStripAddSelectedUsersToTeams_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 406);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log ";
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 16);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(702, 66);
            this.logBox.TabIndex = 0;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(300, 6);
            // 
            // removeSelectedUsersMenuItem
            // 
            this.removeSelectedUsersMenuItem.Name = "removeSelectedUsersMenuItem";
            this.removeSelectedUsersMenuItem.Size = new System.Drawing.Size(303, 22);
            this.removeSelectedUsersMenuItem.Text = "Remove selected users from selected teams";
            this.removeSelectedUsersMenuItem.Click += new System.EventHandler(this.removeSelectedUsersMenuItem_Click);
            // 
            // TeamAssistantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeamAssistantMain";
            this.Size = new System.Drawing.Size(708, 491);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton loadTeamsAndUsersButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddSelectedUsersToTeams;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.ColumnHeader columnHeaderTeamName;
        private System.Windows.Forms.ColumnHeader columnHeaderBUName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noTeamsLabel;
        private System.Windows.Forms.Label labelTeamType;
        private System.Windows.Forms.ComboBox teamTypeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectedUsers;
        private System.Windows.Forms.Label labelUsersViews;
        private System.Windows.Forms.ComboBox comboBoxUsersViews;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label lblSelectedTeams;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedUsersMenuItem;
    }
}
