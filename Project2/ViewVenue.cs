/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 0
 * Change: 3
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
    public partial class ViewVenue : Form
    {
        private VenObj creator;
        private Show subcreate;

        public Show SubCreatr
        {
            get { return subcreate; }
        }

        public VenObj Creator
        {
            get { return creator; }
        }

        public ViewVenue()
        {
            InitializeComponent();
        }

        public void Prep(VenObj V)
        {
            creator = V;
            this.buyButton.Enabled = false;
            this.Controls.Remove(buyButton);
            vennameLabel.Text = V.VenueName;

            ressampButton.ForeColor = Color.Red;
            ressampButton.BackColor = Color.DarkRed;
            opensampButton.ForeColor = Color.Green;
            stagesampButton.BackColor = Color.Yellow;

            foreach (instaSeat b in V.SeatLayout)
            {
                if (b.DSP != "Stage")
                {
                    Button a = new Button();
                    a.Size = b.S;
                    a.Location = b.P;
                    a.Text = b.DSP;
                    a.Show();
                    this.Controls.Add(a);
                    a.Click += instaButton_Click;
                }
                else
                {
                    Button s = new Button();
                    s.Size = b.S;
                    s.Location = b.P;
                    s.Text = "Stage";
                    s.Enabled = false;
                    s.BackColor = Color.Yellow;
                    this.Controls.Add(s);
                    s.Show();
                }
            }
        }

        public void Prep(VenObj V, Show S)
        {
            creator = V;
            subcreate = S;

            showLabel.Text = S.name;
            vennameLabel.Text = V.VenueName;

            ressampButton.ForeColor = Color.Red;
            ressampButton.BackColor = Color.DarkRed;
            opensampButton.ForeColor = Color.Green;
            stagesampButton.BackColor = Color.Yellow;

            foreach (instaSeat b in V.AShows.Find(item => item.Id == S.Id).Seats)
            {
                if (b.DSP != "Stage")
                {
                    Button a = new Button();
                    a.Size = b.S;
                    a.Location = b.P;
                    a.Text = b.DSP;
                    a.Show();
                    this.Controls.Add(a);
                    a.Click += instaButton_Click;
                    if (b.C == Color.Blue || b.C == Color.Red)
                        a.BackColor = b.C;
                }
                else
                {
                    Button s = new Button();
                    s.Size = b.S;
                    s.Location = b.P;
                    s.Text = "Stage";
                    s.Enabled = false;
                    s.BackColor = Color.Yellow;
                    this.Controls.Add(s);
                    s.Show();
                }
            }
        }

        private void ViewVenue_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void instaButton_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                if (((Button)sender).BackColor == DefaultBackColor)
                {
                    MessageBox.Show(((Button)sender).Text + " Has been selected.");
                    ((Button)sender).BackColor = Color.Blue;
                    int i = subcreate.Seats.FindIndex(item => item.DSP == ((Button)sender).Text);
                    subcreate.Seats.ElementAt(i).C = Color.Blue;
                    int j = creator.AShows.FindIndex(item => item.Id == subcreate.Id);
                    creator.AShows.RemoveAt(j);
                    creator.AShows.Insert(j, subcreate);
                    VenDBase.Instance.Add(Creator);
                }
                else if (((Button)sender).BackColor == Color.Red)
                {
                    MessageBox.Show("This seat has been reserved by " + subcreate.Seats.Find(item => item.DSP == ((Button)sender).Text).rCust.CombName);
                }
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            SelectCustomer sel = new SelectCustomer();
            sel.ShowDialog();
            Customer C = sel.reVal;
            sel.Close();
            sel.Dispose();
            
            //Dangerous
            subcreate.Seats.Clear();
            //

            foreach(Control b in this.Controls) 
            {
                if (b.GetType() == typeof(Button))
                {
                    instaSeat i = new instaSeat();
                    i.DSP = b.Text;
                    i.C = b.BackColor;
                    i.P = b.Location;
                    i.S = b.Size;

                    if (b.BackColor == Color.Red)
                        i.Reserve = true;

                    creator.AShows.Find(item => item.Equals(subcreate)).Seats.Add(i);
                }
            }
            

            Checkout ck = new Checkout();
            ck.Load(C, creator, subcreate);
            ck.Show();
        }

        private void cancpurButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
