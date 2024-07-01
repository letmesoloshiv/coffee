using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double Item1 = 120.00;
        double Item2 = 110.00;
        double Item3 = 125.00;
        double Item4 = 150.00;
        double Item5 = 90.00;
        double Item6 = 135.00;
        double Item7 = 155.00;
        double Item8 = 162.00;
        double PointsEarned;
        double Total = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void chkItem1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkItem1.Checked) {
                nudItem1.Value = 1;
                nudItem1.Enabled = true;
            } else {
                nudItem1.Value = 0;
                nudItem1.Enabled = false;
            }
            
        }

        private void chkItem2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem2.Checked) {
                nudItem2.Value = 1;
                nudItem2.Enabled = true;
            } else {
                nudItem2.Value = 0;
                nudItem2.Enabled = false;
            }
        }

        private void chkItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem3.Checked) {
                nudItem3.Value = 1;
                nudItem3.Enabled = true;
            } else {
                nudItem3.Value = 0;
                nudItem3.Enabled = false;
            }
        }

        private void chkItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem4.Checked) {
                nudItem4.Value = 1;
                nudItem4.Enabled = true;
            } else {
                nudItem4.Value = 0;
                nudItem4.Enabled = false;
            }
        }

        private void chkItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem5.Checked) {
                nudItem5.Value = 1;
                nudItem5.Enabled = true;
            } else {
                nudItem5.Value = 0;
                nudItem5.Enabled = false;
            }
        }

        private void chkItem6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem6.Checked) {
                nudItem6.Value = 1;
                nudItem6.Enabled = true;
            } else {
                nudItem6.Value = 0;
                nudItem6.Enabled = false;
            }
        }

        private void chkItem7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem7.Checked) {
                nudItem7.Value = 1;
                nudItem7.Enabled = true;
            } else {
                nudItem7.Value = 0;
                nudItem7.Enabled = false;
            }
        }

        private void chkItem8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem1.Checked) {
                nudItem8.Value = 1;
                nudItem8.Enabled = true;
            } else {
                nudItem8.Value = 0;
                nudItem8.Enabled = false;
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            double tempTotal = 0;

            if(!chkItem1.Checked && !chkItem2.Checked && !chkItem3.Checked && !chkItem4.Checked && !chkItem5.Checked && !chkItem6.Checked && !chkItem7.Checked && !chkItem8.Checked) {
                MessageBox.Show("Please select an item from the menu.");
                
            } else if(!rdForHere.Checked && !rdToGo.Checked) {
                MessageBox.Show("Please select dining method."); 
      
            } else {

                // This is passed to form2
                DataTable dt = new DataTable();
                dt.Columns.Add("Item name");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Total");

                tempTotal = computeOrder(tempTotal, dt);

                if (rdToGo.Checked)
                {
                    tempTotal += 10;
                }

                if (chkMember.Checked)
                {
                    tempTotal -= 50;
                    PointsEarned = tempTotal * 0.03;
                  
                }
                

                // Display
                if (tempTotal != Total)
                {
                    Total = tempTotal;
                  

                    Form2 form2 = new Form2(chkMember.Checked, rdForHere.Checked, Total, PointsEarned, dt);
                    form2.ShowDialog();
                }
            }
            



        }

        public double computeOrder(double tempTotal, DataTable dt)
        {
            if (chkItem1.Checked) {
                double total = Item1 * double.Parse(nudItem1.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Creamy Caramel Latte", nudItem1.Value, total);
            }
            if (chkItem2.Checked) {
                double total = Item2 * double.Parse(nudItem2.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Salted Caramel Cold Brew", nudItem2.Value, total);
            }
            if (chkItem3.Checked) {
                double total = Item3 * double.Parse(nudItem3.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Vanilla Sweet Cream Cold Brew", nudItem3.Value, total);
            }
            if (chkItem4.Checked) {
                double total = Item4 * double.Parse(nudItem4.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Burnt Caramel Oatmilk Latte", nudItem4.Value, total);
            }
            if (chkItem5.Checked) {
                double total = Item5 * double.Parse(nudItem5.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Hot Brewed Coffee", nudItem5.Value, total);
            }
            if (chkItem6.Checked) {
                double total = Item6 * double.Parse(nudItem6.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Iced Caramel Machiatto", nudItem6.Value, total);
            }
            if (chkItem7.Checked) {
                double total = Item7 * double.Parse(nudItem7.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Green Tea Cream Frappuccino", nudItem7.Value, total);
            }
            if (chkItem8.Checked) {
                double total = Item8 * double.Parse(nudItem8.Value.ToString());
                tempTotal += total;
                dt.Rows.Add("Java Chip Frappuccino", nudItem8.Value, total);
            }
            return tempTotal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }






















        private void clear()
        {
           
          
            chkMember.Checked = false;
            rdForHere.Checked = false;
            rdToGo.Checked = false;
            chkItem1.Checked = false;
            chkItem2.Checked = false;
            chkItem3.Checked = false;
            chkItem4.Checked = false;
            chkItem5.Checked = false;
            chkItem6.Checked = false;
            chkItem7.Checked = false;
            chkItem8.Checked = false;
            nudItem1.Enabled = false;
            nudItem2.Enabled = false;
            nudItem3.Enabled = false;
            nudItem4.Enabled = false;
            nudItem5.Enabled = false;
            nudItem6.Enabled = false;
            nudItem7.Enabled = false;
            nudItem8.Enabled = false;
            nudItem1.Value = 0;
            nudItem2.Value = 0;
            nudItem3.Value = 0;
            nudItem4.Value = 0;
            nudItem5.Value = 0;
            nudItem6.Value = 0;
            nudItem7.Value = 0;
            nudItem8.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
