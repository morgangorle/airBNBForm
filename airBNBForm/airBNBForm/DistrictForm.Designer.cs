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
            this.editDistrictButton = new System.Windows.Forms.Button();
            this.addDistrictButton = new System.Windows.Forms.Button();
            this.addNHoodButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.districtOutputBox = new System.Windows.Forms.ListBox();
            this.nHoodOutputBox = new System.Windows.Forms.ListBox();
            this.propertyOutputBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.districtLabel = new System.Windows.Forms.Label();
            this.nHoodLabel = new System.Windows.Forms.Label();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.editDistrictNameButton = new System.Windows.Forms.Button();
            this.deleteDistrict = new System.Windows.Forms.Button();
            this.nHoodBox = new System.Windows.Forms.TextBox();
            this.editNHoodNameButton = new System.Windows.Forms.Button();
            this.deleteNHoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editDistrictButton
            // 
            this.editDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editDistrictButton.Location = new System.Drawing.Point(12, 80);
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
            this.addDistrictButton.Location = new System.Drawing.Point(12, 137);
            this.addDistrictButton.Name = "addDistrictButton";
            this.addDistrictButton.Size = new System.Drawing.Size(135, 51);
            this.addDistrictButton.TabIndex = 3;
            this.addDistrictButton.Text = "Add District";
            this.addDistrictButton.UseVisualStyleBackColor = true;
            this.addDistrictButton.Click += new System.EventHandler(this.AddDistrictButton_Click);
            // 
            // addNHoodButton
            // 
            this.addNHoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNHoodButton.Location = new System.Drawing.Point(12, 194);
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
            this.addPropertyButton.Location = new System.Drawing.Point(12, 256);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(135, 43);
            this.addPropertyButton.TabIndex = 8;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFileButton.Location = new System.Drawing.Point(12, 305);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(135, 54);
            this.readFileButton.TabIndex = 9;
            this.readFileButton.Text = "Read data from file";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // districtOutputBox
            // 
            this.districtOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtOutputBox.FormattingEnabled = true;
            this.districtOutputBox.ItemHeight = 20;
            this.districtOutputBox.Location = new System.Drawing.Point(431, 44);
            this.districtOutputBox.Name = "districtOutputBox";
            this.districtOutputBox.Size = new System.Drawing.Size(618, 164);
            this.districtOutputBox.TabIndex = 10;
            this.districtOutputBox.SelectedIndexChanged += new System.EventHandler(this.DistrictOutputBox_SelectedIndexChanged);
            // 
            // nHoodOutputBox
            // 
            this.nHoodOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHoodOutputBox.FormattingEnabled = true;
            this.nHoodOutputBox.ItemHeight = 20;
            this.nHoodOutputBox.Location = new System.Drawing.Point(431, 237);
            this.nHoodOutputBox.Name = "nHoodOutputBox";
            this.nHoodOutputBox.Size = new System.Drawing.Size(618, 144);
            this.nHoodOutputBox.TabIndex = 11;
            this.nHoodOutputBox.SelectedIndexChanged += new System.EventHandler(this.NHoodOutputBox_SelectedIndexChanged);
            // 
            // propertyOutputBox
            // 
            this.propertyOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyOutputBox.FormattingEnabled = true;
            this.propertyOutputBox.ItemHeight = 16;
            this.propertyOutputBox.Location = new System.Drawing.Point(431, 413);
            this.propertyOutputBox.Name = "propertyOutputBox";
            this.propertyOutputBox.Size = new System.Drawing.Size(608, 196);
            this.propertyOutputBox.TabIndex = 12;
            this.propertyOutputBox.SelectedIndexChanged += new System.EventHandler(this.PropertyOutputBox_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(12, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(135, 51);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.Location = new System.Drawing.Point(435, 9);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(90, 26);
            this.districtLabel.TabIndex = 14;
            this.districtLabel.Text = "Districts";
            // 
            // nHoodLabel
            // 
            this.nHoodLabel.AutoSize = true;
            this.nHoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHoodLabel.Location = new System.Drawing.Point(426, 208);
            this.nHoodLabel.Name = "nHoodLabel";
            this.nHoodLabel.Size = new System.Drawing.Size(159, 26);
            this.nHoodLabel.TabIndex = 15;
            this.nHoodLabel.Text = "Neighborhoods";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel.Location = new System.Drawing.Point(426, 384);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(111, 26);
            this.propertyLabel.TabIndex = 16;
            this.propertyLabel.Text = "Properties";
            // 
            // districtBox
            // 
            this.districtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtBox.Location = new System.Drawing.Point(266, 80);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(159, 26);
            this.districtBox.TabIndex = 17;
            // 
            // editDistrictNameButton
            // 
            this.editDistrictNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDistrictNameButton.Location = new System.Drawing.Point(266, 112);
            this.editDistrictNameButton.Name = "editDistrictNameButton";
            this.editDistrictNameButton.Size = new System.Drawing.Size(138, 34);
            this.editDistrictNameButton.TabIndex = 18;
            this.editDistrictNameButton.Text = "Edit District Name";
            this.editDistrictNameButton.UseVisualStyleBackColor = true;
            this.editDistrictNameButton.Click += new System.EventHandler(this.EditDistrictNameButton_Click);
            // 
            // deleteDistrict
            // 
            this.deleteDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDistrict.Location = new System.Drawing.Point(266, 153);
            this.deleteDistrict.Name = "deleteDistrict";
            this.deleteDistrict.Size = new System.Drawing.Size(138, 35);
            this.deleteDistrict.TabIndex = 19;
            this.deleteDistrict.Text = "Delete district";
            this.deleteDistrict.UseVisualStyleBackColor = true;
            this.deleteDistrict.Click += new System.EventHandler(this.DeleteDistrict_Click);
            // 
            // nHoodBox
            // 
            this.nHoodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHoodBox.Location = new System.Drawing.Point(282, 256);
            this.nHoodBox.Name = "nHoodBox";
            this.nHoodBox.Size = new System.Drawing.Size(143, 26);
            this.nHoodBox.TabIndex = 20;
            // 
            // editNHoodNameButton
            // 
            this.editNHoodNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNHoodNameButton.Location = new System.Drawing.Point(282, 283);
            this.editNHoodNameButton.Name = "editNHoodNameButton";
            this.editNHoodNameButton.Size = new System.Drawing.Size(143, 47);
            this.editNHoodNameButton.TabIndex = 21;
            this.editNHoodNameButton.Text = "Edit Neighborhood Name";
            this.editNHoodNameButton.UseVisualStyleBackColor = true;
            this.editNHoodNameButton.Click += new System.EventHandler(this.EditNHoodNameButton_Click);
            // 
            // deleteNHoodButton
            // 
            this.deleteNHoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNHoodButton.Location = new System.Drawing.Point(282, 336);
            this.deleteNHoodButton.Name = "deleteNHoodButton";
            this.deleteNHoodButton.Size = new System.Drawing.Size(143, 45);
            this.deleteNHoodButton.TabIndex = 22;
            this.deleteNHoodButton.Text = "Delete Neighborhood";
            this.deleteNHoodButton.UseVisualStyleBackColor = true;
            this.deleteNHoodButton.Click += new System.EventHandler(this.DeleteNHoodButton_Click);
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 608);
            this.Controls.Add(this.deleteNHoodButton);
            this.Controls.Add(this.editNHoodNameButton);
            this.Controls.Add(this.nHoodBox);
            this.Controls.Add(this.deleteDistrict);
            this.Controls.Add(this.editDistrictNameButton);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.propertyLabel);
            this.Controls.Add(this.nHoodLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.propertyOutputBox);
            this.Controls.Add(this.nHoodOutputBox);
            this.Controls.Add(this.districtOutputBox);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.addNHoodButton);
            this.Controls.Add(this.addDistrictButton);
            this.Controls.Add(this.editDistrictButton);
            this.Name = "DistrictForm";
            this.Text = "Air BNB Property Manager";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editDistrictButton;
        private System.Windows.Forms.Button addDistrictButton;
        private System.Windows.Forms.Button addNHoodButton;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.ListBox districtOutputBox;
        private System.Windows.Forms.ListBox nHoodOutputBox;
        private System.Windows.Forms.ListBox propertyOutputBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label nHoodLabel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Button editDistrictNameButton;
        private System.Windows.Forms.Button deleteDistrict;
        private System.Windows.Forms.TextBox nHoodBox;
        private System.Windows.Forms.Button editNHoodNameButton;
        private System.Windows.Forms.Button deleteNHoodButton;
    }
}

