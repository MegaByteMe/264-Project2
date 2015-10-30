/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 2
 * Change: 0
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
    public partial class Checkout : Form
    {
        public VenObj A = new VenObj();
        public Show B = new Show();
        public Customer D = new Customer();

        public Checkout()
        {
            InitializeComponent();
        }

        public void Load(Customer C, VenObj V, Show S) 
        {
            A = V;
            B = S;
            D = C;

            int op = 0;
            venseatLabel.Text = "";
            foreach (instaSeat i in S.Seats)
            {
                if (i.C == Color.Blue)
                {
                    op++;
                    venseatLabel.Text += i.DSP + "\n";
                }
            }

            totalpriceLabel.Text = (S.TikPrice * op).ToString();
            tikpriceLabel.Text = S.TikPrice.ToString();
            vennameLabel.Text = V.VenueName;

            custLabel.Text = C.CombName + " " + C.Phone;
            caddLabel.Text = C.Street + "\n" + C.City + " " + C.State + " " + C.Zip;

            showLabel.Text = S.name;
            dateLabel.Text = S.ShowDate;

            billingLabel.Text = C.CardNum + " " + C.CardType + " " + C.ExpMon + " " + C.ExpYear + " " + C.CVV;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Need to save venue object
            for (int i = 0; i < A.AShows.Find(item => item.Id == B.Id).Seats.Count - 1; i++)
            {
                if (A.AShows.Find(item => item.Id == B.Id).Seats.ElementAt(i).C == Color.Blue)
                {
                    A.AShows.Find(item => item.Id == B.Id).Seats.ElementAt(i).C = Color.Red;
                    A.AShows.Find(item => item.Id == B.Id).Seats.ElementAt(i).Reserve = true;
                    A.AShows.Find(item => item.Id == B.Id).Seats.ElementAt(i).rCust = D;
                }
            }

            VenDBase.Instance.Add(A);
            this.Close();
        }
    }
}
