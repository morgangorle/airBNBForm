namespace airBNBForm
{
    partial class searchPropertyForm
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
            this.searchResultsBox = new System.Windows.Forms.ListBox();
            this.districtCheckBox = new System.Windows.Forms.CheckBox();
            this.NHoodCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitSearchButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyNameBox = new System.Windows.Forms.TextBox();
            this.exactCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // searchResultsBox
            // 
            this.searchResultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsBox.FormattingEnabled = true;
            this.searchResultsBox.HorizontalScrollbar = true;
            this.searchResultsBox.ItemHeight = 16;
            this.searchResultsBox.Location = new System.Drawing.Point(655, 10);
            this.searchResultsBox.Name = "searchResultsBox";
            this.searchResultsBox.Size = new System.Drawing.Size(795, 628);
            this.searchResultsBox.TabIndex = 0;
            // 
            // districtCheckBox
            // 
            this.districtCheckBox.AutoSize = true;
            this.districtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtCheckBox.Location = new System.Drawing.Point(69, 82);
            this.districtCheckBox.Name = "districtCheckBox";
            this.districtCheckBox.Size = new System.Drawing.Size(152, 24);
            this.districtCheckBox.TabIndex = 1;
            this.districtCheckBox.Text = "In Current District";
            this.districtCheckBox.UseVisualStyleBackColor = true;
            this.districtCheckBox.CheckedChanged += new System.EventHandler(this.DistrictCheckBox_CheckedChanged);
            // 
            // NHoodCheckBox
            // 
            this.NHoodCheckBox.AutoSize = true;
            this.NHoodCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHoodCheckBox.Location = new System.Drawing.Point(69, 122);
            this.NHoodCheckBox.Name = "NHoodCheckBox";
            this.NHoodCheckBox.Size = new System.Drawing.Size(203, 24);
            this.NHoodCheckBox.TabIndex = 2;
            this.NHoodCheckBox.Text = "In Current Neighborhood";
            this.NHoodCheckBox.UseVisualStyleBackColor = true;
            this.NHoodCheckBox.CheckedChanged += new System.EventHandler(this.NHoodCheckBox_CheckedChanged);
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriceBox.Location = new System.Drawing.Point(194, 197);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(128, 26);
            this.maxPriceBox.TabIndex = 3;
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriceLabel.Location = new System.Drawing.Point(69, 200);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(119, 20);
            this.maxPriceLabel.TabIndex = 4;
            this.maxPriceLabel.Text = "Maximum Price:";
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(137, 594);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 34);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // exitSearchButton
            // 
            this.exitSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSearchButton.Location = new System.Drawing.Point(267, 594);
            this.exitSearchButton.Name = "exitSearchButton";
            this.exitSearchButton.Size = new System.Drawing.Size(106, 34);
            this.exitSearchButton.TabIndex = 6;
            this.exitSearchButton.Text = "Exit Search";
            this.exitSearchButton.UseVisualStyleBackColor = true;
            this.exitSearchButton.Click += new System.EventHandler(this.ExitSearchButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(65, 448);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 20);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "errorLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Property Name:";
            // 
            // propertyNameBox
            // 
            this.propertyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyNameBox.Location = new System.Drawing.Point(194, 266);
            this.propertyNameBox.Name = "propertyNameBox";
            this.propertyNameBox.Size = new System.Drawing.Size(128, 26);
            this.propertyNameBox.TabIndex = 9;
            // 
            // exactCheckBox
            // 
            this.exactCheckBox.AutoSize = true;
            this.exactCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactCheckBox.Location = new System.Drawing.Point(348, 268);
            this.exactCheckBox.Name = "exactCheckBox";
            this.exactCheckBox.Size = new System.Drawing.Size(156, 24);
            this.exactCheckBox.TabIndex = 10;
            this.exactCheckBox.Text = "Use Exact Name?";
            this.exactCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 640);
            this.Controls.Add(this.exactCheckBox);
            this.Controls.Add(this.propertyNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.maxPriceBox);
            this.Controls.Add(this.NHoodCheckBox);
            this.Controls.Add(this.districtCheckBox);
            this.Controls.Add(this.searchResultsBox);
            this.Name = "searchPropertyForm";
            this.Text = "searchPropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchResultsBox;
        private System.Windows.Forms.CheckBox districtCheckBox;
        private System.Windows.Forms.CheckBox NHoodCheckBox;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitSearchButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox propertyNameBox;
        private System.Windows.Forms.CheckBox exactCheckBox;
    }
}