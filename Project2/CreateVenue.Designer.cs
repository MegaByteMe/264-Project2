namespace Project2
{
    partial class CreateVenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dragButton = new System.Windows.Forms.Button();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.seatBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savevenButton = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seatButton = new System.Windows.Forms.RadioButton();
            this.stageButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venue Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dragButton
            // 
            this.dragButton.Location = new System.Drawing.Point(99, 54);
            this.dragButton.Name = "dragButton";
            this.dragButton.Size = new System.Drawing.Size(95, 23);
            this.dragButton.TabIndex = 0;
            this.dragButton.Text = "Drag Me";
            this.dragButton.UseVisualStyleBackColor = true;
            this.dragButton.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(4, 57);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(26, 20);
            this.rowBox.TabIndex = 2;
            this.rowBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // seatBox
            // 
            this.seatBox.Location = new System.Drawing.Point(42, 58);
            this.seatBox.Name = "seatBox";
            this.seatBox.Size = new System.Drawing.Size(26, 20);
            this.seatBox.TabIndex = 3;
            this.seatBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // savevenButton
            // 
            this.savevenButton.Location = new System.Drawing.Point(497, 627);
            this.savevenButton.Name = "savevenButton";
            this.savevenButton.Size = new System.Drawing.Size(75, 23);
            this.savevenButton.TabIndex = 4;
            this.savevenButton.Text = "Save";
            this.savevenButton.UseVisualStyleBackColor = true;
            this.savevenButton.Click += new System.EventHandler(this.savevenButton_Click);
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(12, 627);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(75, 23);
            this.clrButton.TabIndex = 6;
            this.clrButton.Text = "Clear";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stageButton);
            this.groupBox1.Controls.Add(this.seatButton);
            this.groupBox1.Controls.Add(this.dragButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.seatBox);
            this.groupBox1.Controls.Add(this.rowBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(372, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // seatButton
            // 
            this.seatButton.AutoSize = true;
            this.seatButton.Location = new System.Drawing.Point(7, 20);
            this.seatButton.Name = "seatButton";
            this.seatButton.Size = new System.Drawing.Size(61, 17);
            this.seatButton.TabIndex = 0;
            this.seatButton.TabStop = true;
            this.seatButton.Text = "Seating";
            this.seatButton.UseVisualStyleBackColor = true;
            this.seatButton.CheckedChanged += new System.EventHandler(this.seatButton_CheckedChanged);
            // 
            // stageButton
            // 
            this.stageButton.AutoSize = true;
            this.stageButton.Location = new System.Drawing.Point(99, 20);
            this.stageButton.Name = "stageButton";
            this.stageButton.Size = new System.Drawing.Size(53, 17);
            this.stageButton.TabIndex = 1;
            this.stageButton.TabStop = true;
            this.stageButton.Text = "Stage";
            this.stageButton.UseVisualStyleBackColor = true;
            this.stageButton.CheckedChanged += new System.EventHandler(this.stageButton_CheckedChanged);
            // 
            // CreateVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.savevenButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateVenue";
            this.Text = "Create Venue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dragButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatBox;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.Button savevenButton;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stageButton;
        private System.Windows.Forms.RadioButton seatButton;
    }
}

