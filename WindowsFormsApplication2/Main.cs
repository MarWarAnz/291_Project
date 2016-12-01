using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication2 {

    public partial class Main : Form {

        enum permissions {Customer, Employee, Manager};
        permissions userType = permissions.Customer;
        int ID = 1;

        public Main() {
            InitializeComponent();

            string[] Provinces = { "", "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };
            customers_create_Province.DataSource = Provinces;
            branches_create_Province.DataSource = Provinces;
            employees_create_Province.DataSource = Provinces;

            PopulateCarTypeMenus();
            PopulateStatusMenus();
            PopulateBranchMenus();
            PopulateVehicleMenus();
            PopulatePendingMenus();
            PopulateCustomerMenus();
        }

        private void PopulateCustomerMenus() {
            SqlCommand cmd;
             if (userType == permissions.Employee || userType == permissions.Manager) {
                cmd = new SqlCommand("Select Concat(FirstName, LastName) as Name, CID from Customers");
            } else {
                rentals_create_CID.Enabled = false;
                cmd = new SqlCommand("Select Concat(FirstName, LastName) as Name, CID from Customers where CID = @CID");
                cmd.Parameters.AddWithValue("@CID", ID);
            }
            Interaction interaction = new Interaction();
            interaction.search(cmd, rentals_create_CID, "Name", "CID");
        }

        private void PopulateRateMenus() {
            SqlCommand cmd = new SqlCommand("SELECT Name, RateID FROM Rates");
            Interaction interaction = new Interaction();
            interaction.search(cmd, types_create_RateID, "Name", "RateID");
        }

        private void PopulateVehicleMenus() {
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(Make, Model) as thisCar, VID FROM Vehicles INNER JOIN CarTypes ON Vehicles.TypeID = CarTypes.TID WHERE CurrentBID = @BranchID");
            if (!(rentals_create_RentedBranch.SelectedValue.ToString() == "System.Data.DataRowView")) {
                cmd.Parameters.AddWithValue("@BranchID", rentals_create_RentedBranch.SelectedValue.ToString());
                Interaction interaction = new Interaction();
                interaction.search(cmd, rentals_create_Vehicle, "thisCar", "VID");
            }
        }

        private void PopulateStatusMenus() {
            SqlCommand cmd = new SqlCommand("Select Name, SID from Status");
            Interaction interaction = new Interaction();
            interaction.search(cmd, cars_create_Status, "Name", "SID");
        }

        private void PopulateBranchMenus() {
            SqlCommand cmd = new SqlCommand("Select BID, Name from Branches");
            Interaction interaction = new Interaction();
            interaction.search(cmd, cars_create_CurrentBID, "Name", "BID");
            interaction.search(cmd, employees_create_BID, "Name", "BID");
            interaction.search(cmd, rentals_create_RentedBranch, "Name", "BID");
            interaction.search(cmd, rentals_pending_BranchID, "Name", "BID");
        }

        private void PopulatePendingMenus() {
            SqlCommand cmd = new SqlCommand("Select * from Transactions where RentedBranch = @BranchID and Pending = 1");
            if (!(rentals_pending_BranchID.SelectedValue.ToString() == "System.Data.DataRowView")) {
                cmd.Parameters.AddWithValue("@BranchID", rentals_pending_BranchID.SelectedValue);
                Interaction interaction = new Interaction();
                interaction.search(cmd, rentals_pending_Pending);
            }
        }

        private void PopulateCarTypeMenus() {
            SqlCommand cmd = new SqlCommand("Select Model, TID from CarTypes");
            Interaction interaction = new Interaction();
            interaction.search(cmd, cars_create_TypeID, "Model", "TID");
        }

        private void branches_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Branches " +
                "(Name, Address1, Address2, City, Province, PostalCode, Phone1)" +
                "VALUES (@Name, @Address1, @Address2, @City, @Province, @PostalCode, @Phone1)");
            Control[] fields = { branches_create_Name, branches_create_Address1, branches_create_Address2, branches_create_City, branches_create_Province, branches_create_PostalCode, branches_create_Phone1 };
            validation.types[] checkAs = { validation.types.Name, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode, validation.types.Phone };
            bool[] nullable = { false, false, true, false, false, false, false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
            PopulateBranchMenus();
        }

        private void cars_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles " +
            "(TypeID, Status, VIN, Mileage, CurrentBID)" +
            "VALUES (@TypeID, @Status, @VIN, @Mileage, @CurrentBID)");
            Control[] fields = { cars_create_TypeID, cars_create_Status, cars_create_VIN, cars_create_Mileage, cars_create_CurrentBID };
            validation.types[] checkAs = { validation.types.Type, validation.types.ID, validation.types.VIN, validation.types.Mileage, validation.types.ID };
            bool[] nullable = { false, false, false, false, false};

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
            PopulateVehicleMenus();
        }

        //DOB does not work
        //password needs to be addressed
        //DLN needs validation rules
        private void customers_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers " +
            "(FirstName, LastName, Phone1, Phone2, DLN, DOB, CC, Address1, Address2, City, Province, PostalCode)" +
            "VALUES (@FirstName, @LastName, @Phone1, @Phone2, @DLN, @DOB, @CC, @Address1, @Address2, @City, @Province, @PostalCode)");
            Control[] fields = { customers_create_FirstName, customers_create_LastName, customers_create_Phone1, customers_create_Phone2, customers_create_DLN, customers_create_DOB, customers_create_CC, customers_create_Address1, customers_create_Address2, customers_create_City, customers_create_Province, customers_create_PostalCode, customers_create_Username, customers_create_Password };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Phone, validation.types.Phone, validation.types.DLN, validation.types.DOB, validation.types.CC, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode, validation.types.Email, validation.types.Email };
            bool[] nullable = { false, false, false, true, false, false, false, false, true, false, false, false, true, true };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        private void employees_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Employees " +
            "(FirstName, LastName, Phone1, Phone2, BID, Address1, Address2, City, Province, PostalCode)" +
            "VALUES (@FirstName, @LastName, @Phone1, @Phone2, @BID, @Address1, @Address2, @City, @Province, @PostalCode)");
            bool[] nullable = { false, false, false, true, false, false, true, false, false, false , true, true };
            Control[] fields = { employees_create_FirstName, employees_create_LastName, employees_create_Phone1, employees_create_Phone2, employees_create_BID, employees_create_Address1, employees_create_Address2, employees_create_City, employees_create_Province, employees_create_PostalCode, employees_create_Username, employees_create_Password };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Phone, validation.types.Phone, validation.types.ID, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode, validation.types.Email, validation.types.Email };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }
        //validation for "amount" must be created and implemented, replacing the use of CC here
        private void fees_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO AdditionalFees" +
            "(Name, Cost)" +
            "VALUES (@Name, @Cost)");
            Control[] fields = { fees_create_Name, fees_create_Cost };
            validation.types[] checkAs = { validation.types.Name, validation.types.CC };
            bool[] nullable = { false, false};

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        private void status_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Status " +
            "(Name)" +
            "VALUES (@Name)");
            Control[] fields = { status_create_Name };
            validation.types[] checkAs = { validation.types.Address };
            bool[] nullable = { false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
            PopulateStatusMenus();
        }

        private void types_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO CarType " +
                "(Make, Model, BodyType, RateID)" +
                "VALUES (@Make, @Model, @BodyType, @RateID)");
            Control[] fields = { types_create_Make, types_create_Model, types_create_BodyType, types_create_RateID };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Name, validation.types.ID};
            bool[] nullable = { false, false, false, false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
            PopulateCarTypeMenus();
        }

        private void rates_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Rates " +
                "(Name, Daily, Weekly, Monthly)" +
                "VALUES (@Name, @Daily, @Weekly, @Monthly)");
            Control[] fields = { rates_create_Name, rates_create_Daily, rates_create_Weekly, rates_create_Monthly };
            validation.types[] checkAs = { validation.types.Name, validation.types.ID, validation.types.ID, validation.types.ID };
            bool[] nullable = { false, false, false, false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        //needs customer credentials from login, or selection if employee
        //add validation rules for Date
        private void rentals_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Transactions " +
                "(DateOut, DateIn, RentedBranch, CID, Vehicle)" +
                "VALUES (@DateOut, @DateIn, @RentedBranch, @CID, @Vehicle)");
            Control[] fields = { rentals_create_DateOut, rentals_create_DateIn, rentals_create_RentedBranch, rentals_create_CID, rentals_create_Vehicle};
            validation.types[] checkAs = { validation.types.Address, validation.types.Address, validation.types.ID, validation.types.ID, validation.types.ID};
            bool[] nullable = { false, false, false, false, false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        private void branches_search_Submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("Select * from Branches");

            Interaction interaction = new Interaction();
            interaction.search(cmd, branches_search_Results);
        }

        private void rentals_create_RentedBranch_SelectedIndexChanged(object sender, EventArgs e) {
            PopulateVehicleMenus();
        }

        private void rentals_pending_BranchID_SelectedIndexChanged(object sender, EventArgs e) {
            PopulatePendingMenus();
        }

        private void rentals_pending_submitbtn_Click(object sender, EventArgs e) {
            if (rentals_pending_Pending.SelectedRows.Count < 0)
                for (int i = 0; i < rentals_pending_Pending.SelectedRows.Count; i++) {
                    SqlCommand cmd = new SqlCommand("UPDATE Transactions SET Pending = '0', Processed = '1' where TID = @TID");
                    cmd.Parameters.AddWithValue("@TID", rentals_pending_Pending.SelectedRows[i].Cells[1].Value);
                    Interaction interaction = new Interaction();
                    interaction.execute(cmd);
                }
            PopulatePendingMenus();
        }
    }
}
