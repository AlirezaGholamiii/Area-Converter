using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormConvertingArea
{
    public partial class frmAreaConvert : Form
    {
        public frmAreaConvert()
        {
            InitializeComponent();
            txtboxdate.Text = DateTime.Now.ToShortDateString();
           
        }
        ConvertEaria object1 = new ConvertEaria();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                object1.Cm = Convert.ToDouble(textBox1.Text);
                textBox5.Text = Convert.ToString(object1.cmToinch());
            }
            catch(Exception e1)
            {
               if( MessageBox.Show("This is not a correct value \nplrase enter a value.","Exeption",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error).ToString() == "Cancel")
                {
                    this.Close();
                }
               else
                {
                    textBox1.Text = "0";
                    textBox1.Focus();
                }
            }


        }
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                object1.M = Convert.ToDouble(textBox2.Text);
                textBox6.Text = Convert.ToString(object1.mToyard());
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object1.Hectar = Convert.ToDouble(textBox3.Text);
                textBox7.Text = Convert.ToString(object1.hectarToacres());
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                object1.Km = Convert.ToDouble(textBox4.Text);
                textBox8.Text = Convert.ToString(object1.kmTomile());
            }
            catch(Exception e4)
            {
                MessageBox.Show(e4.Message);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to quit ?", " Exit ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK") 
            {
                MessageBox.Show("You decide to quit.") ;
                
                Application.Exit();
                
            }
            else
            {
                textBox1.Text = "0";
                textBox1.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox11.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox1.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAreaConvert_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalChars_Click(object sender, EventArgs e)
        {
            
            object1.Name = Convert.ToString(textBox9.Text);
            textBox10.Text = Convert.ToString(object1.getname());
        }

        private void btnTotalID_Click(object sender, EventArgs e)
        {

            /*
                        int Total = 0;

                        Total += Convert.ToInt32(txtID1.Text);
                        Total += Convert.ToInt32(txtID2.Text);
                        Total += Convert.ToInt32(txtID3.Text);
                        Total += Convert.ToInt32(txtID4.Text);
                        Total += Convert.ToInt32(txtID5.Text);
                        Total += Convert.ToInt32(txtID6.Text);
                        Total += Convert.ToInt32(txtID7.Text);

                        textBox11.Text = Convert.ToString(Total);*/


            

                int total = 0;

                foreach (char num in textBox11.Text)
                {
                    total += int.Parse(num.ToString());
                }

                textBox11.Text = total.ToString();


           

            
            

        }

        private void txtID1_Click(object sender, EventArgs e)
        {
            if(textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text += "1";
           
        }

        private void txtID2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text +=  "2";
        }

        private void txtID3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text += "3";
        }

        private void txtID4_Click(object sender, EventArgs e)
        {
            textBox11.Text += "4";
        }

        private void txtID5_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text += "5";
        }

        private void txtID6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text += "6";
        }

        private void txtID7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "0")
            {
                textBox11.Clear();
            }
            textBox11.Text +=  "7";
        }
    }
}
