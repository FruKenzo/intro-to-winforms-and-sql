namespace SuperheroesWinApp
{
    partial class SearchForHero
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchDepIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.SearchNameTextbox = new System.Windows.Forms.TextBox();
            this.SearchHeroIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.SearchHeroPickColumn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDepIDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchHeroIDUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(31, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 30);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchDepIDUpDown
            // 
            this.SearchDepIDUpDown.Location = new System.Drawing.Point(54, 75);
            this.SearchDepIDUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SearchDepIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SearchDepIDUpDown.Name = "SearchDepIDUpDown";
            this.SearchDepIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.SearchDepIDUpDown.TabIndex = 5;
            this.SearchDepIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SearchDepIDUpDown.Visible = false;
            // 
            // SearchNameTextbox
            // 
            this.SearchNameTextbox.Location = new System.Drawing.Point(54, 74);
            this.SearchNameTextbox.Name = "SearchNameTextbox";
            this.SearchNameTextbox.Size = new System.Drawing.Size(120, 20);
            this.SearchNameTextbox.TabIndex = 6;
            this.SearchNameTextbox.Visible = false;
            // 
            // SearchHeroIDUpDown
            // 
            this.SearchHeroIDUpDown.Location = new System.Drawing.Point(54, 75);
            this.SearchHeroIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SearchHeroIDUpDown.Name = "SearchHeroIDUpDown";
            this.SearchHeroIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.SearchHeroIDUpDown.TabIndex = 7;
            this.SearchHeroIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchHeroPickColumn
            // 
            this.SearchHeroPickColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchHeroPickColumn.FormattingEnabled = true;
            this.SearchHeroPickColumn.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Department_ID"});
            this.SearchHeroPickColumn.Location = new System.Drawing.Point(31, 47);
            this.SearchHeroPickColumn.Name = "SearchHeroPickColumn";
            this.SearchHeroPickColumn.Size = new System.Drawing.Size(159, 21);
            this.SearchHeroPickColumn.TabIndex = 8;
            this.SearchHeroPickColumn.SelectedIndexChanged += new System.EventHandler(this.SearchHeroPickColumn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search for hero by:";
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchButton.Location = new System.Drawing.Point(31, 151);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(159, 30);
            this.CancelSearchButton.TabIndex = 10;
            this.CancelSearchButton.Text = "Cancel";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // SearchForHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 226);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchHeroPickColumn);
            this.Controls.Add(this.SearchHeroIDUpDown);
            this.Controls.Add(this.SearchNameTextbox);
            this.Controls.Add(this.SearchDepIDUpDown);
            this.Controls.Add(this.SearchButton);
            this.Name = "SearchForHero";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForHero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDepIDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchHeroIDUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.NumericUpDown SearchDepIDUpDown;
        private System.Windows.Forms.TextBox SearchNameTextbox;
        private System.Windows.Forms.NumericUpDown SearchHeroIDUpDown;
        private System.Windows.Forms.ComboBox SearchHeroPickColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelSearchButton;
    }
}