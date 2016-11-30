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

            //            populateTables();
        }
        /*
                private void populateTables()
                {
                    string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM TableName WHERE FirstColumn = @0", conn);
                    }
                }       
        */
        private void Main_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet8.Employees' table. You can move, or remove it, as needed.
            //            this.employeesTableAdapter.Fill(this.cMPT291_ProjectDataSet8.Employees);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet7.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter5.Fill(this.cMPT291_ProjectDataSet7.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet6.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter4.Fill(this.cMPT291_ProjectDataSet6.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet5.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter3.Fill(this.cMPT291_ProjectDataSet5.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet4.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter2.Fill(this.cMPT291_ProjectDataSet4.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet3.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter1.Fill(this.cMPT291_ProjectDataSet3.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet2.Branches' table. You can move, or remove it, as needed.
            //            this.branchesTableAdapter.Fill(this.cMPT291_ProjectDataSet2.Branches);
            // TODO: This line of code loads data into the 'cMPT291_ProjectDataSet1.Customers' table. You can move, or remove it, as needed.
            //            this.customersTableAdapter.Fill(this.cMPT291_ProjectDataSet1.Customers);

        }

        private void branches_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Branches " +
                "(Name, Address1, Address2, City, Province, PostalCode, Phone1)" +
                "VALUES (@Name, @Address1, @Address2, @City, @Province, @PostalCode, @Phone1)");
            Control[] fields = { branches_create_Name, branches_create_Address1, branches_create_Address2, branches_create_City, branches_create_Province, branches_create_PostalCode, branches_create_Phone1 };
            validation.types[] checkAs = { validation.types.Name, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode, validation.types.Phone };

            insert(cmd, fields, checkAs);
        }

        private void cars_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles " +
            "(Type, VIN, Mileage, CurrentBID, Fee)" +
            "VALUES (@TypeID, @VIN, @Mileage, @BranchID, @FID)");
            Control[] fields = { cars_create_TypeID, cars_create_VIN, cars_create_Mileage, cars_create_BranchID };
            validation.types[] checkAs = { validation.types.Type, validation.types.VIN, validation.types.Mileage, validation.types.ID };

            insert(cmd, fields, checkAs);
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

            insert(cmd, fields, checkAs);
        }
        private void employees_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Employees " +
            "(FirstName, LastName, Phone1, Phone2, BID, Address1, Address2, City, Province, PostalCode)" +
            "VALUES (@FirstName, @LastName, @Phone1, @Phone2, @BID, @Address1, @Address2, @City, @Province, @PostalCode)");
            Control[] fields = { employees_create_FirstName, employees_create_LastName, employees_create_Phone1, employees_create_Phone2, employees_create_BID, employees_create_Address1, employees_create_Address2, employees_create_City, employees_create_Province, employees_create_PostalCode };
            validation.types[] checkAs = { validation.types.Name, validation.types.Name, validation.types.Phone, validation.types.Phone, validation.types.ID, validation.types.Address, validation.types.Address, validation.types.City, validation.types.Province, validation.types.PostalCode };

            insert(cmd, fields, checkAs);
        }
        //validation for "amount" must be created and implemented, replacing the use of CC here
        private void fees_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO AdditionalFees" +
            "(Name, Cost)" +
            "VALUES (@Name, @Cost)");
            Control[] fields = { fees_create_Name, fees_create_Cost };
            validation.types[] checkAs = { validation.types.Name, validation.types.CC };

            insert(cmd, fields, checkAs);
        }
        private void status_create_submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("INSERT INTO Status " +
            "(Name)" +
            "VALUES (@Name)");
            Control[] fields = { status_create_Name };
            validation.types[] checkAs = { validation.types.Address };
        }


        private void insert(SqlCommand cmd, Control[] fields, validation.types[] checkAs) {
            bool acceptable = true;
            validation isValid = new validation();
            for (int i = 0; i < fields.Length; i++) {
                if (!isValid.validate(fields[i].Text, checkAs[i])) {
                    fields[i].BackColor = Color.Tomato;
                    acceptable = false;
                }
            }
            if (acceptable == false)
                return;
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString)) {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                for (int i = 0; i < fields.Length; i++) {
                    int index = fields[i].Name.LastIndexOf('_');
                    cmd.Parameters.AddWithValue("@" + fields[i].Name.Substring(index + 1), fields[i].Text);
                    fields[i].Text = "";
                }
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void branches_search_Submitbtn_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand("Select * from Branches");
            search(cmd, branches_search_Results);
        }

        private void search(SqlCommand cmd, DataGridView display) {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString)) {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                //                connection.Open();
                DataTable results = new DataTable();
                data.Fill(results);
                display.DataSource = results;
            }
        }
    }
}
