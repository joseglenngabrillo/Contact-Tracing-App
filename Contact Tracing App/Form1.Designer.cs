
namespace Contact_Tracing_App
{
    partial class Contact_Tracing_App
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
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameBox1 = new System.Windows.Forms.TextBox();
            this.MiddleNameBox2 = new System.Windows.Forms.TextBox();
            this.LastNameBox3 = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.AgeBox4 = new System.Windows.Forms.TextBox();
            this.AddressBox5 = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumberBox6 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(38, 13);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(26, 44);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(69, 13);
            this.MiddleName.TabIndex = 1;
            this.MiddleName.Text = "Middle Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(37, 73);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // FirstNameBox1
            // 
            this.FirstNameBox1.Location = new System.Drawing.Point(101, 6);
            this.FirstNameBox1.Name = "FirstNameBox1";
            this.FirstNameBox1.Size = new System.Drawing.Size(289, 20);
            this.FirstNameBox1.TabIndex = 3;
            this.FirstNameBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MiddleNameBox2
            // 
            this.MiddleNameBox2.Location = new System.Drawing.Point(101, 37);
            this.MiddleNameBox2.Name = "MiddleNameBox2";
            this.MiddleNameBox2.Size = new System.Drawing.Size(289, 20);
            this.MiddleNameBox2.TabIndex = 4;
            // 
            // LastNameBox3
            // 
            this.LastNameBox3.Location = new System.Drawing.Point(101, 66);
            this.LastNameBox3.Name = "LastNameBox3";
            this.LastNameBox3.Size = new System.Drawing.Size(289, 20);
            this.LastNameBox3.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(69, 108);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.Age_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(455, 76);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 7;
            this.Address.Text = "Address";
            // 
            // AgeBox4
            // 
            this.AgeBox4.Location = new System.Drawing.Point(101, 101);
            this.AgeBox4.Name = "AgeBox4";
            this.AgeBox4.Size = new System.Drawing.Size(43, 20);
            this.AgeBox4.TabIndex = 8;
            // 
            // AddressBox5
            // 
            this.AddressBox5.Location = new System.Drawing.Point(506, 73);
            this.AddressBox5.Multiline = true;
            this.AddressBox5.Name = "AddressBox5";
            this.AddressBox5.Size = new System.Drawing.Size(289, 88);
            this.AddressBox5.TabIndex = 9;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(422, 13);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 10;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // PhoneNumberBox6
            // 
            this.PhoneNumberBox6.Location = new System.Drawing.Point(506, 6);
            this.PhoneNumberBox6.Name = "PhoneNumberBox6";
            this.PhoneNumberBox6.Size = new System.Drawing.Size(289, 20);
            this.PhoneNumberBox6.TabIndex = 11;
            this.PhoneNumberBox6.TextChanged += new System.EventHandler(this.PhoneNumberBox6_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(468, 44);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // EmailBox7
            // 
            this.EmailBox7.Location = new System.Drawing.Point(506, 37);
            this.EmailBox7.Name = "EmailBox7";
            this.EmailBox7.Size = new System.Drawing.Size(289, 20);
            this.EmailBox7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Contact_Tracing_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 498);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailBox7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumberBox6);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.AddressBox5);
            this.Controls.Add(this.AgeBox4);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.LastNameBox3);
            this.Controls.Add(this.MiddleNameBox2);
            this.Controls.Add(this.FirstNameBox1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Contact_Tracing_App";
            this.ShowIcon = false;
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.Contact_Tracing_App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FirstNameBox1;
        private System.Windows.Forms.TextBox MiddleNameBox2;
        private System.Windows.Forms.TextBox LastNameBox3;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox AgeBox4;
        private System.Windows.Forms.TextBox AddressBox5;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox PhoneNumberBox6;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

