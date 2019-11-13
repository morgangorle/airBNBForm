namespace airBNBForm
{
    partial class DistrictForm
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
            this.displayDistrictButton = new System.Windows.Forms.Button();
            this.nextDistrictButton = new System.Windows.Forms.Button();
            this.editDistrictButton = new System.Windows.Forms.Button();
            this.addDistrictButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.districtNameLabel = new System.Windows.Forms.Label();
            this.districtNamePrefixLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayDistrictButton
            // 
            this.displayDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayDistrictButton.Location = new System.Drawing.Point(63, 72);
            this.displayDistrictButton.Name = "displayDistrictButton";
            this.displayDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.displayDistrictButton.TabIndex = 0;
            this.displayDistrictButton.Text = "Display District Properties";
            this.displayDistrictButton.UseVisualStyleBackColor = true;
            this.displayDistrictButton.Click += new System.EventHandler(this.displayDistrictButton_Click);
            // 
            // nextDistrictButton
            // 
            this.nextDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nextDistrictButton.Location = new System.Drawing.Point(63, 122);
            this.nextDistrictButton.Name = "nextDistrictButton";
            this.nextDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.nextDistrictButton.TabIndex = 1;
            this.nextDistrictButton.Text = "Next District";
            this.nextDistrictButton.UseVisualStyleBackColor = true;
            // 
            // editDistrictButton
            // 
            this.editDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editDistrictButton.Location = new System.Drawing.Point(63, 179);
            this.editDistrictButton.Name = "editDistrictButton";
            this.editDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.editDistrictButton.TabIndex = 2;
            this.editDistrictButton.Text = "Edit Districts";
            this.editDistrictButton.UseVisualStyleBackColor = true;
            // 
            // addDistrictButton
            // 
            this.addDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDistrictButton.Location = new System.Drawing.Point(63, 236);
            this.addDistrictButton.Name = "addDistrictButton";
            this.addDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.addDistrictButton.TabIndex = 3;
            this.addDistrictButton.Text = "Add District";
            this.addDistrictButton.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(300, 72);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(488, 368);
            this.outputBox.TabIndex = 4;
            // 
            // districtNameLabel
            // 
            this.districtNameLabel.AutoSize = true;
            this.districtNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.districtNameLabel.Location = new System.Drawing.Point(417, 34);
            this.districtNameLabel.Name = "districtNameLabel";
            this.districtNameLabel.Size = new System.Drawing.Size(187, 26);
            this.districtNameLabel.TabIndex = 5;
            this.districtNameLabel.Text = "Name will be here";
            // 
            // districtNamePrefixLabel
            // 
            this.districtNamePrefixLabel.AutoSize = true;
            this.districtNamePrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.districtNamePrefixLabel.Location = new System.Drawing.Point(261, 34);
            this.districtNamePrefixLabel.Name = "districtNamePrefixLabel";
            this.districtNamePrefixLabel.Size = new System.Drawing.Size(150, 26);
            this.districtNamePrefixLabel.TabIndex = 6;
            this.districtNamePrefixLabel.Text = "District Name:";
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.districtNamePrefixLabel);
            this.Controls.Add(this.districtNameLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.addDistrictButton);
            this.Controls.Add(this.editDistrictButton);
            this.Controls.Add(this.nextDistrictButton);
            this.Controls.Add(this.displayDistrictButton);
            this.Name = "DistrictForm";
            this.Text = "Air BNB Property Manager";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayDistrictButton;
        private System.Windows.Forms.Button nextDistrictButton;
        private System.Windows.Forms.Button editDistrictButton;
        private System.Windows.Forms.Button addDistrictButton;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Label districtNameLabel;
        private System.Windows.Forms.Label districtNamePrefixLabel;
    }
}

