
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SearchBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(187, 167);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(343, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(506, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(101, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Orange;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(357, 472);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            // 
            // SearchBox8
            // 
            this.SearchBox8.Location = new System.Drawing.Point(187, 211);
            this.SearchBox8.Name = "SearchBox8";
            this.SearchBox8.Size = new System.Drawing.Size(464, 20);
            this.SearchBox8.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 238);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(785, 228);
            this.dataGridView1.TabIndex = 20;
            // 
            // Contact_Tracing_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBox8);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox SearchBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

