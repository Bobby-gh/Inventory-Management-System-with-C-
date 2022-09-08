using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BobCs
{
    public partial class Users : UserControl
    {


        public Users()
        {
            InitializeComponent();
            CreateUser();
        }

        public string user_id;
        public string name;
        public string email;
        public string phone;
        public string role;
        public string gender;


        public void Clear()
        {
            UserName.Clear();
            UserUserName.Clear();
            UserPassword.Clear();
            UserPhone.Clear();
            UserRole.Text = "";
            UserName.Focus();
        }

        private string generateUserID()
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
        public void CreateUser()
        {
            int i = 0;
            userTables.Rows.Clear();
            string query = "Select * from user";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                userTables.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[2].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text == "" || UserEmail.Text == "" || UserPassword.Text == "" || UserPhone.Text == "" || UserUserName.Text == "")
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
                    bool user_exits = false;

                    query = "Select * from products where productName = '" + UserName.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("User already Exist !");
                        user_exits = true;
                    }
                    else
                    {
                        user_exits = false;
                    }
                    dr.Close();
                    if (!user_exits)
                    {
                        query = "Insert into products(userName,userPassword,userPhone,userUserName) values(@UserName,@UserPassword,@UserPhone,@userUserName)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@userPassword", UserPassword.Text);
                        command.Parameters.AddWithValue("@userName", UserName.Text);
                        command.Parameters.AddWithValue("@userPhone", UserPhone.Text);
                        command.Parameters.AddWithValue("@userEmail", UserEmail.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CreateUser();
                        Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
