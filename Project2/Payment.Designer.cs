namespace Project2
{
    partial class Payment
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
            this.ccBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccExpMonBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CCexpYearBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.saddressLabel = new System.Windows.Forms.Label();
            this.caddressLabel = new System.Windows.Forms.Label();
            this.stateaddressLabel = new System.Windows.Forms.Label();
            this.zaddressLabel = new System.Windows.Forms.Label();
            this.cIssueBox = new System.Windows.Forms.GroupBox();
            this.ctButton4 = new System.Windows.Forms.RadioButton();
            this.ctButton3 = new System.Windows.Forms.RadioButton();
            this.ctButton2 = new System.Windows.Forms.RadioButton();
            this.ctButton = new System.Windows.Forms.RadioButton();
            this.cardLogoBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cphone = new System.Windows.Forms.Label();
            this.cIssueBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ccBox1
            // 
            this.ccBox1.Location = new System.Drawing.Point(12, 188);
            this.ccBox1.Name = "ccBox1";
            this.ccBox1.Size = new System.Drawing.Size(212, 20);
            this.ccBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Month";
            // 
            // ccExpMonBox
            // 
            this.ccExpMonBox.FormattingEnabled = true;
            this.ccExpMonBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ccExpMonBox.Location = new System.Drawing.Point(12, 263);
            this.ccExpMonBox.Name = "ccExpMonBox";
            this.ccExpMonBox.Size = new System.Drawing.Size(52, 21);
            this.ccExpMonBox.TabIndex = 8;
            this.ccExpMonBox.SelectedIndexChanged += new System.EventHandler(this.ccExpMonBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year";
            // 
            // CCexpYearBox
            // 
            this.CCexpYearBox.FormattingEnabled = true;
            this.CCexpYearBox.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.CCexpYearBox.Location = new System.Drawing.Point(70, 263);
            this.CCexpYearBox.Name = "CCexpYearBox";
            this.CCexpYearBox.Size = new System.Drawing.Size(68, 21);
            this.CCexpYearBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CVV Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loaded Customer Information";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(12, 44);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(57, 13);
            this.fnameLabel.TabIndex = 14;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(141, 44);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(58, 13);
            this.lnameLabel.TabIndex = 15;
            this.lnameLabel.Text = "Last Name";
            // 
            // saddressLabel
            // 
            this.saddressLabel.AutoSize = true;
            this.saddressLabel.Location = new System.Drawing.Point(12, 74);
            this.saddressLabel.Name = "saddressLabel";
            this.saddressLabel.Size = new System.Drawing.Size(123, 13);
            this.saddressLabel.TabIndex = 16;
            this.saddressLabel.Text = "Customer Street Address";
            // 
            // caddressLabel
            // 
            this.caddressLabel.AutoSize = true;
            this.caddressLabel.Location = new System.Drawing.Point(12, 106);
            this.caddressLabel.Name = "caddressLabel";
            this.caddressLabel.Size = new System.Drawing.Size(71, 13);
            this.caddressLabel.TabIndex = 17;
            this.caddressLabel.Text = "Customer City";
            // 
            // stateaddressLabel
            // 
            this.stateaddressLabel.AutoSize = true;
            this.stateaddressLabel.Location = new System.Drawing.Point(124, 106);
            this.stateaddressLabel.Name = "stateaddressLabel";
            this.stateaddressLabel.Size = new System.Drawing.Size(32, 13);
            this.stateaddressLabel.TabIndex = 18;
            this.stateaddressLabel.Text = "State";
            // 
            // zaddressLabel
            // 
            this.zaddressLabel.AutoSize = true;
            this.zaddressLabel.Location = new System.Drawing.Point(207, 106);
            this.zaddressLabel.Name = "zaddressLabel";
            this.zaddressLabel.Size = new System.Drawing.Size(50, 13);
            this.zaddressLabel.TabIndex = 19;
            this.zaddressLabel.Text = "Zip Code";
            // 
            // cIssueBox
            // 
            this.cIssueBox.Controls.Add(this.ctButton4);
            this.cIssueBox.Controls.Add(this.ctButton3);
            this.cIssueBox.Controls.Add(this.ctButton2);
            this.cIssueBox.Controls.Add(this.ctButton);
            this.cIssueBox.Location = new System.Drawing.Point(276, 174);
            this.cIssueBox.Name = "cIssueBox";
            this.cIssueBox.Size = new System.Drawing.Size(98, 110);
            this.cIssueBox.TabIndex = 20;
            this.cIssueBox.TabStop = false;
            this.cIssueBox.Text = "Card Type";
            // 
            // ctButton4
            // 
            this.ctButton4.AutoSize = true;
            this.ctButton4.Location = new System.Drawing.Point(6, 86);
            this.ctButton4.Name = "ctButton4";
            this.ctButton4.Size = new System.Drawing.Size(55, 17);
            this.ctButton4.TabIndex = 3;
            this.ctButton4.TabStop = true;
            this.ctButton4.Text = "AMEX";
            this.ctButton4.UseVisualStyleBackColor = true;
            this.ctButton4.CheckedChanged += new System.EventHandler(this.ctButton4_CheckedChanged);
            // 
            // ctButton3
            // 
            this.ctButton3.AutoSize = true;
            this.ctButton3.Location = new System.Drawing.Point(6, 63);
            this.ctButton3.Name = "ctButton3";
            this.ctButton3.Size = new System.Drawing.Size(67, 17);
            this.ctButton3.TabIndex = 2;
            this.ctButton3.TabStop = true;
            this.ctButton3.Text = "Discover";
            this.ctButton3.UseVisualStyleBackColor = true;
            this.ctButton3.CheckedChanged += new System.EventHandler(this.ctButton3_CheckedChanged);
            // 
            // ctButton2
            // 
            this.ctButton2.AutoSize = true;
            this.ctButton2.Location = new System.Drawing.Point(7, 40);
            this.ctButton2.Name = "ctButton2";
            this.ctButton2.Size = new System.Drawing.Size(49, 17);
            this.ctButton2.TabIndex = 1;
            this.ctButton2.TabStop = true;
            this.ctButton2.Text = "VISA";
            this.ctButton2.UseVisualStyleBackColor = true;
            this.ctButton2.CheckedChanged += new System.EventHandler(this.ctButton2_CheckedChanged);
            // 
            // ctButton
            // 
            this.ctButton.AutoSize = true;
            this.ctButton.Location = new System.Drawing.Point(7, 20);
            this.ctButton.Name = "ctButton";
            this.ctButton.Size = new System.Drawing.Size(79, 17);
            this.ctButton.TabIndex = 0;
            this.ctButton.TabStop = true;
            this.ctButton.Text = "MasterCard";
            this.ctButton.UseVisualStyleBackColor = true;
            this.ctButton.CheckedChanged += new System.EventHandler(this.ctButton_CheckedChanged);
            // 
            // cardLogoBox
            // 
            this.cardLogoBox.Location = new System.Drawing.Point(276, 106);
            this.cardLogoBox.Name = "cardLogoBox";
            this.cardLogoBox.Size = new System.Drawing.Size(98, 62);
            this.cardLogoBox.TabIndex = 21;
            this.cardLogoBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(276, 309);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cphone
            // 
            this.cphone.AutoSize = true;
            this.cphone.Location = new System.Drawing.Point(12, 136);
            this.cphone.Name = "cphone";
            this.cphone.Size = new System.Drawing.Size(38, 13);
            this.cphone.TabIndex = 24;
            this.cphone.Text = "Phone";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 352);
            this.Controls.Add(this.cphone);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.cardLogoBox);
            this.Controls.Add(this.cIssueBox);
            this.Controls.Add(this.zaddressLabel);
            this.Controls.Add(this.stateaddressLabel);
            this.Controls.Add(this.caddressLabel);
            this.Controls.Add(this.saddressLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CCexpYearBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ccExpMonBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ccBox1);
            this.Name = "Payment";
            this.Text = "Credit Card Information";
            this.cIssueBox.ResumeLayout(false);
            this.cIssueBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ccBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccExpMonBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CCexpYearBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label saddressLabel;
        private System.Windows.Forms.Label caddressLabel;
        private System.Windows.Forms.Label stateaddressLabel;
        private System.Windows.Forms.Label zaddressLabel;
        private System.Windows.Forms.GroupBox cIssueBox;
        private System.Windows.Forms.RadioButton ctButton4;
        private System.Windows.Forms.RadioButton ctButton3;
        private System.Windows.Forms.RadioButton ctButton2;
        private System.Windows.Forms.RadioButton ctButton;
        private System.Windows.Forms.PictureBox cardLogoBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cphone;
    }
}

