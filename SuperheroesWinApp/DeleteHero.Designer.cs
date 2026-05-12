namespace SuperheroesWinApp
{
    partial class DeleteHero
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
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.DeleteHeroIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteHeroIDUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchButton.Location = new System.Drawing.Point(23, 112);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(159, 30);
            this.CancelSearchButton.TabIndex = 13;
            this.CancelSearchButton.Text = "Cancel";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // DeleteHeroIDUpDown
            // 
            this.DeleteHeroIDUpDown.Location = new System.Drawing.Point(46, 36);
            this.DeleteHeroIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeleteHeroIDUpDown.Name = "DeleteHeroIDUpDown";
            this.DeleteHeroIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.DeleteHeroIDUpDown.TabIndex = 12;
            this.DeleteHeroIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(23, 76);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 30);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hero ID";
            // 
            // DeleteHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.DeleteHeroIDUpDown);
            this.Controls.Add(this.DeleteButton);
            this.Name = "DeleteHero";
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteHeroIDUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.NumericUpDown DeleteHeroIDUpDown;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
    }
}