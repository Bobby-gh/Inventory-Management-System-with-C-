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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect.open_connection();
            MySqlCommand command;
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    //string enc_pass = Ecrypt.HashString(password.Text)
                    string query = "select * from user where username = '" + txtUsername.Text + "'&& password = '" + txtPassword.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        reader.Close();
                        InventorySystem inventorySystem = new InventorySystem();
                        inventorySystem.Show();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Incorrect credentials!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBConnect.close_connection();
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect.open_connection();
            MySqlCommand command;
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    //string enc_pass = Ecrypt.HashString(password.Text)
                    string query = "select * from user where username = '" + txtUsername.Text + "'&& password = '" + txtPassword.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        reader.Close();
                        InventorySystem inventory = new InventorySystem();
                        inventory.Show();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Incorrect credentials!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBConnect.close_connection();
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }
    }
}
