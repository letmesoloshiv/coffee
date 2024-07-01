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
    public partial class Form2 : Form
    {
        bool isMemberChecked, isForHereChecked;
        double total, points;
        DataTable dt = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            display();
            dgItems.DataSource = dt;
        }

        public Form2(bool isMemberChecked, bool isForHereChecked, double total, double points, DataTable dt)
        {
            InitializeComponent();
            this.isMemberChecked = isMemberChecked;
            this.isForHereChecked = isForHereChecked;
            this.total = total;
            this.points = points;
            this.dt = dt;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

          
            double payment = double.Parse(txtPayment.Text);

            double change = payment - total;

            if (payment >= total)
            {
                change = payment - total;
                MessageBox.Show(" Payment: " + payment.ToString() + "\n Total: " + total.ToString() + "\n Change: " + change.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("Insufficient funds");
            }

  
        }

        public void display() {
            if (isMemberChecked) {
                lblMember.Text += " Yes";
            } else {
                lblMember.Text += " No";
            }

            if (isForHereChecked) {
                lblDining.Text += " For Here";
            } else {
                lblDining.Text += " To Go";
            }

            lblTotal.Text += total.ToString();
            lblPoints.Text += points.ToString();
        }
    }
}
