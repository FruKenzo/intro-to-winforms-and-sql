namespace SuperheroesWinApp
{
    partial class UpdateHero
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
            this.UpdateLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateDepIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateCancelButton = new System.Windows.Forms.Button();
            this.UpdateDepIDLabel = new System.Windows.Forms.Label();
            this.UpdateWeaknessTextbox = new System.Windows.Forms.TextBox();
            this.UpdateWeaknessLabel = new System.Windows.Forms.Label();
            this.UpdateLevelLabel = new System.Windows.Forms.Label();
            this.UpdatePowerTextbox = new System.Windows.Forms.TextBox();
            this.UpdatePowerLabel = new System.Windows.Forms.Label();
            this.UpdateNameTextbox = new System.Windows.Forms.TextBox();
            this.UpdateNameLabel = new System.Windows.Forms.Label();
            this.UpdateHeroButton = new System.Windows.Forms.Button();
            this.UpdateHerpIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateHeroID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDepIDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateHerpIDUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateLevelUpDown
            // 
            this.UpdateLevelUpDown.Location = new System.Drawing.Point(250, 185);
            this.UpdateLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdateLevelUpDown.Name = "UpdateLevelUpDown";
            this.UpdateLevelUpDown.Size = new System.Drawing.Size(129, 20);
            this.UpdateLevelUpDown.TabIndex = 33;
            this.UpdateLevelUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpdateDepIDUpDown
            // 
            this.UpdateDepIDUpDown.Location = new System.Drawing.Point(250, 293);
            this.UpdateDepIDUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpdateDepIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdateDepIDUpDown.Name = "UpdateDepIDUpDown";
            this.UpdateDepIDUpDown.Size = new System.Drawing.Size(129, 20);
            this.UpdateDepIDUpDown.TabIndex = 32;
            this.UpdateDepIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpdateCancelButton
            // 
            this.UpdateCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCancelButton.Location = new System.Drawing.Point(233, 347);
            this.UpdateCancelButton.Name = "UpdateCancelButton";
            this.UpdateCancelButton.Size = new System.Drawing.Size(122, 33);
            this.UpdateCancelButton.TabIndex = 30;
            this.UpdateCancelButton.Text = "Cancel";
            this.UpdateCancelButton.UseVisualStyleBackColor = true;
            this.UpdateCancelButton.Click += new System.EventHandler(this.UpdateCancelButton_Click);
            // 
            // UpdateDepIDLabel
            // 
            this.UpdateDepIDLabel.AutoSize = true;
            this.UpdateDepIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UpdateDepIDLabel.Location = new System.Drawing.Point(57, 291);
            this.UpdateDepIDLabel.Name = "UpdateDepIDLabel";
            this.UpdateDepIDLabel.Size = new System.Drawing.Size(103, 18);
            this.UpdateDepIDLabel.TabIndex = 29;
            this.UpdateDepIDLabel.Text = "Department ID";
            // 
            // UpdateWeaknessTextbox
            // 
            this.UpdateWeaknessTextbox.Location = new System.Drawing.Point(250, 236);
            this.UpdateWeaknessTextbox.Name = "UpdateWeaknessTextbox";
            this.UpdateWeaknessTextbox.Size = new System.Drawing.Size(129, 20);
            this.UpdateWeaknessTextbox.TabIndex = 28;
            // 
            // UpdateWeaknessLabel
            // 
            this.UpdateWeaknessLabel.AutoSize = true;
            this.UpdateWeaknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UpdateWeaknessLabel.Location = new System.Drawing.Point(57, 236);
            this.UpdateWeaknessLabel.Name = "UpdateWeaknessLabel";
            this.UpdateWeaknessLabel.Size = new System.Drawing.Size(79, 18);
            this.UpdateWeaknessLabel.TabIndex = 27;
            this.UpdateWeaknessLabel.Text = "Weakness";
            // 
            // UpdateLevelLabel
            // 
            this.UpdateLevelLabel.AutoSize = true;
            this.UpdateLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLevelLabel.Location = new System.Drawing.Point(57, 183);
            this.UpdateLevelLabel.Name = "UpdateLevelLabel";
            this.UpdateLevelLabel.Size = new System.Drawing.Size(42, 18);
            this.UpdateLevelLabel.TabIndex = 26;
            this.UpdateLevelLabel.Text = "Level";
            // 
            // UpdatePowerTextbox
            // 
            this.UpdatePowerTextbox.Location = new System.Drawing.Point(250, 135);
            this.UpdatePowerTextbox.Name = "UpdatePowerTextbox";
            this.UpdatePowerTextbox.Size = new System.Drawing.Size(129, 20);
            this.UpdatePowerTextbox.TabIndex = 25;
            // 
            // UpdatePowerLabel
            // 
            this.UpdatePowerLabel.AutoSize = true;
            this.UpdatePowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UpdatePowerLabel.Location = new System.Drawing.Point(57, 135);
            this.UpdatePowerLabel.Name = "UpdatePowerLabel";
            this.UpdatePowerLabel.Size = new System.Drawing.Size(51, 18);
            this.UpdatePowerLabel.TabIndex = 24;
            this.UpdatePowerLabel.Text = "Power";
            // 
            // UpdateNameTextbox
            // 
            this.UpdateNameTextbox.Location = new System.Drawing.Point(250, 82);
            this.UpdateNameTextbox.Name = "UpdateNameTextbox";
            this.UpdateNameTextbox.Size = new System.Drawing.Size(129, 20);
            this.UpdateNameTextbox.TabIndex = 23;
            // 
            // UpdateNameLabel
            // 
            this.UpdateNameLabel.AutoSize = true;
            this.UpdateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNameLabel.Location = new System.Drawing.Point(57, 82);
            this.UpdateNameLabel.Name = "UpdateNameLabel";
            this.UpdateNameLabel.Size = new System.Drawing.Size(48, 18);
            this.UpdateNameLabel.TabIndex = 22;
            this.UpdateNameLabel.Text = "Name";
            // 
            // UpdateHeroButton
            // 
            this.UpdateHeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateHeroButton.Location = new System.Drawing.Point(78, 347);
            this.UpdateHeroButton.Name = "UpdateHeroButton";
            this.UpdateHeroButton.Size = new System.Drawing.Size(122, 33);
            this.UpdateHeroButton.TabIndex = 21;
            this.UpdateHeroButton.Text = "Update";
            this.UpdateHeroButton.UseVisualStyleBackColor = true;
            // 
            // UpdateHerpIDUpDown
            // 
            this.UpdateHerpIDUpDown.Location = new System.Drawing.Point(250, 33);
            this.UpdateHerpIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdateHerpIDUpDown.Name = "UpdateHerpIDUpDown";
            this.UpdateHerpIDUpDown.Size = new System.Drawing.Size(129, 20);
            this.UpdateHerpIDUpDown.TabIndex = 35;
            this.UpdateHerpIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpdateHeroID
            // 
            this.UpdateHeroID.AutoSize = true;
            this.UpdateHeroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UpdateHeroID.Location = new System.Drawing.Point(57, 31);
            this.UpdateHeroID.Name = "UpdateHeroID";
            this.UpdateHeroID.Size = new System.Drawing.Size(59, 18);
            this.UpdateHeroID.TabIndex = 34;
            this.UpdateHeroID.Text = "Hero ID";
            // 
            // UpdateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 414);
            this.Controls.Add(this.UpdateHerpIDUpDown);
            this.Controls.Add(this.UpdateHeroID);
            this.Controls.Add(this.UpdateLevelUpDown);
            this.Controls.Add(this.UpdateDepIDUpDown);
            this.Controls.Add(this.UpdateCancelButton);
            this.Controls.Add(this.UpdateDepIDLabel);
            this.Controls.Add(this.UpdateWeaknessTextbox);
            this.Controls.Add(this.UpdateWeaknessLabel);
            this.Controls.Add(this.UpdateLevelLabel);
            this.Controls.Add(this.UpdatePowerTextbox);
            this.Controls.Add(this.UpdatePowerLabel);
            this.Controls.Add(this.UpdateNameTextbox);
            this.Controls.Add(this.UpdateNameLabel);
            this.Controls.Add(this.UpdateHeroButton);
            this.Name = "UpdateHero";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDepIDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateHerpIDUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpdateLevelUpDown;
        private System.Windows.Forms.NumericUpDown UpdateDepIDUpDown;
        private System.Windows.Forms.Button UpdateCancelButton;
        private System.Windows.Forms.Label UpdateDepIDLabel;
        private System.Windows.Forms.TextBox UpdateWeaknessTextbox;
        private System.Windows.Forms.Label UpdateWeaknessLabel;
        private System.Windows.Forms.Label UpdateLevelLabel;
        private System.Windows.Forms.TextBox UpdatePowerTextbox;
        private System.Windows.Forms.Label UpdatePowerLabel;
        private System.Windows.Forms.TextBox UpdateNameTextbox;
        private System.Windows.Forms.Label UpdateNameLabel;
        private System.Windows.Forms.Button UpdateHeroButton;
        private System.Windows.Forms.NumericUpDown UpdateHerpIDUpDown;
        private System.Windows.Forms.Label UpdateHeroID;
    }
}