using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ParcelOffice_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.groupBoxSchool = new System.Windows.Forms.GroupBox();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.groupBoxCourse = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblJsonInfo = new System.Windows.Forms.Label();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnBulkUpload = new System.Windows.Forms.Button();
            this.tabParcel = new System.Windows.Forms.TabPage();
            this.groupBoxParcelEntry = new System.Windows.Forms.GroupBox();
            this.cmbStudentSearch = new System.Windows.Forms.ComboBox();
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.groupBoxStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.groupBoxParcelDetails = new System.Windows.Forms.GroupBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.btnSaveParcel = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.lblSearchPlaceholder = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            this.btnGenerateToken = new System.Windows.Forms.Button();
            this.btnMarkCollected = new System.Windows.Forms.Button();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblTotalParcels = new System.Windows.Forms.Label();
            this.lblPendingParcels = new System.Windows.Forms.Label();
            this.lblCollectedParcels = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.groupBoxSchool.SuspendLayout();
            this.groupBoxDepartment.SuspendLayout();
            this.groupBoxCourse.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabParcel.SuspendLayout();
            this.groupBoxParcelEntry.SuspendLayout();
            this.groupBoxStudentDetails.SuspendLayout();
            this.groupBoxParcelDetails.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.tabDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudent);
            this.tabControl1.Controls.Add(this.tabParcel);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 750);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.groupBoxSchool);
            this.tabStudent.Controls.Add(this.groupBoxDepartment);
            this.tabStudent.Controls.Add(this.groupBoxCourse);
            this.tabStudent.Controls.Add(this.groupBoxStudent);
            this.tabStudent.Controls.Add(this.dgvStudents);
            this.tabStudent.Controls.Add(this.lblJsonInfo);
            this.tabStudent.Controls.Add(this.btnUpdateStudent);
            this.tabStudent.Controls.Add(this.btnDeleteStudent);
            this.tabStudent.Controls.Add(this.btnBulkUpload);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(1092, 724);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Student Management";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // groupBoxSchool
            // 
            this.groupBoxSchool.Controls.Add(this.txtSchoolName);
            this.groupBoxSchool.Controls.Add(this.btnAddSchool);
            this.groupBoxSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxSchool.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxSchool.Location = new System.Drawing.Point(10, 10);
            this.groupBoxSchool.Name = "groupBoxSchool";
            this.groupBoxSchool.Size = new System.Drawing.Size(260, 110);
            this.groupBoxSchool.TabIndex = 0;
            this.groupBoxSchool.TabStop = false;
            this.groupBoxSchool.Text = "1. Add School";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(10, 45);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(240, 21);
            this.txtSchoolName.TabIndex = 0;
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSchool.ForeColor = System.Drawing.Color.White;
            this.btnAddSchool.Location = new System.Drawing.Point(10, 75);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(240, 25);
            this.btnAddSchool.TabIndex = 1;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = false;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.cmbSchool);
            this.groupBoxDepartment.Controls.Add(this.txtDepartmentName);
            this.groupBoxDepartment.Controls.Add(this.btnAddDepartment);
            this.groupBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxDepartment.Location = new System.Drawing.Point(280, 10);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(260, 160);
            this.groupBoxDepartment.TabIndex = 1;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "2. Add Department";
            // 
            // cmbSchool
            // 
            this.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchool.Location = new System.Drawing.Point(10, 30);
            this.cmbSchool.Name = "cmbSchool";
            this.cmbSchool.Size = new System.Drawing.Size(240, 23);
            this.cmbSchool.TabIndex = 2;
            this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(10, 80);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(240, 21);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(10, 110);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(240, 25);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // groupBoxCourse
            // 
            this.groupBoxCourse.Controls.Add(this.cmbDepartment);
            this.groupBoxCourse.Controls.Add(this.txtCourseName);
            this.groupBoxCourse.Controls.Add(this.btnAddCourse);
            this.groupBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxCourse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxCourse.Location = new System.Drawing.Point(550, 10);
            this.groupBoxCourse.Name = "groupBoxCourse";
            this.groupBoxCourse.Size = new System.Drawing.Size(260, 160);
            this.groupBoxCourse.TabIndex = 2;
            this.groupBoxCourse.TabStop = false;
            this.groupBoxCourse.Text = "3. Add Course";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Location = new System.Drawing.Point(6, 30);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(240, 23);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(10, 80);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(240, 21);
            this.txtCourseName.TabIndex = 6;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(10, 110);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(240, 25);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.cmbCourse);
            this.groupBoxStudent.Controls.Add(this.txtStudentName);
            this.groupBoxStudent.Controls.Add(this.txtStudentEmail);
            this.groupBoxStudent.Controls.Add(this.txtStudentPhone);
            this.groupBoxStudent.Controls.Add(this.btnAddStudent);
            this.groupBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxStudent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxStudent.Location = new System.Drawing.Point(820, 10);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(260, 210);
            this.groupBoxStudent.TabIndex = 3;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "4. Add Student";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Location = new System.Drawing.Point(10, 30);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(240, 23);
            this.cmbCourse.TabIndex = 8;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(10, 75);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(240, 21);
            this.txtStudentName.TabIndex = 9;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(10, 110);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(240, 21);
            this.txtStudentEmail.TabIndex = 10;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(10, 145);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(240, 21);
            this.txtStudentPhone.TabIndex = 11;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(10, 175);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(240, 25);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.Color.LightGray;
            this.dgvStudents.Location = new System.Drawing.Point(10, 235);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1070, 350);
            this.dgvStudents.TabIndex = 13;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // lblJsonInfo
            // 
            this.lblJsonInfo.AutoSize = true;
            this.lblJsonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblJsonInfo.Location = new System.Drawing.Point(370, 585);
            this.lblJsonInfo.Name = "lblJsonInfo";
            this.lblJsonInfo.Size = new System.Drawing.Size(404, 15);
            this.lblJsonInfo.TabIndex = 14;
            this.lblJsonInfo.Text = "Upload JSON with School → Department → Course → Students structure";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(10, 600);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(160, 35);
            this.btnUpdateStudent.TabIndex = 15;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(180, 600);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(160, 35);
            this.btnDeleteStudent.TabIndex = 16;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnBulkUpload
            // 
            this.btnBulkUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBulkUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBulkUpload.ForeColor = System.Drawing.Color.White;
            this.btnBulkUpload.Location = new System.Drawing.Point(920, 600);
            this.btnBulkUpload.Name = "btnBulkUpload";
            this.btnBulkUpload.Size = new System.Drawing.Size(160, 35);
            this.btnBulkUpload.TabIndex = 17;
            this.btnBulkUpload.Text = "Upload JSON";
            this.btnBulkUpload.UseVisualStyleBackColor = false;
            this.btnBulkUpload.Click += new System.EventHandler(this.btnBulkUpload_Click);
            // 
            // tabParcel
            // 
            this.tabParcel.Controls.Add(this.groupBoxParcelEntry);
            this.tabParcel.Location = new System.Drawing.Point(4, 22);
            this.tabParcel.Name = "tabParcel";
            this.tabParcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabParcel.Size = new System.Drawing.Size(1092, 724);
            this.tabParcel.TabIndex = 1;
            this.tabParcel.Text = "Parcel Entry";
            this.tabParcel.UseVisualStyleBackColor = true;
            // 
            // groupBoxParcelEntry
            // 
            this.groupBoxParcelEntry.Controls.Add(this.groupBoxStudentDetails);
            this.groupBoxParcelEntry.Controls.Add(this.groupBoxParcelDetails);
            this.groupBoxParcelEntry.Controls.Add(this.lblStudentSearch);
            this.groupBoxParcelEntry.Controls.Add(this.cmbStudentSearch);
            this.groupBoxParcelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxParcelEntry.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxParcelEntry.Location = new System.Drawing.Point(10, 10);
            this.groupBoxParcelEntry.Name = "groupBoxParcelEntry";
            this.groupBoxParcelEntry.Size = new System.Drawing.Size(500, 700);
            this.groupBoxParcelEntry.TabIndex = 0;
            this.groupBoxParcelEntry.TabStop = false;
            this.groupBoxParcelEntry.Text = "Parcel Entry";
            // 
            // lblStudentSearch
            // 
            this.lblStudentSearch.AutoSize = true;
            this.lblStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentSearch.Location = new System.Drawing.Point(10, 25);
            this.lblStudentSearch.Name = "lblStudentSearch";
            this.lblStudentSearch.Size = new System.Drawing.Size(101, 15);
            this.lblStudentSearch.TabIndex = 0;
            this.lblStudentSearch.Text = "Search Student";
            // 
            // cmbStudentSearch
            // 
            this.cmbStudentSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbStudentSearch.Location = new System.Drawing.Point(10, 45);
            this.cmbStudentSearch.Name = "cmbStudentSearch";
            this.cmbStudentSearch.Size = new System.Drawing.Size(470, 23);
            this.cmbStudentSearch.TabIndex = 1;
            this.cmbStudentSearch.SelectedIndexChanged += new System.EventHandler(this.cmbStudentSearch_SelectedIndexChanged);
            // 
            // groupBoxStudentDetails
            // 
            this.groupBoxStudentDetails.Controls.Add(this.lblName);
            this.groupBoxStudentDetails.Controls.Add(this.txtName);
            this.groupBoxStudentDetails.Controls.Add(this.lblEmail);
            this.groupBoxStudentDetails.Controls.Add(this.txtEmail);
            this.groupBoxStudentDetails.Controls.Add(this.lblPhone);
            this.groupBoxStudentDetails.Controls.Add(this.txtPhone);
            this.groupBoxStudentDetails.Controls.Add(this.lblSchool);
            this.groupBoxStudentDetails.Controls.Add(this.txtSchool);
            this.groupBoxStudentDetails.Controls.Add(this.lblDepartment);
            this.groupBoxStudentDetails.Controls.Add(this.txtDepartment);
            this.groupBoxStudentDetails.Controls.Add(this.lblCourse);
            this.groupBoxStudentDetails.Controls.Add(this.txtCourse);
            this.groupBoxStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBoxStudentDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxStudentDetails.Location = new System.Drawing.Point(10, 80);
            this.groupBoxStudentDetails.Name = "groupBoxStudentDetails";
            this.groupBoxStudentDetails.Size = new System.Drawing.Size(470, 280);
            this.groupBoxStudentDetails.TabIndex = 2;
            this.groupBoxStudentDetails.TabStop = false;
            this.groupBoxStudentDetails.Text = "Student Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblName.Location = new System.Drawing.Point(10, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtName.Location = new System.Drawing.Point(10, 40);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(450, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblEmail.Location = new System.Drawing.Point(10, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtEmail.Location = new System.Drawing.Point(10, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(450, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPhone.Location = new System.Drawing.Point(10, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPhone.Location = new System.Drawing.Point(10, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(450, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSchool.Location = new System.Drawing.Point(10, 145);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(50, 13);
            this.lblSchool.TabIndex = 6;
            this.lblSchool.Text = "School:";
            // 
            // txtSchool
            // 
            this.txtSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSchool.Location = new System.Drawing.Point(10, 160);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(450, 20);
            this.txtSchool.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDepartment.Location = new System.Drawing.Point(10, 185);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(75, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtDepartment.Location = new System.Drawing.Point(10, 200);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(450, 20);
            this.txtDepartment.TabIndex = 9;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCourse.Location = new System.Drawing.Point(10, 225);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(49, 13);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Course:";
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCourse.Location = new System.Drawing.Point(10, 240);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(450, 20);
            this.txtCourse.TabIndex = 11;
            // 
            // groupBoxParcelDetails
            // 
            this.groupBoxParcelDetails.Controls.Add(this.lblTrackingNumber);
            this.groupBoxParcelDetails.Controls.Add(this.txtTrackingNumber);
            this.groupBoxParcelDetails.Controls.Add(this.lblVendorName);
            this.groupBoxParcelDetails.Controls.Add(this.txtVendorName);
            this.groupBoxParcelDetails.Controls.Add(this.btnSaveParcel);
            this.groupBoxParcelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBoxParcelDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxParcelDetails.Location = new System.Drawing.Point(10, 370);
            this.groupBoxParcelDetails.Name = "groupBoxParcelDetails";
            this.groupBoxParcelDetails.Size = new System.Drawing.Size(470, 310);
            this.groupBoxParcelDetails.TabIndex = 3;
            this.groupBoxParcelDetails.TabStop = false;
            this.groupBoxParcelDetails.Text = "Parcel Details";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTrackingNumber.Location = new System.Drawing.Point(10, 25);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(111, 13);
            this.lblTrackingNumber.TabIndex = 0;
            this.lblTrackingNumber.Text = "Tracking Number:";
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTrackingNumber.Location = new System.Drawing.Point(10, 40);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(450, 21);
            this.txtTrackingNumber.TabIndex = 0;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblVendorName.Location = new System.Drawing.Point(10, 75);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(133, 13);
            this.lblVendorName.TabIndex = 2;
            this.lblVendorName.Text = "Vendor Name (Optional):";
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtVendorName.Location = new System.Drawing.Point(10, 90);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(450, 21);
            this.txtVendorName.TabIndex = 1;
            // 
            // btnSaveParcel
            // 
            this.btnSaveParcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnSaveParcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveParcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveParcel.ForeColor = System.Drawing.Color.White;
            this.btnSaveParcel.Location = new System.Drawing.Point(10, 125);
            this.btnSaveParcel.Name = "btnSaveParcel";
            this.btnSaveParcel.Size = new System.Drawing.Size(450, 35);
            this.btnSaveParcel.TabIndex = 2;
            this.btnSaveParcel.Text = "Save Parcel";
            this.btnSaveParcel.UseVisualStyleBackColor = false;
            this.btnSaveParcel.Click += new System.EventHandler(this.btnSaveParcel_Click);

            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.lblSearchPlaceholder);
            this.tabSearch.Controls.Add(this.txtSearch);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.dgvParcels);
            this.tabSearch.Controls.Add(this.btnGenerateToken);
            this.tabSearch.Controls.Add(this.btnMarkCollected);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1092, 724);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Search & Manage";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchPlaceholder
            // 
            this.lblSearchPlaceholder.AutoSize = true;
            this.lblSearchPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchPlaceholder.Location = new System.Drawing.Point(20, 20);
            this.lblSearchPlaceholder.Name = "lblSearchPlaceholder";
            this.lblSearchPlaceholder.Size = new System.Drawing.Size(356, 17);
            this.lblSearchPlaceholder.TabIndex = 28;
            this.lblSearchPlaceholder.Text = "Search by Parcel ID / Student Name / Tracking Number / Vendor Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 20);
            this.txtSearch.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(330, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 24);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvParcels
            // 
            this.dgvParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcels.Location = new System.Drawing.Point(20, 90);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcels.Size = new System.Drawing.Size(1050, 400);
            this.dgvParcels.TabIndex = 31;
            this.dgvParcels.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellEndEdit);
            // 
            // btnGenerateToken
            // 
            this.btnGenerateToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerateToken.ForeColor = System.Drawing.Color.White;
            this.btnGenerateToken.Location = new System.Drawing.Point(20, 510);
            this.btnGenerateToken.Name = "btnGenerateToken";
            this.btnGenerateToken.Size = new System.Drawing.Size(160, 35);
            this.btnGenerateToken.TabIndex = 32;
            this.btnGenerateToken.Text = "Generate Token";
            this.btnGenerateToken.UseVisualStyleBackColor = false;
            this.btnGenerateToken.Click += new System.EventHandler(this.btnGenerateToken_Click);
            // 
            // btnMarkCollected
            // 
            this.btnMarkCollected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnMarkCollected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkCollected.ForeColor = System.Drawing.Color.White;
            this.btnMarkCollected.Location = new System.Drawing.Point(190, 510);
            this.btnMarkCollected.Name = "btnMarkCollected";
            this.btnMarkCollected.Size = new System.Drawing.Size(160, 35);
            this.btnMarkCollected.TabIndex = 33;
            this.btnMarkCollected.Text = "Mark Collected";
            this.btnMarkCollected.UseVisualStyleBackColor = false;
            this.btnMarkCollected.Click += new System.EventHandler(this.btnMarkCollected_Click);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblTotalParcels);
            this.tabDashboard.Controls.Add(this.lblPendingParcels);
            this.tabDashboard.Controls.Add(this.lblCollectedParcels);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1092, 724);
            this.tabDashboard.TabIndex = 3;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblTotalParcels
            // 
            this.lblTotalParcels.AutoSize = true;
            this.lblTotalParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalParcels.Location = new System.Drawing.Point(50, 80);
            this.lblTotalParcels.Name = "lblTotalParcels";
            this.lblTotalParcels.Size = new System.Drawing.Size(154, 24);
            this.lblTotalParcels.TabIndex = 34;
            this.lblTotalParcels.Text = "Total Parcels: 0";
            // 
            // lblPendingParcels
            // 
            this.lblPendingParcels.AutoSize = true;
            this.lblPendingParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPendingParcels.Location = new System.Drawing.Point(50, 150);
            this.lblPendingParcels.Name = "lblPendingParcels";
            this.lblPendingParcels.Size = new System.Drawing.Size(186, 24);
            this.lblPendingParcels.TabIndex = 35;
            this.lblPendingParcels.Text = "Pending Parcels: 0";
            // 
            // lblCollectedParcels
            // 
            this.lblCollectedParcels.AutoSize = true;
            this.lblCollectedParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCollectedParcels.Location = new System.Drawing.Point(50, 220);
            this.lblCollectedParcels.Name = "lblCollectedParcels";
            this.lblCollectedParcels.Size = new System.Drawing.Size(196, 24);
            this.lblCollectedParcels.TabIndex = 36;
            this.lblCollectedParcels.Text = "Collected Parcels: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Parcel Office Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.groupBoxSchool.ResumeLayout(false);
            this.groupBoxSchool.PerformLayout();
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            this.groupBoxCourse.ResumeLayout(false);
            this.groupBoxCourse.PerformLayout();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabParcel.ResumeLayout(false);
            this.groupBoxParcelEntry.ResumeLayout(false);
            this.groupBoxParcelEntry.PerformLayout();
            this.groupBoxStudentDetails.ResumeLayout(false);
            this.groupBoxStudentDetails.PerformLayout();
            this.groupBoxParcelDetails.ResumeLayout(false);
            this.groupBoxParcelDetails.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabParcel;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabDashboard;

        // Tab 1 controls
        private System.Windows.Forms.GroupBox groupBoxSchool;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Button btnAddSchool;

        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Button btnAddDepartment;

        private System.Windows.Forms.GroupBox groupBoxCourse;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnAddCourse;

        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Button btnAddStudent;

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnBulkUpload;
        private System.Windows.Forms.Label lblJsonInfo;

        // Tab 2 controls
        private System.Windows.Forms.GroupBox groupBoxParcelEntry;
        private System.Windows.Forms.Label lblStudentSearch;
        private System.Windows.Forms.ComboBox cmbStudentSearch;
        private System.Windows.Forms.GroupBox groupBoxStudentDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.GroupBox groupBoxParcelDetails;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Button btnSaveParcel;

        // Tab 3 controls
        private System.Windows.Forms.Label lblSearchPlaceholder;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvParcels;
        private System.Windows.Forms.Button btnGenerateToken;
        private System.Windows.Forms.Button btnMarkCollected;

        // Tab 4 controls
        private System.Windows.Forms.Label lblTotalParcels;
        private System.Windows.Forms.Label lblPendingParcels;
        private System.Windows.Forms.Label lblCollectedParcels;
    }
}
