namespace airBNBForm
{
    partial class addNeighborhoodForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.NHoodLabel = new System.Windows.Forms.Label();
            this.NHoodBox = new System.Windows.Forms.TextBox();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.addNHoodButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(591, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NHoodLabel
            // 
            this.NHoodLabel.AutoSize = true;
            this.NHoodLabel.Location = new System.Drawing.Point(64, 99);
            this.NHoodLabel.Name = "NHoodLabel";
            this.NHoodLabel.Size = new System.Drawing.Size(108, 13);
            this.NHoodLabel.TabIndex = 1;
            this.NHoodLabel.Text = "Neighborhood Name:";
            // 
            // NHoodBox
            // 
            this.NHoodBox.Location = new System.Drawing.Point(178, 96);
            this.NHoodBox.Name = "NHoodBox";
            this.NHoodBox.Size = new System.Drawing.Size(100, 20);
            this.NHoodBox.TabIndex = 2;
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(146, 173);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(100, 20);
            this.districtBox.TabIndex = 3;
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(67, 176);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(73, 13);
            this.DistrictLabel.TabIndex = 4;
            this.DistrictLabel.Text = "District Name:";
            // 
            // addNHoodButton
            // 
            this.addNHoodButton.Location = new System.Drawing.Point(434, 382);
            this.addNHoodButton.Name = "addNHoodButton";
            this.addNHoodButton.Size = new System.Drawing.Size(109, 23);
            this.addNHoodButton.TabIndex = 5;
            this.addNHoodButton.Text = "Add Neighborhood";
            this.addNHoodButton.UseVisualStyleBackColor = true;
            this.addNHoodButton.Click += new System.EventHandler(this.AddNHoodButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(104, 245);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(58, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Error Label";
            // 
            // addNeighborhoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addNHoodButton);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.NHoodBox);
            this.Controls.Add(this.NHoodLabel);
            this.Controls.Add(this.cancelButton);
            this.Name = "addNeighborhoodForm";
            this.Text = "addNeighborhoodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label NHoodLabel;
        private System.Windows.Forms.TextBox NHoodBox;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Button addNHoodButton;
        private System.Windows.Forms.Label errorLabel;
    }
}