namespace School_system
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Submit = new Button();
            panel1 = new Panel();
            label6 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            FrtName = new TextBox();
            LtName = new TextBox();
            HTown = new TextBox();
            numAge = new NumericUpDown();
            WorkPlace = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(143, 166);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(143, 235);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(143, 298);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 0;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(143, 356);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 0;
            label4.Text = "Home Town";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(143, 416);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 0;
            label5.Text = "Working Place";
            label5.Click += label5_Click;
            // 
            // Submit
            // 
            Submit.BackColor = Color.PeachPuff;
            Submit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            Submit.Location = new Point(439, 483);
            Submit.Name = "Submit";
            Submit.Size = new Size(124, 38);
            Submit.TabIndex = 3;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 81);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(278, 25);
            label6.Name = "label6";
            label6.Size = new Size(181, 35);
            label6.TabIndex = 0;
            label6.Text = "Input Details";
            label6.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            button1.Location = new Point(291, 483);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 606);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 15);
            panel2.TabIndex = 5;
            // 
            // FrtName
            // 
            FrtName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            FrtName.Location = new Point(324, 159);
            FrtName.Name = "FrtName";
            FrtName.Size = new Size(239, 30);
            FrtName.TabIndex = 1;
            // 
            // LtName
            // 
            LtName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            LtName.Location = new Point(324, 228);
            LtName.Name = "LtName";
            LtName.Size = new Size(239, 30);
            LtName.TabIndex = 2;
            // 
            // HTown
            // 
            HTown.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            HTown.Location = new Point(324, 349);
            HTown.Name = "HTown";
            HTown.Size = new Size(239, 30);
            HTown.TabIndex = 4;
            // 
            // numAge
            // 
            numAge.Location = new Point(324, 298);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 3;
            // 
            // WorkPlace
            // 
            WorkPlace.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            WorkPlace.Location = new Point(324, 409);
            WorkPlace.Name = "WorkPlace";
            WorkPlace.Size = new Size(239, 30);
            WorkPlace.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(731, 621);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(numAge);
            Controls.Add(WorkPlace);
            Controls.Add(HTown);
            Controls.Add(LtName);
            Controls.Add(FrtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Submit;
        private Panel panel1;
        private Label label6;
        private Button button1;
        private Panel panel2;
        private TextBox FrtName;
        private TextBox LtName;
        private TextBox HTown;
        private NumericUpDown numAge;
        private TextBox WorkPlace;
    }
}