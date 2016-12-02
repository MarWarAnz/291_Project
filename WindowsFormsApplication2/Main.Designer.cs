namespace WindowsFormsApplication2 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label eIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label bIDLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label postalCodeLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newRental = new System.Windows.Forms.TabPage();
            this.rentals = new System.Windows.Forms.TabControl();
            this.rentals_create = new System.Windows.Forms.TabPage();
            this.rentals_create_CID = new System.Windows.Forms.ListBox();
            this.label66 = new System.Windows.Forms.Label();
            this.rentals_create_submitbtn = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.rentals_create_Vehicle = new System.Windows.Forms.ListBox();
            this.rentals_create_RentedBranch = new System.Windows.Forms.ListBox();
            this.rentals_create_DateIn = new System.Windows.Forms.DateTimePicker();
            this.rentals_create_DateOut = new System.Windows.Forms.DateTimePicker();
            this.rentals_search = new System.Windows.Forms.TabPage();
            this.rentals_search_Datagridview = new System.Windows.Forms.DataGridView();
            this.label90 = new System.Windows.Forms.Label();
            this.rentals_search_fees_Listbox = new System.Windows.Forms.ListBox();
            this.rentals_search_Branch_return = new System.Windows.Forms.TextBox();
            this.rentals_search_Branch_rental = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.rentals_search_Customer_last_name = new System.Windows.Forms.TextBox();
            this.rentals_search_Customer_first_name = new System.Windows.Forms.TextBox();
            this.rentals_search_Vehicle_bodyType = new System.Windows.Forms.ComboBox();
            this.rentals_search_Vehicle_model = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.rentals_search_Vehicle_name = new System.Windows.Forms.TextBox();
            this.rentals_search_Vehicle_make = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.rentals_search_RentalRate_type = new System.Windows.Forms.CheckedListBox();
            this.label81 = new System.Windows.Forms.Label();
            this.rentals_search_RetalRate_cost = new System.Windows.Forms.NumericUpDown();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.rentals_search_Pending_retrun_radio = new System.Windows.Forms.RadioButton();
            this.rentals_search_Pending_rental_radio = new System.Windows.Forms.RadioButton();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.rentals_search_Vehicle_milesTravelled = new System.Windows.Forms.NumericUpDown();
            this.rentals_search_return_Date = new System.Windows.Forms.DateTimePicker();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.rentals_search_rented_Date = new System.Windows.Forms.DateTimePicker();
            this.label72 = new System.Windows.Forms.Label();
            this.rentals_pending = new System.Windows.Forms.TabPage();
            this.rentals_pending_submitbtn = new System.Windows.Forms.Button();
            this.rentals_pending_BranchID = new System.Windows.Forms.ListBox();
            this.label65 = new System.Windows.Forms.Label();
            this.rentals_pending_Pending = new System.Windows.Forms.DataGridView();
            this.rentals_return = new System.Windows.Forms.TabPage();
            this.cars = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.cars_create = new System.Windows.Forms.TabPage();
            this.cars_create_Status = new System.Windows.Forms.ListBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cars_create_CurrentBID = new System.Windows.Forms.ListBox();
            this.cars_create_TypeID = new System.Windows.Forms.ListBox();
            this.cars_create_Mileage = new System.Windows.Forms.TextBox();
            this.cars_create_VIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cars_create_submitbtn = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cars_search = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.cars_search_BID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cars_search_Mileage = new System.Windows.Forms.TextBox();
            this.cars_search_VIN = new System.Windows.Forms.TextBox();
            this.cars_search_Type = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.branches = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.branches_create = new System.Windows.Forms.TabPage();
            this.branches_create_Province = new System.Windows.Forms.ComboBox();
            this.branches_create_Phone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.branches_create_submitbtn = new System.Windows.Forms.Button();
            this.branches_create_Address2 = new System.Windows.Forms.TextBox();
            this.branches_create_City = new System.Windows.Forms.TextBox();
            this.branches_create_PostalCode = new System.Windows.Forms.TextBox();
            this.branches_create_Address1 = new System.Windows.Forms.TextBox();
            this.branches_create_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.branches_search = new System.Windows.Forms.TabPage();
            this.label71 = new System.Windows.Forms.Label();
            this.branches_search_Phonenumber = new System.Windows.Forms.NumericUpDown();
            this.branches_search_Refreshbtn = new System.Windows.Forms.Button();
            this.branches_search_Address1 = new System.Windows.Forms.TextBox();
            this.branches_search_City = new System.Windows.Forms.TextBox();
            this.branches_search_PostalCode = new System.Windows.Forms.TextBox();
            this.branches_search_Name = new System.Windows.Forms.TextBox();
            this.branches_search_Submitbtn = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.branches_search_Province = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.branches_search_Results = new System.Windows.Forms.DataGridView();
            this.customers = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.customers_create = new System.Windows.Forms.TabPage();
            this.customers_create_Password = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.customers_create_Username = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.customers_create_DOB = new System.Windows.Forms.DateTimePicker();
            this.customers_create_Province = new System.Windows.Forms.ComboBox();
            this.customers_create_submitbtn = new System.Windows.Forms.Button();
            this.customers_create_Address2 = new System.Windows.Forms.TextBox();
            this.customers_create_City = new System.Windows.Forms.TextBox();
            this.customers_create_PostalCode = new System.Windows.Forms.TextBox();
            this.customers_create_Address1 = new System.Windows.Forms.TextBox();
            this.customers_create_CC = new System.Windows.Forms.TextBox();
            this.customers_create_DLN = new System.Windows.Forms.TextBox();
            this.customers_create_Phone2 = new System.Windows.Forms.TextBox();
            this.customers_create_Phone1 = new System.Windows.Forms.TextBox();
            this.customers_create_LastName = new System.Windows.Forms.TextBox();
            this.customers_create_FirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.customers_search = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label53 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.employees_create = new System.Windows.Forms.TabPage();
            this.employees_create_Password = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.employees_create_Username = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.employees_create_BID = new System.Windows.Forms.ListBox();
            this.employees_create_Province = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employees_create_submitbtn = new System.Windows.Forms.Button();
            this.employees_create_Address2 = new System.Windows.Forms.TextBox();
            this.employees_create_City = new System.Windows.Forms.TextBox();
            this.employees_create_PostalCode = new System.Windows.Forms.TextBox();
            this.employees_create_Address1 = new System.Windows.Forms.TextBox();
            this.employees_create_Phone2 = new System.Windows.Forms.TextBox();
            this.employees_create_Phone1 = new System.Windows.Forms.TextBox();
            this.employees_create_LastName = new System.Windows.Forms.TextBox();
            this.employees_create_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.employees_search = new System.Windows.Forms.TabPage();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.postalCodeComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.address2ComboBox = new System.Windows.Forms.ComboBox();
            this.address1ComboBox = new System.Windows.Forms.ComboBox();
            this.bIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.eIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fees = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.fees_create = new System.Windows.Forms.TabPage();
            this.Amount = new System.Windows.Forms.Label();
            this.fees_create_Cost = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.fees_create_Name = new System.Windows.Forms.TextBox();
            this.fees_create_submitbtn = new System.Windows.Forms.Button();
            this.fees_search = new System.Windows.Forms.TabPage();
            this.rates = new System.Windows.Forms.TabPage();
            this.tabControl9 = new System.Windows.Forms.TabControl();
            this.rates_create = new System.Windows.Forms.TabPage();
            this.rates_create_Monthly = new System.Windows.Forms.NumericUpDown();
            this.rates_create_Weekly = new System.Windows.Forms.NumericUpDown();
            this.rates_create_Daily = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.rates_create_Name = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.rates_create_submitbtn = new System.Windows.Forms.Button();
            this.rates_search = new System.Windows.Forms.TabPage();
            this.Rental_fees_dataTable = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.TabPage();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.status_create = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.status_create_Name = new System.Windows.Forms.TextBox();
            this.status_create_submitbtn = new System.Windows.Forms.Button();
            this.status_search = new System.Windows.Forms.TabPage();
            this.types = new System.Windows.Forms.TabPage();
            this.tabControl10 = new System.Windows.Forms.TabControl();
            this.types_create = new System.Windows.Forms.TabPage();
            this.label64 = new System.Windows.Forms.Label();
            this.types_create_RateID = new System.Windows.Forms.ListBox();
            this.types_create_submitbtn = new System.Windows.Forms.Button();
            this.types_create_Model = new System.Windows.Forms.TextBox();
            this.types_create_BodyType = new System.Windows.Forms.TextBox();
            this.types_create_Make = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.types_search = new System.Windows.Forms.TabPage();
            this.branchesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rental_create_Model = new System.Windows.Forms.ComboBox();
            this.rental_create_Make = new System.Windows.Forms.ComboBox();
            this.rental_create_BodyType = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.rental_create_Rate = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.rental_create_RateCost = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.rental_create_rate_Total = new System.Windows.Forms.TextBox();
            eIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            bIDLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.newRental.SuspendLayout();
            this.rentals.SuspendLayout();
            this.rentals_create.SuspendLayout();
            this.rentals_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_Datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_RetalRate_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_Vehicle_milesTravelled)).BeginInit();
            this.rentals_pending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_pending_Pending)).BeginInit();
            this.cars.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.cars_create.SuspendLayout();
            this.cars_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.branches.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.branches_create.SuspendLayout();
            this.branches_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branches_search_Phonenumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branches_search_Results)).BeginInit();
            this.customers.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.customers_create.SuspendLayout();
            this.customers_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.employees.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.employees_create.SuspendLayout();
            this.employees_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.fees.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.fees_create.SuspendLayout();
            this.rates.SuspendLayout();
            this.tabControl9.SuspendLayout();
            this.rates_create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Weekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Daily)).BeginInit();
            this.rates_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rental_fees_dataTable)).BeginInit();
            this.status.SuspendLayout();
            this.tabControl8.SuspendLayout();
            this.status_create.SuspendLayout();
            this.types.SuspendLayout();
            this.tabControl10.SuspendLayout();
            this.types_create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // eIDLabel
            // 
            eIDLabel.AutoSize = true;
            eIDLabel.Location = new System.Drawing.Point(269, 47);
            eIDLabel.Name = "eIDLabel";
            eIDLabel.Size = new System.Drawing.Size(66, 17);
            eIDLabel.TabIndex = 1;
            eIDLabel.Text = "Employe:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(61, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(39, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(61, 71);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(39, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last:";
            // 
            // bIDLabel
            // 
            bIDLabel.AutoSize = true;
            bIDLabel.Location = new System.Drawing.Point(279, 71);
            bIDLabel.Name = "bIDLabel";
            bIDLabel.Size = new System.Drawing.Size(57, 17);
            bIDLabel.TabIndex = 7;
            bIDLabel.Text = "Branch:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(737, 20);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(72, 17);
            address1Label.TabIndex = 9;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(737, 50);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(72, 17);
            address2Label.TabIndex = 11;
            address2Label.Text = "Address2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(547, 27);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(515, 59);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(67, 17);
            provinceLabel.TabIndex = 15;
            provinceLabel.Text = "Province:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(721, 80);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(88, 17);
            postalCodeLabel.TabIndex = 17;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.newRental);
            this.tabControl1.Controls.Add(this.cars);
            this.tabControl1.Controls.Add(this.branches);
            this.tabControl1.Controls.Add(this.customers);
            this.tabControl1.Controls.Add(this.employees);
            this.tabControl1.Controls.Add(this.fees);
            this.tabControl1.Controls.Add(this.rates);
            this.tabControl1.Controls.Add(this.status);
            this.tabControl1.Controls.Add(this.types);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // newRental
            // 
            this.newRental.Controls.Add(this.rentals);
            this.newRental.Location = new System.Drawing.Point(4, 25);
            this.newRental.Margin = new System.Windows.Forms.Padding(4);
            this.newRental.Name = "newRental";
            this.newRental.Padding = new System.Windows.Forms.Padding(4);
            this.newRental.Size = new System.Drawing.Size(1008, 428);
            this.newRental.TabIndex = 0;
            this.newRental.Text = "Rentals";
            this.newRental.UseVisualStyleBackColor = true;
            // 
            // rentals
            // 
            this.rentals.Controls.Add(this.rentals_create);
            this.rentals.Controls.Add(this.rentals_search);
            this.rentals.Controls.Add(this.rentals_pending);
            this.rentals.Controls.Add(this.rentals_return);
            this.rentals.Location = new System.Drawing.Point(0, 0);
            this.rentals.Margin = new System.Windows.Forms.Padding(4);
            this.rentals.Name = "rentals";
            this.rentals.SelectedIndex = 0;
            this.rentals.Size = new System.Drawing.Size(1004, 428);
            this.rentals.TabIndex = 0;
            // 
            // rentals_create
            // 
            this.rentals_create.Controls.Add(this.rental_create_rate_Total);
            this.rentals_create.Controls.Add(this.label100);
            this.rentals_create.Controls.Add(this.label99);
            this.rentals_create.Controls.Add(this.rental_create_RateCost);
            this.rentals_create.Controls.Add(this.label98);
            this.rentals_create.Controls.Add(this.label97);
            this.rentals_create.Controls.Add(this.label96);
            this.rentals_create.Controls.Add(this.label95);
            this.rentals_create.Controls.Add(this.label94);
            this.rentals_create.Controls.Add(this.rental_create_Rate);
            this.rentals_create.Controls.Add(this.label93);
            this.rentals_create.Controls.Add(this.label92);
            this.rentals_create.Controls.Add(this.label91);
            this.rentals_create.Controls.Add(this.rental_create_BodyType);
            this.rentals_create.Controls.Add(this.rental_create_Make);
            this.rentals_create.Controls.Add(this.rental_create_Model);
            this.rentals_create.Controls.Add(this.rentals_create_CID);
            this.rentals_create.Controls.Add(this.label66);
            this.rentals_create.Controls.Add(this.rentals_create_submitbtn);
            this.rentals_create.Controls.Add(this.label63);
            this.rentals_create.Controls.Add(this.label62);
            this.rentals_create.Controls.Add(this.label61);
            this.rentals_create.Controls.Add(this.label60);
            this.rentals_create.Controls.Add(this.rentals_create_Vehicle);
            this.rentals_create.Controls.Add(this.rentals_create_RentedBranch);
            this.rentals_create.Controls.Add(this.rentals_create_DateIn);
            this.rentals_create.Controls.Add(this.rentals_create_DateOut);
            this.rentals_create.Location = new System.Drawing.Point(4, 25);
            this.rentals_create.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create.Name = "rentals_create";
            this.rentals_create.Padding = new System.Windows.Forms.Padding(4);
            this.rentals_create.Size = new System.Drawing.Size(996, 399);
            this.rentals_create.TabIndex = 0;
            this.rentals_create.Text = "Create Rental";
            this.rentals_create.UseVisualStyleBackColor = true;
            this.rentals_create.Click += new System.EventHandler(this.rentals_create_Click);
            // 
            // rentals_create_CID
            // 
            this.rentals_create_CID.FormattingEnabled = true;
            this.rentals_create_CID.ItemHeight = 16;
            this.rentals_create_CID.Location = new System.Drawing.Point(17, 44);
            this.rentals_create_CID.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_CID.Name = "rentals_create_CID";
            this.rentals_create_CID.Size = new System.Drawing.Size(203, 116);
            this.rentals_create_CID.TabIndex = 12;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(14, 23);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(68, 17);
            this.label66.TabIndex = 11;
            this.label66.Text = "Customer";
            this.label66.Click += new System.EventHandler(this.label66_Click);
            // 
            // rentals_create_submitbtn
            // 
            this.rentals_create_submitbtn.Location = new System.Drawing.Point(843, 350);
            this.rentals_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_submitbtn.Name = "rentals_create_submitbtn";
            this.rentals_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.rentals_create_submitbtn.TabIndex = 10;
            this.rentals_create_submitbtn.Text = "Reserve";
            this.rentals_create_submitbtn.UseVisualStyleBackColor = true;
            this.rentals_create_submitbtn.Click += new System.EventHandler(this.rentals_create_submitbtn_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(327, 176);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(54, 17);
            this.label63.TabIndex = 9;
            this.label63.Text = "Vehicle";
            this.label63.Click += new System.EventHandler(this.label63_Click);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(14, 176);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(99, 17);
            this.label62.TabIndex = 8;
            this.label62.Text = "Pickup Branch";
            this.label62.Click += new System.EventHandler(this.label62_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(593, 83);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(51, 17);
            this.label61.TabIndex = 7;
            this.label61.Text = "Return";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(649, 25);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(83, 17);
            this.label60.TabIndex = 6;
            this.label60.Text = "Rental Date";
            // 
            // rentals_create_Vehicle
            // 
            this.rentals_create_Vehicle.FormattingEnabled = true;
            this.rentals_create_Vehicle.ItemHeight = 16;
            this.rentals_create_Vehicle.Location = new System.Drawing.Point(330, 197);
            this.rentals_create_Vehicle.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_Vehicle.Name = "rentals_create_Vehicle";
            this.rentals_create_Vehicle.Size = new System.Drawing.Size(219, 116);
            this.rentals_create_Vehicle.TabIndex = 3;
            // 
            // rentals_create_RentedBranch
            // 
            this.rentals_create_RentedBranch.FormattingEnabled = true;
            this.rentals_create_RentedBranch.ItemHeight = 16;
            this.rentals_create_RentedBranch.Location = new System.Drawing.Point(17, 197);
            this.rentals_create_RentedBranch.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_RentedBranch.Name = "rentals_create_RentedBranch";
            this.rentals_create_RentedBranch.Size = new System.Drawing.Size(203, 116);
            this.rentals_create_RentedBranch.TabIndex = 2;
            this.rentals_create_RentedBranch.SelectedIndexChanged += new System.EventHandler(this.rentals_create_RentedBranch_SelectedIndexChanged);
            // 
            // rentals_create_DateIn
            // 
            this.rentals_create_DateIn.Location = new System.Drawing.Point(652, 78);
            this.rentals_create_DateIn.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_DateIn.Name = "rentals_create_DateIn";
            this.rentals_create_DateIn.Size = new System.Drawing.Size(265, 22);
            this.rentals_create_DateIn.TabIndex = 2;
            // 
            // rentals_create_DateOut
            // 
            this.rentals_create_DateOut.Location = new System.Drawing.Point(652, 48);
            this.rentals_create_DateOut.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_create_DateOut.Name = "rentals_create_DateOut";
            this.rentals_create_DateOut.Size = new System.Drawing.Size(265, 22);
            this.rentals_create_DateOut.TabIndex = 1;
            // 
            // rentals_search
            // 
            this.rentals_search.Controls.Add(this.rentals_search_Datagridview);
            this.rentals_search.Controls.Add(this.label90);
            this.rentals_search.Controls.Add(this.rentals_search_fees_Listbox);
            this.rentals_search.Controls.Add(this.rentals_search_Branch_return);
            this.rentals_search.Controls.Add(this.rentals_search_Branch_rental);
            this.rentals_search.Controls.Add(this.label89);
            this.rentals_search.Controls.Add(this.label88);
            this.rentals_search.Controls.Add(this.rentals_search_Customer_last_name);
            this.rentals_search.Controls.Add(this.rentals_search_Customer_first_name);
            this.rentals_search.Controls.Add(this.rentals_search_Vehicle_bodyType);
            this.rentals_search.Controls.Add(this.rentals_search_Vehicle_model);
            this.rentals_search.Controls.Add(this.label87);
            this.rentals_search.Controls.Add(this.label86);
            this.rentals_search.Controls.Add(this.label85);
            this.rentals_search.Controls.Add(this.rentals_search_Vehicle_name);
            this.rentals_search.Controls.Add(this.rentals_search_Vehicle_make);
            this.rentals_search.Controls.Add(this.label84);
            this.rentals_search.Controls.Add(this.label83);
            this.rentals_search.Controls.Add(this.label82);
            this.rentals_search.Controls.Add(this.rentals_search_RentalRate_type);
            this.rentals_search.Controls.Add(this.label81);
            this.rentals_search.Controls.Add(this.rentals_search_RetalRate_cost);
            this.rentals_search.Controls.Add(this.label80);
            this.rentals_search.Controls.Add(this.label79);
            this.rentals_search.Controls.Add(this.label78);
            this.rentals_search.Controls.Add(this.label77);
            this.rentals_search.Controls.Add(this.rentals_search_Pending_retrun_radio);
            this.rentals_search.Controls.Add(this.rentals_search_Pending_rental_radio);
            this.rentals_search.Controls.Add(this.label76);
            this.rentals_search.Controls.Add(this.label75);
            this.rentals_search.Controls.Add(this.rentals_search_Vehicle_milesTravelled);
            this.rentals_search.Controls.Add(this.rentals_search_return_Date);
            this.rentals_search.Controls.Add(this.label74);
            this.rentals_search.Controls.Add(this.label73);
            this.rentals_search.Controls.Add(this.rentals_search_rented_Date);
            this.rentals_search.Controls.Add(this.label72);
            this.rentals_search.Location = new System.Drawing.Point(4, 25);
            this.rentals_search.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_search.Name = "rentals_search";
            this.rentals_search.Padding = new System.Windows.Forms.Padding(4);
            this.rentals_search.Size = new System.Drawing.Size(996, 399);
            this.rentals_search.TabIndex = 1;
            this.rentals_search.Text = "Search";
            this.rentals_search.UseVisualStyleBackColor = true;
            // 
            // rentals_search_Datagridview
            // 
            this.rentals_search_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentals_search_Datagridview.Location = new System.Drawing.Point(4, 212);
            this.rentals_search_Datagridview.Name = "rentals_search_Datagridview";
            this.rentals_search_Datagridview.RowTemplate.Height = 24;
            this.rentals_search_Datagridview.Size = new System.Drawing.Size(985, 180);
            this.rentals_search_Datagridview.TabIndex = 36;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(357, 98);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 17);
            this.label90.TabIndex = 35;
            this.label90.Text = "Branch";
            // 
            // rentals_search_fees_Listbox
            // 
            this.rentals_search_fees_Listbox.FormattingEnabled = true;
            this.rentals_search_fees_Listbox.ItemHeight = 16;
            this.rentals_search_fees_Listbox.Location = new System.Drawing.Point(566, 138);
            this.rentals_search_fees_Listbox.Name = "rentals_search_fees_Listbox";
            this.rentals_search_fees_Listbox.Size = new System.Drawing.Size(120, 68);
            this.rentals_search_fees_Listbox.TabIndex = 34;
            // 
            // rentals_search_Branch_return
            // 
            this.rentals_search_Branch_return.Location = new System.Drawing.Point(360, 149);
            this.rentals_search_Branch_return.Name = "rentals_search_Branch_return";
            this.rentals_search_Branch_return.Size = new System.Drawing.Size(161, 22);
            this.rentals_search_Branch_return.TabIndex = 33;
            // 
            // rentals_search_Branch_rental
            // 
            this.rentals_search_Branch_rental.Location = new System.Drawing.Point(360, 118);
            this.rentals_search_Branch_rental.Name = "rentals_search_Branch_rental";
            this.rentals_search_Branch_rental.Size = new System.Drawing.Size(161, 22);
            this.rentals_search_Branch_rental.TabIndex = 32;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(319, 65);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(35, 17);
            this.label89.TabIndex = 31;
            this.label89.Text = "Last";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(319, 33);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(35, 17);
            this.label88.TabIndex = 30;
            this.label88.Text = "First";
            // 
            // rentals_search_Customer_last_name
            // 
            this.rentals_search_Customer_last_name.Location = new System.Drawing.Point(360, 62);
            this.rentals_search_Customer_last_name.Name = "rentals_search_Customer_last_name";
            this.rentals_search_Customer_last_name.Size = new System.Drawing.Size(161, 22);
            this.rentals_search_Customer_last_name.TabIndex = 29;
            // 
            // rentals_search_Customer_first_name
            // 
            this.rentals_search_Customer_first_name.Location = new System.Drawing.Point(360, 36);
            this.rentals_search_Customer_first_name.Name = "rentals_search_Customer_first_name";
            this.rentals_search_Customer_first_name.Size = new System.Drawing.Size(161, 22);
            this.rentals_search_Customer_first_name.TabIndex = 28;
            // 
            // rentals_search_Vehicle_bodyType
            // 
            this.rentals_search_Vehicle_bodyType.FormattingEnabled = true;
            this.rentals_search_Vehicle_bodyType.Location = new System.Drawing.Point(94, 124);
            this.rentals_search_Vehicle_bodyType.Name = "rentals_search_Vehicle_bodyType";
            this.rentals_search_Vehicle_bodyType.Size = new System.Drawing.Size(200, 24);
            this.rentals_search_Vehicle_bodyType.TabIndex = 27;
            // 
            // rentals_search_Vehicle_model
            // 
            this.rentals_search_Vehicle_model.FormattingEnabled = true;
            this.rentals_search_Vehicle_model.Location = new System.Drawing.Point(94, 94);
            this.rentals_search_Vehicle_model.Name = "rentals_search_Vehicle_model";
            this.rentals_search_Vehicle_model.Size = new System.Drawing.Size(200, 24);
            this.rentals_search_Vehicle_model.TabIndex = 26;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(12, 124);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(76, 17);
            this.label87.TabIndex = 25;
            this.label87.Text = "Body Type";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(42, 97);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(46, 17);
            this.label86.TabIndex = 24;
            this.label86.Text = "Model";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(46, 63);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(42, 17);
            this.label85.TabIndex = 23;
            this.label85.Text = "Make";
            // 
            // rentals_search_Vehicle_name
            // 
            this.rentals_search_Vehicle_name.Location = new System.Drawing.Point(94, 34);
            this.rentals_search_Vehicle_name.Name = "rentals_search_Vehicle_name";
            this.rentals_search_Vehicle_name.Size = new System.Drawing.Size(200, 22);
            this.rentals_search_Vehicle_name.TabIndex = 22;
            // 
            // rentals_search_Vehicle_make
            // 
            this.rentals_search_Vehicle_make.FormattingEnabled = true;
            this.rentals_search_Vehicle_make.Location = new System.Drawing.Point(94, 62);
            this.rentals_search_Vehicle_make.Name = "rentals_search_Vehicle_make";
            this.rentals_search_Vehicle_make.Size = new System.Drawing.Size(200, 24);
            this.rentals_search_Vehicle_make.TabIndex = 21;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(43, 34);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(45, 17);
            this.label84.TabIndex = 20;
            this.label84.Text = "Name";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(91, 9);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(54, 17);
            this.label83.TabIndex = 19;
            this.label83.Text = "Vehicle";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(544, 95);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(16, 17);
            this.label82.TabIndex = 18;
            this.label82.Text = "$";
            // 
            // rentals_search_RentalRate_type
            // 
            this.rentals_search_RentalRate_type.FormattingEnabled = true;
            this.rentals_search_RentalRate_type.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.rentals_search_RentalRate_type.Location = new System.Drawing.Point(566, 32);
            this.rentals_search_RentalRate_type.Name = "rentals_search_RentalRate_type";
            this.rentals_search_RentalRate_type.Size = new System.Drawing.Size(80, 55);
            this.rentals_search_RentalRate_type.TabIndex = 17;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(563, 12);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(83, 17);
            this.label81.TabIndex = 16;
            this.label81.Text = "Rental Rate";
            // 
            // rentals_search_RetalRate_cost
            // 
            this.rentals_search_RetalRate_cost.Location = new System.Drawing.Point(566, 93);
            this.rentals_search_RetalRate_cost.Name = "rentals_search_RetalRate_cost";
            this.rentals_search_RetalRate_cost.Size = new System.Drawing.Size(120, 22);
            this.rentals_search_RetalRate_cost.TabIndex = 15;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(563, 116);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(39, 17);
            this.label80.TabIndex = 14;
            this.label80.Text = "Fees";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(305, 152);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(51, 17);
            this.label79.TabIndex = 12;
            this.label79.Text = "Return";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(305, 115);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(49, 17);
            this.label78.TabIndex = 11;
            this.label78.Text = "Rental";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(357, 12);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(109, 17);
            this.label77.TabIndex = 10;
            this.label77.Text = "Customer Name";
            // 
            // rentals_search_Pending_retrun_radio
            // 
            this.rentals_search_Pending_retrun_radio.AutoSize = true;
            this.rentals_search_Pending_retrun_radio.Location = new System.Drawing.Point(780, 154);
            this.rentals_search_Pending_retrun_radio.Name = "rentals_search_Pending_retrun_radio";
            this.rentals_search_Pending_retrun_radio.Size = new System.Drawing.Size(72, 21);
            this.rentals_search_Pending_retrun_radio.TabIndex = 9;
            this.rentals_search_Pending_retrun_radio.TabStop = true;
            this.rentals_search_Pending_retrun_radio.Text = "Return";
            this.rentals_search_Pending_retrun_radio.UseVisualStyleBackColor = true;
            // 
            // rentals_search_Pending_rental_radio
            // 
            this.rentals_search_Pending_rental_radio.AutoSize = true;
            this.rentals_search_Pending_rental_radio.Location = new System.Drawing.Point(780, 127);
            this.rentals_search_Pending_rental_radio.Name = "rentals_search_Pending_rental_radio";
            this.rentals_search_Pending_rental_radio.Size = new System.Drawing.Size(70, 21);
            this.rentals_search_Pending_rental_radio.TabIndex = 8;
            this.rentals_search_Pending_rental_radio.TabStop = true;
            this.rentals_search_Pending_rental_radio.Text = "Rental";
            this.rentals_search_Pending_rental_radio.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(777, 106);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(114, 17);
            this.label76.TabIndex = 7;
            this.label76.Text = "Pending Cars for";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(4, 156);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(103, 17);
            this.label75.TabIndex = 6;
            this.label75.Text = "Miles Travelled";
            // 
            // rentals_search_Vehicle_milesTravelled
            // 
            this.rentals_search_Vehicle_milesTravelled.Location = new System.Drawing.Point(113, 151);
            this.rentals_search_Vehicle_milesTravelled.Name = "rentals_search_Vehicle_milesTravelled";
            this.rentals_search_Vehicle_milesTravelled.Size = new System.Drawing.Size(181, 22);
            this.rentals_search_Vehicle_milesTravelled.TabIndex = 5;
            // 
            // rentals_search_return_Date
            // 
            this.rentals_search_return_Date.Location = new System.Drawing.Point(780, 70);
            this.rentals_search_return_Date.Name = "rentals_search_return_Date";
            this.rentals_search_return_Date.Size = new System.Drawing.Size(200, 22);
            this.rentals_search_return_Date.TabIndex = 4;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(711, 70);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(51, 17);
            this.label74.TabIndex = 3;
            this.label74.Text = "Return";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(708, 37);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(54, 17);
            this.label73.TabIndex = 2;
            this.label73.Text = "Rented";
            // 
            // rentals_search_rented_Date
            // 
            this.rentals_search_rented_Date.Location = new System.Drawing.Point(780, 32);
            this.rentals_search_rented_Date.Name = "rentals_search_rented_Date";
            this.rentals_search_rented_Date.Size = new System.Drawing.Size(200, 22);
            this.rentals_search_rented_Date.TabIndex = 1;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(777, 13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 17);
            this.label72.TabIndex = 0;
            this.label72.Text = "Date";
            // 
            // rentals_pending
            // 
            this.rentals_pending.Controls.Add(this.rentals_pending_submitbtn);
            this.rentals_pending.Controls.Add(this.rentals_pending_BranchID);
            this.rentals_pending.Controls.Add(this.label65);
            this.rentals_pending.Controls.Add(this.rentals_pending_Pending);
            this.rentals_pending.Location = new System.Drawing.Point(4, 25);
            this.rentals_pending.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_pending.Name = "rentals_pending";
            this.rentals_pending.Size = new System.Drawing.Size(996, 399);
            this.rentals_pending.TabIndex = 2;
            this.rentals_pending.Text = "Pending";
            this.rentals_pending.UseVisualStyleBackColor = true;
            // 
            // rentals_pending_submitbtn
            // 
            this.rentals_pending_submitbtn.Location = new System.Drawing.Point(89, 234);
            this.rentals_pending_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_pending_submitbtn.Name = "rentals_pending_submitbtn";
            this.rentals_pending_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.rentals_pending_submitbtn.TabIndex = 30;
            this.rentals_pending_submitbtn.Text = "Approve";
            this.rentals_pending_submitbtn.UseVisualStyleBackColor = true;
            this.rentals_pending_submitbtn.Click += new System.EventHandler(this.rentals_pending_submitbtn_Click);
            // 
            // rentals_pending_BranchID
            // 
            this.rentals_pending_BranchID.FormattingEnabled = true;
            this.rentals_pending_BranchID.ItemHeight = 16;
            this.rentals_pending_BranchID.Location = new System.Drawing.Point(89, 17);
            this.rentals_pending_BranchID.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_pending_BranchID.Name = "rentals_pending_BranchID";
            this.rentals_pending_BranchID.Size = new System.Drawing.Size(159, 116);
            this.rentals_pending_BranchID.Sorted = true;
            this.rentals_pending_BranchID.TabIndex = 1;
            this.rentals_pending_BranchID.SelectedIndexChanged += new System.EventHandler(this.rentals_pending_BranchID_SelectedIndexChanged);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(24, 17);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(53, 17);
            this.label65.TabIndex = 67;
            this.label65.Text = "Branch";
            // 
            // rentals_pending_Pending
            // 
            this.rentals_pending_Pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentals_pending_Pending.Location = new System.Drawing.Point(389, 4);
            this.rentals_pending_Pending.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_pending_Pending.Name = "rentals_pending_Pending";
            this.rentals_pending_Pending.Size = new System.Drawing.Size(588, 335);
            this.rentals_pending_Pending.TabIndex = 0;
            // 
            // rentals_return
            // 
            this.rentals_return.Location = new System.Drawing.Point(4, 25);
            this.rentals_return.Margin = new System.Windows.Forms.Padding(4);
            this.rentals_return.Name = "rentals_return";
            this.rentals_return.Size = new System.Drawing.Size(996, 399);
            this.rentals_return.TabIndex = 3;
            this.rentals_return.Text = "Return";
            this.rentals_return.UseVisualStyleBackColor = true;
            // 
            // cars
            // 
            this.cars.Controls.Add(this.tabControl5);
            this.cars.Location = new System.Drawing.Point(4, 25);
            this.cars.Margin = new System.Windows.Forms.Padding(4);
            this.cars.Name = "cars";
            this.cars.Padding = new System.Windows.Forms.Padding(4);
            this.cars.Size = new System.Drawing.Size(1008, 428);
            this.cars.TabIndex = 1;
            this.cars.Text = "Cars";
            this.cars.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.cars_create);
            this.tabControl5.Controls.Add(this.cars_search);
            this.tabControl5.Location = new System.Drawing.Point(0, 4);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(992, 394);
            this.tabControl5.TabIndex = 2;
            // 
            // cars_create
            // 
            this.cars_create.Controls.Add(this.cars_create_Status);
            this.cars_create.Controls.Add(this.label56);
            this.cars_create.Controls.Add(this.cars_create_CurrentBID);
            this.cars_create.Controls.Add(this.cars_create_TypeID);
            this.cars_create.Controls.Add(this.cars_create_Mileage);
            this.cars_create.Controls.Add(this.cars_create_VIN);
            this.cars_create.Controls.Add(this.label3);
            this.cars_create.Controls.Add(this.cars_create_submitbtn);
            this.cars_create.Controls.Add(this.label27);
            this.cars_create.Controls.Add(this.label28);
            this.cars_create.Controls.Add(this.label33);
            this.cars_create.Location = new System.Drawing.Point(4, 25);
            this.cars_create.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create.Name = "cars_create";
            this.cars_create.Padding = new System.Windows.Forms.Padding(4);
            this.cars_create.Size = new System.Drawing.Size(984, 365);
            this.cars_create.TabIndex = 0;
            this.cars_create.Text = "Create Car";
            this.cars_create.UseVisualStyleBackColor = true;
            // 
            // cars_create_Status
            // 
            this.cars_create_Status.FormattingEnabled = true;
            this.cars_create_Status.ItemHeight = 16;
            this.cars_create_Status.Location = new System.Drawing.Point(409, 36);
            this.cars_create_Status.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_Status.Name = "cars_create_Status";
            this.cars_create_Status.Size = new System.Drawing.Size(159, 116);
            this.cars_create_Status.Sorted = true;
            this.cars_create_Status.TabIndex = 68;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(344, 36);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(48, 17);
            this.label56.TabIndex = 67;
            this.label56.Text = "Status";
            // 
            // cars_create_CurrentBID
            // 
            this.cars_create_CurrentBID.FormattingEnabled = true;
            this.cars_create_CurrentBID.ItemHeight = 16;
            this.cars_create_CurrentBID.Location = new System.Drawing.Point(91, 178);
            this.cars_create_CurrentBID.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_CurrentBID.Name = "cars_create_CurrentBID";
            this.cars_create_CurrentBID.Size = new System.Drawing.Size(159, 116);
            this.cars_create_CurrentBID.Sorted = true;
            this.cars_create_CurrentBID.TabIndex = 66;
            // 
            // cars_create_TypeID
            // 
            this.cars_create_TypeID.FormattingEnabled = true;
            this.cars_create_TypeID.ItemHeight = 16;
            this.cars_create_TypeID.Location = new System.Drawing.Point(91, 36);
            this.cars_create_TypeID.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_TypeID.Name = "cars_create_TypeID";
            this.cars_create_TypeID.Size = new System.Drawing.Size(159, 116);
            this.cars_create_TypeID.Sorted = true;
            this.cars_create_TypeID.TabIndex = 65;
            // 
            // cars_create_Mileage
            // 
            this.cars_create_Mileage.Location = new System.Drawing.Point(409, 207);
            this.cars_create_Mileage.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_Mileage.Name = "cars_create_Mileage";
            this.cars_create_Mileage.Size = new System.Drawing.Size(203, 22);
            this.cars_create_Mileage.TabIndex = 64;
            // 
            // cars_create_VIN
            // 
            this.cars_create_VIN.Location = new System.Drawing.Point(409, 175);
            this.cars_create_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_VIN.Name = "cars_create_VIN";
            this.cars_create_VIN.Size = new System.Drawing.Size(203, 22);
            this.cars_create_VIN.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Branch";
            // 
            // cars_create_submitbtn
            // 
            this.cars_create_submitbtn.Location = new System.Drawing.Point(427, 283);
            this.cars_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cars_create_submitbtn.Name = "cars_create_submitbtn";
            this.cars_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.cars_create_submitbtn.TabIndex = 30;
            this.cars_create_submitbtn.Text = "Submit";
            this.cars_create_submitbtn.UseVisualStyleBackColor = true;
            this.cars_create_submitbtn.Click += new System.EventHandler(this.cars_create_submitbtn_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(335, 210);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 17);
            this.label27.TabIndex = 37;
            this.label27.Text = "Mileage";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(335, 178);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 17);
            this.label28.TabIndex = 36;
            this.label28.Text = "VIN";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(25, 36);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 17);
            this.label33.TabIndex = 30;
            this.label33.Text = "Type";
            // 
            // cars_search
            // 
            this.cars_search.Controls.Add(this.dataGridView1);
            this.cars_search.Controls.Add(this.button5);
            this.cars_search.Controls.Add(this.cars_search_BID);
            this.cars_search.Controls.Add(this.label20);
            this.cars_search.Controls.Add(this.cars_search_Mileage);
            this.cars_search.Controls.Add(this.cars_search_VIN);
            this.cars_search.Controls.Add(this.cars_search_Type);
            this.cars_search.Controls.Add(this.label29);
            this.cars_search.Controls.Add(this.label30);
            this.cars_search.Controls.Add(this.label31);
            this.cars_search.Location = new System.Drawing.Point(4, 25);
            this.cars_search.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search.Name = "cars_search";
            this.cars_search.Padding = new System.Windows.Forms.Padding(4);
            this.cars_search.Size = new System.Drawing.Size(984, 365);
            this.cars_search.TabIndex = 1;
            this.cars_search.Text = "Search";
            this.cars_search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.vehicleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 185);
            this.dataGridView1.TabIndex = 67;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 73);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 66;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cars_search_BID
            // 
            this.cars_search_BID.Location = new System.Drawing.Point(257, 113);
            this.cars_search_BID.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_BID.Name = "cars_search_BID";
            this.cars_search_BID.Size = new System.Drawing.Size(203, 22);
            this.cars_search_BID.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(68, 117);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 64;
            this.label20.Text = "Branch";
            // 
            // cars_search_Mileage
            // 
            this.cars_search_Mileage.Location = new System.Drawing.Point(257, 81);
            this.cars_search_Mileage.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_Mileage.Name = "cars_search_Mileage";
            this.cars_search_Mileage.Size = new System.Drawing.Size(203, 22);
            this.cars_search_Mileage.TabIndex = 63;
            // 
            // cars_search_VIN
            // 
            this.cars_search_VIN.Location = new System.Drawing.Point(257, 49);
            this.cars_search_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_VIN.Name = "cars_search_VIN";
            this.cars_search_VIN.Size = new System.Drawing.Size(203, 22);
            this.cars_search_VIN.TabIndex = 62;
            // 
            // cars_search_Type
            // 
            this.cars_search_Type.Location = new System.Drawing.Point(257, 17);
            this.cars_search_Type.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_Type.Name = "cars_search_Type";
            this.cars_search_Type.Size = new System.Drawing.Size(203, 22);
            this.cars_search_Type.TabIndex = 61;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(68, 85);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 17);
            this.label29.TabIndex = 60;
            this.label29.Text = "Mileage";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(69, 53);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 17);
            this.label30.TabIndex = 59;
            this.label30.Text = "VIN";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(69, 21);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 17);
            this.label31.TabIndex = 58;
            this.label31.Text = "Type";
            // 
            // branches
            // 
            this.branches.AllowDrop = true;
            this.branches.AutoScroll = true;
            this.branches.Controls.Add(this.tabControl6);
            this.branches.Location = new System.Drawing.Point(4, 25);
            this.branches.Margin = new System.Windows.Forms.Padding(4);
            this.branches.Name = "branches";
            this.branches.Size = new System.Drawing.Size(1008, 428);
            this.branches.TabIndex = 2;
            this.branches.Text = "Branch";
            this.branches.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            this.tabControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl6.Controls.Add(this.branches_create);
            this.tabControl6.Controls.Add(this.branches_search);
            this.tabControl6.Location = new System.Drawing.Point(0, 4);
            this.tabControl6.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(997, 399);
            this.tabControl6.TabIndex = 2;
            // 
            // branches_create
            // 
            this.branches_create.Controls.Add(this.branches_create_Province);
            this.branches_create.Controls.Add(this.branches_create_Phone1);
            this.branches_create.Controls.Add(this.label4);
            this.branches_create.Controls.Add(this.branches_create_submitbtn);
            this.branches_create.Controls.Add(this.branches_create_Address2);
            this.branches_create.Controls.Add(this.branches_create_City);
            this.branches_create.Controls.Add(this.branches_create_PostalCode);
            this.branches_create.Controls.Add(this.branches_create_Address1);
            this.branches_create.Controls.Add(this.branches_create_Name);
            this.branches_create.Controls.Add(this.label14);
            this.branches_create.Controls.Add(this.label32);
            this.branches_create.Controls.Add(this.label34);
            this.branches_create.Controls.Add(this.label35);
            this.branches_create.Controls.Add(this.label36);
            this.branches_create.Controls.Add(this.label38);
            this.branches_create.Location = new System.Drawing.Point(4, 25);
            this.branches_create.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create.Name = "branches_create";
            this.branches_create.Padding = new System.Windows.Forms.Padding(4);
            this.branches_create.Size = new System.Drawing.Size(989, 370);
            this.branches_create.TabIndex = 0;
            this.branches_create.Text = "Create Branch";
            this.branches_create.UseVisualStyleBackColor = true;
            // 
            // branches_create_Province
            // 
            this.branches_create_Province.FormattingEnabled = true;
            this.branches_create_Province.Location = new System.Drawing.Point(428, 164);
            this.branches_create_Province.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_Province.Name = "branches_create_Province";
            this.branches_create_Province.Size = new System.Drawing.Size(203, 24);
            this.branches_create_Province.TabIndex = 57;
            this.branches_create_Province.Tag = "Province, nullable";
            // 
            // branches_create_Phone1
            // 
            this.branches_create_Phone1.Location = new System.Drawing.Point(428, 231);
            this.branches_create_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_Phone1.Name = "branches_create_Phone1";
            this.branches_create_Phone1.Size = new System.Drawing.Size(203, 22);
            this.branches_create_Phone1.TabIndex = 7;
            this.branches_create_Phone1.Text = "7801234567";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Primary Phone";
            // 
            // branches_create_submitbtn
            // 
            this.branches_create_submitbtn.Location = new System.Drawing.Point(428, 282);
            this.branches_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_submitbtn.Name = "branches_create_submitbtn";
            this.branches_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.branches_create_submitbtn.TabIndex = 30;
            this.branches_create_submitbtn.Text = "Submit";
            this.branches_create_submitbtn.UseVisualStyleBackColor = true;
            this.branches_create_submitbtn.Click += new System.EventHandler(this.branches_create_submitbtn_Click);
            // 
            // branches_create_Address2
            // 
            this.branches_create_Address2.Location = new System.Drawing.Point(428, 100);
            this.branches_create_Address2.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_Address2.Name = "branches_create_Address2";
            this.branches_create_Address2.Size = new System.Drawing.Size(203, 22);
            this.branches_create_Address2.TabIndex = 3;
            // 
            // branches_create_City
            // 
            this.branches_create_City.Location = new System.Drawing.Point(428, 132);
            this.branches_create_City.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_City.Name = "branches_create_City";
            this.branches_create_City.Size = new System.Drawing.Size(203, 22);
            this.branches_create_City.TabIndex = 4;
            this.branches_create_City.Text = "Edmonton";
            // 
            // branches_create_PostalCode
            // 
            this.branches_create_PostalCode.Location = new System.Drawing.Point(428, 199);
            this.branches_create_PostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_PostalCode.Name = "branches_create_PostalCode";
            this.branches_create_PostalCode.Size = new System.Drawing.Size(203, 22);
            this.branches_create_PostalCode.TabIndex = 6;
            this.branches_create_PostalCode.Text = "H0H0H0";
            // 
            // branches_create_Address1
            // 
            this.branches_create_Address1.Location = new System.Drawing.Point(428, 68);
            this.branches_create_Address1.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_Address1.Name = "branches_create_Address1";
            this.branches_create_Address1.Size = new System.Drawing.Size(203, 22);
            this.branches_create_Address1.TabIndex = 2;
            this.branches_create_Address1.Text = "123 Main Street";
            // 
            // branches_create_Name
            // 
            this.branches_create_Name.Location = new System.Drawing.Point(428, 34);
            this.branches_create_Name.Margin = new System.Windows.Forms.Padding(4);
            this.branches_create_Name.Name = "branches_create_Name";
            this.branches_create_Name.Size = new System.Drawing.Size(203, 22);
            this.branches_create_Name.TabIndex = 1;
            this.branches_create_Name.Text = "Charles Car Rental";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 203);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Postal Code";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(319, 167);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 17);
            this.label32.TabIndex = 34;
            this.label32.Text = "Province";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(319, 135);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 17);
            this.label34.TabIndex = 33;
            this.label34.Text = "City";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(317, 103);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(103, 17);
            this.label35.TabIndex = 32;
            this.label35.Text = "Address Line 2";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(317, 71);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(103, 17);
            this.label36.TabIndex = 31;
            this.label36.Text = "Address Line 1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(317, 34);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 17);
            this.label38.TabIndex = 29;
            this.label38.Text = "Name";
            // 
            // branches_search
            // 
            this.branches_search.AutoScroll = true;
            this.branches_search.Controls.Add(this.label71);
            this.branches_search.Controls.Add(this.branches_search_Phonenumber);
            this.branches_search.Controls.Add(this.branches_search_Refreshbtn);
            this.branches_search.Controls.Add(this.branches_search_Address1);
            this.branches_search.Controls.Add(this.branches_search_City);
            this.branches_search.Controls.Add(this.branches_search_PostalCode);
            this.branches_search.Controls.Add(this.branches_search_Name);
            this.branches_search.Controls.Add(this.branches_search_Submitbtn);
            this.branches_search.Controls.Add(this.label49);
            this.branches_search.Controls.Add(this.branches_search_Province);
            this.branches_search.Controls.Add(this.label48);
            this.branches_search.Controls.Add(this.label47);
            this.branches_search.Controls.Add(this.label46);
            this.branches_search.Controls.Add(this.label45);
            this.branches_search.Controls.Add(this.branches_search_Results);
            this.branches_search.Location = new System.Drawing.Point(4, 25);
            this.branches_search.Margin = new System.Windows.Forms.Padding(4);
            this.branches_search.Name = "branches_search";
            this.branches_search.Padding = new System.Windows.Forms.Padding(4);
            this.branches_search.Size = new System.Drawing.Size(989, 370);
            this.branches_search.TabIndex = 1;
            this.branches_search.Text = "Search";
            this.branches_search.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(549, 114);
            this.label71.Name = "label71";
            this.label71.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label71.Size = new System.Drawing.Size(103, 17);
            this.label71.TabIndex = 33;
            this.label71.Text = "Phone Number";
            // 
            // branches_search_Phonenumber
            // 
            this.branches_search_Phonenumber.Location = new System.Drawing.Point(658, 112);
            this.branches_search_Phonenumber.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.branches_search_Phonenumber.Name = "branches_search_Phonenumber";
            this.branches_search_Phonenumber.Size = new System.Drawing.Size(169, 22);
            this.branches_search_Phonenumber.TabIndex = 32;
            // 
            // branches_search_Refreshbtn
            // 
            this.branches_search_Refreshbtn.Location = new System.Drawing.Point(894, 53);
            this.branches_search_Refreshbtn.Name = "branches_search_Refreshbtn";
            this.branches_search_Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.branches_search_Refreshbtn.TabIndex = 31;
            this.branches_search_Refreshbtn.Text = "Refresh";
            this.branches_search_Refreshbtn.UseVisualStyleBackColor = true;
            this.branches_search_Refreshbtn.Click += new System.EventHandler(this.branches_search_Refreshbtn_Click);
            // 
            // branches_search_Address1
            // 
            this.branches_search_Address1.Location = new System.Drawing.Point(115, 114);
            this.branches_search_Address1.Margin = new System.Windows.Forms.Padding(4);
            this.branches_search_Address1.Name = "branches_search_Address1";
            this.branches_search_Address1.Size = new System.Drawing.Size(171, 22);
            this.branches_search_Address1.TabIndex = 4;
            // 
            // branches_search_City
            // 
            this.branches_search_City.Location = new System.Drawing.Point(367, 54);
            this.branches_search_City.Margin = new System.Windows.Forms.Padding(4);
            this.branches_search_City.Name = "branches_search_City";
            this.branches_search_City.Size = new System.Drawing.Size(171, 22);
            this.branches_search_City.TabIndex = 2;
            // 
            // branches_search_PostalCode
            // 
            this.branches_search_PostalCode.Location = new System.Drawing.Point(656, 54);
            this.branches_search_PostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.branches_search_PostalCode.Name = "branches_search_PostalCode";
            this.branches_search_PostalCode.Size = new System.Drawing.Size(171, 22);
            this.branches_search_PostalCode.TabIndex = 3;
            // 
            // branches_search_Name
            // 
            this.branches_search_Name.Location = new System.Drawing.Point(115, 54);
            this.branches_search_Name.Margin = new System.Windows.Forms.Padding(4);
            this.branches_search_Name.Name = "branches_search_Name";
            this.branches_search_Name.Size = new System.Drawing.Size(171, 22);
            this.branches_search_Name.TabIndex = 1;
            // 
            // branches_search_Submitbtn
            // 
            this.branches_search_Submitbtn.Location = new System.Drawing.Point(894, 112);
            this.branches_search_Submitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branches_search_Submitbtn.Name = "branches_search_Submitbtn";
            this.branches_search_Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.branches_search_Submitbtn.TabIndex = 30;
            this.branches_search_Submitbtn.Text = "Submit";
            this.branches_search_Submitbtn.UseVisualStyleBackColor = true;
            this.branches_search_Submitbtn.Click += new System.EventHandler(this.branches_search_Submitbtn_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(564, 58);
            this.label49.Name = "label49";
            this.label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label49.Size = new System.Drawing.Size(84, 17);
            this.label49.TabIndex = 10;
            this.label49.Text = "Postal Code";
            // 
            // branches_search_Province
            // 
            this.branches_search_Province.FormattingEnabled = true;
            this.branches_search_Province.Location = new System.Drawing.Point(367, 113);
            this.branches_search_Province.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branches_search_Province.Name = "branches_search_Province";
            this.branches_search_Province.Size = new System.Drawing.Size(70, 24);
            this.branches_search_Province.TabIndex = 5;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(296, 118);
            this.label48.Name = "label48";
            this.label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label48.Size = new System.Drawing.Size(63, 17);
            this.label48.TabIndex = 6;
            this.label48.Text = "Province";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(328, 58);
            this.label47.Name = "label47";
            this.label47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label47.Size = new System.Drawing.Size(31, 17);
            this.label47.TabIndex = 5;
            this.label47.Text = "City";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(47, 118);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(60, 17);
            this.label46.TabIndex = 3;
            this.label46.Text = "Address";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(47, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(45, 17);
            this.label45.TabIndex = 2;
            this.label45.Text = "Name";
            // 
            // branches_search_Results
            // 
            this.branches_search_Results.AllowUserToOrderColumns = true;
            this.branches_search_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branches_search_Results.Location = new System.Drawing.Point(7, 172);
            this.branches_search_Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branches_search_Results.Name = "branches_search_Results";
            this.branches_search_Results.RowTemplate.Height = 24;
            this.branches_search_Results.Size = new System.Drawing.Size(941, 164);
            this.branches_search_Results.TabIndex = 0;
            // 
            // customers
            // 
            this.customers.Controls.Add(this.tabControl3);
            this.customers.Location = new System.Drawing.Point(4, 25);
            this.customers.Margin = new System.Windows.Forms.Padding(4);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(1008, 428);
            this.customers.TabIndex = 4;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.customers_create);
            this.tabControl3.Controls.Add(this.customers_search);
            this.tabControl3.Location = new System.Drawing.Point(0, 4);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(992, 394);
            this.tabControl3.TabIndex = 1;
            // 
            // customers_create
            // 
            this.customers_create.Controls.Add(this.customers_create_Password);
            this.customers_create.Controls.Add(this.label68);
            this.customers_create.Controls.Add(this.customers_create_Username);
            this.customers_create.Controls.Add(this.label67);
            this.customers_create.Controls.Add(this.customers_create_DOB);
            this.customers_create.Controls.Add(this.customers_create_Province);
            this.customers_create.Controls.Add(this.customers_create_submitbtn);
            this.customers_create.Controls.Add(this.customers_create_Address2);
            this.customers_create.Controls.Add(this.customers_create_City);
            this.customers_create.Controls.Add(this.customers_create_PostalCode);
            this.customers_create.Controls.Add(this.customers_create_Address1);
            this.customers_create.Controls.Add(this.customers_create_CC);
            this.customers_create.Controls.Add(this.customers_create_DLN);
            this.customers_create.Controls.Add(this.customers_create_Phone2);
            this.customers_create.Controls.Add(this.customers_create_Phone1);
            this.customers_create.Controls.Add(this.customers_create_LastName);
            this.customers_create.Controls.Add(this.customers_create_FirstName);
            this.customers_create.Controls.Add(this.label12);
            this.customers_create.Controls.Add(this.label15);
            this.customers_create.Controls.Add(this.label16);
            this.customers_create.Controls.Add(this.label17);
            this.customers_create.Controls.Add(this.label18);
            this.customers_create.Controls.Add(this.label19);
            this.customers_create.Controls.Add(this.label21);
            this.customers_create.Controls.Add(this.label22);
            this.customers_create.Controls.Add(this.label23);
            this.customers_create.Controls.Add(this.label24);
            this.customers_create.Controls.Add(this.label25);
            this.customers_create.Controls.Add(this.label26);
            this.customers_create.Location = new System.Drawing.Point(4, 25);
            this.customers_create.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create.Name = "customers_create";
            this.customers_create.Padding = new System.Windows.Forms.Padding(4);
            this.customers_create.Size = new System.Drawing.Size(984, 365);
            this.customers_create.TabIndex = 0;
            this.customers_create.Text = "Create Customer";
            this.customers_create.UseVisualStyleBackColor = true;
            // 
            // customers_create_Password
            // 
            this.customers_create_Password.Location = new System.Drawing.Point(643, 262);
            this.customers_create_Password.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Password.Name = "customers_create_Password";
            this.customers_create_Password.Size = new System.Drawing.Size(276, 22);
            this.customers_create_Password.TabIndex = 14;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(533, 266);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(69, 17);
            this.label68.TabIndex = 45;
            this.label68.Text = "Password";
            // 
            // customers_create_Username
            // 
            this.customers_create_Username.Location = new System.Drawing.Point(643, 230);
            this.customers_create_Username.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Username.Name = "customers_create_Username";
            this.customers_create_Username.Size = new System.Drawing.Size(276, 22);
            this.customers_create_Username.TabIndex = 13;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(533, 234);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(73, 17);
            this.label67.TabIndex = 43;
            this.label67.Text = "Username";
            // 
            // customers_create_DOB
            // 
            this.customers_create_DOB.Location = new System.Drawing.Point(221, 194);
            this.customers_create_DOB.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_DOB.Name = "customers_create_DOB";
            this.customers_create_DOB.Size = new System.Drawing.Size(265, 22);
            this.customers_create_DOB.TabIndex = 6;
            // 
            // customers_create_Province
            // 
            this.customers_create_Province.FormattingEnabled = true;
            this.customers_create_Province.Location = new System.Drawing.Point(643, 130);
            this.customers_create_Province.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Province.Name = "customers_create_Province";
            this.customers_create_Province.Size = new System.Drawing.Size(276, 24);
            this.customers_create_Province.TabIndex = 11;
            this.customers_create_Province.Tag = "Province, nullable";
            // 
            // customers_create_submitbtn
            // 
            this.customers_create_submitbtn.Location = new System.Drawing.Point(427, 326);
            this.customers_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_submitbtn.Name = "customers_create_submitbtn";
            this.customers_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.customers_create_submitbtn.TabIndex = 30;
            this.customers_create_submitbtn.Text = "Submit";
            this.customers_create_submitbtn.UseVisualStyleBackColor = true;
            this.customers_create_submitbtn.Click += new System.EventHandler(this.customers_create_submitbtn_Click);
            // 
            // customers_create_Address2
            // 
            this.customers_create_Address2.Location = new System.Drawing.Point(643, 66);
            this.customers_create_Address2.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Address2.Name = "customers_create_Address2";
            this.customers_create_Address2.Size = new System.Drawing.Size(276, 22);
            this.customers_create_Address2.TabIndex = 9;
            // 
            // customers_create_City
            // 
            this.customers_create_City.Location = new System.Drawing.Point(643, 98);
            this.customers_create_City.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_City.Name = "customers_create_City";
            this.customers_create_City.Size = new System.Drawing.Size(276, 22);
            this.customers_create_City.TabIndex = 10;
            // 
            // customers_create_PostalCode
            // 
            this.customers_create_PostalCode.Location = new System.Drawing.Point(643, 166);
            this.customers_create_PostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_PostalCode.Name = "customers_create_PostalCode";
            this.customers_create_PostalCode.Size = new System.Drawing.Size(276, 22);
            this.customers_create_PostalCode.TabIndex = 12;
            // 
            // customers_create_Address1
            // 
            this.customers_create_Address1.Location = new System.Drawing.Point(643, 34);
            this.customers_create_Address1.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Address1.Name = "customers_create_Address1";
            this.customers_create_Address1.Size = new System.Drawing.Size(276, 22);
            this.customers_create_Address1.TabIndex = 8;
            // 
            // customers_create_CC
            // 
            this.customers_create_CC.Location = new System.Drawing.Point(221, 226);
            this.customers_create_CC.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_CC.Name = "customers_create_CC";
            this.customers_create_CC.Size = new System.Drawing.Size(265, 22);
            this.customers_create_CC.TabIndex = 7;
            // 
            // customers_create_DLN
            // 
            this.customers_create_DLN.Location = new System.Drawing.Point(221, 162);
            this.customers_create_DLN.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_DLN.Name = "customers_create_DLN";
            this.customers_create_DLN.Size = new System.Drawing.Size(265, 22);
            this.customers_create_DLN.TabIndex = 5;
            // 
            // customers_create_Phone2
            // 
            this.customers_create_Phone2.Location = new System.Drawing.Point(221, 130);
            this.customers_create_Phone2.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Phone2.Name = "customers_create_Phone2";
            this.customers_create_Phone2.Size = new System.Drawing.Size(265, 22);
            this.customers_create_Phone2.TabIndex = 4;
            // 
            // customers_create_Phone1
            // 
            this.customers_create_Phone1.Location = new System.Drawing.Point(221, 98);
            this.customers_create_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_Phone1.Name = "customers_create_Phone1";
            this.customers_create_Phone1.Size = new System.Drawing.Size(265, 22);
            this.customers_create_Phone1.TabIndex = 3;
            // 
            // customers_create_LastName
            // 
            this.customers_create_LastName.Location = new System.Drawing.Point(221, 66);
            this.customers_create_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_LastName.Name = "customers_create_LastName";
            this.customers_create_LastName.Size = new System.Drawing.Size(265, 22);
            this.customers_create_LastName.TabIndex = 2;
            // 
            // customers_create_FirstName
            // 
            this.customers_create_FirstName.Location = new System.Drawing.Point(221, 34);
            this.customers_create_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.customers_create_FirstName.Name = "customers_create_FirstName";
            this.customers_create_FirstName.Size = new System.Drawing.Size(265, 22);
            this.customers_create_FirstName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "CC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(533, 170);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "Postal Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 198);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "DOB";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 166);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "Drivers License no.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 134);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "Secondary Phone";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 102);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Primary Phone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(533, 134);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 34;
            this.label21.Text = "Province";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(533, 102);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 17);
            this.label22.TabIndex = 33;
            this.label22.Text = "City";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(532, 70);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 17);
            this.label23.TabIndex = 32;
            this.label23.Text = "Address Line 2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(532, 38);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 17);
            this.label24.TabIndex = 31;
            this.label24.Text = "Address Line 1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 70);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 17);
            this.label25.TabIndex = 30;
            this.label25.Text = "Last Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(33, 34);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 17);
            this.label26.TabIndex = 29;
            this.label26.Text = "First Name";
            // 
            // customers_search
            // 
            this.customers_search.Controls.Add(this.textBox2);
            this.customers_search.Controls.Add(this.textBox1);
            this.customers_search.Controls.Add(this.dateTimePicker1);
            this.customers_search.Controls.Add(this.label53);
            this.customers_search.Controls.Add(this.checkBox1);
            this.customers_search.Controls.Add(this.label52);
            this.customers_search.Controls.Add(this.label51);
            this.customers_search.Controls.Add(this.label50);
            this.customers_search.Controls.Add(this.label37);
            this.customers_search.Controls.Add(this.comboBox10);
            this.customers_search.Controls.Add(this.comboBox9);
            this.customers_search.Controls.Add(this.comboBox8);
            this.customers_search.Controls.Add(this.dataGridView2);
            this.customers_search.Location = new System.Drawing.Point(4, 25);
            this.customers_search.Margin = new System.Windows.Forms.Padding(4);
            this.customers_search.Name = "customers_search";
            this.customers_search.Padding = new System.Windows.Forms.Padding(4);
            this.customers_search.Size = new System.Drawing.Size(984, 365);
            this.customers_search.TabIndex = 1;
            this.customers_search.Text = "Search";
            this.customers_search.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 40);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(247, 21);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(87, 17);
            this.label53.TabIndex = 13;
            this.label53.Text = "Date of Birth";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(744, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Gold Star";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(502, 21);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 17);
            this.label52.TabIndex = 10;
            this.label52.Text = "Address";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(87, 22);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(45, 17);
            this.label51.TabIndex = 9;
            this.label51.Text = "Name";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(7, 78);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 17);
            this.label50.TabIndex = 8;
            this.label50.Text = "Last";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 48);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 17);
            this.label37.TabIndex = 7;
            this.label37.Text = "First";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(505, 48);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(55, 24);
            this.comboBox10.TabIndex = 5;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(565, 48);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 24);
            this.comboBox9.TabIndex = 4;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(505, 78);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(181, 24);
            this.comboBox8.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.customersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(981, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // employees
            // 
            this.employees.AutoScroll = true;
            this.employees.Controls.Add(this.tabControl4);
            this.employees.Location = new System.Drawing.Point(4, 25);
            this.employees.Margin = new System.Windows.Forms.Padding(4);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(1008, 428);
            this.employees.TabIndex = 5;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl4.Controls.Add(this.employees_create);
            this.tabControl4.Controls.Add(this.employees_search);
            this.tabControl4.Location = new System.Drawing.Point(0, 4);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(997, 421);
            this.tabControl4.TabIndex = 2;
            // 
            // employees_create
            // 
            this.employees_create.Controls.Add(this.employees_create_Password);
            this.employees_create.Controls.Add(this.label69);
            this.employees_create.Controls.Add(this.employees_create_Username);
            this.employees_create.Controls.Add(this.label70);
            this.employees_create.Controls.Add(this.employees_create_BID);
            this.employees_create.Controls.Add(this.employees_create_Province);
            this.employees_create.Controls.Add(this.label1);
            this.employees_create.Controls.Add(this.employees_create_submitbtn);
            this.employees_create.Controls.Add(this.employees_create_Address2);
            this.employees_create.Controls.Add(this.employees_create_City);
            this.employees_create.Controls.Add(this.employees_create_PostalCode);
            this.employees_create.Controls.Add(this.employees_create_Address1);
            this.employees_create.Controls.Add(this.employees_create_Phone2);
            this.employees_create.Controls.Add(this.employees_create_Phone1);
            this.employees_create.Controls.Add(this.employees_create_LastName);
            this.employees_create.Controls.Add(this.employees_create_FirstName);
            this.employees_create.Controls.Add(this.label2);
            this.employees_create.Controls.Add(this.label5);
            this.employees_create.Controls.Add(this.label6);
            this.employees_create.Controls.Add(this.label7);
            this.employees_create.Controls.Add(this.label8);
            this.employees_create.Controls.Add(this.label9);
            this.employees_create.Controls.Add(this.label10);
            this.employees_create.Controls.Add(this.label11);
            this.employees_create.Controls.Add(this.label13);
            this.employees_create.Location = new System.Drawing.Point(4, 25);
            this.employees_create.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create.Name = "employees_create";
            this.employees_create.Padding = new System.Windows.Forms.Padding(4);
            this.employees_create.Size = new System.Drawing.Size(989, 392);
            this.employees_create.TabIndex = 0;
            this.employees_create.Text = "Create Employee";
            this.employees_create.UseVisualStyleBackColor = true;
            // 
            // employees_create_Password
            // 
            this.employees_create_Password.Location = new System.Drawing.Point(125, 246);
            this.employees_create_Password.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Password.Name = "employees_create_Password";
            this.employees_create_Password.Size = new System.Drawing.Size(276, 22);
            this.employees_create_Password.TabIndex = 12;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(16, 250);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(69, 17);
            this.label69.TabIndex = 71;
            this.label69.Text = "Password";
            // 
            // employees_create_Username
            // 
            this.employees_create_Username.Location = new System.Drawing.Point(125, 214);
            this.employees_create_Username.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Username.Name = "employees_create_Username";
            this.employees_create_Username.Size = new System.Drawing.Size(276, 22);
            this.employees_create_Username.TabIndex = 11;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(16, 218);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(73, 17);
            this.label70.TabIndex = 70;
            this.label70.Text = "Username";
            // 
            // employees_create_BID
            // 
            this.employees_create_BID.FormattingEnabled = true;
            this.employees_create_BID.ItemHeight = 16;
            this.employees_create_BID.Location = new System.Drawing.Point(104, 27);
            this.employees_create_BID.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_BID.Name = "employees_create_BID";
            this.employees_create_BID.Size = new System.Drawing.Size(196, 148);
            this.employees_create_BID.Sorted = true;
            this.employees_create_BID.TabIndex = 67;
            // 
            // employees_create_Province
            // 
            this.employees_create_Province.FormattingEnabled = true;
            this.employees_create_Province.Location = new System.Drawing.Point(705, 245);
            this.employees_create_Province.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Province.Name = "employees_create_Province";
            this.employees_create_Province.Size = new System.Drawing.Size(203, 24);
            this.employees_create_Province.TabIndex = 57;
            this.employees_create_Province.Tag = "Province, nullable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Branch";
            // 
            // employees_create_submitbtn
            // 
            this.employees_create_submitbtn.Location = new System.Drawing.Point(420, 314);
            this.employees_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_submitbtn.Name = "employees_create_submitbtn";
            this.employees_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.employees_create_submitbtn.TabIndex = 30;
            this.employees_create_submitbtn.Text = "Submit";
            this.employees_create_submitbtn.UseVisualStyleBackColor = true;
            this.employees_create_submitbtn.Click += new System.EventHandler(this.employees_create_submitbtn_Click);
            // 
            // employees_create_Address2
            // 
            this.employees_create_Address2.Location = new System.Drawing.Point(705, 182);
            this.employees_create_Address2.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Address2.Name = "employees_create_Address2";
            this.employees_create_Address2.Size = new System.Drawing.Size(203, 22);
            this.employees_create_Address2.TabIndex = 7;
            // 
            // employees_create_City
            // 
            this.employees_create_City.Location = new System.Drawing.Point(705, 214);
            this.employees_create_City.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_City.Name = "employees_create_City";
            this.employees_create_City.Size = new System.Drawing.Size(203, 22);
            this.employees_create_City.TabIndex = 8;
            this.employees_create_City.Text = "Hobbiton";
            // 
            // employees_create_PostalCode
            // 
            this.employees_create_PostalCode.Location = new System.Drawing.Point(705, 282);
            this.employees_create_PostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_PostalCode.Name = "employees_create_PostalCode";
            this.employees_create_PostalCode.Size = new System.Drawing.Size(203, 22);
            this.employees_create_PostalCode.TabIndex = 10;
            this.employees_create_PostalCode.Text = "H0H0H0";
            // 
            // employees_create_Address1
            // 
            this.employees_create_Address1.Location = new System.Drawing.Point(705, 150);
            this.employees_create_Address1.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Address1.Name = "employees_create_Address1";
            this.employees_create_Address1.Size = new System.Drawing.Size(203, 22);
            this.employees_create_Address1.TabIndex = 6;
            this.employees_create_Address1.Text = "123 Main Street";
            // 
            // employees_create_Phone2
            // 
            this.employees_create_Phone2.Location = new System.Drawing.Point(708, 114);
            this.employees_create_Phone2.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Phone2.Name = "employees_create_Phone2";
            this.employees_create_Phone2.Size = new System.Drawing.Size(203, 22);
            this.employees_create_Phone2.TabIndex = 4;
            // 
            // employees_create_Phone1
            // 
            this.employees_create_Phone1.Location = new System.Drawing.Point(708, 82);
            this.employees_create_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_Phone1.Name = "employees_create_Phone1";
            this.employees_create_Phone1.Size = new System.Drawing.Size(203, 22);
            this.employees_create_Phone1.TabIndex = 3;
            this.employees_create_Phone1.Text = "8776245555";
            // 
            // employees_create_LastName
            // 
            this.employees_create_LastName.Location = new System.Drawing.Point(708, 50);
            this.employees_create_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_LastName.Name = "employees_create_LastName";
            this.employees_create_LastName.Size = new System.Drawing.Size(203, 22);
            this.employees_create_LastName.TabIndex = 2;
            this.employees_create_LastName.Text = "Hippo";
            // 
            // employees_create_FirstName
            // 
            this.employees_create_FirstName.Location = new System.Drawing.Point(708, 18);
            this.employees_create_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.employees_create_FirstName.Name = "employees_create_FirstName";
            this.employees_create_FirstName.Size = new System.Drawing.Size(203, 22);
            this.employees_create_FirstName.TabIndex = 1;
            this.employees_create_FirstName.Text = "Bobby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Secondary Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Primary Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address Line 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Address Line 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(488, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "First Name";
            // 
            // employees_search
            // 
            this.employees_search.AutoScroll = true;
            this.employees_search.Controls.Add(this.label55);
            this.employees_search.Controls.Add(this.label54);
            this.employees_search.Controls.Add(postalCodeLabel);
            this.employees_search.Controls.Add(this.postalCodeComboBox);
            this.employees_search.Controls.Add(provinceLabel);
            this.employees_search.Controls.Add(this.provinceComboBox);
            this.employees_search.Controls.Add(cityLabel);
            this.employees_search.Controls.Add(this.cityComboBox);
            this.employees_search.Controls.Add(address2Label);
            this.employees_search.Controls.Add(this.address2ComboBox);
            this.employees_search.Controls.Add(address1Label);
            this.employees_search.Controls.Add(this.address1ComboBox);
            this.employees_search.Controls.Add(bIDLabel);
            this.employees_search.Controls.Add(this.bIDNumericUpDown);
            this.employees_search.Controls.Add(lastNameLabel);
            this.employees_search.Controls.Add(this.lastNameComboBox);
            this.employees_search.Controls.Add(firstNameLabel);
            this.employees_search.Controls.Add(this.firstNameComboBox);
            this.employees_search.Controls.Add(eIDLabel);
            this.employees_search.Controls.Add(this.eIDNumericUpDown);
            this.employees_search.Controls.Add(this.employeesDataGridView);
            this.employees_search.Location = new System.Drawing.Point(4, 25);
            this.employees_search.Margin = new System.Windows.Forms.Padding(4);
            this.employees_search.Name = "employees_search";
            this.employees_search.Padding = new System.Windows.Forms.Padding(4);
            this.employees_search.Size = new System.Drawing.Size(989, 392);
            this.employees_search.TabIndex = 1;
            this.employees_search.Text = "Search";
            this.employees_search.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(359, 17);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(21, 17);
            this.label55.TabIndex = 20;
            this.label55.Text = "ID";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(131, 17);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(45, 17);
            this.label54.TabIndex = 19;
            this.label54.Text = "Name";
            // 
            // postalCodeComboBox
            // 
            this.postalCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PostalCode", true));
            this.postalCodeComboBox.FormattingEnabled = true;
            this.postalCodeComboBox.Location = new System.Drawing.Point(815, 78);
            this.postalCodeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postalCodeComboBox.Name = "postalCodeComboBox";
            this.postalCodeComboBox.Size = new System.Drawing.Size(121, 24);
            this.postalCodeComboBox.TabIndex = 18;
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Province", true));
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(589, 57);
            this.provinceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(121, 24);
            this.provinceComboBox.TabIndex = 16;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "City", true));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(589, 25);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 24);
            this.cityComboBox.TabIndex = 14;
            // 
            // address2ComboBox
            // 
            this.address2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address2", true));
            this.address2ComboBox.FormattingEnabled = true;
            this.address2ComboBox.Location = new System.Drawing.Point(815, 47);
            this.address2ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address2ComboBox.Name = "address2ComboBox";
            this.address2ComboBox.Size = new System.Drawing.Size(121, 24);
            this.address2ComboBox.TabIndex = 12;
            // 
            // address1ComboBox
            // 
            this.address1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address1", true));
            this.address1ComboBox.FormattingEnabled = true;
            this.address1ComboBox.Location = new System.Drawing.Point(815, 17);
            this.address1ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address1ComboBox.Name = "address1ComboBox";
            this.address1ComboBox.Size = new System.Drawing.Size(121, 24);
            this.address1ComboBox.TabIndex = 10;
            // 
            // bIDNumericUpDown
            // 
            this.bIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "BID", true));
            this.bIDNumericUpDown.Location = new System.Drawing.Point(339, 69);
            this.bIDNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIDNumericUpDown.Name = "bIDNumericUpDown";
            this.bIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.bIDNumericUpDown.TabIndex = 8;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(107, 71);
            this.lastNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.lastNameComboBox.TabIndex = 6;
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(107, 43);
            this.firstNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.firstNameComboBox.TabIndex = 4;
            // 
            // eIDNumericUpDown
            // 
            this.eIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "EID", true));
            this.eIDNumericUpDown.Location = new System.Drawing.Point(339, 44);
            this.eIDNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eIDNumericUpDown.Name = "eIDNumericUpDown";
            this.eIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.eIDNumericUpDown.TabIndex = 2;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 119);
            this.employeesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.Size = new System.Drawing.Size(955, 220);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "EID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            // 
            // fees
            // 
            this.fees.Controls.Add(this.tabControl7);
            this.fees.Location = new System.Drawing.Point(4, 25);
            this.fees.Margin = new System.Windows.Forms.Padding(4);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(1008, 428);
            this.fees.TabIndex = 3;
            this.fees.Text = "Fees";
            this.fees.UseVisualStyleBackColor = true;
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.fees_create);
            this.tabControl7.Controls.Add(this.fees_search);
            this.tabControl7.Location = new System.Drawing.Point(0, 0);
            this.tabControl7.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(997, 402);
            this.tabControl7.TabIndex = 0;
            // 
            // fees_create
            // 
            this.fees_create.Controls.Add(this.Amount);
            this.fees_create.Controls.Add(this.fees_create_Cost);
            this.fees_create.Controls.Add(this.label40);
            this.fees_create.Controls.Add(this.fees_create_Name);
            this.fees_create.Controls.Add(this.fees_create_submitbtn);
            this.fees_create.Location = new System.Drawing.Point(4, 25);
            this.fees_create.Margin = new System.Windows.Forms.Padding(4);
            this.fees_create.Name = "fees_create";
            this.fees_create.Padding = new System.Windows.Forms.Padding(4);
            this.fees_create.Size = new System.Drawing.Size(989, 373);
            this.fees_create.TabIndex = 0;
            this.fees_create.Text = "Create Fee";
            this.fees_create.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(349, 149);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(36, 17);
            this.Amount.TabIndex = 67;
            this.Amount.Text = "Cost";
            // 
            // fees_create_Cost
            // 
            this.fees_create_Cost.Location = new System.Drawing.Point(439, 145);
            this.fees_create_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.fees_create_Cost.Name = "fees_create_Cost";
            this.fees_create_Cost.Size = new System.Drawing.Size(203, 22);
            this.fees_create_Cost.TabIndex = 2;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(349, 117);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(45, 17);
            this.label40.TabIndex = 69;
            this.label40.Text = "Name";
            // 
            // fees_create_Name
            // 
            this.fees_create_Name.Location = new System.Drawing.Point(439, 113);
            this.fees_create_Name.Margin = new System.Windows.Forms.Padding(4);
            this.fees_create_Name.Name = "fees_create_Name";
            this.fees_create_Name.Size = new System.Drawing.Size(203, 22);
            this.fees_create_Name.TabIndex = 1;
            // 
            // fees_create_submitbtn
            // 
            this.fees_create_submitbtn.Location = new System.Drawing.Point(457, 287);
            this.fees_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.fees_create_submitbtn.Name = "fees_create_submitbtn";
            this.fees_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.fees_create_submitbtn.TabIndex = 30;
            this.fees_create_submitbtn.Text = "Submit";
            this.fees_create_submitbtn.UseVisualStyleBackColor = true;
            this.fees_create_submitbtn.Click += new System.EventHandler(this.fees_create_submitbtn_Click);
            // 
            // fees_search
            // 
            this.fees_search.Location = new System.Drawing.Point(4, 25);
            this.fees_search.Margin = new System.Windows.Forms.Padding(4);
            this.fees_search.Name = "fees_search";
            this.fees_search.Padding = new System.Windows.Forms.Padding(4);
            this.fees_search.Size = new System.Drawing.Size(989, 373);
            this.fees_search.TabIndex = 1;
            this.fees_search.Text = "Search";
            this.fees_search.UseVisualStyleBackColor = true;
            // 
            // rates
            // 
            this.rates.Controls.Add(this.tabControl9);
            this.rates.Location = new System.Drawing.Point(4, 25);
            this.rates.Margin = new System.Windows.Forms.Padding(4);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(1008, 428);
            this.rates.TabIndex = 6;
            this.rates.Text = "Rates";
            this.rates.UseVisualStyleBackColor = true;
            // 
            // tabControl9
            // 
            this.tabControl9.Controls.Add(this.rates_create);
            this.tabControl9.Controls.Add(this.rates_search);
            this.tabControl9.Location = new System.Drawing.Point(-3, -2);
            this.tabControl9.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl9.Name = "tabControl9";
            this.tabControl9.SelectedIndex = 0;
            this.tabControl9.Size = new System.Drawing.Size(997, 402);
            this.tabControl9.TabIndex = 1;
            // 
            // rates_create
            // 
            this.rates_create.Controls.Add(this.rates_create_Monthly);
            this.rates_create.Controls.Add(this.rates_create_Weekly);
            this.rates_create.Controls.Add(this.rates_create_Daily);
            this.rates_create.Controls.Add(this.label42);
            this.rates_create.Controls.Add(this.rates_create_Name);
            this.rates_create.Controls.Add(this.label44);
            this.rates_create.Controls.Add(this.label43);
            this.rates_create.Controls.Add(this.label41);
            this.rates_create.Controls.Add(this.rates_create_submitbtn);
            this.rates_create.Location = new System.Drawing.Point(4, 25);
            this.rates_create.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create.Name = "rates_create";
            this.rates_create.Padding = new System.Windows.Forms.Padding(4);
            this.rates_create.Size = new System.Drawing.Size(989, 373);
            this.rates_create.TabIndex = 0;
            this.rates_create.Text = "Create Rate";
            this.rates_create.UseVisualStyleBackColor = true;
            // 
            // rates_create_Monthly
            // 
            this.rates_create_Monthly.Location = new System.Drawing.Point(457, 213);
            this.rates_create_Monthly.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create_Monthly.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rates_create_Monthly.Name = "rates_create_Monthly";
            this.rates_create_Monthly.Size = new System.Drawing.Size(204, 22);
            this.rates_create_Monthly.TabIndex = 78;
            // 
            // rates_create_Weekly
            // 
            this.rates_create_Weekly.Location = new System.Drawing.Point(457, 181);
            this.rates_create_Weekly.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create_Weekly.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rates_create_Weekly.Name = "rates_create_Weekly";
            this.rates_create_Weekly.Size = new System.Drawing.Size(204, 22);
            this.rates_create_Weekly.TabIndex = 77;
            // 
            // rates_create_Daily
            // 
            this.rates_create_Daily.Location = new System.Drawing.Point(457, 149);
            this.rates_create_Daily.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create_Daily.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rates_create_Daily.Name = "rates_create_Daily";
            this.rates_create_Daily.Size = new System.Drawing.Size(204, 22);
            this.rates_create_Daily.TabIndex = 76;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(368, 117);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 17);
            this.label42.TabIndex = 75;
            this.label42.Text = "Name";
            // 
            // rates_create_Name
            // 
            this.rates_create_Name.Location = new System.Drawing.Point(457, 113);
            this.rates_create_Name.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create_Name.Name = "rates_create_Name";
            this.rates_create_Name.Size = new System.Drawing.Size(203, 22);
            this.rates_create_Name.TabIndex = 74;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(368, 181);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(54, 17);
            this.label44.TabIndex = 73;
            this.label44.Text = "Weekly";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(368, 213);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(57, 17);
            this.label43.TabIndex = 71;
            this.label43.Text = "Monthly";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(368, 149);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(39, 17);
            this.label41.TabIndex = 67;
            this.label41.Text = "Daily";
            // 
            // rates_create_submitbtn
            // 
            this.rates_create_submitbtn.Location = new System.Drawing.Point(457, 287);
            this.rates_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rates_create_submitbtn.Name = "rates_create_submitbtn";
            this.rates_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.rates_create_submitbtn.TabIndex = 30;
            this.rates_create_submitbtn.Text = "Submit";
            this.rates_create_submitbtn.UseVisualStyleBackColor = true;
            this.rates_create_submitbtn.Click += new System.EventHandler(this.rates_create_submitbtn_Click);
            // 
            // rates_search
            // 
            this.rates_search.Controls.Add(this.Rental_fees_dataTable);
            this.rates_search.Location = new System.Drawing.Point(4, 25);
            this.rates_search.Margin = new System.Windows.Forms.Padding(4);
            this.rates_search.Name = "rates_search";
            this.rates_search.Padding = new System.Windows.Forms.Padding(4);
            this.rates_search.Size = new System.Drawing.Size(989, 373);
            this.rates_search.TabIndex = 1;
            this.rates_search.Text = "Search";
            this.rates_search.UseVisualStyleBackColor = true;
            // 
            // Rental_fees_dataTable
            // 
            this.Rental_fees_dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rental_fees_dataTable.Location = new System.Drawing.Point(7, 135);
            this.Rental_fees_dataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rental_fees_dataTable.Name = "Rental_fees_dataTable";
            this.Rental_fees_dataTable.RowTemplate.Height = 24;
            this.Rental_fees_dataTable.Size = new System.Drawing.Size(944, 194);
            this.Rental_fees_dataTable.TabIndex = 0;
            // 
            // status
            // 
            this.status.Controls.Add(this.tabControl8);
            this.status.Location = new System.Drawing.Point(4, 25);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1008, 428);
            this.status.TabIndex = 7;
            this.status.Text = "Status";
            this.status.UseVisualStyleBackColor = true;
            // 
            // tabControl8
            // 
            this.tabControl8.Controls.Add(this.status_create);
            this.tabControl8.Controls.Add(this.status_search);
            this.tabControl8.Location = new System.Drawing.Point(-3, -2);
            this.tabControl8.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            this.tabControl8.Size = new System.Drawing.Size(997, 402);
            this.tabControl8.TabIndex = 1;
            // 
            // status_create
            // 
            this.status_create.Controls.Add(this.label39);
            this.status_create.Controls.Add(this.status_create_Name);
            this.status_create.Controls.Add(this.status_create_submitbtn);
            this.status_create.Location = new System.Drawing.Point(4, 25);
            this.status_create.Margin = new System.Windows.Forms.Padding(4);
            this.status_create.Name = "status_create";
            this.status_create.Padding = new System.Windows.Forms.Padding(4);
            this.status_create.Size = new System.Drawing.Size(989, 373);
            this.status_create.TabIndex = 0;
            this.status_create.Text = "Create Status";
            this.status_create.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(319, 139);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(45, 17);
            this.label39.TabIndex = 69;
            this.label39.Text = "Name";
            // 
            // status_create_Name
            // 
            this.status_create_Name.Location = new System.Drawing.Point(408, 135);
            this.status_create_Name.Margin = new System.Windows.Forms.Padding(4);
            this.status_create_Name.Name = "status_create_Name";
            this.status_create_Name.Size = new System.Drawing.Size(203, 22);
            this.status_create_Name.TabIndex = 1;
            // 
            // status_create_submitbtn
            // 
            this.status_create_submitbtn.Location = new System.Drawing.Point(457, 287);
            this.status_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.status_create_submitbtn.Name = "status_create_submitbtn";
            this.status_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.status_create_submitbtn.TabIndex = 30;
            this.status_create_submitbtn.Text = "Submit";
            this.status_create_submitbtn.UseVisualStyleBackColor = true;
            this.status_create_submitbtn.Click += new System.EventHandler(this.status_create_submitbtn_Click);
            // 
            // status_search
            // 
            this.status_search.Location = new System.Drawing.Point(4, 25);
            this.status_search.Margin = new System.Windows.Forms.Padding(4);
            this.status_search.Name = "status_search";
            this.status_search.Padding = new System.Windows.Forms.Padding(4);
            this.status_search.Size = new System.Drawing.Size(989, 373);
            this.status_search.TabIndex = 1;
            this.status_search.Text = "Search";
            this.status_search.UseVisualStyleBackColor = true;
            // 
            // types
            // 
            this.types.Controls.Add(this.tabControl10);
            this.types.Location = new System.Drawing.Point(4, 25);
            this.types.Margin = new System.Windows.Forms.Padding(4);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(1008, 428);
            this.types.TabIndex = 8;
            this.types.Text = "Vehicle Types";
            this.types.UseVisualStyleBackColor = true;
            // 
            // tabControl10
            // 
            this.tabControl10.Controls.Add(this.types_create);
            this.tabControl10.Controls.Add(this.types_search);
            this.tabControl10.Location = new System.Drawing.Point(0, 0);
            this.tabControl10.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl10.Name = "tabControl10";
            this.tabControl10.SelectedIndex = 0;
            this.tabControl10.Size = new System.Drawing.Size(1011, 430);
            this.tabControl10.TabIndex = 0;
            // 
            // types_create
            // 
            this.types_create.Controls.Add(this.label64);
            this.types_create.Controls.Add(this.types_create_RateID);
            this.types_create.Controls.Add(this.types_create_submitbtn);
            this.types_create.Controls.Add(this.types_create_Model);
            this.types_create.Controls.Add(this.types_create_BodyType);
            this.types_create.Controls.Add(this.types_create_Make);
            this.types_create.Controls.Add(this.label59);
            this.types_create.Controls.Add(this.label58);
            this.types_create.Controls.Add(this.label57);
            this.types_create.Location = new System.Drawing.Point(4, 25);
            this.types_create.Margin = new System.Windows.Forms.Padding(4);
            this.types_create.Name = "types_create";
            this.types_create.Padding = new System.Windows.Forms.Padding(4);
            this.types_create.Size = new System.Drawing.Size(1003, 401);
            this.types_create.TabIndex = 0;
            this.types_create.Text = "Create";
            this.types_create.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(657, 122);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(38, 17);
            this.label64.TabIndex = 32;
            this.label64.Text = "Rate";
            // 
            // types_create_RateID
            // 
            this.types_create_RateID.FormattingEnabled = true;
            this.types_create_RateID.ItemHeight = 16;
            this.types_create_RateID.Location = new System.Drawing.Point(748, 118);
            this.types_create_RateID.Margin = new System.Windows.Forms.Padding(4);
            this.types_create_RateID.Name = "types_create_RateID";
            this.types_create_RateID.Size = new System.Drawing.Size(159, 116);
            this.types_create_RateID.TabIndex = 31;
            // 
            // types_create_submitbtn
            // 
            this.types_create_submitbtn.Location = new System.Drawing.Point(425, 258);
            this.types_create_submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.types_create_submitbtn.Name = "types_create_submitbtn";
            this.types_create_submitbtn.Size = new System.Drawing.Size(100, 28);
            this.types_create_submitbtn.TabIndex = 30;
            this.types_create_submitbtn.Text = "Submit";
            this.types_create_submitbtn.UseVisualStyleBackColor = true;
            this.types_create_submitbtn.Click += new System.EventHandler(this.types_create_submitbtn_Click);
            // 
            // types_create_Model
            // 
            this.types_create_Model.Location = new System.Drawing.Point(413, 154);
            this.types_create_Model.Margin = new System.Windows.Forms.Padding(4);
            this.types_create_Model.Name = "types_create_Model";
            this.types_create_Model.Size = new System.Drawing.Size(132, 22);
            this.types_create_Model.TabIndex = 2;
            // 
            // types_create_BodyType
            // 
            this.types_create_BodyType.Location = new System.Drawing.Point(413, 187);
            this.types_create_BodyType.Margin = new System.Windows.Forms.Padding(4);
            this.types_create_BodyType.Name = "types_create_BodyType";
            this.types_create_BodyType.Size = new System.Drawing.Size(132, 22);
            this.types_create_BodyType.TabIndex = 3;
            // 
            // types_create_Make
            // 
            this.types_create_Make.Location = new System.Drawing.Point(413, 118);
            this.types_create_Make.Margin = new System.Windows.Forms.Padding(4);
            this.types_create_Make.Name = "types_create_Make";
            this.types_create_Make.Size = new System.Drawing.Size(132, 22);
            this.types_create_Make.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(303, 191);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(76, 17);
            this.label59.TabIndex = 2;
            this.label59.Text = "Body Type";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(303, 158);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(46, 17);
            this.label58.TabIndex = 1;
            this.label58.Text = "Model";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(303, 122);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(42, 17);
            this.label57.TabIndex = 0;
            this.label57.Text = "Make";
            // 
            // types_search
            // 
            this.types_search.Location = new System.Drawing.Point(4, 25);
            this.types_search.Margin = new System.Windows.Forms.Padding(4);
            this.types_search.Name = "types_search";
            this.types_search.Padding = new System.Windows.Forms.Padding(4);
            this.types_search.Size = new System.Drawing.Size(1003, 401);
            this.types_search.TabIndex = 1;
            this.types_search.Text = "Search";
            this.types_search.UseVisualStyleBackColor = true;
            // 
            // rental_create_Model
            // 
            this.rental_create_Model.FormattingEnabled = true;
            this.rental_create_Model.Location = new System.Drawing.Point(379, 46);
            this.rental_create_Model.Name = "rental_create_Model";
            this.rental_create_Model.Size = new System.Drawing.Size(170, 24);
            this.rental_create_Model.TabIndex = 13;
            this.rental_create_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rental_create_Make
            // 
            this.rental_create_Make.FormattingEnabled = true;
            this.rental_create_Make.Location = new System.Drawing.Point(379, 85);
            this.rental_create_Make.Name = "rental_create_Make";
            this.rental_create_Make.Size = new System.Drawing.Size(170, 24);
            this.rental_create_Make.TabIndex = 14;
            // 
            // rental_create_BodyType
            // 
            this.rental_create_BodyType.FormattingEnabled = true;
            this.rental_create_BodyType.Location = new System.Drawing.Point(379, 125);
            this.rental_create_BodyType.Name = "rental_create_BodyType";
            this.rental_create_BodyType.Size = new System.Drawing.Size(170, 24);
            this.rental_create_BodyType.TabIndex = 15;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(327, 47);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(46, 17);
            this.label91.TabIndex = 16;
            this.label91.Text = "Model";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(331, 88);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(42, 17);
            this.label92.TabIndex = 17;
            this.label92.Text = "Make";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(302, 128);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(71, 17);
            this.label93.TabIndex = 18;
            this.label93.Text = "Body type";
            // 
            // rental_create_Rate
            // 
            this.rental_create_Rate.FormattingEnabled = true;
            this.rental_create_Rate.Location = new System.Drawing.Point(796, 125);
            this.rental_create_Rate.Name = "rental_create_Rate";
            this.rental_create_Rate.Size = new System.Drawing.Size(121, 24);
            this.rental_create_Rate.TabIndex = 19;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(752, 125);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(38, 17);
            this.label94.TabIndex = 20;
            this.label94.Text = "Rate";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(774, 162);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(16, 17);
            this.label95.TabIndex = 21;
            this.label95.Text = "$";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(606, 53);
            this.label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(38, 17);
            this.label96.TabIndex = 22;
            this.label96.Text = "Start";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(796, 162);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(0, 17);
            this.label97.TabIndex = 23;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(700, 162);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(68, 17);
            this.label98.TabIndex = 24;
            this.label98.Text = "Rate cost";
            // 
            // rental_create_RateCost
            // 
            this.rental_create_RateCost.Location = new System.Drawing.Point(796, 162);
            this.rental_create_RateCost.Name = "rental_create_RateCost";
            this.rental_create_RateCost.Size = new System.Drawing.Size(121, 22);
            this.rental_create_RateCost.TabIndex = 25;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(664, 210);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(104, 17);
            this.label99.TabIndex = 26;
            this.label99.Text = "Total Rate cost";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(774, 210);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(16, 17);
            this.label100.TabIndex = 27;
            this.label100.Text = "$";
            // 
            // rental_create_rate_Total
            // 
            this.rental_create_rate_Total.Location = new System.Drawing.Point(796, 205);
            this.rental_create_rate_Total.Name = "rental_create_rate_Total";
            this.rental_create_rate_Total.Size = new System.Drawing.Size(121, 22);
            this.rental_create_rate_Total.TabIndex = 28;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 459);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Bob\'s Car Rental";
            this.tabControl1.ResumeLayout(false);
            this.newRental.ResumeLayout(false);
            this.rentals.ResumeLayout(false);
            this.rentals_create.ResumeLayout(false);
            this.rentals_create.PerformLayout();
            this.rentals_search.ResumeLayout(false);
            this.rentals_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_Datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_RetalRate_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_search_Vehicle_milesTravelled)).EndInit();
            this.rentals_pending.ResumeLayout(false);
            this.rentals_pending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentals_pending_Pending)).EndInit();
            this.cars.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.cars_create.ResumeLayout(false);
            this.cars_create.PerformLayout();
            this.cars_search.ResumeLayout(false);
            this.cars_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.branches.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.branches_create.ResumeLayout(false);
            this.branches_create.PerformLayout();
            this.branches_search.ResumeLayout(false);
            this.branches_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branches_search_Phonenumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branches_search_Results)).EndInit();
            this.customers.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.customers_create.ResumeLayout(false);
            this.customers_create.PerformLayout();
            this.customers_search.ResumeLayout(false);
            this.customers_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.employees.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.employees_create.ResumeLayout(false);
            this.employees_create.PerformLayout();
            this.employees_search.ResumeLayout(false);
            this.employees_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.fees.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.fees_create.ResumeLayout(false);
            this.fees_create.PerformLayout();
            this.rates.ResumeLayout(false);
            this.tabControl9.ResumeLayout(false);
            this.rates_create.ResumeLayout(false);
            this.rates_create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Monthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Weekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rates_create_Daily)).EndInit();
            this.rates_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rental_fees_dataTable)).EndInit();
            this.status.ResumeLayout(false);
            this.tabControl8.ResumeLayout(false);
            this.status_create.ResumeLayout(false);
            this.status_create.PerformLayout();
            this.types.ResumeLayout(false);
            this.tabControl10.ResumeLayout(false);
            this.types_create.ResumeLayout(false);
            this.types_create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newRental;
        private System.Windows.Forms.TabPage cars;
        private System.Windows.Forms.TabPage branches;
        private System.Windows.Forms.TabPage fees;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabControl rentals;
        private System.Windows.Forms.TabPage rentals_create;
        private System.Windows.Forms.TabPage rentals_search;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage customers_create;
        private System.Windows.Forms.Button customers_create_submitbtn;
        private System.Windows.Forms.TextBox customers_create_Address2;
        private System.Windows.Forms.TextBox customers_create_City;
        private System.Windows.Forms.TextBox customers_create_PostalCode;
        private System.Windows.Forms.TextBox customers_create_Address1;
        private System.Windows.Forms.TextBox customers_create_CC;
        private System.Windows.Forms.TextBox customers_create_DLN;
        private System.Windows.Forms.TextBox customers_create_Phone2;
        private System.Windows.Forms.TextBox customers_create_Phone1;
        private System.Windows.Forms.TextBox customers_create_LastName;
        private System.Windows.Forms.TextBox customers_create_FirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage customers_search;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage employees_create;
        private System.Windows.Forms.Button employees_create_submitbtn;
        private System.Windows.Forms.TextBox employees_create_Address2;
        private System.Windows.Forms.TextBox employees_create_City;
        private System.Windows.Forms.TextBox employees_create_PostalCode;
        private System.Windows.Forms.TextBox employees_create_Address1;
        private System.Windows.Forms.TextBox employees_create_Phone2;
        private System.Windows.Forms.TextBox employees_create_Phone1;
        private System.Windows.Forms.TextBox employees_create_LastName;
        private System.Windows.Forms.TextBox employees_create_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage employees_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage cars_create;
        private System.Windows.Forms.Button cars_create_submitbtn;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage cars_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage branches_create;
        private System.Windows.Forms.Button branches_create_submitbtn;
        private System.Windows.Forms.TextBox branches_create_Address2;
        private System.Windows.Forms.TextBox branches_create_City;
        private System.Windows.Forms.TextBox branches_create_PostalCode;
        private System.Windows.Forms.TextBox branches_create_Address1;
        private System.Windows.Forms.TextBox branches_create_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox branches_create_Phone1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox cars_search_BID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cars_search_Mileage;
        private System.Windows.Forms.TextBox cars_search_VIN;
        private System.Windows.Forms.TextBox cars_search_Type;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage rates;
        private System.Windows.Forms.TabPage status;
        private System.Windows.Forms.TextBox cars_create_Mileage;
        private System.Windows.Forms.TextBox cars_create_VIN;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage fees_create;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox fees_create_Cost;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox fees_create_Name;
        private System.Windows.Forms.Button fees_create_submitbtn;
        private System.Windows.Forms.TabPage fees_search;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabPage status_create;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox status_create_Name;
        private System.Windows.Forms.Button status_create_submitbtn;
        private System.Windows.Forms.TabPage status_search;
        private System.Windows.Forms.TabControl tabControl9;
        private System.Windows.Forms.TabPage rates_create;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button rates_create_submitbtn;
        private System.Windows.Forms.TabPage rates_search;
        private System.Windows.Forms.TabPage types;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private System.Windows.Forms.BindingSource branchesBindingSource1;
        private System.Windows.Forms.BindingSource branchesBindingSource2;
        private System.Windows.Forms.BindingSource branchesBindingSource3;
        private System.Windows.Forms.BindingSource branchesBindingSource4;
        private System.Windows.Forms.BindingSource branchesBindingSource5;
        private System.Windows.Forms.TabPage branches_search;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox branches_search_Province;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DataGridView branches_search_Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goldStarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox postalCodeComboBox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox address2ComboBox;
        private System.Windows.Forms.ComboBox address1ComboBox;
        private System.Windows.Forms.NumericUpDown bIDNumericUpDown;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.NumericUpDown eIDNumericUpDown;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.DataGridView Rental_fees_dataTable;
        private System.Windows.Forms.Button branches_search_Submitbtn;
        private System.Windows.Forms.ComboBox customers_create_Province;
        private System.Windows.Forms.TextBox branches_search_Address1;
        private System.Windows.Forms.TextBox branches_search_City;
        private System.Windows.Forms.TextBox branches_search_PostalCode;
        private System.Windows.Forms.TextBox branches_search_Name;
        private System.Windows.Forms.ListBox cars_create_TypeID;
        private System.Windows.Forms.ListBox cars_create_CurrentBID;
        private System.Windows.Forms.ListBox cars_create_Status;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox branches_create_Province;
        private System.Windows.Forms.ComboBox employees_create_Province;
        private System.Windows.Forms.DateTimePicker customers_create_DOB;
        private System.Windows.Forms.ListBox employees_create_BID;
        private System.Windows.Forms.TabControl tabControl10;
        private System.Windows.Forms.TabPage types_create;
        private System.Windows.Forms.Button types_create_submitbtn;
        private System.Windows.Forms.TextBox types_create_Model;
        private System.Windows.Forms.TextBox types_create_BodyType;
        private System.Windows.Forms.TextBox types_create_Make;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TabPage types_search;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ListBox rentals_create_Vehicle;
        private System.Windows.Forms.ListBox rentals_create_RentedBranch;
        private System.Windows.Forms.DateTimePicker rentals_create_DateIn;
        private System.Windows.Forms.DateTimePicker rentals_create_DateOut;
        private System.Windows.Forms.NumericUpDown rates_create_Monthly;
        private System.Windows.Forms.NumericUpDown rates_create_Weekly;
        private System.Windows.Forms.NumericUpDown rates_create_Daily;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox rates_create_Name;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ListBox types_create_RateID;
        private System.Windows.Forms.Button rentals_create_submitbtn;
        private System.Windows.Forms.TabPage rentals_pending;
        private System.Windows.Forms.ListBox rentals_pending_BranchID;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.DataGridView rentals_pending_Pending;
        private System.Windows.Forms.TabPage rentals_return;
        private System.Windows.Forms.ListBox rentals_create_CID;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button rentals_pending_submitbtn;
        private System.Windows.Forms.TextBox customers_create_Username;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox customers_create_Password;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox employees_create_Password;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox employees_create_Username;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button branches_search_Refreshbtn;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.NumericUpDown branches_search_Phonenumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.NumericUpDown rentals_search_Vehicle_milesTravelled;
        private System.Windows.Forms.DateTimePicker rentals_search_return_Date;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.DateTimePicker rentals_search_rented_Date;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.RadioButton rentals_search_Pending_retrun_radio;
        private System.Windows.Forms.RadioButton rentals_search_Pending_rental_radio;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.CheckedListBox rentals_search_RentalRate_type;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.NumericUpDown rentals_search_RetalRate_cost;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.ComboBox rentals_search_Vehicle_bodyType;
        private System.Windows.Forms.ComboBox rentals_search_Vehicle_model;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox rentals_search_Vehicle_name;
        private System.Windows.Forms.ComboBox rentals_search_Vehicle_make;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox rentals_search_Customer_last_name;
        private System.Windows.Forms.TextBox rentals_search_Customer_first_name;
        private System.Windows.Forms.ListBox rentals_search_fees_Listbox;
        private System.Windows.Forms.TextBox rentals_search_Branch_return;
        private System.Windows.Forms.TextBox rentals_search_Branch_rental;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.DataGridView rentals_search_Datagridview;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ComboBox rental_create_BodyType;
        private System.Windows.Forms.ComboBox rental_create_Make;
        private System.Windows.Forms.ComboBox rental_create_Model;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.ComboBox rental_create_Rate;
        private System.Windows.Forms.TextBox rental_create_RateCost;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TextBox rental_create_rate_Total;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
    }
}

