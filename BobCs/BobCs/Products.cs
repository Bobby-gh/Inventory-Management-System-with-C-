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
    public partial class Products : UserControl
    {
        DBConnect db = new DBConnect();
        public Products()
        {
            InitializeComponent();
            LoadProduct();
            loadCategory();
        }

        public void LoadProduct()
        {
            int i = 0;
            ProductTables.Rows.Clear();
            string query = "Select * from products";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ProductTables.Rows.Add(dr[0].ToString(), dr[3].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }

        public void Clear()
        {
            ProductName.Clear();
            ProductDescreption.Clear();
        }

        public void loadCategory()
        {
            productCategory.Items.Clear();
            productCategory.DataSource = db.getTable("SELECT * FROM category");
            productCategory.DisplayMember = "categoryName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductName.Text == "" || productCategory.Text == "" || ProductDescreption.Text == "")
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

                    query = "Select * from products where productName = '" + ProductName.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Productname already Exist !");
                        product_exits = true;
                    }
                    else
                    {
                        product_exits = false;
                    }
                    dr.Close();
                    if (!product_exits)
                    {
                        query = "Insert into products(productName,category,description) values(@ProductName,@productCategory,@ProductDescreption)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@ProductName", ProductName.Text);
                        command.Parameters.AddWithValue("@productCategory", productCategory.Text);
                        command.Parameters.AddWithValue("@ProductDescreption", ProductDescreption.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduct();



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
