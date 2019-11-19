namespace airBNBForm
{
    partial class addPropertyForm
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
            this.propertyIDLabel = new System.Windows.Forms.Label();
            this.propertyIDBox = new System.Windows.Forms.TextBox();
            this.propertyNameLabel = new System.Windows.Forms.Label();
            this.propertyNameBox = new System.Windows.Forms.TextBox();
            this.hostIDBox = new System.Windows.Forms.TextBox();
            this.hostIDLabel = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.hostNameBox = new System.Windows.Forms.TextBox();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomTypeBox = new System.Windows.Forms.TextBox();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.minNumNightsBox = new System.Windows.Forms.TextBox();
            this.availiabilityBox = new System.Windows.Forms.TextBox();
            this.numOfPropertiesBox = new System.Windows.Forms.TextBox();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minNumNightsLabel = new System.Windows.Forms.Label();
            this.availiabilityLabel = new System.Windows.Forms.Label();
            this.numPropertiesLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nHoodNameBox = new System.Windows.Forms.TextBox();
            this.districtNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(600, 396);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // propertyIDLabel
            // 
            this.propertyIDLabel.AutoSize = true;
            this.propertyIDLabel.Location = new System.Drawing.Point(52, 43);
            this.propertyIDLabel.Name = "propertyIDLabel";
            this.propertyIDLabel.Size = new System.Drawing.Size(63, 13);
            this.propertyIDLabel.TabIndex = 1;
            this.propertyIDLabel.Text = "Property ID:";
            // 
            // propertyIDBox
            // 
            this.propertyIDBox.Location = new System.Drawing.Point(138, 40);
            this.propertyIDBox.Name = "propertyIDBox";
            this.propertyIDBox.Size = new System.Drawing.Size(100, 20);
            this.propertyIDBox.TabIndex = 2;
            // 
            // propertyNameLabel
            // 
            this.propertyNameLabel.AutoSize = true;
            this.propertyNameLabel.Location = new System.Drawing.Point(52, 73);
            this.propertyNameLabel.Name = "propertyNameLabel";
            this.propertyNameLabel.Size = new System.Drawing.Size(80, 13);
            this.propertyNameLabel.TabIndex = 3;
            this.propertyNameLabel.Text = "Property Name:";
            // 
            // propertyNameBox
            // 
            this.propertyNameBox.Location = new System.Drawing.Point(138, 73);
            this.propertyNameBox.Name = "propertyNameBox";
            this.propertyNameBox.Size = new System.Drawing.Size(100, 20);
            this.propertyNameBox.TabIndex = 4;
            // 
            // hostIDBox
            // 
            this.hostIDBox.Location = new System.Drawing.Point(138, 115);
            this.hostIDBox.Name = "hostIDBox";
            this.hostIDBox.Size = new System.Drawing.Size(100, 20);
            this.hostIDBox.TabIndex = 5;
            // 
            // hostIDLabel
            // 
            this.hostIDLabel.AutoSize = true;
            this.hostIDLabel.Location = new System.Drawing.Point(52, 115);
            this.hostIDLabel.Name = "hostIDLabel";
            this.hostIDLabel.Size = new System.Drawing.Size(46, 13);
            this.hostIDLabel.TabIndex = 6;
            this.hostIDLabel.Text = "Host ID:";
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(52, 162);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(63, 13);
            this.hostNameLabel.TabIndex = 7;
            this.hostNameLabel.Text = "Host Name:";
            // 
            // hostNameBox
            // 
            this.hostNameBox.Location = new System.Drawing.Point(138, 162);
            this.hostNameBox.Name = "hostNameBox";
            this.hostNameBox.Size = new System.Drawing.Size(100, 20);
            this.hostNameBox.TabIndex = 8;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(55, 208);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Room Type:";
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Location = new System.Drawing.Point(138, 201);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(100, 20);
            this.roomTypeBox.TabIndex = 10;
            // 
            // latitudeBox
            // 
            this.latitudeBox.Location = new System.Drawing.Point(138, 247);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.Size = new System.Drawing.Size(100, 20);
            this.latitudeBox.TabIndex = 11;
            // 
            // longitudeBox
            // 
            this.longitudeBox.Location = new System.Drawing.Point(138, 283);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeBox.TabIndex = 12;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(138, 317);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 13;
            // 
            // minNumNightsBox
            // 
            this.minNumNightsBox.Location = new System.Drawing.Point(148, 371);
            this.minNumNightsBox.Name = "minNumNightsBox";
            this.minNumNightsBox.Size = new System.Drawing.Size(100, 20);
            this.minNumNightsBox.TabIndex = 14;
            // 
            // availiabilityBox
            // 
            this.availiabilityBox.Location = new System.Drawing.Point(360, 43);
            this.availiabilityBox.Name = "availiabilityBox";
            this.availiabilityBox.Size = new System.Drawing.Size(100, 20);
            this.availiabilityBox.TabIndex = 15;
            // 
            // numOfPropertiesBox
            // 
            this.numOfPropertiesBox.Location = new System.Drawing.Point(403, 94);
            this.numOfPropertiesBox.Name = "numOfPropertiesBox";
            this.numOfPropertiesBox.Size = new System.Drawing.Size(100, 20);
            this.numOfPropertiesBox.TabIndex = 16;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(55, 247);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(48, 13);
            this.latitudeLabel.TabIndex = 17;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Location = new System.Drawing.Point(58, 283);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(57, 13);
            this.longitudeLabel.TabIndex = 18;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(55, 320);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Price:";
            // 
            // minNumNightsLabel
            // 
            this.minNumNightsLabel.AutoSize = true;
            this.minNumNightsLabel.Location = new System.Drawing.Point(55, 374);
            this.minNumNightsLabel.Name = "minNumNightsLabel";
            this.minNumNightsLabel.Size = new System.Drawing.Size(97, 13);
            this.minNumNightsLabel.TabIndex = 20;
            this.minNumNightsLabel.Text = "Min Num of Nights:";
            // 
            // availiabilityLabel
            // 
            this.availiabilityLabel.AutoSize = true;
            this.availiabilityLabel.Location = new System.Drawing.Point(300, 43);
            this.availiabilityLabel.Name = "availiabilityLabel";
            this.availiabilityLabel.Size = new System.Drawing.Size(61, 13);
            this.availiabilityLabel.TabIndex = 21;
            this.availiabilityLabel.Text = "Availiability:";
            // 
            // numPropertiesLabel
            // 
            this.numPropertiesLabel.AutoSize = true;
            this.numPropertiesLabel.Location = new System.Drawing.Point(303, 97);
            this.numPropertiesLabel.Name = "numPropertiesLabel";
            this.numPropertiesLabel.Size = new System.Drawing.Size(94, 13);
            this.numPropertiesLabel.TabIndex = 22;
            this.numPropertiesLabel.Text = "Num of Properties:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(511, 395);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Neighborhood Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "District Name:";
            // 
            // nHoodNameBox
            // 
            this.nHoodNameBox.Location = new System.Drawing.Point(420, 159);
            this.nHoodNameBox.Name = "nHoodNameBox";
            this.nHoodNameBox.Size = new System.Drawing.Size(100, 20);
            this.nHoodNameBox.TabIndex = 26;
            // 
            // districtNameBox
            // 
            this.districtNameBox.Location = new System.Drawing.Point(420, 208);
            this.districtNameBox.Name = "districtNameBox";
            this.districtNameBox.Size = new System.Drawing.Size(100, 20);
            this.districtNameBox.TabIndex = 27;
            // 
            // addPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.districtNameBox);
            this.Controls.Add(this.nHoodNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numPropertiesLabel);
            this.Controls.Add(this.availiabilityLabel);
            this.Controls.Add(this.minNumNightsLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.numOfPropertiesBox);
            this.Controls.Add(this.availiabilityBox);
            this.Controls.Add(this.minNumNightsBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.longitudeBox);
            this.Controls.Add(this.latitudeBox);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.hostNameBox);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.hostIDLabel);
            this.Controls.Add(this.hostIDBox);
            this.Controls.Add(this.propertyNameBox);
            this.Controls.Add(this.propertyNameLabel);
            this.Controls.Add(this.propertyIDBox);
            this.Controls.Add(this.propertyIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Name = "addPropertyForm";
            this.Text = "addProperty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label propertyIDLabel;
        private System.Windows.Forms.TextBox propertyIDBox;
        private System.Windows.Forms.Label propertyNameLabel;
        private System.Windows.Forms.TextBox propertyNameBox;
        private System.Windows.Forms.TextBox hostIDBox;
        private System.Windows.Forms.Label hostIDLabel;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.TextBox hostNameBox;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.TextBox roomTypeBox;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox minNumNightsBox;
        private System.Windows.Forms.TextBox availiabilityBox;
        private System.Windows.Forms.TextBox numOfPropertiesBox;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minNumNightsLabel;
        private System.Windows.Forms.Label availiabilityLabel;
        private System.Windows.Forms.Label numPropertiesLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nHoodNameBox;
        private System.Windows.Forms.TextBox districtNameBox;
    }
}