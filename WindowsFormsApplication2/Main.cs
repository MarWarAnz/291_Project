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
        public Main() {
            InitializeComponent();

            string[] Provinces = { "", "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };
            customers_create_Province.DataSource = Provinces;

            Interaction interaction = new Interaction();

            SqlCommand cmd = new SqlCommand("Select Model, TID from CarType");
            interaction.search(cmd, cars_create_TypeID, "Model", "TID");
            cmd = new SqlCommand("Select BID, Name from Branches");
            interaction.search(cmd, cars_create_BranchID, "Name", "BID");
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
        }

        private void cars_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles " +
            "(Type, VIN, Mileage, CurrentBID, Fee)" +
            "VALUES (@TypeID, @VIN, @Mileage, @BranchID, @FID)");
            Control[] fields = { cars_create_TypeID, cars_create_VIN, cars_create_Mileage, cars_create_BranchID };
            validation.types[] checkAs = { validation.types.Type, validation.types.VIN, validation.types.Mileage, validation.types.ID };
            bool[] nullable = { false, false, false, false};

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        //DOB does not work
        //password needs to be addressed
        //DLN needs validation rules
        private void customers_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers " +
            "(FirstName, LastName, Phone1, Phone2, DLN, DOB, CC, Address1, Address2, City, Province, PostalCode)" +
            "VALUES (@FirstName, @LastName, @Phone1, @Phone2, @DLN, @DOB, @CC, @Address1, @Address2, @City, @Province, @PostalCode)");
            Control[] fields = { customers_create_FirstName, customers_create_LastName, customers_create_Phone1, customers_create_Phone2, customers_create_DLN, customers_create_DOB, customers_create_CC, customers_create_Address1, customers_create_Address2, customers_create_City, customers_create_Province, customers_create_PostalCode };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Phone, validation.types.Phone, validation.types.DLN, validation.types.DOB, validation.types.CC, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode };
            bool[] nullable = { false, false, false, true, false, false, false, false, true, false, false, false };

            Interaction interaction = new Interaction();
            interaction.insert(cmd, fields, checkAs, nullable);
        }

        private void employees_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Employees " +
            "(FirstName, LastName, Phone1, Phone2, BID, Address1, Address2, City, Province, PostalCode)" +
            "VALUES (@FirstName, @LastName, @Phone1, @Phone2, @BID, @Address1, @Address2, @City, @Province, @PostalCode)");
            bool[] nullable = { false, false, false, true, false, false, true, false, false, false };
            Control[] fields = { employees_create_FirstName, employees_create_LastName, employees_create_Phone1, employees_create_Phone2, employees_create_BID, employees_create_Address1, employees_create_Address2, employees_create_City, employees_create_Province, employees_create_PostalCode };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Phone, validation.types.Phone, validation.types.ID, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode };

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
        }

        private void branches_search_Submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("Select * from Branches");

            Interaction interaction = new Interaction();
            interaction.search(cmd, branches_search_Results);
        }
    }
}
