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
            this.addNHoodButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayDistrictButton
            // 
            this.displayDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayDistrictButton.Location = new System.Drawing.Point(66, 23);
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
            this.nextDistrictButton.Location = new System.Drawing.Point(66, 73);
            this.nextDistrictButton.Name = "nextDistrictButton";
            this.nextDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.nextDistrictButton.TabIndex = 1;
            this.nextDistrictButton.Text = "Next District";
            this.nextDistrictButton.UseVisualStyleBackColor = true;
            this.nextDistrictButton.Click += new System.EventHandler(this.NextDistrictButton_Click);
            // 
            // editDistrictButton
            // 
            this.editDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editDistrictButton.Location = new System.Drawing.Point(66, 130);
            this.editDistrictButton.Name = "editDistrictButton";
            this.editDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.editDistrictButton.TabIndex = 2;
            this.editDistrictButton.Text = "Edit Districts";
            this.editDistrictButton.UseVisualStyleBackColor = true;
            this.editDistrictButton.Click += new System.EventHandler(this.EditDistrictButton_Click);
            // 
            // addDistrictButton
            // 
            this.addDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDistrictButton.Location = new System.Drawing.Point(66, 187);
            this.addDistrictButton.Name = "addDistrictButton";
            this.addDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.addDistrictButton.TabIndex = 3;
            this.addDistrictButton.Text = "Add District";
            this.addDistrictButton.UseVisualStyleBackColor = true;
            this.addDistrictButton.Click += new System.EventHandler(this.AddDistrictButton_Click);
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
            this.districtNameLabel.Location = new System.Drawing.Point(568, 34);
            this.districtNameLabel.Name = "districtNameLabel";
            this.districtNameLabel.Size = new System.Drawing.Size(187, 26);
            this.districtNameLabel.TabIndex = 5;
            this.districtNameLabel.Text = "Name will be here";
            // 
            // districtNamePrefixLabel
            // 
            this.districtNamePrefixLabel.AutoSize = true;
            this.districtNamePrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.districtNamePrefixLabel.Location = new System.Drawing.Point(392, 34);
            this.districtNamePrefixLabel.Name = "districtNamePrefixLabel";
            this.districtNamePrefixLabel.Size = new System.Drawing.Size(150, 26);
            this.districtNamePrefixLabel.TabIndex = 6;
            this.districtNamePrefixLabel.Text = "District Name:";
            // 
            // addNHoodButton
            // 
            this.addNHoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNHoodButton.Location = new System.Drawing.Point(66, 244);
            this.addNHoodButton.Name = "addNHoodButton";
            this.addNHoodButton.Size = new System.Drawing.Size(135, 56);
            this.addNHoodButton.TabIndex = 7;
            this.addNHoodButton.Text = "Add Neighborhood";
            this.addNHoodButton.UseVisualStyleBackColor = true;
            this.addNHoodButton.Click += new System.EventHandler(this.AddNHoodButton_Click);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPropertyButton.Location = new System.Drawing.Point(66, 306);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(135, 43);
            this.addPropertyButton.TabIndex = 8;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.addNHoodButton);
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
        private System.Windows.Forms.Button addNHoodButton;
        private System.Windows.Forms.Button addPropertyButton;
    }
}

