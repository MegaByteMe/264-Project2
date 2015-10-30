/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 1
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

namespace Project2
{
    public partial class SelectCustomer : Form
    {
        private Customer reval;

        public Customer reVal
        {
            get { return reval; }
        }

        public SelectCustomer()
        {
            InitializeComponent();

            updateClist();

            numCust.Text = CustDBase.Instance.KnownCust.Count.ToString();

            if (CustDBase.Instance.KnownCust.Count() <= 0 ) {
                button1.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)          //Edit Customer Info
        {
            NewCustomer newC = new NewCustomer();
            newC.loadC((Customer)custlistBox.SelectedItem);
            newC.Show();
        }

        private void button3_Click(object sender, EventArgs e)          //New Customer
        {
            NewCustomer newC = new NewCustomer();
            newC.Show();
        }

        private void custlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateClist();
            custlistBox.Invalidate();
            custlistBox.Update();
        }

        private void button4_Click(object sender, EventArgs e)          //Delete Customer
        {
            if(MessageBox.Show("Delete Customer " + 
                        CustDBase.Instance.KnownCust.ElementAt(custlistBox.SelectedIndex).CombName + "?",
                        "Confirm User Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    
                CustDBase.Instance.KnownCust.RemoveAt(custlistBox.SelectedIndex);
                CustDBase.Instance.Save();
                }

            updateClist();
        }

        private void button5_Click(object sender, EventArgs e)          //Edit Payment Info
        {
            if (CustDBase.Instance.KnownCust.Count() > 0)
            {
                Payment pay = new Payment();
                pay.LoadC((Customer)custlistBox.SelectedItem);
                pay.Show();
            }
            else
                MessageBox.Show("There are no customers on file!");
        }

        private void button2_Click(object sender, EventArgs e)          //Select Customer
        {
            reval = (Customer)custlistBox.SelectedItem;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   //Search List
        {
            if (CustDBase.Instance.KnownCust.Any(item => item.FName.ToUpper() == textBox1.Text.ToUpper()))
                custlistBox.DataSource = CustDBase.Instance.KnownCust.FindAll(
                                        item => item.FName.ToUpper() == textBox1.Text.ToUpper());
            else
                custlistBox.DataSource = CustDBase.Instance.KnownCust;

            custlistBox.Invalidate();
        }

        public void updateClist()
        {
            custlistBox.DataSource = null;
            custlistBox.DataSource = CustDBase.Instance.KnownCust;
            custlistBox.DisplayMember = "CombName";
            custlistBox.ValueMember = "CombName";
        }

    }
}
