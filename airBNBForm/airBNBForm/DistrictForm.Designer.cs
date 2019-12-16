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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistrictForm));
            this.addDistrictButton = new System.Windows.Forms.Button();
            this.addNHoodButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.districtOutputBox = new System.Windows.Forms.ListBox();
            this.nHoodOutputBox = new System.Windows.Forms.ListBox();
            this.propertyOutputBox = new System.Windows.Forms.ListBox();
            this.districtLabel = new System.Windows.Forms.Label();
            this.nHoodLabel = new System.Windows.Forms.Label();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.editDistrictNameButton = new System.Windows.Forms.Button();
            this.deleteDistrict = new System.Windows.Forms.Button();
            this.nHoodBox = new System.Windows.Forms.TextBox();
            this.editNHoodNameButton = new System.Windows.Forms.Button();
            this.deleteNHoodButton = new System.Windows.Forms.Button();
            this.editPropertyButton = new System.Windows.Forms.Button();
            this.deletePropertyButton = new System.Windows.Forms.Button();
            this.propertyIDBox = new System.Windows.Forms.TextBox();
            this.propertyNameBox = new System.Windows.Forms.TextBox();
            this.roomTypeBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.hostNameBox = new System.Windows.Forms.TextBox();
            this.hostIDBox = new System.Windows.Forms.TextBox();
            this.numOfPropertiesBox = new System.Windows.Forms.TextBox();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.minNumOfNightsBox = new System.Windows.Forms.TextBox();
            this.availiabilityBox = new System.Windows.Forms.TextBox();
            this.propertyIDLabel = new System.Windows.Forms.Label();
            this.propertyNameLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.hostIDLabel = new System.Windows.Forms.Label();
            this.numOfPropertiesLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.minNumOfNightsLabel = new System.Windows.Forms.Label();
            this.availiabilityLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDistrictButton
            // 
            this.addDistrictButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDistrictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDistrictButton.Location = new System.Drawing.Point(948, 40);
            this.addDistrictButton.Name = "addDistrictButton";
            this.addDistrictButton.Size = new System.Drawing.Size(138, 32);
            this.addDistrictButton.TabIndex = 3;
            this.addDistrictButton.Text = "Add District";
            this.addDistrictButton.UseVisualStyleBackColor = true;
            this.addDistrictButton.Click += new System.EventHandler(this.AddDistrictButton_Click);
            // 
            // addNHoodButton
            // 
            this.addNHoodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNHoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addNHoodButton.Location = new System.Drawing.Point(1592, 41);
            this.addNHoodButton.Name = "addNHoodButton";
            this.addNHoodButton.Size = new System.Drawing.Size(143, 37);
            this.addNHoodButton.TabIndex = 7;
            this.addNHoodButton.Text = "Add Neighborhood";
            this.addNHoodButton.UseVisualStyleBackColor = true;
            this.addNHoodButton.Click += new System.EventHandler(this.AddNHoodButton_Click);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPropertyButton.Location = new System.Drawing.Point(1101, 456);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(135, 43);
            this.addPropertyButton.TabIndex = 8;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // districtOutputBox
            // 
            this.districtOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtOutputBox.FormattingEnabled = true;
            this.districtOutputBox.ItemHeight = 20;
            this.districtOutputBox.Location = new System.Drawing.Point(510, 40);
            this.districtOutputBox.Name = "districtOutputBox";
            this.districtOutputBox.Size = new System.Drawing.Size(432, 224);
            this.districtOutputBox.TabIndex = 10;
            this.districtOutputBox.SelectedIndexChanged += new System.EventHandler(this.DistrictOutputBox_SelectedIndexChanged);
            // 
            // nHoodOutputBox
            // 
            this.nHoodOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHoodOutputBox.FormattingEnabled = true;
            this.nHoodOutputBox.ItemHeight = 20;
            this.nHoodOutputBox.Location = new System.Drawing.Point(1092, 42);
            this.nHoodOutputBox.Name = "nHoodOutputBox";
            this.nHoodOutputBox.Size = new System.Drawing.Size(494, 224);
            this.nHoodOutputBox.TabIndex = 11;
            this.nHoodOutputBox.SelectedIndexChanged += new System.EventHandler(this.NHoodOutputBox_SelectedIndexChanged);
            // 
            // propertyOutputBox
            // 
            this.propertyOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyOutputBox.FormattingEnabled = true;
            this.propertyOutputBox.HorizontalScrollbar = true;
            this.propertyOutputBox.ItemHeight = 16;
            this.propertyOutputBox.Location = new System.Drawing.Point(1, 450);
            this.propertyOutputBox.Name = "propertyOutputBox";
            this.propertyOutputBox.Size = new System.Drawing.Size(1085, 356);
            this.propertyOutputBox.TabIndex = 12;
            this.propertyOutputBox.SelectedIndexChanged += new System.EventHandler(this.PropertyOutputBox_SelectedIndexChanged);
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.Location = new System.Drawing.Point(606, 7);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(90, 26);
            this.districtLabel.TabIndex = 14;
            this.districtLabel.Text = "Districts";
            // 
            // nHoodLabel
            // 
            this.nHoodLabel.AutoSize = true;
            this.nHoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHoodLabel.Location = new System.Drawing.Point(1166, 13);
            this.nHoodLabel.Name = "nHoodLabel";
            this.nHoodLabel.Size = new System.Drawing.Size(159, 26);
            this.nHoodLabel.TabIndex = 15;
            this.nHoodLabel.Text = "Neighborhoods";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel.Location = new System.Drawing.Point(409, 423);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(111, 26);
            this.propertyLabel.TabIndex = 16;
            this.propertyLabel.Text = "Properties";
            // 
            // districtBox
            // 
            this.districtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtBox.Location = new System.Drawing.Point(783, 12);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(159, 26);
            this.districtBox.TabIndex = 17;
            // 
            // editDistrictNameButton
            // 
            this.editDistrictNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editDistrictNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDistrictNameButton.Location = new System.Drawing.Point(948, 76);
            this.editDistrictNameButton.Name = "editDistrictNameButton";
            this.editDistrictNameButton.Size = new System.Drawing.Size(138, 34);
            this.editDistrictNameButton.TabIndex = 18;
            this.editDistrictNameButton.Text = "Edit District Name";
            this.editDistrictNameButton.UseVisualStyleBackColor = true;
            this.editDistrictNameButton.Click += new System.EventHandler(this.EditDistrictNameButton_Click);
            // 
            // deleteDistrict
            // 
            this.deleteDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDistrict.Location = new System.Drawing.Point(948, 116);
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
            this.nHoodBox.Location = new System.Drawing.Point(1443, 12);
            this.nHoodBox.Name = "nHoodBox";
            this.nHoodBox.Size = new System.Drawing.Size(143, 26);
            this.nHoodBox.TabIndex = 20;
            // 
            // editNHoodNameButton
            // 
            this.editNHoodNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editNHoodNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNHoodNameButton.Location = new System.Drawing.Point(1592, 80);
            this.editNHoodNameButton.Name = "editNHoodNameButton";
            this.editNHoodNameButton.Size = new System.Drawing.Size(143, 47);
            this.editNHoodNameButton.TabIndex = 21;
            this.editNHoodNameButton.Text = "Edit Neighborhood Name";
            this.editNHoodNameButton.UseVisualStyleBackColor = true;
            this.editNHoodNameButton.Click += new System.EventHandler(this.EditNHoodNameButton_Click);
            // 
            // deleteNHoodButton
            // 
            this.deleteNHoodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteNHoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNHoodButton.Location = new System.Drawing.Point(1592, 133);
            this.deleteNHoodButton.Name = "deleteNHoodButton";
            this.deleteNHoodButton.Size = new System.Drawing.Size(143, 45);
            this.deleteNHoodButton.TabIndex = 22;
            this.deleteNHoodButton.Text = "Delete Neighborhood";
            this.deleteNHoodButton.UseVisualStyleBackColor = true;
            this.deleteNHoodButton.Click += new System.EventHandler(this.DeleteNHoodButton_Click);
            // 
            // editPropertyButton
            // 
            this.editPropertyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPropertyButton.Location = new System.Drawing.Point(1242, 456);
            this.editPropertyButton.Name = "editPropertyButton";
            this.editPropertyButton.Size = new System.Drawing.Size(135, 43);
            this.editPropertyButton.TabIndex = 23;
            this.editPropertyButton.Text = "Edit Property";
            this.editPropertyButton.UseVisualStyleBackColor = true;
            this.editPropertyButton.Click += new System.EventHandler(this.EditPropertyButton_Click);
            // 
            // deletePropertyButton
            // 
            this.deletePropertyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletePropertyButton.Location = new System.Drawing.Point(1392, 456);
            this.deletePropertyButton.Name = "deletePropertyButton";
            this.deletePropertyButton.Size = new System.Drawing.Size(132, 43);
            this.deletePropertyButton.TabIndex = 24;
            this.deletePropertyButton.Text = "Delete Property";
            this.deletePropertyButton.UseVisualStyleBackColor = true;
            this.deletePropertyButton.Click += new System.EventHandler(this.DeletePropertyButton_Click);
            // 
            // propertyIDBox
            // 
            this.propertyIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyIDBox.Location = new System.Drawing.Point(1225, 559);
            this.propertyIDBox.Name = "propertyIDBox";
            this.propertyIDBox.Size = new System.Drawing.Size(152, 26);
            this.propertyIDBox.TabIndex = 25;
            // 
            // propertyNameBox
            // 
            this.propertyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyNameBox.Location = new System.Drawing.Point(1225, 514);
            this.propertyNameBox.Name = "propertyNameBox";
            this.propertyNameBox.Size = new System.Drawing.Size(470, 26);
            this.propertyNameBox.TabIndex = 26;
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeBox.Location = new System.Drawing.Point(1225, 611);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(215, 26);
            this.roomTypeBox.TabIndex = 27;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(1494, 559);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(107, 26);
            this.priceBox.TabIndex = 28;
            // 
            // hostNameBox
            // 
            this.hostNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameBox.Location = new System.Drawing.Point(1225, 699);
            this.hostNameBox.Name = "hostNameBox";
            this.hostNameBox.Size = new System.Drawing.Size(175, 26);
            this.hostNameBox.TabIndex = 29;
            // 
            // hostIDBox
            // 
            this.hostIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostIDBox.Location = new System.Drawing.Point(1225, 738);
            this.hostIDBox.Name = "hostIDBox";
            this.hostIDBox.Size = new System.Drawing.Size(122, 26);
            this.hostIDBox.TabIndex = 30;
            // 
            // numOfPropertiesBox
            // 
            this.numOfPropertiesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPropertiesBox.Location = new System.Drawing.Point(1533, 735);
            this.numOfPropertiesBox.Name = "numOfPropertiesBox";
            this.numOfPropertiesBox.Size = new System.Drawing.Size(100, 26);
            this.numOfPropertiesBox.TabIndex = 31;
            // 
            // latitudeBox
            // 
            this.latitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeBox.Location = new System.Drawing.Point(1225, 652);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.Size = new System.Drawing.Size(122, 26);
            this.latitudeBox.TabIndex = 32;
            // 
            // longitudeBox
            // 
            this.longitudeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeBox.Location = new System.Drawing.Point(1475, 652);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.Size = new System.Drawing.Size(100, 26);
            this.longitudeBox.TabIndex = 33;
            // 
            // minNumOfNightsBox
            // 
            this.minNumOfNightsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumOfNightsBox.Location = new System.Drawing.Point(1581, 693);
            this.minNumOfNightsBox.Name = "minNumOfNightsBox";
            this.minNumOfNightsBox.Size = new System.Drawing.Size(114, 26);
            this.minNumOfNightsBox.TabIndex = 34;
            // 
            // availiabilityBox
            // 
            this.availiabilityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availiabilityBox.Location = new System.Drawing.Point(1581, 611);
            this.availiabilityBox.Name = "availiabilityBox";
            this.availiabilityBox.Size = new System.Drawing.Size(100, 26);
            this.availiabilityBox.TabIndex = 35;
            // 
            // propertyIDLabel
            // 
            this.propertyIDLabel.AutoSize = true;
            this.propertyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyIDLabel.Location = new System.Drawing.Point(1101, 565);
            this.propertyIDLabel.Name = "propertyIDLabel";
            this.propertyIDLabel.Size = new System.Drawing.Size(93, 20);
            this.propertyIDLabel.TabIndex = 36;
            this.propertyIDLabel.Text = "Property ID:";
            // 
            // propertyNameLabel
            // 
            this.propertyNameLabel.AutoSize = true;
            this.propertyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyNameLabel.Location = new System.Drawing.Point(1102, 514);
            this.propertyNameLabel.Name = "propertyNameLabel";
            this.propertyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.propertyNameLabel.TabIndex = 37;
            this.propertyNameLabel.Text = "Property Name:";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(1102, 609);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.roomTypeLabel.TabIndex = 38;
            this.roomTypeLabel.Text = "Room Type:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(1433, 565);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 39;
            this.priceLabel.Text = "Price:";
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameLabel.Location = new System.Drawing.Point(1102, 699);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(93, 20);
            this.hostNameLabel.TabIndex = 40;
            this.hostNameLabel.Text = "Host Name:";
            // 
            // hostIDLabel
            // 
            this.hostIDLabel.AutoSize = true;
            this.hostIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostIDLabel.Location = new System.Drawing.Point(1101, 738);
            this.hostIDLabel.Name = "hostIDLabel";
            this.hostIDLabel.Size = new System.Drawing.Size(68, 20);
            this.hostIDLabel.TabIndex = 41;
            this.hostIDLabel.Text = "Host ID:";
            // 
            // numOfPropertiesLabel
            // 
            this.numOfPropertiesLabel.AutoSize = true;
            this.numOfPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPropertiesLabel.Location = new System.Drawing.Point(1364, 741);
            this.numOfPropertiesLabel.Name = "numOfPropertiesLabel";
            this.numOfPropertiesLabel.Size = new System.Drawing.Size(163, 20);
            this.numOfPropertiesLabel.TabIndex = 42;
            this.numOfPropertiesLabel.Text = "Number of Properties:";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLabel.Location = new System.Drawing.Point(1102, 658);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(67, 20);
            this.latitudeLabel.TabIndex = 43;
            this.latitudeLabel.Text = "Latitude";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLabel.Location = new System.Drawing.Point(1364, 655);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(84, 20);
            this.longitudeLabel.TabIndex = 44;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // minNumOfNightsLabel
            // 
            this.minNumOfNightsLabel.AutoSize = true;
            this.minNumOfNightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumOfNightsLabel.Location = new System.Drawing.Point(1433, 696);
            this.minNumOfNightsLabel.Name = "minNumOfNightsLabel";
            this.minNumOfNightsLabel.Size = new System.Drawing.Size(142, 20);
            this.minNumOfNightsLabel.TabIndex = 45;
            this.minNumOfNightsLabel.Text = "Min Num of Nights:";
            // 
            // availiabilityLabel
            // 
            this.availiabilityLabel.AutoSize = true;
            this.availiabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availiabilityLabel.Location = new System.Drawing.Point(1446, 614);
            this.availiabilityLabel.Name = "availiabilityLabel";
            this.availiabilityLabel.Size = new System.Drawing.Size(129, 20);
            this.availiabilityLabel.TabIndex = 46;
            this.availiabilityLabel.Text = "Availiability (/365)";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(1267, 772);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(232, 26);
            this.errorLabel.TabIndex = 47;
            this.errorLabel.Text = "Errors Displayed Here!";
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1533, 456);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 43);
            this.searchButton.TabIndex = 48;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1742, 807);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.availiabilityLabel);
            this.Controls.Add(this.minNumOfNightsLabel);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.numOfPropertiesLabel);
            this.Controls.Add(this.hostIDLabel);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.propertyNameLabel);
            this.Controls.Add(this.propertyIDLabel);
            this.Controls.Add(this.availiabilityBox);
            this.Controls.Add(this.minNumOfNightsBox);
            this.Controls.Add(this.longitudeBox);
            this.Controls.Add(this.latitudeBox);
            this.Controls.Add(this.numOfPropertiesBox);
            this.Controls.Add(this.hostIDBox);
            this.Controls.Add(this.hostNameBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.propertyNameBox);
            this.Controls.Add(this.propertyIDBox);
            this.Controls.Add(this.deletePropertyButton);
            this.Controls.Add(this.editPropertyButton);
            this.Controls.Add(this.deleteNHoodButton);
            this.Controls.Add(this.editNHoodNameButton);
            this.Controls.Add(this.nHoodBox);
            this.Controls.Add(this.deleteDistrict);
            this.Controls.Add(this.editDistrictNameButton);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.propertyLabel);
            this.Controls.Add(this.nHoodLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.propertyOutputBox);
            this.Controls.Add(this.nHoodOutputBox);
            this.Controls.Add(this.districtOutputBox);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.addNHoodButton);
            this.Controls.Add(this.addDistrictButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DistrictForm";
            this.Text = "Air BNB Property Manager";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addDistrictButton;
        private System.Windows.Forms.Button addNHoodButton;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.ListBox districtOutputBox;
        private System.Windows.Forms.ListBox nHoodOutputBox;
        private System.Windows.Forms.ListBox propertyOutputBox;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label nHoodLabel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Button editDistrictNameButton;
        private System.Windows.Forms.Button deleteDistrict;
        private System.Windows.Forms.TextBox nHoodBox;
        private System.Windows.Forms.Button editNHoodNameButton;
        private System.Windows.Forms.Button deleteNHoodButton;
        private System.Windows.Forms.Button editPropertyButton;
        private System.Windows.Forms.Button deletePropertyButton;
        private System.Windows.Forms.TextBox propertyIDBox;
        private System.Windows.Forms.TextBox propertyNameBox;
        private System.Windows.Forms.TextBox roomTypeBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox hostNameBox;
        private System.Windows.Forms.TextBox hostIDBox;
        private System.Windows.Forms.TextBox numOfPropertiesBox;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.TextBox minNumOfNightsBox;
        private System.Windows.Forms.TextBox availiabilityBox;
        private System.Windows.Forms.Label propertyIDLabel;
        private System.Windows.Forms.Label propertyNameLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label hostIDLabel;
        private System.Windows.Forms.Label numOfPropertiesLabel;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label minNumOfNightsLabel;
        private System.Windows.Forms.Label availiabilityLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

