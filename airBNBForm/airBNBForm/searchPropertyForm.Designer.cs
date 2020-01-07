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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchPropertyForm));
            this.searchResultsBox = new System.Windows.Forms.ListBox();
            this.districtCheckBox = new System.Windows.Forms.CheckBox();
            this.NHoodCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitSearchButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.propertyNameLabel = new System.Windows.Forms.Label();
            this.propertyNameBox = new System.Windows.Forms.TextBox();
            this.exactCheckBox = new System.Windows.Forms.CheckBox();
            this.availiabilityLabel = new System.Windows.Forms.Label();
            this.minNumOfNightsLabel = new System.Windows.Forms.Label();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.numOfPropertiesLabel = new System.Windows.Forms.Label();
            this.hostIDLabel = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.displayPropertyNameLabel = new System.Windows.Forms.Label();
            this.propertyIDLabel = new System.Windows.Forms.Label();
            this.displayPropertyNameBox = new System.Windows.Forms.TextBox();
            this.propertyIDBox = new System.Windows.Forms.TextBox();
            this.roomTypeBox = new System.Windows.Forms.TextBox();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.hostNameBox = new System.Windows.Forms.TextBox();
            this.hostIDBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.availiabilityBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.minNumOfNightsBox = new System.Windows.Forms.TextBox();
            this.numOfPropertiesBox = new System.Windows.Forms.TextBox();
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
            this.searchResultsBox.SelectedIndexChanged += new System.EventHandler(this.SearchResultsBox_SelectedIndexChanged);
            // 
            // districtCheckBox
            // 
            this.districtCheckBox.AutoSize = true;
            this.districtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtCheckBox.Location = new System.Drawing.Point(56, 399);
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
            this.NHoodCheckBox.Location = new System.Drawing.Point(56, 443);
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
            this.maxPriceBox.Location = new System.Drawing.Point(177, 296);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(128, 26);
            this.maxPriceBox.TabIndex = 3;
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriceLabel.Location = new System.Drawing.Point(52, 299);
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
            this.errorLabel.Location = new System.Drawing.Point(64, 525);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 20);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "errorLabel";
            // 
            // propertyNameLabel
            // 
            this.propertyNameLabel.AutoSize = true;
            this.propertyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyNameLabel.Location = new System.Drawing.Point(52, 347);
            this.propertyNameLabel.Name = "propertyNameLabel";
            this.propertyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.propertyNameLabel.TabIndex = 8;
            this.propertyNameLabel.Text = "Property Name:";
            // 
            // propertyNameBox
            // 
            this.propertyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyNameBox.Location = new System.Drawing.Point(177, 344);
            this.propertyNameBox.Name = "propertyNameBox";
            this.propertyNameBox.Size = new System.Drawing.Size(128, 26);
            this.propertyNameBox.TabIndex = 9;
            // 
            // exactCheckBox
            // 
            this.exactCheckBox.AutoSize = true;
            this.exactCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactCheckBox.Location = new System.Drawing.Point(321, 347);
            this.exactCheckBox.Name = "exactCheckBox";
            this.exactCheckBox.Size = new System.Drawing.Size(156, 24);
            this.exactCheckBox.TabIndex = 10;
            this.exactCheckBox.Text = "Use Exact Name?";
            this.exactCheckBox.UseVisualStyleBackColor = true;
            // 
            // availiabilityLabel
            // 
            this.availiabilityLabel.AutoSize = true;
            this.availiabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availiabilityLabel.Location = new System.Drawing.Point(277, 103);
            this.availiabilityLabel.Name = "availiabilityLabel";
            this.availiabilityLabel.Size = new System.Drawing.Size(129, 20);
            this.availiabilityLabel.TabIndex = 57;
            this.availiabilityLabel.Text = "Availiability (/365)";
            // 
            // minNumOfNightsLabel
            // 
            this.minNumOfNightsLabel.AutoSize = true;
            this.minNumOfNightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumOfNightsLabel.Location = new System.Drawing.Point(277, 195);
            this.minNumOfNightsLabel.Name = "minNumOfNightsLabel";
            this.minNumOfNightsLabel.Size = new System.Drawing.Size(142, 20);
            this.minNumOfNightsLabel.TabIndex = 56;
            this.minNumOfNightsLabel.Text = "Min Num of Nights:";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLabel.Location = new System.Drawing.Point(277, 152);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(84, 20);
            this.longitudeLabel.TabIndex = 55;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLabel.Location = new System.Drawing.Point(57, 154);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(67, 20);
            this.latitudeLabel.TabIndex = 54;
            this.latitudeLabel.Text = "Latitude";
            // 
            // numOfPropertiesLabel
            // 
            this.numOfPropertiesLabel.AutoSize = true;
            this.numOfPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPropertiesLabel.Location = new System.Drawing.Point(277, 232);
            this.numOfPropertiesLabel.Name = "numOfPropertiesLabel";
            this.numOfPropertiesLabel.Size = new System.Drawing.Size(163, 20);
            this.numOfPropertiesLabel.TabIndex = 53;
            this.numOfPropertiesLabel.Text = "Number of Properties:";
            // 
            // hostIDLabel
            // 
            this.hostIDLabel.AutoSize = true;
            this.hostIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostIDLabel.Location = new System.Drawing.Point(56, 234);
            this.hostIDLabel.Name = "hostIDLabel";
            this.hostIDLabel.Size = new System.Drawing.Size(68, 20);
            this.hostIDLabel.TabIndex = 52;
            this.hostIDLabel.Text = "Host ID:";
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameLabel.Location = new System.Drawing.Point(57, 195);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(93, 20);
            this.hostNameLabel.TabIndex = 51;
            this.hostNameLabel.Text = "Host Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(277, 58);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 50;
            this.priceLabel.Text = "Price:";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(57, 105);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.roomTypeLabel.TabIndex = 49;
            this.roomTypeLabel.Text = "Room Type:";
            // 
            // displayPropertyNameLabel
            // 
            this.displayPropertyNameLabel.AutoSize = true;
            this.displayPropertyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPropertyNameLabel.Location = new System.Drawing.Point(57, 23);
            this.displayPropertyNameLabel.Name = "displayPropertyNameLabel";
            this.displayPropertyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.displayPropertyNameLabel.TabIndex = 48;
            this.displayPropertyNameLabel.Text = "Property Name:";
            // 
            // propertyIDLabel
            // 
            this.propertyIDLabel.AutoSize = true;
            this.propertyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyIDLabel.Location = new System.Drawing.Point(56, 61);
            this.propertyIDLabel.Name = "propertyIDLabel";
            this.propertyIDLabel.Size = new System.Drawing.Size(93, 20);
            this.propertyIDLabel.TabIndex = 47;
            this.propertyIDLabel.Text = "Property ID:";
            // 
            // displayPropertyNameBox
            // 
            this.displayPropertyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPropertyNameBox.Location = new System.Drawing.Point(177, 23);
            this.displayPropertyNameBox.Name = "displayPropertyNameBox";
            this.displayPropertyNameBox.ReadOnly = true;
            this.displayPropertyNameBox.Size = new System.Drawing.Size(369, 26);
            this.displayPropertyNameBox.TabIndex = 58;
            // 
            // propertyIDBox
            // 
            this.propertyIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyIDBox.Location = new System.Drawing.Point(171, 60);
            this.propertyIDBox.Name = "propertyIDBox";
            this.propertyIDBox.ReadOnly = true;
            this.propertyIDBox.Size = new System.Drawing.Size(100, 26);
            this.propertyIDBox.TabIndex = 59;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeBox.Location = new System.Drawing.Point(171, 105);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.ReadOnly = true;
            this.roomTypeBox.Size = new System.Drawing.Size(100, 26);
            this.roomTypeBox.TabIndex = 60;
            // 
            // latitudeBox
            // 
            this.latitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeBox.Location = new System.Drawing.Point(171, 154);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.ReadOnly = true;
            this.latitudeBox.Size = new System.Drawing.Size(100, 26);
            this.latitudeBox.TabIndex = 61;
            // 
            // hostNameBox
            // 
            this.hostNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameBox.Location = new System.Drawing.Point(171, 197);
            this.hostNameBox.Name = "hostNameBox";
            this.hostNameBox.ReadOnly = true;
            this.hostNameBox.Size = new System.Drawing.Size(100, 26);
            this.hostNameBox.TabIndex = 62;
            // 
            // hostIDBox
            // 
            this.hostIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostIDBox.Location = new System.Drawing.Point(171, 234);
            this.hostIDBox.Name = "hostIDBox";
            this.hostIDBox.ReadOnly = true;
            this.hostIDBox.Size = new System.Drawing.Size(100, 26);
            this.hostIDBox.TabIndex = 63;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(446, 58);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 26);
            this.priceBox.TabIndex = 64;
            // 
            // availiabilityBox
            // 
            this.availiabilityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availiabilityBox.Location = new System.Drawing.Point(446, 107);
            this.availiabilityBox.Name = "availiabilityBox";
            this.availiabilityBox.ReadOnly = true;
            this.availiabilityBox.Size = new System.Drawing.Size(100, 26);
            this.availiabilityBox.TabIndex = 65;
            // 
            // longitudeBox
            // 
            this.longitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeBox.Location = new System.Drawing.Point(446, 154);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.ReadOnly = true;
            this.longitudeBox.Size = new System.Drawing.Size(100, 26);
            this.longitudeBox.TabIndex = 66;
            // 
            // minNumOfNightsBox
            // 
            this.minNumOfNightsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumOfNightsBox.Location = new System.Drawing.Point(446, 197);
            this.minNumOfNightsBox.Name = "minNumOfNightsBox";
            this.minNumOfNightsBox.ReadOnly = true;
            this.minNumOfNightsBox.Size = new System.Drawing.Size(100, 26);
            this.minNumOfNightsBox.TabIndex = 67;
            // 
            // numOfPropertiesBox
            // 
            this.numOfPropertiesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPropertiesBox.Location = new System.Drawing.Point(446, 232);
            this.numOfPropertiesBox.Name = "numOfPropertiesBox";
            this.numOfPropertiesBox.ReadOnly = true;
            this.numOfPropertiesBox.Size = new System.Drawing.Size(100, 26);
            this.numOfPropertiesBox.TabIndex = 68;
            // 
            // searchPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 640);
            this.Controls.Add(this.numOfPropertiesBox);
            this.Controls.Add(this.minNumOfNightsBox);
            this.Controls.Add(this.longitudeBox);
            this.Controls.Add(this.availiabilityBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.hostIDBox);
            this.Controls.Add(this.hostNameBox);
            this.Controls.Add(this.latitudeBox);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.propertyIDBox);
            this.Controls.Add(this.displayPropertyNameBox);
            this.Controls.Add(this.availiabilityLabel);
            this.Controls.Add(this.minNumOfNightsLabel);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.numOfPropertiesLabel);
            this.Controls.Add(this.hostIDLabel);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.displayPropertyNameLabel);
            this.Controls.Add(this.propertyIDLabel);
            this.Controls.Add(this.exactCheckBox);
            this.Controls.Add(this.propertyNameBox);
            this.Controls.Add(this.propertyNameLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.maxPriceBox);
            this.Controls.Add(this.NHoodCheckBox);
            this.Controls.Add(this.districtCheckBox);
            this.Controls.Add(this.searchResultsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchPropertyForm";
            this.Text = "Search Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchPropertyForm_FormClosing);
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
        private System.Windows.Forms.Label propertyNameLabel;
        private System.Windows.Forms.TextBox propertyNameBox;
        private System.Windows.Forms.CheckBox exactCheckBox;
        private System.Windows.Forms.Label availiabilityLabel;
        private System.Windows.Forms.Label minNumOfNightsLabel;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label numOfPropertiesLabel;
        private System.Windows.Forms.Label hostIDLabel;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label displayPropertyNameLabel;
        private System.Windows.Forms.Label propertyIDLabel;
        private System.Windows.Forms.TextBox displayPropertyNameBox;
        private System.Windows.Forms.TextBox propertyIDBox;
        private System.Windows.Forms.TextBox roomTypeBox;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox hostNameBox;
        private System.Windows.Forms.TextBox hostIDBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox availiabilityBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.TextBox minNumOfNightsBox;
        private System.Windows.Forms.TextBox numOfPropertiesBox;
    }
}