namespace SuperheroesWinApp
{
    partial class SuperheroesWinApp
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.loginErrorMessage = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.HeroDataGrid = new System.Windows.Forms.DataGridView();
            this.HeroNavName = new System.Windows.Forms.Label();
            this.HeroHeroicActsButton = new System.Windows.Forms.Button();
            this.HeroProblemsButton = new System.Windows.Forms.Button();
            this.HeroProfileButton = new System.Windows.Forms.Button();
            this.AdminProblemsButton = new System.Windows.Forms.Button();
            this.AdminSuperheroesButton = new System.Windows.Forms.Button();
            this.AdminDataGrid = new System.Windows.Forms.DataGridView();
            this.AdminCreateHeroButton = new System.Windows.Forms.Button();
            this.AdminSearchButton = new System.Windows.Forms.Button();
            this.AdminUpdateButton = new System.Windows.Forms.Button();
            this.AdminDeleteButton = new System.Windows.Forms.Button();
            this.AdminCRUDButtons = new System.Windows.Forms.Panel();
            this.HeroLogOutButton = new System.Windows.Forms.Button();
            this.AdminlogOutButton = new System.Windows.Forms.Button();
            this.AdminNav = new System.Windows.Forms.Panel();
            this.HeroNav = new System.Windows.Forms.GroupBox();
            this.HeroProfileLabel = new System.Windows.Forms.Label();
            this.HeroProblemsLabel = new System.Windows.Forms.Label();
            this.HeroHeroicActsLabel = new System.Windows.Forms.Label();
            this.AdminSuperheroesLabel = new System.Windows.Forms.Label();
            this.AdminProblemsLabel = new System.Windows.Forms.Label();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.loginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).BeginInit();
            this.AdminCRUDButtons.SuspendLayout();
            this.AdminNav.SuspendLayout();
            this.HeroNav.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.Location = new System.Drawing.Point(21, 33);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(146, 20);
            this.usernameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.Location = new System.Drawing.Point(21, 78);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(146, 20);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(19, 17);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(19, 62);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.Location = new System.Drawing.Point(21, 104);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(146, 23);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // loginErrorMessage
            // 
            this.loginErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loginErrorMessage.AutoSize = true;
            this.loginErrorMessage.Location = new System.Drawing.Point(19, 130);
            this.loginErrorMessage.Name = "loginErrorMessage";
            this.loginErrorMessage.Size = new System.Drawing.Size(74, 13);
            this.loginErrorMessage.TabIndex = 8;
            this.loginErrorMessage.Text = "Error message";
            this.loginErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginErrorMessage.Visible = false;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginGroupBox.Controls.Add(this.logInButton);
            this.loginGroupBox.Controls.Add(this.loginErrorMessage);
            this.loginGroupBox.Controls.Add(this.passwordTextbox);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.usernameTextbox);
            this.loginGroupBox.Controls.Add(this.usernameLabel);
            this.loginGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginGroupBox.Location = new System.Drawing.Point(284, 134);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(193, 166);
            this.loginGroupBox.TabIndex = 9;
            this.loginGroupBox.TabStop = false;
            // 
            // HeroDataGrid
            // 
            this.HeroDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeroDataGrid.Location = new System.Drawing.Point(12, 148);
            this.HeroDataGrid.Name = "HeroDataGrid";
            this.HeroDataGrid.Size = new System.Drawing.Size(762, 292);
            this.HeroDataGrid.TabIndex = 10;
            this.HeroDataGrid.Visible = false;
            // 
            // HeroNavName
            // 
            this.HeroNavName.AutoSize = true;
            this.HeroNavName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroNavName.Location = new System.Drawing.Point(15, 15);
            this.HeroNavName.Name = "HeroNavName";
            this.HeroNavName.Size = new System.Drawing.Size(152, 55);
            this.HeroNavName.TabIndex = 11;
            this.HeroNavName.Text = "label1";
            // 
            // HeroHeroicActsButton
            // 
            this.HeroHeroicActsButton.Location = new System.Drawing.Point(566, 15);
            this.HeroHeroicActsButton.Name = "HeroHeroicActsButton";
            this.HeroHeroicActsButton.Size = new System.Drawing.Size(100, 30);
            this.HeroHeroicActsButton.TabIndex = 12;
            this.HeroHeroicActsButton.Text = "Heroic Acts";
            this.HeroHeroicActsButton.UseVisualStyleBackColor = true;
            this.HeroHeroicActsButton.Click += new System.EventHandler(this.HeroHeroicActsButton_Click);
            // 
            // HeroProblemsButton
            // 
            this.HeroProblemsButton.Location = new System.Drawing.Point(460, 15);
            this.HeroProblemsButton.Name = "HeroProblemsButton";
            this.HeroProblemsButton.Size = new System.Drawing.Size(100, 30);
            this.HeroProblemsButton.TabIndex = 13;
            this.HeroProblemsButton.Text = "Problems";
            this.HeroProblemsButton.UseVisualStyleBackColor = true;
            this.HeroProblemsButton.Click += new System.EventHandler(this.HeroProblemsButton_Click);
            // 
            // HeroProfileButton
            // 
            this.HeroProfileButton.Location = new System.Drawing.Point(354, 15);
            this.HeroProfileButton.Name = "HeroProfileButton";
            this.HeroProfileButton.Size = new System.Drawing.Size(100, 30);
            this.HeroProfileButton.TabIndex = 14;
            this.HeroProfileButton.Text = "Profile";
            this.HeroProfileButton.UseVisualStyleBackColor = true;
            this.HeroProfileButton.Click += new System.EventHandler(this.HeroProfileButton_Click);
            // 
            // AdminProblemsButton
            // 
            this.AdminProblemsButton.Location = new System.Drawing.Point(568, 12);
            this.AdminProblemsButton.Name = "AdminProblemsButton";
            this.AdminProblemsButton.Size = new System.Drawing.Size(100, 30);
            this.AdminProblemsButton.TabIndex = 17;
            this.AdminProblemsButton.Text = "Problems";
            this.AdminProblemsButton.UseVisualStyleBackColor = true;
            this.AdminProblemsButton.Click += new System.EventHandler(this.AdminProblemsButton_Click);
            // 
            // AdminSuperheroesButton
            // 
            this.AdminSuperheroesButton.Location = new System.Drawing.Point(462, 12);
            this.AdminSuperheroesButton.Name = "AdminSuperheroesButton";
            this.AdminSuperheroesButton.Size = new System.Drawing.Size(100, 30);
            this.AdminSuperheroesButton.TabIndex = 18;
            this.AdminSuperheroesButton.Text = "Superheroes";
            this.AdminSuperheroesButton.UseVisualStyleBackColor = true;
            this.AdminSuperheroesButton.Click += new System.EventHandler(this.AdminSuperheroesButton_Click);
            // 
            // AdminDataGrid
            // 
            this.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDataGrid.Location = new System.Drawing.Point(12, 150);
            this.AdminDataGrid.Name = "AdminDataGrid";
            this.AdminDataGrid.Size = new System.Drawing.Size(762, 290);
            this.AdminDataGrid.TabIndex = 16;
            this.AdminDataGrid.Visible = false;
            // 
            // AdminCreateHeroButton
            // 
            this.AdminCreateHeroButton.Location = new System.Drawing.Point(2, 3);
            this.AdminCreateHeroButton.Name = "AdminCreateHeroButton";
            this.AdminCreateHeroButton.Size = new System.Drawing.Size(100, 30);
            this.AdminCreateHeroButton.TabIndex = 19;
            this.AdminCreateHeroButton.Text = "Create";
            this.AdminCreateHeroButton.UseVisualStyleBackColor = true;
            this.AdminCreateHeroButton.Click += new System.EventHandler(this.AdminCreateHeroButton_Click);
            // 
            // AdminSearchButton
            // 
            this.AdminSearchButton.Location = new System.Drawing.Point(108, 3);
            this.AdminSearchButton.Name = "AdminSearchButton";
            this.AdminSearchButton.Size = new System.Drawing.Size(100, 30);
            this.AdminSearchButton.TabIndex = 21;
            this.AdminSearchButton.Text = "Search";
            this.AdminSearchButton.UseVisualStyleBackColor = true;
            this.AdminSearchButton.Click += new System.EventHandler(this.AdminSearchButton_Click);
            // 
            // AdminUpdateButton
            // 
            this.AdminUpdateButton.Location = new System.Drawing.Point(214, 3);
            this.AdminUpdateButton.Name = "AdminUpdateButton";
            this.AdminUpdateButton.Size = new System.Drawing.Size(100, 30);
            this.AdminUpdateButton.TabIndex = 23;
            this.AdminUpdateButton.Text = "Update";
            this.AdminUpdateButton.UseVisualStyleBackColor = true;
            this.AdminUpdateButton.Click += new System.EventHandler(this.AdminUpdateButton_Click);
            // 
            // AdminDeleteButton
            // 
            this.AdminDeleteButton.Location = new System.Drawing.Point(320, 3);
            this.AdminDeleteButton.Name = "AdminDeleteButton";
            this.AdminDeleteButton.Size = new System.Drawing.Size(100, 30);
            this.AdminDeleteButton.TabIndex = 25;
            this.AdminDeleteButton.Text = "Delete";
            this.AdminDeleteButton.UseVisualStyleBackColor = true;
            this.AdminDeleteButton.Click += new System.EventHandler(this.AdminDeleteButton_Click);
            // 
            // AdminCRUDButtons
            // 
            this.AdminCRUDButtons.Controls.Add(this.AdminCreateHeroButton);
            this.AdminCRUDButtons.Controls.Add(this.AdminDeleteButton);
            this.AdminCRUDButtons.Controls.Add(this.AdminUpdateButton);
            this.AdminCRUDButtons.Controls.Add(this.AdminSearchButton);
            this.AdminCRUDButtons.Location = new System.Drawing.Point(12, 109);
            this.AdminCRUDButtons.Name = "AdminCRUDButtons";
            this.AdminCRUDButtons.Size = new System.Drawing.Size(419, 35);
            this.AdminCRUDButtons.TabIndex = 27;
            this.AdminCRUDButtons.Visible = false;
            // 
            // HeroLogOutButton
            // 
            this.HeroLogOutButton.Location = new System.Drawing.Point(672, 15);
            this.HeroLogOutButton.Name = "HeroLogOutButton";
            this.HeroLogOutButton.Size = new System.Drawing.Size(100, 30);
            this.HeroLogOutButton.TabIndex = 28;
            this.HeroLogOutButton.Text = "Log out";
            this.HeroLogOutButton.UseVisualStyleBackColor = true;
            this.HeroLogOutButton.Click += new System.EventHandler(this.HeroLogOutButton_Click);
            // 
            // AdminlogOutButton
            // 
            this.AdminlogOutButton.Location = new System.Drawing.Point(674, 12);
            this.AdminlogOutButton.Name = "AdminlogOutButton";
            this.AdminlogOutButton.Size = new System.Drawing.Size(100, 30);
            this.AdminlogOutButton.TabIndex = 28;
            this.AdminlogOutButton.Text = "Log out";
            this.AdminlogOutButton.UseVisualStyleBackColor = true;
            this.AdminlogOutButton.Click += new System.EventHandler(this.AdminlogOutButton_Click);
            // 
            // AdminNav
            // 
            this.AdminNav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AdminNav.Controls.Add(this.AdminlogOutButton);
            this.AdminNav.Controls.Add(this.AdminProblemsButton);
            this.AdminNav.Controls.Add(this.AdminSuperheroesButton);
            this.AdminNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminNav.Location = new System.Drawing.Point(0, 0);
            this.AdminNav.Name = "AdminNav";
            this.AdminNav.Size = new System.Drawing.Size(786, 86);
            this.AdminNav.TabIndex = 28;
            this.AdminNav.Visible = false;
            // 
            // HeroNav
            // 
            this.HeroNav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeroNav.Controls.Add(this.HeroNavName);
            this.HeroNav.Controls.Add(this.HeroProfileButton);
            this.HeroNav.Controls.Add(this.HeroProblemsButton);
            this.HeroNav.Controls.Add(this.HeroHeroicActsButton);
            this.HeroNav.Controls.Add(this.HeroLogOutButton);
            this.HeroNav.Location = new System.Drawing.Point(-3, -2);
            this.HeroNav.Name = "HeroNav";
            this.HeroNav.Size = new System.Drawing.Size(789, 88);
            this.HeroNav.TabIndex = 15;
            this.HeroNav.TabStop = false;
            this.HeroNav.Visible = false;
            // 
            // HeroProfileLabel
            // 
            this.HeroProfileLabel.AutoSize = true;
            this.HeroProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroProfileLabel.Location = new System.Drawing.Point(59, 9);
            this.HeroProfileLabel.Name = "HeroProfileLabel";
            this.HeroProfileLabel.Size = new System.Drawing.Size(62, 24);
            this.HeroProfileLabel.TabIndex = 29;
            this.HeroProfileLabel.Text = "Profile";
            this.HeroProfileLabel.Visible = false;
            // 
            // HeroProblemsLabel
            // 
            this.HeroProblemsLabel.AutoSize = true;
            this.HeroProblemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroProblemsLabel.Location = new System.Drawing.Point(45, 9);
            this.HeroProblemsLabel.Name = "HeroProblemsLabel";
            this.HeroProblemsLabel.Size = new System.Drawing.Size(90, 24);
            this.HeroProblemsLabel.TabIndex = 30;
            this.HeroProblemsLabel.Text = "Problems";
            this.HeroProblemsLabel.Visible = false;
            // 
            // HeroHeroicActsLabel
            // 
            this.HeroHeroicActsLabel.AutoSize = true;
            this.HeroHeroicActsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroHeroicActsLabel.Location = new System.Drawing.Point(36, 9);
            this.HeroHeroicActsLabel.Name = "HeroHeroicActsLabel";
            this.HeroHeroicActsLabel.Size = new System.Drawing.Size(104, 24);
            this.HeroHeroicActsLabel.TabIndex = 31;
            this.HeroHeroicActsLabel.Text = "Heroic acts";
            this.HeroHeroicActsLabel.Visible = false;
            // 
            // AdminSuperheroesLabel
            // 
            this.AdminSuperheroesLabel.AutoSize = true;
            this.AdminSuperheroesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSuperheroesLabel.Location = new System.Drawing.Point(20, 9);
            this.AdminSuperheroesLabel.Name = "AdminSuperheroesLabel";
            this.AdminSuperheroesLabel.Size = new System.Drawing.Size(120, 24);
            this.AdminSuperheroesLabel.TabIndex = 32;
            this.AdminSuperheroesLabel.Text = "Superheroes";
            this.AdminSuperheroesLabel.Visible = false;
            // 
            // AdminProblemsLabel
            // 
            this.AdminProblemsLabel.AutoSize = true;
            this.AdminProblemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminProblemsLabel.Location = new System.Drawing.Point(45, 9);
            this.AdminProblemsLabel.Name = "AdminProblemsLabel";
            this.AdminProblemsLabel.Size = new System.Drawing.Size(90, 24);
            this.AdminProblemsLabel.TabIndex = 33;
            this.AdminProblemsLabel.Text = "Problems";
            this.AdminProblemsLabel.Visible = false;
            // 
            // LabelPanel
            // 
            this.LabelPanel.Controls.Add(this.AdminProblemsLabel);
            this.LabelPanel.Controls.Add(this.HeroProfileLabel);
            this.LabelPanel.Controls.Add(this.HeroProblemsLabel);
            this.LabelPanel.Controls.Add(this.HeroHeroicActsLabel);
            this.LabelPanel.Controls.Add(this.AdminSuperheroesLabel);
            this.LabelPanel.Location = new System.Drawing.Point(627, 107);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(147, 35);
            this.LabelPanel.TabIndex = 34;
            // 
            // SuperheroesWinApp
            // 
            this.ClientSize = new System.Drawing.Size(786, 452);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.AdminCRUDButtons);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.AdminDataGrid);
            this.Controls.Add(this.HeroDataGrid);
            this.Controls.Add(this.HeroNav);
            this.Controls.Add(this.AdminNav);
            this.Name = "SuperheroesWinApp";
            this.Text = "Superheroes";
            this.Load += new System.EventHandler(this.SuperheroesWinApp_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeroDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).EndInit();
            this.AdminCRUDButtons.ResumeLayout(false);
            this.AdminNav.ResumeLayout(false);
            this.HeroNav.ResumeLayout(false);
            this.HeroNav.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label loginErrorMessage;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.DataGridView HeroDataGrid;
        private System.Windows.Forms.Label HeroNavName;
        private System.Windows.Forms.Button HeroHeroicActsButton;
        private System.Windows.Forms.Button HeroProblemsButton;
        private System.Windows.Forms.Button HeroProfileButton;
        private System.Windows.Forms.Button AdminProblemsButton;
        private System.Windows.Forms.Button AdminSuperheroesButton;
        private System.Windows.Forms.DataGridView AdminDataGrid;
        private System.Windows.Forms.Button AdminCreateHeroButton;
        private System.Windows.Forms.Button AdminSearchButton;
        private System.Windows.Forms.Button AdminUpdateButton;
        private System.Windows.Forms.Button AdminDeleteButton;
        private System.Windows.Forms.Panel AdminCRUDButtons;
        private System.Windows.Forms.Button HeroLogOutButton;
        private System.Windows.Forms.Button AdminlogOutButton;
        private System.Windows.Forms.Panel AdminNav;
        private System.Windows.Forms.GroupBox HeroNav;
        private System.Windows.Forms.Label HeroProfileLabel;
        private System.Windows.Forms.Label HeroProblemsLabel;
        private System.Windows.Forms.Label HeroHeroicActsLabel;
        private System.Windows.Forms.Label AdminSuperheroesLabel;
        private System.Windows.Forms.Label AdminProblemsLabel;
        private System.Windows.Forms.Panel LabelPanel;
    }
}

