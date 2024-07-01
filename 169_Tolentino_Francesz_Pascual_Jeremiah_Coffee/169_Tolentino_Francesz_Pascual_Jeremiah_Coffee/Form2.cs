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
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        double total, pnts;
        bool chk, fh, tg;
        

        private void btnPur_Click(object sender, EventArgs e)
        {
            double payment, change = 0;
            payment = double.Parse(txtPayment.Text);
            if (payment < total)
            {
                MessageBox.Show("Insufficient amount of money");
            }
            else 
            {
                change = payment - total;
                MessageBox.Show("Your Total amount is: " +total +"\nYour Change is: " + change );

                
            }
        }

        public Form2(double _total, double _pnts, DataTable _dt, bool _chk, bool _fh, bool _tg )
        {
            InitializeComponent();
            total = _total;
            pnts = _pnts;
            dt = _dt;
            chk = _chk;
            fh = _fh;
            tg = _tg;
            dgvDisplay.DataSource = dt;            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            if(chk == true)
            {
                lblMember.Text = "Yes";
            }
            else
            {
                lblMember.Text = "No";
            }


            if(fh == true )
            {
                lblDining.Text = "For Here";
            }
            else if(tg == true)
            {
                lblDining.Text = "To go";
            }
      
            lblTotal.Text = total.ToString();
            lblPoints.Text = pnts.ToString();
          
            
        }
    }
}
