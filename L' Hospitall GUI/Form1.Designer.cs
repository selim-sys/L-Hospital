namespace WindowsFormsApp3
{
    partial class Form1
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
            this.lblFind = new System.Windows.Forms.Label();
            this.textFind = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFind.Location = new System.Drawing.Point(12, 430);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(410, 298);
            this.lblFind.TabIndex = 122;
            this.lblFind.Click += new System.EventHandler(this.lblSearcH_Click);
            // 
            // textFind
            // 
            this.textFind.BackColor = System.Drawing.Color.Gainsboro;
            this.textFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFind.Location = new System.Drawing.Point(150, 370);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(272, 27);
            this.textFind.TabIndex = 121;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Indigo;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 355);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 56);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(150, 275);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 56);
            this.btnClear.TabIndex = 119;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.Cyan;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(12, 274);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(131, 56);
            this.btnAddPatient.TabIndex = 118;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(667, 229);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(246, 28);
            this.comboGender.TabIndex = 117;
            // 
            // textDepartment
            // 
            this.textDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.textDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartment.Location = new System.Drawing.Point(177, 229);
            this.textDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(246, 27);
            this.textDepartment.TabIndex = 116;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(667, 168);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(246, 27);
            this.textAddress.TabIndex = 115;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(177, 169);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(246, 27);
            this.textEmail.TabIndex = 114;
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumber.Location = new System.Drawing.Point(667, 109);
            this.textNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(246, 27);
            this.textNumber.TabIndex = 113;
            // 
            // textAge
            // 
            this.textAge.BackColor = System.Drawing.Color.Gainsboro;
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(177, 108);
            this.textAge.Margin = new System.Windows.Forms.Padding(4);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(246, 27);
            this.textAge.TabIndex = 112;
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(667, 46);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(246, 27);
            this.textLastName.TabIndex = 111;
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Location = new System.Drawing.Point(177, 45);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(246, 27);
            this.textFirstName.TabIndex = 110;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 109;
            this.label1.Text = "Disease :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(13, 168);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 22);
            this.lblEmail.TabIndex = 108;
            this.lblEmail.Text = "Email :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Location = new System.Drawing.Point(503, 167);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 22);
            this.lblAddress.TabIndex = 107;
            this.lblAddress.Text = "Address :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumber.Location = new System.Drawing.Point(503, 108);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(94, 22);
            this.lblNumber.TabIndex = 106;
            this.lblNumber.Text = "Number :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGender.Location = new System.Drawing.Point(503, 228);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 22);
            this.lblGender.TabIndex = 105;
            this.lblGender.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAge.Location = new System.Drawing.Point(13, 107);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(58, 22);
            this.lblAge.TabIndex = 104;
            this.lblAge.Text = "Age :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Location = new System.Drawing.Point(503, 45);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 22);
            this.lblLastName.TabIndex = 103;
            this.lblLastName.Text = "LastName :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirstname.Location = new System.Drawing.Point(13, 48);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(115, 22);
            this.lblFirstname.TabIndex = 102;
            this.lblFirstname.Text = "FirstName :";
            this.lblFirstname.Click += new System.EventHandler(this.lblFirstname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1130, 737);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
    }
}

