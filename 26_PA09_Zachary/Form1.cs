using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_PA09_Zachary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnconvert_Click(object sender, EventArgs e)
        {
            double amountentered;
            double convertvalue;

            try
            {
                if (radusd.Checked == true && radyen.Checked == false)
                {
                    amountentered = double.Parse(txtamount.Text);
                    convertvalue = amountentered * 0.74;

                    txtvalue.Text = convertvalue.ToString();
                }
                if (radyen.Checked == true && radusd.Checked == false)
                {
                    amountentered = double.Parse(txtamount.Text);
                    convertvalue = amountentered * 81.97;

                    txtvalue.Text = convertvalue.ToString();
                }

                if (radyen.Checked == false && radusd.Checked == false)
                {
                    txtvalue.Text = "Select atleast one type of currency to convert";
                }
            }
            catch (Exception)
            {
                txtamount.Text = "Please enter a valid amount";
            }
           
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            txtamount.Text = "";
            radyen.Checked = false;
            radusd.Checked = false;
            txtvalue.Text = "";
        }
    }
}
