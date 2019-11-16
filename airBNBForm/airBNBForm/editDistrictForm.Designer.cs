namespace airBNBForm
{
    partial class editDistrictForm
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
            this.currentNamePrefixLabel = new System.Windows.Forms.Label();
            this.CurrentNameLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.nextDistrictButton = new System.Windows.Forms.Button();
            this.searchInstructLabel = new System.Windows.Forms.Label();
            this.searchTopLabel = new System.Windows.Forms.Label();
            this.searchInputBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(617, 389);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // currentNamePrefixLabel
            // 
            this.currentNamePrefixLabel.AutoSize = true;
            this.currentNamePrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentNamePrefixLabel.Location = new System.Drawing.Point(52, 71);
            this.currentNamePrefixLabel.Name = "currentNamePrefixLabel";
            this.currentNamePrefixLabel.Size = new System.Drawing.Size(112, 20);
            this.currentNamePrefixLabel.TabIndex = 1;
            this.currentNamePrefixLabel.Text = "Current Name:";
            // 
            // CurrentNameLabel
            // 
            this.CurrentNameLabel.AutoSize = true;
            this.CurrentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CurrentNameLabel.Location = new System.Drawing.Point(170, 71);
            this.CurrentNameLabel.Name = "CurrentNameLabel";
            this.CurrentNameLabel.Size = new System.Drawing.Size(105, 20);
            this.CurrentNameLabel.TabIndex = 2;
            this.CurrentNameLabel.Text = "NAME HERE";
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newNameLabel.Location = new System.Drawing.Point(52, 179);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(90, 20);
            this.newNameLabel.TabIndex = 3;
            this.newNameLabel.Text = "New Name:";
            // 
            // newNameBox
            // 
            this.newNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newNameBox.Location = new System.Drawing.Point(148, 176);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(230, 26);
            this.newNameBox.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(454, 389);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit Edits";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // nextDistrictButton
            // 
            this.nextDistrictButton.Location = new System.Drawing.Point(303, 389);
            this.nextDistrictButton.Name = "nextDistrictButton";
            this.nextDistrictButton.Size = new System.Drawing.Size(75, 23);
            this.nextDistrictButton.TabIndex = 7;
            this.nextDistrictButton.Text = "Next District";
            this.nextDistrictButton.UseVisualStyleBackColor = true;
            this.nextDistrictButton.Click += new System.EventHandler(this.NextDistrictButton_Click);
            // 
            // searchInstructLabel
            // 
            this.searchInstructLabel.AutoSize = true;
            this.searchInstructLabel.Location = new System.Drawing.Point(378, 78);
            this.searchInstructLabel.Name = "searchInstructLabel";
            this.searchInstructLabel.Size = new System.Drawing.Size(243, 13);
            this.searchInstructLabel.TabIndex = 8;
            this.searchInstructLabel.Text = "Type in the district name you want to change here";
            // 
            // searchTopLabel
            // 
            this.searchTopLabel.AutoSize = true;
            this.searchTopLabel.Location = new System.Drawing.Point(542, 26);
            this.searchTopLabel.Name = "searchTopLabel";
            this.searchTopLabel.Size = new System.Drawing.Size(165, 13);
            this.searchTopLabel.TabIndex = 9;
            this.searchTopLabel.Text = "Search for a district by name here";
            // 
            // searchInputBox
            // 
            this.searchInputBox.Location = new System.Drawing.Point(637, 78);
            this.searchInputBox.Name = "searchInputBox";
            this.searchInputBox.Size = new System.Drawing.Size(100, 20);
            this.searchInputBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(545, 162);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.Location = new System.Drawing.Point(542, 132);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(95, 13);
            this.searchErrorLabel.TabIndex = 12;
            this.searchErrorLabel.Text = "Search Error Label";
            // 
            // editDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInputBox);
            this.Controls.Add(this.searchTopLabel);
            this.Controls.Add(this.searchInstructLabel);
            this.Controls.Add(this.nextDistrictButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.CurrentNameLabel);
            this.Controls.Add(this.currentNamePrefixLabel);
            this.Controls.Add(this.cancelButton);
            this.Name = "editDistrictForm";
            this.Text = "editDistrictForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label currentNamePrefixLabel;
        private System.Windows.Forms.Label CurrentNameLabel;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button nextDistrictButton;
        private System.Windows.Forms.Label searchInstructLabel;
        private System.Windows.Forms.Label searchTopLabel;
        private System.Windows.Forms.TextBox searchInputBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchErrorLabel;
    }
}