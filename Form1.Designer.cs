namespace Student_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblNumber = new Label();
            lblEid = new Label();
            label1 = new Label();
            lblGender = new Label();
            lblAddress = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            txtEid = new TextBox();
            txtDate = new DateTimePicker();
            ddlGender = new ComboBox();
            txtAddress = new TextBox();
            dataGV = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnShow = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(25, 123);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name *";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(332, 123);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(30, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email *";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(294, 172);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(130, 20);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Mobile Number *";
            // 
            // lblEid
            // 
            lblEid.AutoSize = true;
            lblEid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEid.Location = new Point(592, 125);
            lblEid.Name = "lblEid";
            lblEid.Size = new Size(118, 20);
            lblEid.TabIndex = 4;
            lblEid.Text = "Enrolment No *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(595, 178);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Date of Birth *";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(34, 222);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(71, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender *";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(333, 227);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 20);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 6F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(32, 293);
            label2.Name = "label2";
            label2.Size = new Size(134, 12);
            label2.TabIndex = 8;
            label2.Text = "NOTE: * Mandatory field";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(132, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(425, 122);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(125, 27);
            txtSecondName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(428, 167);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 12;
            // 
            // txtEid
            // 
            txtEid.Location = new Point(710, 124);
            txtEid.Name = "txtEid";
            txtEid.Size = new Size(175, 27);
            txtEid.TabIndex = 13;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(710, 174);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(175, 27);
            txtDate.TabIndex = 14;
            txtDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // ddlGender
            // 
            ddlGender.FormattingEnabled = true;
            ddlGender.Location = new Point(132, 218);
            ddlGender.Name = "ddlGender";
            ddlGender.Size = new Size(125, 28);
            ddlGender.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(425, 224);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 16;
            // 
            // dataGV
            // 
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV.Location = new Point(50, 375);
            dataGV.Name = "dataGV";
            dataGV.RowHeadersWidth = 51;
            dataGV.Size = new Size(1016, 313);
            dataGV.TabIndex = 17;
            dataGV.CellContentClick += dataGV_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(600, 228);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(784, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 322);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(343, 320);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(784, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 29);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(605, 272);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(953, 228);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(113, 73);
            btnShow.TabIndex = 24;
            btnShow.Text = "Show All";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 24);
            label3.Name = "label3";
            label3.Size = new Size(672, 62);
            label3.TabIndex = 25;
            label3.Text = "Student Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1117, 700);
            Controls.Add(label3);
            Controls.Add(btnShow);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGV);
            Controls.Add(txtAddress);
            Controls.Add(ddlGender);
            Controls.Add(txtDate);
            Controls.Add(txtEid);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(lblAddress);
            Controls.Add(lblGender);
            Controls.Add(label1);
            Controls.Add(lblEid);
            Controls.Add(lblNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Student Management System";
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblNumber;
        private Label lblEid;
        private Label label1;
        private Label lblGender;
        private Label lblAddress;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private TextBox txtEid;
        private DateTimePicker txtDate;
        private ComboBox ddlGender;
        private TextBox txtAddress;
        private DataGridView dataGV;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnSave;
        private Button btnShow;
        private Label label3;
    }
}
