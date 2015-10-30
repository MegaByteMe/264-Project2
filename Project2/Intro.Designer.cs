namespace Project2
{
    partial class Intro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.venueBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rmvenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rmeventButton = new System.Windows.Forms.Button();
            this.addeventButton = new System.Windows.Forms.Button();
            this.addvenButton = new System.Windows.Forms.Button();
            this.evendatePicker = new System.Windows.Forms.DateTimePicker();
            this.newnameBox = new System.Windows.Forms.TextBox();
            this.evetovenButton = new System.Windows.Forms.Button();
            this.eventBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apassBox = new System.Windows.Forms.TextBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.custlistButton = new System.Windows.Forms.Button();
            this.numEvents = new System.Windows.Forms.Label();
            this.numVenues = new System.Windows.Forms.Label();
            this.vieweveButton = new System.Windows.Forms.Button();
            this.viewvenButtton = new System.Windows.Forms.Button();
            this.adminlogout = new System.Windows.Forms.Button();
            this.scheduleBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventselLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.venshowButton = new System.Windows.Forms.Button();
            this.showdesBox = new System.Windows.Forms.TextBox();
            this.rmsfromvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // venueBox
            // 
            this.venueBox.FormattingEnabled = true;
            this.venueBox.Location = new System.Drawing.Point(21, 220);
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(184, 95);
            this.venueBox.TabIndex = 0;
            this.venueBox.SelectedIndexChanged += new System.EventHandler(this.venueBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Venues";
            // 
            // rmvenButton
            // 
            this.rmvenButton.Location = new System.Drawing.Point(211, 292);
            this.rmvenButton.Name = "rmvenButton";
            this.rmvenButton.Size = new System.Drawing.Size(121, 23);
            this.rmvenButton.TabIndex = 2;
            this.rmvenButton.Text = "Remove Venue";
            this.rmvenButton.UseVisualStyleBackColor = true;
            this.rmvenButton.Click += new System.EventHandler(this.rmvenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Events";
            // 
            // rmeventButton
            // 
            this.rmeventButton.Location = new System.Drawing.Point(211, 116);
            this.rmeventButton.Name = "rmeventButton";
            this.rmeventButton.Size = new System.Drawing.Size(121, 23);
            this.rmeventButton.TabIndex = 5;
            this.rmeventButton.Text = "Remove Event";
            this.rmeventButton.UseVisualStyleBackColor = true;
            this.rmeventButton.Click += new System.EventHandler(this.rmeventButton_Click);
            // 
            // addeventButton
            // 
            this.addeventButton.Location = new System.Drawing.Point(350, 150);
            this.addeventButton.Name = "addeventButton";
            this.addeventButton.Size = new System.Drawing.Size(121, 23);
            this.addeventButton.TabIndex = 6;
            this.addeventButton.Text = "Create Event";
            this.addeventButton.UseVisualStyleBackColor = true;
            this.addeventButton.Click += new System.EventHandler(this.addeventButton_Click);
            // 
            // addvenButton
            // 
            this.addvenButton.Location = new System.Drawing.Point(211, 263);
            this.addvenButton.Name = "addvenButton";
            this.addvenButton.Size = new System.Drawing.Size(121, 23);
            this.addvenButton.TabIndex = 7;
            this.addvenButton.Text = "Create Venue";
            this.addvenButton.UseVisualStyleBackColor = true;
            this.addvenButton.Click += new System.EventHandler(this.addvenButton_Click);
            // 
            // evendatePicker
            // 
            this.evendatePicker.Location = new System.Drawing.Point(350, 44);
            this.evendatePicker.Name = "evendatePicker";
            this.evendatePicker.Size = new System.Drawing.Size(200, 20);
            this.evendatePicker.TabIndex = 10;
            this.evendatePicker.ValueChanged += new System.EventHandler(this.evendatePicker_ValueChanged);
            // 
            // newnameBox
            // 
            this.newnameBox.Location = new System.Drawing.Point(350, 71);
            this.newnameBox.Name = "newnameBox";
            this.newnameBox.Size = new System.Drawing.Size(200, 20);
            this.newnameBox.TabIndex = 11;
            this.newnameBox.Text = "New Event Name";
            this.newnameBox.TextChanged += new System.EventHandler(this.newnameBox_TextChanged);
            // 
            // evetovenButton
            // 
            this.evetovenButton.Location = new System.Drawing.Point(21, 161);
            this.evetovenButton.Name = "evetovenButton";
            this.evetovenButton.Size = new System.Drawing.Size(121, 23);
            this.evetovenButton.TabIndex = 12;
            this.evetovenButton.Text = "Load Event to Venue";
            this.evetovenButton.UseVisualStyleBackColor = true;
            this.evetovenButton.Click += new System.EventHandler(this.evetovenButton_Click);
            // 
            // eventBox
            // 
            this.eventBox.FormattingEnabled = true;
            this.eventBox.Location = new System.Drawing.Point(21, 44);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(184, 95);
            this.eventBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Admin Access Password";
            // 
            // apassBox
            // 
            this.apassBox.Location = new System.Drawing.Point(211, 448);
            this.apassBox.Name = "apassBox";
            this.apassBox.Size = new System.Drawing.Size(156, 20);
            this.apassBox.TabIndex = 15;
            this.apassBox.UseSystemPasswordChar = true;
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(292, 474);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 14;
            this.adminButton.Text = "Login Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // custlistButton
            // 
            this.custlistButton.Location = new System.Drawing.Point(211, 360);
            this.custlistButton.Name = "custlistButton";
            this.custlistButton.Size = new System.Drawing.Size(121, 23);
            this.custlistButton.TabIndex = 17;
            this.custlistButton.Text = "Customer List";
            this.custlistButton.UseVisualStyleBackColor = true;
            this.custlistButton.Click += new System.EventHandler(this.custlistButton_Click);
            // 
            // numEvents
            // 
            this.numEvents.AutoSize = true;
            this.numEvents.Location = new System.Drawing.Point(104, 25);
            this.numEvents.Name = "numEvents";
            this.numEvents.Size = new System.Drawing.Size(35, 13);
            this.numEvents.TabIndex = 18;
            this.numEvents.Text = "label5";
            // 
            // numVenues
            // 
            this.numVenues.AutoSize = true;
            this.numVenues.Location = new System.Drawing.Point(104, 201);
            this.numVenues.Name = "numVenues";
            this.numVenues.Size = new System.Drawing.Size(35, 13);
            this.numVenues.TabIndex = 19;
            this.numVenues.Text = "label4";
            // 
            // vieweveButton
            // 
            this.vieweveButton.Location = new System.Drawing.Point(211, 45);
            this.vieweveButton.Name = "vieweveButton";
            this.vieweveButton.Size = new System.Drawing.Size(121, 23);
            this.vieweveButton.TabIndex = 21;
            this.vieweveButton.Text = "View Event";
            this.vieweveButton.UseVisualStyleBackColor = true;
            this.vieweveButton.Click += new System.EventHandler(this.vieweveButton_Click);
            // 
            // viewvenButtton
            // 
            this.viewvenButtton.Location = new System.Drawing.Point(211, 220);
            this.viewvenButtton.Name = "viewvenButtton";
            this.viewvenButtton.Size = new System.Drawing.Size(121, 23);
            this.viewvenButtton.TabIndex = 20;
            this.viewvenButtton.Text = "View Venue";
            this.viewvenButtton.UseVisualStyleBackColor = true;
            this.viewvenButtton.Click += new System.EventHandler(this.chkVButtton_Click);
            // 
            // adminlogout
            // 
            this.adminlogout.Location = new System.Drawing.Point(211, 474);
            this.adminlogout.Name = "adminlogout";
            this.adminlogout.Size = new System.Drawing.Size(75, 23);
            this.adminlogout.TabIndex = 22;
            this.adminlogout.Text = "Logout";
            this.adminlogout.UseVisualStyleBackColor = true;
            this.adminlogout.Click += new System.EventHandler(this.adminlogout_Click);
            // 
            // scheduleBox
            // 
            this.scheduleBox.FormattingEnabled = true;
            this.scheduleBox.Location = new System.Drawing.Point(338, 220);
            this.scheduleBox.Name = "scheduleBox";
            this.scheduleBox.Size = new System.Drawing.Size(212, 95);
            this.scheduleBox.TabIndex = 23;
            this.scheduleBox.SelectedIndexChanged += new System.EventHandler(this.scheduleBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Events at Venue selected";
            // 
            // eventselLabel
            // 
            this.eventselLabel.AutoSize = true;
            this.eventselLabel.Location = new System.Drawing.Point(470, 201);
            this.eventselLabel.Name = "eventselLabel";
            this.eventselLabel.Size = new System.Drawing.Size(35, 13);
            this.eventselLabel.TabIndex = 25;
            this.eventselLabel.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 19);
            this.button1.TabIndex = 26;
            this.button1.Text = "pi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(417, 124);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(72, 20);
            this.priceBox.TabIndex = 27;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(347, 127);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(64, 13);
            this.priceLabel.TabIndex = 28;
            this.priceLabel.Text = "Ticket Price";
            // 
            // venshowButton
            // 
            this.venshowButton.Location = new System.Drawing.Point(417, 322);
            this.venshowButton.Name = "venshowButton";
            this.venshowButton.Size = new System.Drawing.Size(132, 23);
            this.venshowButton.TabIndex = 29;
            this.venshowButton.Text = "Select Venue/Show";
            this.venshowButton.UseVisualStyleBackColor = true;
            this.venshowButton.Click += new System.EventHandler(this.venshowButton_Click);
            // 
            // showdesBox
            // 
            this.showdesBox.Location = new System.Drawing.Point(350, 97);
            this.showdesBox.Name = "showdesBox";
            this.showdesBox.Size = new System.Drawing.Size(200, 20);
            this.showdesBox.TabIndex = 30;
            this.showdesBox.Text = "Show Description";
            // 
            // rmsfromvButton
            // 
            this.rmsfromvButton.Location = new System.Drawing.Point(417, 352);
            this.rmsfromvButton.Name = "rmsfromvButton";
            this.rmsfromvButton.Size = new System.Drawing.Size(131, 23);
            this.rmsfromvButton.TabIndex = 31;
            this.rmsfromvButton.Text = "Remove Venue Show";
            this.rmsfromvButton.UseVisualStyleBackColor = true;
            this.rmsfromvButton.Click += new System.EventHandler(this.rmsfromvButton_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 559);
            this.Controls.Add(this.rmsfromvButton);
            this.Controls.Add(this.showdesBox);
            this.Controls.Add(this.venshowButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eventselLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scheduleBox);
            this.Controls.Add(this.adminlogout);
            this.Controls.Add(this.vieweveButton);
            this.Controls.Add(this.viewvenButtton);
            this.Controls.Add(this.numVenues);
            this.Controls.Add(this.numEvents);
            this.Controls.Add(this.custlistButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apassBox);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.evetovenButton);
            this.Controls.Add(this.newnameBox);
            this.Controls.Add(this.evendatePicker);
            this.Controls.Add(this.addvenButton);
            this.Controls.Add(this.addeventButton);
            this.Controls.Add(this.rmeventButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rmvenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venueBox);
            this.Name = "Intro";
            this.Text = "Ticket MONSTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox venueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rmvenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rmeventButton;
        private System.Windows.Forms.Button addeventButton;
        private System.Windows.Forms.Button addvenButton;
        private System.Windows.Forms.DateTimePicker evendatePicker;
        private System.Windows.Forms.TextBox newnameBox;
        private System.Windows.Forms.Button evetovenButton;
        private System.Windows.Forms.ListBox eventBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apassBox;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button custlistButton;
        private System.Windows.Forms.Label numEvents;
        private System.Windows.Forms.Label numVenues;
        private System.Windows.Forms.Button vieweveButton;
        private System.Windows.Forms.Button viewvenButtton;
        private System.Windows.Forms.Button adminlogout;
        private System.Windows.Forms.ListBox scheduleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eventselLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button venshowButton;
        private System.Windows.Forms.TextBox showdesBox;
        private System.Windows.Forms.Button rmsfromvButton;
    }
}

