/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 1
 * Change: 1
 * Status: Complete
 * Notes:
 *          
 * Methods:
 *          
 * Dependencies:
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Payment : Form
    {
        private String cardIssuer;

        public Payment()
        {
            InitializeComponent();
        }

        public void LoadC( String CFName, String CLName, String CSTaddress, String CCaddress, String CSaddress, 
                        String CZaddress, String Ctele)
        {
            this.fnameLabel.Text = CFName;
            this.lnameLabel.Text = CLName;
            this.saddressLabel.Text = CSTaddress;
            this.caddressLabel.Text = CCaddress;
            this.stateaddressLabel.Text = CSaddress;
            this.zaddressLabel.Text = CZaddress;
            this.cphone.Text = Ctele;
        }

        public void LoadC(Customer C)
        {
            this.fnameLabel.Text = C.FName;
            this.lnameLabel.Text = C.LName;
            this.saddressLabel.Text = C.Street;
            this.caddressLabel.Text = C.City;
            this.stateaddressLabel.Text = C.State;
            this.zaddressLabel.Text = C.Zip;
            this.cphone.Text = C.Phone;

            this.ccBox1.Text = C.CardNum;
            this.ccExpMonBox.Text = C.ExpMon;
            this.CCexpYearBox.Text = C.ExpYear;
            this.textBox1.Text = C.CVV;

            if (C.CardType == "MasterCard")
                ctButton.Checked = true;
            else if (C.CardType == "Visa")
                ctButton2.Checked = true;
            else if (C.CardType == "Discover")
                ctButton3.Checked = true;
            else if (C.CardType == "AMEX")
                ctButton4.Checked = true;
        }

        private void ccExpMonBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer C = new Customer(fnameLabel.Text, lnameLabel.Text, saddressLabel.Text, caddressLabel.Text,
                            stateaddressLabel.Text, zaddressLabel.Text, cphone.Text, ccBox1.Text, textBox1.Text, 
                            ccExpMonBox.Text, CCexpYearBox.Text, cardIssuer);

            CustDBase.Instance.Add(C);
            this.Close();
        }

        private void ccBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctButton_CheckedChanged(object sender, EventArgs e)
        {
            chkRadio();
        }

        private void ctButton2_CheckedChanged(object sender, EventArgs e)
        {
            chkRadio();
        }

        private void ctButton3_CheckedChanged(object sender, EventArgs e)
        {
            chkRadio();
        }

        private void ctButton4_CheckedChanged(object sender, EventArgs e)
        {
            chkRadio();
        }

        private void chkRadio() 
        {
            if (ctButton.Checked == true)
                cardIssuer = "MasterCard";
            else if (ctButton2.Checked == true)
                cardIssuer = "Visa";
            else if (ctButton3.Checked == true)
                cardIssuer = "Discover";
            else if (ctButton4.Checked == true)
                cardIssuer = "AMEX";
        }
    }
}
