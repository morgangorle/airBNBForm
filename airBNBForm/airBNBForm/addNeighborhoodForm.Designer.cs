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
            this.NHoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHoodLabel.Location = new System.Drawing.Point(64, 99);
            this.NHoodLabel.Name = "NHoodLabel";
            this.NHoodLabel.Size = new System.Drawing.Size(159, 20);
            this.NHoodLabel.TabIndex = 1;
            this.NHoodLabel.Text = "Neighborhood Name:";
            // 
            // NHoodBox
            // 
            this.NHoodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHoodBox.Location = new System.Drawing.Point(229, 99);
            this.NHoodBox.Name = "NHoodBox";
            this.NHoodBox.Size = new System.Drawing.Size(100, 26);
            this.NHoodBox.TabIndex = 2;
            // 
            // districtBox
            // 
            this.districtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtBox.Location = new System.Drawing.Point(220, 170);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(100, 26);
            this.districtBox.TabIndex = 3;
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictLabel.Location = new System.Drawing.Point(67, 176);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(108, 20);
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
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(136, 254);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(87, 20);
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