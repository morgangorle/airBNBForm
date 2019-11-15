namespace airBNBForm
{
    partial class addDistrictForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.districtNameLabel = new System.Windows.Forms.Label();
            this.districtNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(496, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submitButton.Location = new System.Drawing.Point(389, 387);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(86, 34);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // districtNameLabel
            // 
            this.districtNameLabel.AutoSize = true;
            this.districtNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.districtNameLabel.Location = new System.Drawing.Point(53, 80);
            this.districtNameLabel.Name = "districtNameLabel";
            this.districtNameLabel.Size = new System.Drawing.Size(106, 20);
            this.districtNameLabel.TabIndex = 2;
            this.districtNameLabel.Text = "District name:";
            // 
            // districtNameBox
            // 
            this.districtNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.districtNameBox.Location = new System.Drawing.Point(165, 77);
            this.districtNameBox.Name = "districtNameBox";
            this.districtNameBox.Size = new System.Drawing.Size(100, 26);
            this.districtNameBox.TabIndex = 3;
            // 
            // addDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.districtNameBox);
            this.Controls.Add(this.districtNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "addDistrictForm";
            this.Text = "addDistrictForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label districtNameLabel;
        private System.Windows.Forms.TextBox districtNameBox;
    }
}