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
    public partial class Product : UserControl
    {
       

        DBConnect db = new DBConnect();
        public Product()
        {
            InitializeComponent();
            loadCategory();
            LoadProduct();
        }
        public void Clear()
        {
            ProductName.Clear();
            ProductDescreption.Clear();
        }

        private string generateProductID()
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

        public void loadCategory()
        {
            productCategory.Items.Clear();
            productCategory.DataSource = db.getTable("SELECT * FROM category");
            productCategory.DisplayMember = "categoryName";
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
        private void Product_Load(object sender, EventArgs e)
        {

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
                        query = "Insert into products(id,productName,category,description) values(@ProductID,@ProductName,@productCategory,@ProductDescreption)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@ProductName", ProductName.Text);
                        command.Parameters.AddWithValue("@productCategory", productCategory.Text);
                        command.Parameters.AddWithValue("@ProductDescreption", ProductDescreption.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduct();
                        Clear();


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
