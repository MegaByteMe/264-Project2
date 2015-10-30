/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 6
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
    public partial class Intro : Form
    {
        private double price = -1;

        public Intro()
        {
            InitializeComponent();

            //Prepare Singleton Classes - Load init files
            CustDBase.Instance.Load();
            ShowDBase.Instance.Load();
            VenDBase.Instance.Load();

            //--------------------------------------->
            //DEBUGING CODE - CAREFUL DEMO LOAD
            //VenDBase.Instance.demoload();
            //VenDBase.Instance.demoload1();
            //DEBUGING CODE - DEMO LOAD
            //--------------------------------------->

            //Prepare Enviroment
            enterUserMode();
            updateElist();
            updateVlist();
            
            evendatePicker.Format = DateTimePickerFormat.Custom;
            evendatePicker.CustomFormat = "MM/dd/yyyy   hh:mm";

            proEmptyEveBox();
            proEmptyVenBox();
        }

        private void addeventButton_Click(object sender, EventArgs e)           //Create New Event
        {
            if (price > 0.000)
                ShowDBase.Instance.Add(new Show(newnameBox.Text, showdesBox.Text, evendatePicker.Value, price));
            else
                MessageBox.Show("Please enter a valid price for the event!");

            updateElist();
            proJointly();
        }

        private void evendatePicker_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void newnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rmeventButton_Click(object sender, EventArgs e)            //Remove Event
        {
            if (MessageBox.Show("Delete Event " + ShowDBase.Instance.KnownShows.ElementAt(eventBox.SelectedIndex).ShowName + "?",
                                "Confirm Event Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ShowDBase.Instance.KnownShows.RemoveAt(eventBox.SelectedIndex);
                ShowDBase.Instance.Save(); 
            }
            
            updateElist();
            proEmptyEveBox();
            proJointly();
        }

        private void rmvenButton_Click(object sender, EventArgs e)              //Remove Venue
        {
            if (MessageBox.Show("Delete Event " + VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex).VenueName + "?",
                                "Confirm Venue Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                VenDBase.Instance.KnownVen.RemoveAt(venueBox.SelectedIndex);
                VenDBase.Instance.Save();
            }

            updateVlist();
            proEmptyVenBox();
            proJointly();
        }

        private void addvenButton_Click(object sender, EventArgs e)             //Add Venue
        {
            CreateVenue newV = new CreateVenue();
            newV.Show();

            updateVlist();
            proEmptyVenBox();
            proJointly();
        }

        private void eventsBox_SelectedIndexChanged(object sender, EventArgs e) //Events Box List Index Changed
        {
            updateElist();
            proEmptyEveBox();
            proJointly();
        }

        private void evetovenButton_Click(object sender, EventArgs e)           //Load Event to venue
        {
            VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex).AddShow(
                                                    ShowDBase.Instance.KnownShows.ElementAt(eventBox.SelectedIndex));
            VenDBase.Instance.Save();
            updateSlist();
        }

        private void adminButton_Click(object sender, EventArgs e)              //Admin Access
        {
            if ((apassBox.Text).ToUpper() == "PASSWORD")                //Grant Admin Access - Add Controls
            {
                enterAdminMode();
            }
        }

        private void vieweveButton_Click(object sender, EventArgs e)            //View Event
        {
            MessageBox.Show("Show: " + ((Show)eventBox.SelectedItem).name + "\n"
                              + "Date and Time: " + ((Show)eventBox.SelectedItem).Date + "\n"
                              + "Description: " + ((Show)eventBox.SelectedItem).description);
        }

        private void chkVButtton_Click(object sender, EventArgs e)              //View Venue
        {
            ViewVenue peekVen = new ViewVenue();
            //peekVen.Prep((VenObj)venueBox.SelectedItem);
            peekVen.Prep(VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex));
            peekVen.Show();
        }

        private void custlistButton_Click(object sender, EventArgs e)           //Customer List
        {
            SelectCustomer selCust = new SelectCustomer();
            selCust.Show();
        }

        private void adminlogout_Click(object sender, EventArgs e)              //Enter User Mode
        {
            enterUserMode();
        }

        private void venueBox_SelectedIndexChanged(object sender, EventArgs e)  //Venue Box Index Change
        {
            updateVlist();
            proEmptyVenBox();
            proJointly();

            updateSlist();
        }

        private void scheduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enterUserMode()                                            //Remove Admin Controls
        {
            this.Text = "Ticket MONSTER";
            this.BackColor = Form.DefaultBackColor;
            this.Controls.Remove(evendatePicker);
            this.Controls.Remove(newnameBox);
            this.Controls.Remove(addeventButton);
            this.Controls.Remove(evetovenButton);
            this.Controls.Remove(rmeventButton);
            this.Controls.Remove(adminlogout);
            this.Controls.Remove(addvenButton);
            this.Controls.Remove(rmvenButton);
            this.Controls.Add(adminButton);
            this.Controls.Remove(priceLabel);
            this.Controls.Remove(priceBox);
            this.Controls.Remove(showdesBox);
            this.Controls.Remove(rmsfromvButton);

            updateElist();
            updateVlist();
            proEmptyVenBox();
            proEmptyEveBox();
            proJointly();
        }

        private void enterAdminMode()                                           //Implement Admin Controls
        {
            this.Text = "Ticket MONSTER // ADMINISTRATOR ACCESS";
            this.BackColor = Color.Red;
            this.Controls.Add(evendatePicker);
            this.Controls.Add(newnameBox);
            this.Controls.Add(addeventButton);
            this.Controls.Add(evetovenButton);
            this.Controls.Add(rmeventButton);
            this.Controls.Add(adminlogout);
            this.Controls.Remove(adminButton);
            this.Controls.Add(addvenButton);
            this.Controls.Add(rmvenButton);
            this.Controls.Add(priceLabel);
            this.Controls.Add(priceBox);
            this.Controls.Add(showdesBox);
            this.Controls.Add(rmsfromvButton);

            updateVlist();
            updateElist();
            proEmptyEveBox();
            proEmptyVenBox();
            proJointly();
        }

        public void updateElist()
        {
            eventBox.DataSource = null;
            eventBox.DataSource = ShowDBase.Instance.KnownShows;
            eventBox.DisplayMember = "NameDate";
            eventBox.ValueMember = "ShowDate";
            numEvents.Text = ShowDBase.Instance.Count.ToString();
        }

        public void updateVlist()
        {
            venueBox.DataSource = null;
            venueBox.DataSource = VenDBase.Instance.KnownVen;
            venueBox.DisplayMember = "VenueName";
            venueBox.ValueMember = "VenueName";
            numVenues.Text = VenDBase.Instance.Count.ToString();
        }

        public void updateSlist()
        {
            scheduleBox.DataSource = null;
            if (VenDBase.Instance.Count > 0 && venueBox.SelectedIndex >= 0 && ShowDBase.Instance.Count > 0)
            {
                eventselLabel.Text = VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex).AShows.Count.ToString();
                scheduleBox.DataSource = VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex).AShows;
                scheduleBox.DisplayMember = "NameDate";
                scheduleBox.ValueMember = "ShowDate";
            }
        }

        //The following functions protect the integrity of selection based buttons
        public void proEmptyVenBox()
        {
            if (VenDBase.Instance.Count > 0)       //No venues so disable specific buttons
            {
                rmvenButton.Enabled = true;
                viewvenButtton.Enabled = true;
                scheduleBox.Enabled = true;
            }
            else
            {
                rmvenButton.Enabled = false;
                viewvenButtton.Enabled = false;
                scheduleBox.Enabled = false;
            }
            proJointly();
        }

        public void proEmptyEveBox()
        {
            if (ShowDBase.Instance.Count > 0)     //No shows so disable specific buttons
            {
                rmeventButton.Enabled = true;
                vieweveButton.Enabled = true;
            }
            else
            {
                rmeventButton.Enabled = false;
                vieweveButton.Enabled = false;
            }
            proJointly();
        }

        public void proJointly()
        {
            if (VenDBase.Instance.Count <= 0 || ShowDBase.Instance.Count <= 0)
                evetovenButton.Enabled = false;
            else
                evetovenButton.Enabled = true;
        }

        //THIS IS FOR TESTING ONLY - REMOVE FOR RELEASE - BYPASS ADMIN PASSWORD
        private void button1_Click(object sender, EventArgs e)
        {
            enterAdminMode();
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            price = -1;
            double.TryParse(priceBox.Text, out price);

            if (price <= 0.0001)
            {
                priceBox.BackColor = Color.Violet;
                MessageBox.Show("Please enter a valid ticket price!");
            }
            else
                priceBox.BackColor = TextBox.DefaultBackColor;
        }

        private void venshowButton_Click(object sender, EventArgs e)                //Select Venue
        {
            ViewVenue peekVen = new ViewVenue();
            peekVen.Prep(VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex),
                        VenDBase.Instance.KnownVen.ElementAt(venueBox.SelectedIndex).AShows.ElementAt(scheduleBox.SelectedIndex));
            peekVen.Show();
        }

        private void rmsfromvButton_Click(object sender, EventArgs e)               //Remove show event from venue
        {
            ((VenObj)venueBox.SelectedItem).AShows.RemoveAt(((Show)scheduleBox.SelectedItem).Id);
            updateSlist();
        }

    }
}