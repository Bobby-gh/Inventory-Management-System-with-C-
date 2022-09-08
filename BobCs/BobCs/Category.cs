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
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void Clear()
        {
            CategoryName.Clear();
            CategoryDescreption.Clear();
        }

        private string generateCategoryID()
        {
            string num = "123456789";
            string user_id = string.Empty;
            int otp_digits = 5;
            string otp;
            int get_index;

            for (int i = 0; i < otp_digits; i++)
            {
                do
                {
                    get_index = new Random().Next(0, num.Length);
                    otp = num.ToCharArray()[get_index].ToString();
                } while (user_id.IndexOf(otp) != -1);

                user_id += otp;
            }

            return user_id;
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
            DBConnect.close_connection
                ();
        }

        private void Category_Load(object sender, EventArgs e)
        {

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
                        query = "Insert into category(id, CategoryName, description) values(@CategoryID,@CategoryName,@CategoryDescreption)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                        command.Parameters.AddWithValue("@CategoryDescreption", CategoryDescreption.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();
                        Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void CategoryName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
