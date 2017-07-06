using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_username
{
    public partial class Form1 : Form
    {
    
        public Form1()
        { 
            InitializeComponent();
            txt_pass.Visible = false;
            btn_Login.Visible = false;
            lb_pass.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
       
            if (txt_user.Text == "mitri")
            {
            lb_pass.Visible = true;
            txt_pass.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 SS = new Form2();
            SS.Show();
          
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text == "mitri")
            {
                btn_Login.Visible = true;
            }
        }
      

        }

      

   

        
    }

