/* Name: Mark Rosa - Independent Group
 * Course: ECE264
 * Date: 22-Apr-2015
 * Assignment: Project 2
 * Revision: 5
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
    public partial class CreateVenue : Form
    {
        public VenObj newV = new VenObj();
        public bool focus = true;

        public CreateVenue()
        {
            InitializeComponent();

            this.AllowDrop = true;

            this.DragDrop += this_DragDrop;
            this.DragEnter += this_DragEnter;

            dragButton.MouseDown += dragButton_MouseDown;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatButton_Click(object sender, EventArgs e)
        {

        }

        private void buildPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        void dragButton_MouseDown(object sender, MouseEventArgs e)
        {
            dragButton.DoDragDrop(dragButton, DragDropEffects.Move);
        }

        void this_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void this_DragDrop(object sender, DragEventArgs e)
        {
            if (seatButton.Checked == true)                      //Laying Seat Buttons
            {
                Button newb = new Button();
                newb.Tag = "DESIGN";
                newb.Size = new Size(40, 20);
                newb.Text = (rowBox.Text + seatBox.Text);
                Point newP = this.PointToClient(new Point(e.X, e.Y));
                newb.Location = newP;
                this.Controls.Add(newb);
                this.Update();

                instaSeat i = new instaSeat();
                i.DSP = newb.Text;
                i.P = newb.Location;
                i.S = newb.Size;

                newV.SeatLayout.Add(i);
            }
            else if (stageButton.Checked == true)                //Laying Stage
            {
                Button newb = new Button();
                newb.Tag = "DESIGN";
                newb.Size = new Size(100, 50);
                newb.Text = "Stage";
                Point newP = this.PointToClient(new Point(e.X, e.Y));
                newb.Location = newP;
                this.Controls.Add(newb);
                this.Update();

                instaSeat i = new instaSeat();
                i.DSP = newb.Text;
                i.P = newb.Location;
                i.S = newb.Size;

                newV.SeatLayout.Add(i);
            }
            else
                MessageBox.Show("Please select which button to use!");

        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(Button) && C.Tag == "DESIGN")
                {
                    this.Controls.Remove(C);
                    this.Update();
                    this.Invalidate();
                }

            }
            newV.SeatLayout.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void seatButton_CheckedChanged(object sender, EventArgs e)
        {
            if (seatButton.Checked == true)
                focus = true;
            else if (stageButton.Checked == true)
                focus = false;
        }

        private void stageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (seatButton.Checked == true)
                focus = true;
            else if (stageButton.Checked == true)
                focus = false;
        }

        private void savevenButton_Click(object sender, EventArgs e)
        {
            newV.venname = textBox1.Text;
            VenDBase.Instance.Add(newV);
            this.Close();
        }

    }
}
