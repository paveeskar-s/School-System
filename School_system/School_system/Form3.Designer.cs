namespace School_system
{
    partial class Form3
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
            panel1 = new Panel();
            label6 = new Label();
            exit = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            txtFirstName = new Label();
            lbllastname = new Label();
            numAge = new Label();
            lblhome = new Label();
            iblWorkPlace = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 81);
            panel1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(284, 28);
            label6.Name = "label6";
            label6.Size = new Size(202, 35);
            label6.TabIndex = 0;
            label6.Text = "Output Details";
            label6.Click += label6_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.PeachPuff;
            exit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            exit.Location = new Point(445, 460);
            exit.Name = "exit";
            exit.Size = new Size(124, 38);
            exit.TabIndex = 16;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += Submit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(149, 393);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 6;
            label5.Text = "Working Place";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(149, 333);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 7;
            label4.Text = "Home Town";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(149, 275);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(149, 212);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(149, 143);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 15);
            panel2.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            button1.Location = new Point(173, 460);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 17;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.AutoSize = true;
            txtFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtFirstName.Location = new Point(486, 143);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(0, 23);
            txtFirstName.TabIndex = 20;
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbllastname.Location = new Point(486, 215);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(0, 23);
            lbllastname.TabIndex = 20;
            // 
            // numAge
            // 
            numAge.AutoSize = true;
            numAge.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            numAge.Location = new Point(486, 278);
            numAge.Name = "numAge";
            numAge.Size = new Size(0, 23);
            numAge.TabIndex = 20;
            // 
            // lblhome
            // 
            lblhome.AutoSize = true;
            lblhome.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblhome.Location = new Point(486, 336);
            lblhome.Name = "lblhome";
            lblhome.Size = new Size(0, 23);
            lblhome.TabIndex = 20;
            // 
            // iblWorkPlace
            // 
            iblWorkPlace.AutoSize = true;
            iblWorkPlace.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            iblWorkPlace.Location = new Point(486, 396);
            iblWorkPlace.Name = "iblWorkPlace";
            iblWorkPlace.Size = new Size(0, 23);
            iblWorkPlace.TabIndex = 20;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 600);
            ControlBox = false;
            Controls.Add(iblWorkPlace);
            Controls.Add(lblhome);
            Controls.Add(numAge);
            Controls.Add(lbllastname);
            Controls.Add(txtFirstName);
            Controls.Add(panel1);
            Controls.Add(exit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button exit;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label txtFirstName;
        private Label lbllastname;
        private Label numAge;
        private Label lblhome;
        private Label iblWorkPlace;
    }
}