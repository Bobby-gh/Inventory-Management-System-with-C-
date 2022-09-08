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
    public partial class InventorySystem : Form
    {
        public InventorySystem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void InventorySystem_Load(object sender, EventArgs e)
        {
            
        }

        private void product1_Load(object sender, EventArgs e)
        {

        }

        private void product1_Load_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            product1.Visible = true;
            dashboard1.Visible = false;
        }

        private void category1_Load(object sender, EventArgs e)
        {

        }

        private void product1_Load_2(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            users1.Visible = true;
            stocks1.Visible = false;
            category1.Visible = false;
            product1.Visible = false;
            dashboard1.Visible=false; 
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            category1.Visible = true;
            product1.Visible = false;
            dashboard1.Visible = false;
                        
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            stocks1.Visible = true;
            category1.Visible = false;
            product1.Visible = false;
            dashboard1.Visible = false;
        }

        private void users1_Load(object sender, EventArgs e)
        {

        }

        private void repot1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            users1.Visible = false;
            stocks1.Visible = false;
            category1.Visible = false;
            product1.Visible = false;
            dashboard1.Visible = false;
            
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void stocks1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
