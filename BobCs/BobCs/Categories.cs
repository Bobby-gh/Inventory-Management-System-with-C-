using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobCs
{
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            CategoryName.Clear();
            CategoryDescreption.Clear();
        }
        public void LoadCategory()
        {
            int i = 0;
            CategoryTables.Rows.Clear();
            string query = "Select * from Category";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                CategoryTables.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            DBConnect.close_connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryName.Text == "" || CategoryDescreption.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DBConnect.open_connection();
                    MySqlCommand command;
                    command = new MySqlCommand();


                    string query = "";
                    bool product_exits = false;

                    query = "Select * from category where categoryName = '" + CategoryName.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Categoryname already Exist !");
                        product_exits = true;
                    }
                    else
                    {
                        product_exits = false;
                    }
                    dr.Close();
                    if (!product_exits)
                    {
                        query = "Insert into category( CategoryName, description) values(@CategoryName,@CategoryDescreption)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                        command.Parameters.AddWithValue("@CategoryDescreption", CategoryDescreption.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }
    }
}
