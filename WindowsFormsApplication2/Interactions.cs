using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;


public class Interaction
{
    public void insert(SqlCommand cmd, Control[] fields, validation.types[] checkAs, bool[] nullable) {
        bool accepted = true;
        validation isValid = new validation();
        for (int i = 0; i < fields.Length; i++) {
            fields[i].BackColor = Color.White;
            if (nullable[i] == true && fields[i].Text.Length == 0)
                continue;
            if (nullable[i] == false && fields[i].Text.Length == 0) {
                fields[i].BackColor = Color.Tomato;
                accepted = false;
            }
            //validation currently not run on DateTimePickers as they cannot be empty
            if (fields[i] is TextBox || fields[i] is ComboBox || fields[i] is NumericUpDown) {
                if (!isValid.validate(fields[i].Text, checkAs[i])) {
                    fields[i].BackColor = Color.Tomato;
                    accepted = false;
                }
            } else if (fields[i] is ListBox) {
                if (!isValid.validate((fields[i] as ListBox).SelectedValue.ToString(), checkAs[i])) {
                    fields[i].BackColor = Color.Tomato;
                    accepted = false;
                }
            }
        }
        if (accepted == false)
            return;
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connString)) {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            for (int i = 0; i < fields.Length; i++) {
                int index = fields[i].Name.LastIndexOf('_');
                if (fields[i] is TextBox || fields[i] is ComboBox || fields[i] is NumericUpDown)
                    cmd.Parameters.AddWithValue("@" + fields[i].Name.Substring(index + 1), fields[i].Text);
                else if (fields[i] is DateTimePicker)
                    cmd.Parameters.AddWithValue("@" + fields[i].Name.Substring(index + 1), (fields[i] as DateTimePicker).Value.Date);
                else if (fields[i] is ListBox)
                    cmd.Parameters.AddWithValue("@" + fields[i].Name.Substring(index + 1), (fields[i] as ListBox).SelectedValue);
                fields[i].Text = "";
            }
            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void execute(SqlCommand cmd) {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connString)) {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void search(SqlCommand cmd, DataGridView display) {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connString)) {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable results = new DataTable();
            data.Fill(results);
            display.DataSource = results;
        }
    }

    public void search(SqlCommand cmd, ListBox listbox, string display, string value)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connString))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable results = new DataTable();
            data.Fill(results);
            listbox.DataSource = results;
            listbox.DisplayMember = display;
            listbox.ValueMember = value;
        }
    }
    public void search(SqlCommand cmd, ComboBox combobox, string display, string value)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["CMPT291_Project"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connString))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable results = new DataTable();
            data.Fill(results);
            combobox.DataSource = results;
            combobox.DisplayMember = display;
            combobox.ValueMember = value;
        }

    }
}
