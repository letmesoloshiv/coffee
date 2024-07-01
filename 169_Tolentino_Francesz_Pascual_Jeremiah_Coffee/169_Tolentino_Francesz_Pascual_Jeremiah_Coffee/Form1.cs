using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Tolentino_Francesz_Pascual_Jeremiah_Coffee
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        double item1 = 120.00, item2 = 110.00, item3 = 125.00, item4 = 150.00, item5 = 90.00,
               item6 = 135, item7 = 155.00, item8 = 162.00, membershipDisc = 50, addFee = 10,
               total, pnts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }


        private void chk1_CheckedChanged(object sender, EventArgs e)
        {

            if (chk1.Checked)
            {
                nmdUp1.Enabled = true; nmdUp1.Value = 1;
            }
           

        }
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                nmdUp2.Enabled = true; nmdUp2.Value = 1;
            }
           
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked)
            {
                nmdUp3.Enabled = true; nmdUp3.Value = 1;
            }
          
        }
        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked)
            {
                nmdUp4.Enabled = true; nmdUp4.Value = 1;
            }
          
        }

        private void chkMember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;
            chk8.Checked = false;
            chkMember.Checked = false;


            nmdUp1.Enabled = false; nmdUp1.Value = 0;
            nmdUp2.Enabled = false; nmdUp2.Value = 0;
            nmdUp3.Enabled = false; nmdUp3.Value = 0;
            nmdUp4.Enabled = false; nmdUp4.Value = 0;
            nmdUp5.Enabled = false; nmdUp5.Value = 0;
            nmdUp6.Enabled = false; nmdUp6.Value = 0;
            nmdUp7.Enabled = false; nmdUp7.Value = 0;
            nmdUp8.Enabled = false; nmdUp8.Value = 0;

            rdo1.Checked = false;
            rdo2.Checked = false;

            lblTotal.Text = "";
            lblPoints.Text = "";
            total = 0;
            pnts = 0;
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked)
            {
                nmdUp5.Enabled = true; nmdUp5.Value = 1;
            }
           
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked)
            {
                nmdUp6.Enabled = true; nmdUp6.Value = 1;
            }
            
        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7.Checked)
            {
                nmdUp7.Enabled = true; nmdUp7.Value = 1;
            }
            
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8.Checked)
            {
                nmdUp8.Enabled = true; nmdUp8.Value = 1;
                
            }
          
        }



        private void btnComplete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item: ");
            dt.Columns.Add("Quantity:");
            dt.Columns.Add("Price:");
            dt.Columns.Add("Total: ");

            total = (item1 * (double)nmdUp1.Value) + (item2 * (double)nmdUp2.Value) +
                             (item3 * (double)nmdUp3.Value) + (item4 * (double)nmdUp4.Value) + (item5 * (double)nmdUp5.Value) +
                             (item6 * (double)nmdUp6.Value) + (item7 * (double)nmdUp7.Value) + (item8 * (double)nmdUp8.Value);
           


            if (chk1.Checked || chk2.Checked || chk3.Checked || chk4.Checked ||
                chk5.Checked || chk6.Checked || chk7.Checked || chk8.Checked)
            {
                if (rdo1.Checked)
                {
                   
                    lblTotal.Text = total.ToString();
                    pnts = total * 0.03;
                    lblPoints.Text = pnts.ToString();
                }
                else if (rdo2.Checked)
                {
                  
                    total = total + addFee;
                    lblTotal.Text = total.ToString();
                    pnts = total * 0.03;
                    lblPoints.Text = pnts.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a dining method");
                }

            }
            else
            {
                MessageBox.Show("Please select an item in the menu");
            }

            if (chkMember.Checked)
            {
                if (rdo1.Checked)
                {

                    total = total - membershipDisc;
                    lblTotal.Text = total.ToString();
                    pnts = total * 0.03;
                    lblPoints.Text = pnts.ToString();
                }
                else if (rdo2.Checked)
                {

                    total = (total + addFee) - membershipDisc;
                    lblTotal.Text = total.ToString();
                    pnts = total * 0.03;
                    lblPoints.Text = pnts.ToString();

                } 
               
            }
            if (chk1.Checked)
            {
                dt.Rows.Add("Creamy Caramel Latte", nmdUp1.Value , item1   ,(item1 * (double)nmdUp1.Value));
            }
            if (chk2.Checked)
            {
                dt.Rows.Add("Salted Caramel Cold", nmdUp2.Value, item2, (item2 * (double)nmdUp2.Value));
            }
            if (chk3.Checked)
            {
                dt.Rows.Add("Vanilla Sweet Cream Cold Brew", nmdUp3.Value, item3, (item3 * (double)nmdUp3.Value));
            }
            if (chk4.Checked)
            {
                dt.Rows.Add("Burnt Caramel Oatmilk Latte", nmdUp4.Value, item4, (item4 * (double)nmdUp4.Value));
            }
            if (chk5.Checked)
            {
                dt.Rows.Add("Hot Brewed Coffee", nmdUp5.Value, item5, (item5 * (double)nmdUp5.Value));
            }
            if (chk6.Checked)
            {
                dt.Rows.Add("Iced Caramel Macchiato", nmdUp6.Value, item6, (item6 * (double)nmdUp6.Value));
            }
            if (chk7.Checked)
            {
                dt.Rows.Add("Green Tea Creamed Frappucino", nmdUp7.Value, item7, (item7 * (double)nmdUp7.Value));
            }
            if (chk8.Checked)
            {
                dt.Rows.Add("Java Chips Frap", nmdUp8.Value, item8, (item8 * (double)nmdUp8.Value));
            }



            Form2 frm = new Form2(total, pnts ,dt, chkMember.Checked, rdo1.Checked, rdo2.Checked);
            frm.ShowDialog();
        }
    }

}
















       





