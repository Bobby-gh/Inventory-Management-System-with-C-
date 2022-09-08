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
    public partial class Stocks : UserControl
    {
        DBConnect db = new DBConnect();
        public Stocks()
        {
            InitializeComponent();
            loadCategory();
            loadProduct();
            loaduser();
            Loadstock();
        }


        public void loadCategory()
        {
            categoryNames.Items.Clear();
            categoryNames.DataSource = db.getTable("SELECT * FROM category");
            categoryNames.DisplayMember = "categoryName";
        }

        public void loadProduct()
        {
            productName.Items.Clear();
            productName.DataSource = db.getTable("SELECT * FROM products");
            productName.DisplayMember = "productName";
        }

        public void loaduser()
        {
            attendantName.Items.Clear();
            attendantName.DataSource = db.getTable("SELECT * FROM user");
            attendantName.DisplayMember = "username";
        }
        private string generateStockID()
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

        public void Loadstock()
        {
            int i = 0;
            stockTable.Rows.Clear();
            string query = "Select * from stock";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                stockTable.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[1].ToString(), dr[4].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {

        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (productName.Text == "" || categoryNames.Text == "" || Qnty.Text == "" || attendantName.Text == "")
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
                    bool stock_exits = false;

                    query = "Select * from stock where product = '" + productName.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("stockID already Exist !");
                        stock_exits = true;
                    }
                    else
                    {
                        stock_exits = false;
                    }
                    dr.Close();
                    if (!stock_exits)
                    {
                        query = "Insert into stock(product,categoryName,quantity,attendantName) values(@productName,@categoryNames,@Qnty,@attenadantName)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@productName", productName.Text);
                        command.Parameters.AddWithValue("@categoryNames", categoryNames.Text);
                        command.Parameters.AddWithValue("@Qnty", Qnty.Text);
                        command.Parameters.AddWithValue("@attendantName", attendantName.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loadstock();


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
