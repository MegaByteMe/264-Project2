/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 0
 * Change: 2
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
using System.Xml;

namespace Project2
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        public void loadC(Customer C)
        {
            fnameBox.Text = C.FName;
            lnameBox.Text = C.LName;
            saddressBox.Text = C.Street;
            caddressBox.Text = C.City;
            staddressBox.Text = C.State;
            zaddressBox.Text = C.Zip;
            textBox2.Text = C.Phone;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            Customer C = new Customer(fnameBox.Text, lnameBox.Text, saddressBox.Text, caddressBox.Text,
                                        staddressBox.Text, zaddressBox.Text, textBox2.Text);
            CustDBase.Instance.Add(C);
            
            this.Close();
        }

        private void addpayButton_Click(object sender, EventArgs e)
        {
            Payment nPay = new Payment();
            nPay.LoadC(fnameBox.Text, lnameBox.Text, saddressBox.Text, caddressBox.Text, staddressBox.Text, 
                            zaddressBox.Text, textBox2.Text);
            nPay.Show();
        }
    }
}