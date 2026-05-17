using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.tabStudent.Text = "Student Management";
            this.tabParcel = new System.Windows.Forms.TabPage();
            this.tabParcel.Text = "Parcel Entry";
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabSearch.Text = "Search & Manage";
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabDashboard.Text = "Dashboard";
            this.panelStudentTop = new System.Windows.Forms.Panel();
            this.panelSchool = new System.Windows.Forms.Panel();
            this.lblSchoolTitle = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.lblDepartmentTitle = new System.Windows.Forms.Label();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.panelCourse = new System.Windows.Forms.Panel();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panelStudentButtons = new System.Windows.Forms.Panel();
            this.lblJsonInfo = new System.Windows.Forms.Label();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnBulkUpload = new System.Windows.Forms.Button();
            this.panelParcelContainer = new System.Windows.Forms.Panel();
            this.panelParcelSearch = new System.Windows.Forms.Panel();
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.cmbStudentSearch = new System.Windows.Forms.ComboBox();
            this.groupBoxStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.groupBoxParcelDetails = new System.Windows.Forms.GroupBox();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.btnSaveParcel = new System.Windows.Forms.Button();
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.panelSearchTop = new System.Windows.Forms.Panel();
            this.lblSearchPlaceholder = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvParcels = new System.Windows.Forms.DataGridView();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.btnGenerateToken = new System.Windows.Forms.Button();
            this.btnMarkCollected = new System.Windows.Forms.Button();
            this.panelDashboardContainer = new System.Windows.Forms.Panel();
            this.panelDashboardTitle = new System.Windows.Forms.Label();
            this.panelTotalParcels = new System.Windows.Forms.Panel();
            this.panelTotalIcon = new System.Windows.Forms.Panel();
            this.lblTotalIcon = new System.Windows.Forms.Label();
            this.lblTotalParcelsValue = new System.Windows.Forms.Label();
            this.lblTotalParcelsTitle = new System.Windows.Forms.Label();
            this.panelPendingParcels = new System.Windows.Forms.Panel();
            this.panelPendingIcon = new System.Windows.Forms.Panel();
            this.lblPendingIcon = new System.Windows.Forms.Label();
            this.lblPendingParcelsValue = new System.Windows.Forms.Label();
            this.lblPendingParcelsTitle = new System.Windows.Forms.Label();
            this.panelCollectedParcels = new System.Windows.Forms.Panel();
            this.panelCollectedIcon = new System.Windows.Forms.Panel();
            this.lblCollectedIcon = new System.Windows.Forms.Label();
            this.lblCollectedParcelsValue = new System.Windows.Forms.Label();
            this.lblCollectedParcelsTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.panelStudentTop.SuspendLayout();
            this.panelSchool.SuspendLayout();
            this.panelDepartment.SuspendLayout();
            this.panelCourse.SuspendLayout();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panelStudentButtons.SuspendLayout();
            this.tabParcel.SuspendLayout();
            this.panelParcelContainer.SuspendLayout();
            this.panelParcelSearch.SuspendLayout();
            this.groupBoxStudentDetails.SuspendLayout();
            this.groupBoxParcelDetails.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panelSearchContainer.SuspendLayout();
            this.panelSearchTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).BeginInit();
            this.panelSearchButtons.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.panelDashboardContainer.SuspendLayout();
            this.panelTotalParcels.SuspendLayout();
            this.panelPendingParcels.SuspendLayout();
            this.panelCollectedParcels.SuspendLayout();
            this.SuspendLayout();

            // ===== GLOBAL COLORS =====
            Color mainBg = Color.FromArgb(244, 247, 252);
            Color cardBg = Color.White;
            Color primaryColor = Color.FromArgb(37, 99, 235);
            Color successColor = Color.FromArgb(22, 163, 74);
            Color dangerColor = Color.FromArgb(220, 38, 38);
            Color warningColor = Color.FromArgb(245, 158, 11);
            Color textDark = Color.FromArgb(30, 41, 59);
            Color textMuted = Color.FromArgb(100, 116, 139);
            Color borderColor = Color.FromArgb(203, 213, 225);
            Color hoverColor = Color.FromArgb(59, 130, 246);

            // ===== FORM SETTINGS =====
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.BackColor = mainBg;

            // ===== TAB CONTROL =====
            this.tabControl1.Controls.Add(this.tabStudent);
            this.tabControl1.Controls.Add(this.tabParcel);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 750);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Padding = new System.Drawing.Point(15, 10);
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 48);
            this.tabControl1.BackColor = Color.White;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);

            // ===== TAB 1 - STUDENT MANAGEMENT =====
            this.tabStudent.BackColor = mainBg;
            this.tabStudent.Padding = new System.Windows.Forms.Padding(20);

            // Top Panel with 4 Cards
            this.panelStudentTop.BackColor = mainBg;
            this.panelStudentTop.Location = new System.Drawing.Point(20, 20);
            this.panelStudentTop.Size = new System.Drawing.Size(1160, 230);

            // Card 1 - School
            this.panelSchool.BackColor = cardBg;
            this.panelSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSchool.Location = new System.Drawing.Point(0, 0);
            this.panelSchool.Size = new System.Drawing.Size(275, 210);
            this.lblSchoolTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSchoolTitle.ForeColor = primaryColor;
            this.lblSchoolTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSchoolTitle.Size = new System.Drawing.Size(245, 25);
            this.lblSchoolTitle.Text = "1. Add School";
            this.txtSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSchoolName.Location = new System.Drawing.Point(15, 50);
            this.txtSchoolName.Size = new System.Drawing.Size(245, 30);
            this.btnAddSchool.BackColor = primaryColor;
            this.btnAddSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchool.FlatAppearance.BorderSize = 0;
            this.btnAddSchool.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSchool.ForeColor = Color.White;
            this.btnAddSchool.Location = new System.Drawing.Point(15, 90);
            this.btnAddSchool.Size = new System.Drawing.Size(245, 35);
            this.btnAddSchool.TabIndex = 1;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = false;
            this.btnAddSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            this.panelSchool.Controls.Add(this.lblSchoolTitle);
            this.panelSchool.Controls.Add(this.txtSchoolName);
            this.panelSchool.Controls.Add(this.btnAddSchool);
            this.panelStudentTop.Controls.Add(this.panelSchool);

            // Card 2 - Department
            this.panelDepartment.BackColor = cardBg;
            this.panelDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepartment.Location = new System.Drawing.Point(295, 0);
            this.panelDepartment.Size = new System.Drawing.Size(275, 210);
            this.lblDepartmentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentTitle.ForeColor = primaryColor;
            this.lblDepartmentTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDepartmentTitle.Size = new System.Drawing.Size(245, 25);
            this.lblDepartmentTitle.Text = "2. Add Department";
            this.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSchool.Location = new System.Drawing.Point(15, 50);
            this.cmbSchool.Size = new System.Drawing.Size(245, 30);
            this.cmbSchool.TabIndex = 2;
            this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartmentName.Location = new System.Drawing.Point(15, 90);
            this.txtDepartmentName.Size = new System.Drawing.Size(245, 30);
            this.btnAddDepartment.BackColor = primaryColor;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(15, 130);
            this.btnAddDepartment.Size = new System.Drawing.Size(245, 35);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            this.panelDepartment.Controls.Add(this.lblDepartmentTitle);
            this.panelDepartment.Controls.Add(this.cmbSchool);
            this.panelDepartment.Controls.Add(this.txtDepartmentName);
            this.panelDepartment.Controls.Add(this.btnAddDepartment);
            this.panelStudentTop.Controls.Add(this.panelDepartment);

            // Card 3 - Course
            this.panelCourse.BackColor = cardBg;
            this.panelCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourse.Location = new System.Drawing.Point(590, 0);
            this.panelCourse.Size = new System.Drawing.Size(275, 210);
            this.lblCourseTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCourseTitle.ForeColor = primaryColor;
            this.lblCourseTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCourseTitle.Size = new System.Drawing.Size(245, 25);
            this.lblCourseTitle.Text = "3. Add Course";
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartment.Location = new System.Drawing.Point(15, 50);
            this.cmbDepartment.Size = new System.Drawing.Size(245, 30);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCourseName.Location = new System.Drawing.Point(15, 90);
            this.txtCourseName.Size = new System.Drawing.Size(245, 30);
            this.btnAddCourse.BackColor = primaryColor;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCourse.ForeColor = Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(15, 130);
            this.btnAddCourse.Size = new System.Drawing.Size(245, 35);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            this.panelCourse.Controls.Add(this.lblCourseTitle);
            this.panelCourse.Controls.Add(this.cmbDepartment);
            this.panelCourse.Controls.Add(this.txtCourseName);
            this.panelCourse.Controls.Add(this.btnAddCourse);
            this.panelStudentTop.Controls.Add(this.panelCourse);

            // Card 4 - Student
            this.panelStudent.BackColor = cardBg;
            this.panelStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudent.Location = new System.Drawing.Point(885, 0);
            this.panelStudent.Size = new System.Drawing.Size(275, 210);
            this.lblStudentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStudentTitle.ForeColor = primaryColor;
            this.lblStudentTitle.Location = new System.Drawing.Point(15, 15);
            this.lblStudentTitle.Size = new System.Drawing.Size(245, 25);
            this.lblStudentTitle.Text = "4. Add Student";
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCourse.Location = new System.Drawing.Point(15, 50);
            this.cmbCourse.Size = new System.Drawing.Size(245, 30);
            this.cmbCourse.TabIndex = 8;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(15, 88);
            this.txtStudentName.Size = new System.Drawing.Size(245, 30);
            this.txtStudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentEmail.Location = new System.Drawing.Point(15, 124);
            this.txtStudentEmail.Size = new System.Drawing.Size(245, 30);
            this.txtStudentPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentPhone.Location = new System.Drawing.Point(15, 160);
            this.txtStudentPhone.Size = new System.Drawing.Size(245, 30);
            this.btnAddStudent.BackColor = primaryColor;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(15, 165);
            this.btnAddStudent.Size = new System.Drawing.Size(245, 35);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.panelStudent.Controls.Add(this.lblStudentTitle);
            this.panelStudent.Controls.Add(this.cmbCourse);
            this.panelStudent.Controls.Add(this.txtStudentName);
            this.panelStudent.Controls.Add(this.txtStudentEmail);
            this.panelStudent.Controls.Add(this.txtStudentPhone);
            this.panelStudent.Controls.Add(this.btnAddStudent);
            this.panelStudentTop.Controls.Add(this.panelStudent);

            this.tabStudent.Controls.Add(this.panelStudentTop);

            // DataGridView Students
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = cardBg;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStudents.ColumnHeadersHeight = 35;
            this.dgvStudents.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvStudents.DefaultCellStyle.BackColor = Color.White;
            this.dgvStudents.DefaultCellStyle.ForeColor = textDark;
            this.dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            this.dgvStudents.DefaultCellStyle.SelectionForeColor = textDark;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = borderColor;
            this.dgvStudents.Location = new System.Drawing.Point(20, 260);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1160, 280);
            this.dgvStudents.TabIndex = 13;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            this.tabStudent.Controls.Add(this.dgvStudents);

            // Bottom Buttons Panel
            this.panelStudentButtons.BackColor = mainBg;
            this.panelStudentButtons.Location = new System.Drawing.Point(20, 555);
            this.panelStudentButtons.Size = new System.Drawing.Size(1160, 50);
            this.lblJsonInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJsonInfo.ForeColor = textMuted;
            this.lblJsonInfo.Location = new System.Drawing.Point(15, 15);
            this.lblJsonInfo.TabIndex = 14;
            this.lblJsonInfo.Text = "Upload JSON with School → Department → Course → Students structure";
            this.btnUpdateStudent.BackColor = primaryColor;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.ForeColor = Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(320, 10);
            this.btnUpdateStudent.Size = new System.Drawing.Size(160, 38);
            this.btnUpdateStudent.TabIndex = 15;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            this.btnDeleteStudent.BackColor = dangerColor;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStudent.ForeColor = Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(495, 10);
            this.btnDeleteStudent.Size = new System.Drawing.Size(160, 38);
            this.btnDeleteStudent.TabIndex = 16;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            this.btnBulkUpload.BackColor = successColor;
            this.btnBulkUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkUpload.FlatAppearance.BorderSize = 0;
            this.btnBulkUpload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBulkUpload.ForeColor = Color.White;
            this.btnBulkUpload.Location = new System.Drawing.Point(980, 10);
            this.btnBulkUpload.Size = new System.Drawing.Size(160, 38);
            this.btnBulkUpload.TabIndex = 17;
            this.btnBulkUpload.Text = "Upload JSON";
            this.btnBulkUpload.UseVisualStyleBackColor = false;
            this.btnBulkUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBulkUpload.Click += new System.EventHandler(this.btnBulkUpload_Click);
            this.panelStudentButtons.Controls.Add(this.lblJsonInfo);
            this.panelStudentButtons.Controls.Add(this.btnUpdateStudent);
            this.panelStudentButtons.Controls.Add(this.btnDeleteStudent);
            this.panelStudentButtons.Controls.Add(this.btnBulkUpload);
            this.tabStudent.Controls.Add(this.panelStudentButtons);

            // ===== TAB 2 - PARCEL ENTRY =====
            this.tabParcel.BackColor = mainBg;
            this.tabParcel.Padding = new System.Windows.Forms.Padding(20);

            this.panelParcelContainer.BackColor = mainBg;
            this.panelParcelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabParcel.Controls.Add(this.panelParcelContainer);

            // Search Panel
            this.panelParcelSearch.BackColor = cardBg;
            this.panelParcelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParcelSearch.Location = new System.Drawing.Point(20, 20);
            this.panelParcelSearch.Size = new System.Drawing.Size(560, 100);

            this.lblStudentSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentSearch.ForeColor = primaryColor;
            this.lblStudentSearch.Location = new System.Drawing.Point(20, 18);
            this.lblStudentSearch.Size = new System.Drawing.Size(200, 25);
            this.lblStudentSearch.Text = "Search Student";

            this.cmbStudentSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbStudentSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudentSearch.Location = new System.Drawing.Point(20, 48);
            this.cmbStudentSearch.Size = new System.Drawing.Size(520, 30);
            this.cmbStudentSearch.TabIndex = 1;
            this.cmbStudentSearch.SelectedIndexChanged += new System.EventHandler(this.cmbStudentSearch_SelectedIndexChanged);

            this.panelParcelSearch.Controls.Add(this.lblStudentSearch);
            this.panelParcelSearch.Controls.Add(this.cmbStudentSearch);
            this.panelParcelContainer.Controls.Add(this.panelParcelSearch);

            // Student Details GroupBox
            this.groupBoxStudentDetails.BackColor = cardBg;
            this.groupBoxStudentDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxStudentDetails.ForeColor = primaryColor;
            this.groupBoxStudentDetails.Location = new System.Drawing.Point(20, 135);
            this.groupBoxStudentDetails.Name = "groupBoxStudentDetails";
            this.groupBoxStudentDetails.Size = new System.Drawing.Size(560, 320);
            this.groupBoxStudentDetails.TabIndex = 2;
            this.groupBoxStudentDetails.TabStop = false;
            this.groupBoxStudentDetails.Text = "Student Details";

            int lblY = 28;
            int txtY = 48;
            int h = 30;

            this.lblName.Text = "Name:"; this.lblName.Location = new System.Drawing.Point(20, lblY); this.lblName.Size = new System.Drawing.Size(80, 20);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblName.ForeColor = textMuted;
            this.txtName.BackColor = Color.FromArgb(248, 250, 252); this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtName.Location = new System.Drawing.Point(20, txtY); this.txtName.Size = new System.Drawing.Size(520, h); this.txtName.ReadOnly = true;
            lblY += 44; txtY += 44;

            this.lblEmail.Text = "Email:"; this.lblEmail.Location = new System.Drawing.Point(20, lblY); this.lblEmail.Size = new System.Drawing.Size(80, 20);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblEmail.ForeColor = textMuted;
            this.txtEmail.BackColor = Color.FromArgb(248, 250, 252); this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtEmail.Location = new System.Drawing.Point(20, txtY); this.txtEmail.Size = new System.Drawing.Size(520, h); this.txtEmail.ReadOnly = true;
            lblY += 44; txtY += 44;

            this.lblPhone.Text = "Phone:"; this.lblPhone.Location = new System.Drawing.Point(20, lblY); this.lblPhone.Size = new System.Drawing.Size(80, 20);
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPhone.ForeColor = textMuted;
            this.txtPhone.BackColor = Color.FromArgb(248, 250, 252); this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtPhone.Location = new System.Drawing.Point(20, txtY); this.txtPhone.Size = new System.Drawing.Size(520, h); this.txtPhone.ReadOnly = true;
            lblY += 44; txtY += 44;

            this.lblSchool.Text = "School:"; this.lblSchool.Location = new System.Drawing.Point(20, lblY); this.lblSchool.Size = new System.Drawing.Size(80, 20);
            this.lblSchool.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblSchool.ForeColor = textMuted;
            this.txtSchool.BackColor = Color.FromArgb(248, 250, 252); this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchool.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtSchool.Location = new System.Drawing.Point(20, txtY); this.txtSchool.Size = new System.Drawing.Size(520, h); this.txtSchool.ReadOnly = true;
            lblY += 44; txtY += 44;

            this.lblDepartment.Text = "Department:"; this.lblDepartment.Location = new System.Drawing.Point(20, lblY); this.lblDepartment.Size = new System.Drawing.Size(100, 20);
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblDepartment.ForeColor = textMuted;
            this.txtDepartment.BackColor = Color.FromArgb(248, 250, 252); this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtDepartment.Location = new System.Drawing.Point(20, txtY); this.txtDepartment.Size = new System.Drawing.Size(520, h); this.txtDepartment.ReadOnly = true;
            lblY += 44; txtY += 44;

            this.lblCourse.Text = "Course:"; this.lblCourse.Location = new System.Drawing.Point(20, lblY); this.lblCourse.Size = new System.Drawing.Size(80, 20);
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblCourse.ForeColor = textMuted;
            this.txtCourse.BackColor = Color.FromArgb(248, 250, 252); this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtCourse.Location = new System.Drawing.Point(20, txtY); this.txtCourse.Size = new System.Drawing.Size(520, h); this.txtCourse.ReadOnly = true;

            this.groupBoxStudentDetails.Controls.Add(this.lblName); this.groupBoxStudentDetails.Controls.Add(this.txtName);
            this.groupBoxStudentDetails.Controls.Add(this.lblEmail); this.groupBoxStudentDetails.Controls.Add(this.txtEmail);
            this.groupBoxStudentDetails.Controls.Add(this.lblPhone); this.groupBoxStudentDetails.Controls.Add(this.txtPhone);
            this.groupBoxStudentDetails.Controls.Add(this.lblSchool); this.groupBoxStudentDetails.Controls.Add(this.txtSchool);
            this.groupBoxStudentDetails.Controls.Add(this.lblDepartment); this.groupBoxStudentDetails.Controls.Add(this.txtDepartment);
            this.groupBoxStudentDetails.Controls.Add(this.lblCourse); this.groupBoxStudentDetails.Controls.Add(this.txtCourse);
            this.panelParcelContainer.Controls.Add(this.groupBoxStudentDetails);

            // Parcel Details GroupBox
            this.groupBoxParcelDetails.BackColor = cardBg;
            this.groupBoxParcelDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxParcelDetails.ForeColor = primaryColor;
            this.groupBoxParcelDetails.Location = new System.Drawing.Point(610, 20);
            this.groupBoxParcelDetails.Name = "groupBoxParcelDetails";
            this.groupBoxParcelDetails.Size = new System.Drawing.Size(560, 280);
            this.groupBoxParcelDetails.TabIndex = 3;
            this.groupBoxParcelDetails.TabStop = false;
            this.groupBoxParcelDetails.Text = "Parcel Details";

            this.lblTrackingNumber.Text = "Tracking Number:"; this.lblTrackingNumber.Location = new System.Drawing.Point(20, 30); this.lblTrackingNumber.Size = new System.Drawing.Size(150, 20);
            this.lblTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblTrackingNumber.ForeColor = textMuted;
            this.txtTrackingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTrackingNumber.Location = new System.Drawing.Point(20, 55);
            this.txtTrackingNumber.Size = new System.Drawing.Size(520, 30);

            this.lblVendorName.Text = "Vendor Name (Optional):"; this.lblVendorName.Location = new System.Drawing.Point(20, 95); this.lblVendorName.Size = new System.Drawing.Size(180, 20);
            this.lblVendorName.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblVendorName.ForeColor = textMuted;
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVendorName.Location = new System.Drawing.Point(20, 120);
            this.txtVendorName.Size = new System.Drawing.Size(520, 30);

            this.btnSaveParcel.BackColor = successColor;
            this.btnSaveParcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveParcel.FlatAppearance.BorderSize = 0;
            this.btnSaveParcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveParcel.ForeColor = Color.White;
            this.btnSaveParcel.Location = new System.Drawing.Point(20, 175);
            this.btnSaveParcel.Size = new System.Drawing.Size(520, 50);
            this.btnSaveParcel.TabIndex = 2;
            this.btnSaveParcel.Text = "Save Parcel";
            this.btnSaveParcel.UseVisualStyleBackColor = false;
            this.btnSaveParcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveParcel.Click += new System.EventHandler(this.btnSaveParcel_Click);

            this.groupBoxParcelDetails.Controls.Add(this.lblTrackingNumber);
            this.groupBoxParcelDetails.Controls.Add(this.txtTrackingNumber);
            this.groupBoxParcelDetails.Controls.Add(this.lblVendorName);
            this.groupBoxParcelDetails.Controls.Add(this.txtVendorName);
            this.groupBoxParcelDetails.Controls.Add(this.btnSaveParcel);
            this.panelParcelContainer.Controls.Add(this.groupBoxParcelDetails);

            // ===== TAB 3 - SEARCH & MANAGE =====
            this.tabSearch.BackColor = mainBg;
            this.tabSearch.Padding = new System.Windows.Forms.Padding(20);

            this.panelSearchContainer.BackColor = mainBg;
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSearch.Controls.Add(this.panelSearchContainer);

            // Search Panel
            this.panelSearchTop.BackColor = cardBg;
            this.panelSearchTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchTop.Location = new System.Drawing.Point(20, 20);
            this.panelSearchTop.Size = new System.Drawing.Size(1160, 80);

            this.lblSearchPlaceholder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchPlaceholder.ForeColor = textMuted;
            this.lblSearchPlaceholder.Location = new System.Drawing.Point(20, 12);
            this.lblSearchPlaceholder.TabIndex = 28;
            this.lblSearchPlaceholder.Text = "Search by Parcel ID / Student Name / Tracking Number / Vendor Name";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(20, 38);
            this.txtSearch.Size = new System.Drawing.Size(950, 32);
            this.txtSearch.TabIndex = 29;

            this.btnSearch.BackColor = primaryColor;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new System.Drawing.Point(985, 36);
            this.btnSearch.Size = new System.Drawing.Size(155, 36);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.panelSearchTop.Controls.Add(this.lblSearchPlaceholder);
            this.panelSearchTop.Controls.Add(this.txtSearch);
            this.panelSearchTop.Controls.Add(this.btnSearch);
            this.panelSearchContainer.Controls.Add(this.panelSearchTop);

            // DataGridView Parcels
            this.dgvParcels.AllowUserToAddRows = false;
            this.dgvParcels.AllowUserToDeleteRows = false;
            this.dgvParcels.BackgroundColor = cardBg;
            this.dgvParcels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvParcels.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            this.dgvParcels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvParcels.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvParcels.ColumnHeadersHeight = 35;
            this.dgvParcels.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvParcels.DefaultCellStyle.BackColor = Color.White;
            this.dgvParcels.DefaultCellStyle.ForeColor = textDark;
            this.dgvParcels.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            this.dgvParcels.DefaultCellStyle.SelectionForeColor = textDark;
            this.dgvParcels.EnableHeadersVisualStyles = false;
            this.dgvParcels.GridColor = borderColor;
            this.dgvParcels.Location = new System.Drawing.Point(20, 115);
            this.dgvParcels.Name = "dgvParcels";
            this.dgvParcels.RowHeadersVisible = false;
            this.dgvParcels.RowTemplate.Height = 30;
            this.dgvParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcels.Size = new System.Drawing.Size(1160, 420);
            this.dgvParcels.TabIndex = 31;
            this.dgvParcels.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcels_CellEndEdit);
            this.dgvParcels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcels.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            this.panelSearchContainer.Controls.Add(this.dgvParcels);

            // Bottom Buttons Panel
            this.panelSearchButtons.BackColor = mainBg;
            this.panelSearchButtons.Location = new System.Drawing.Point(20, 550);
            this.panelSearchButtons.Size = new System.Drawing.Size(1160, 50);

            this.btnGenerateToken.BackColor = warningColor;
            this.btnGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateToken.FlatAppearance.BorderSize = 0;
            this.btnGenerateToken.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateToken.ForeColor = Color.White;
            this.btnGenerateToken.Location = new System.Drawing.Point(420, 8);
            this.btnGenerateToken.Size = new System.Drawing.Size(180, 40);
            this.btnGenerateToken.TabIndex = 32;
            this.btnGenerateToken.Text = "Generate Token";
            this.btnGenerateToken.UseVisualStyleBackColor = false;
            this.btnGenerateToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateToken.Click += new System.EventHandler(this.btnGenerateToken_Click);

            this.btnMarkCollected.BackColor = successColor;
            this.btnMarkCollected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkCollected.FlatAppearance.BorderSize = 0;
            this.btnMarkCollected.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMarkCollected.ForeColor = Color.White;
            this.btnMarkCollected.Location = new System.Drawing.Point(620, 8);
            this.btnMarkCollected.Size = new System.Drawing.Size(180, 40);
            this.btnMarkCollected.TabIndex = 33;
            this.btnMarkCollected.Text = "Mark Collected";
            this.btnMarkCollected.UseVisualStyleBackColor = false;
            this.btnMarkCollected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkCollected.Click += new System.EventHandler(this.btnMarkCollected_Click);

            this.panelSearchButtons.Controls.Add(this.btnGenerateToken);
            this.panelSearchButtons.Controls.Add(this.btnMarkCollected);
            this.panelSearchContainer.Controls.Add(this.panelSearchButtons);

            // ===== TAB 4 - DASHBOARD =====
            this.tabDashboard.BackColor = mainBg;
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(30);

            this.panelDashboardContainer.BackColor = mainBg;
            this.panelDashboardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDashboard.Controls.Add(this.panelDashboardContainer);

            this.panelDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.panelDashboardTitle.ForeColor = textDark;
            this.panelDashboardTitle.Location = new System.Drawing.Point(30, 20);
            this.panelDashboardTitle.Size = new System.Drawing.Size(300, 40);
            this.panelDashboardTitle.Text = "Dashboard Overview";
            this.panelDashboardContainer.Controls.Add(this.panelDashboardTitle);

            // Total Parcels Card
            this.panelTotalParcels.BackColor = cardBg;
            this.panelTotalParcels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalParcels.Location = new System.Drawing.Point(130, 100);
            this.panelTotalParcels.Size = new System.Drawing.Size(280, 200);
            this.panelTotalIcon.BackColor = Color.FromArgb(37, 99, 235);
            this.panelTotalIcon.Location = new System.Drawing.Point(0, 0);
            this.panelTotalIcon.Size = new System.Drawing.Size(280, 50);
            this.lblTotalIcon.Text = "📦";
            this.lblTotalIcon.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTotalIcon.Location = new System.Drawing.Point(115, 8);
            this.lblTotalIcon.Size = new System.Drawing.Size(50, 40);
            this.lblTotalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelTotalIcon.Controls.Add(this.lblTotalIcon);
            this.panelTotalParcels.Controls.Add(this.panelTotalIcon);
            this.lblTotalParcelsTitle.Text = "Total Parcels";
            this.lblTotalParcelsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalParcelsTitle.ForeColor = textDark;
            this.lblTotalParcelsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalParcelsTitle.Location = new System.Drawing.Point(0, 55);
            this.lblTotalParcelsTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTotalParcelsValue.Text = "0";
            this.lblTotalParcelsValue.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblTotalParcelsValue.ForeColor = primaryColor;
            this.lblTotalParcelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalParcelsValue.Location = new System.Drawing.Point(0, 90);
            this.lblTotalParcelsValue.Size = new System.Drawing.Size(280, 100);
            this.panelTotalParcels.Controls.Add(this.lblTotalParcelsValue);
            this.panelTotalParcels.Controls.Add(this.lblTotalParcelsTitle);
            this.panelDashboardContainer.Controls.Add(this.panelTotalParcels);

            // Pending Parcels Card
            this.panelPendingParcels.BackColor = cardBg;
            this.panelPendingParcels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPendingParcels.Location = new System.Drawing.Point(460, 100);
            this.panelPendingParcels.Size = new System.Drawing.Size(280, 200);
            this.panelPendingIcon.BackColor = Color.FromArgb(245, 158, 11);
            this.panelPendingIcon.Location = new System.Drawing.Point(0, 0);
            this.panelPendingIcon.Size = new System.Drawing.Size(280, 50);
            this.lblPendingIcon.Text = "⏳";
            this.lblPendingIcon.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblPendingIcon.Location = new System.Drawing.Point(115, 8);
            this.lblPendingIcon.Size = new System.Drawing.Size(50, 40);
            this.lblPendingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelPendingIcon.Controls.Add(this.lblPendingIcon);
            this.panelPendingParcels.Controls.Add(this.panelPendingIcon);
            this.lblPendingParcelsTitle.Text = "Pending Parcels";
            this.lblPendingParcelsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPendingParcelsTitle.ForeColor = textDark;
            this.lblPendingParcelsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPendingParcelsTitle.Location = new System.Drawing.Point(0, 55);
            this.lblPendingParcelsTitle.Size = new System.Drawing.Size(280, 30);
            this.lblPendingParcelsValue.Text = "0";
            this.lblPendingParcelsValue.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblPendingParcelsValue.ForeColor = warningColor;
            this.lblPendingParcelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPendingParcelsValue.Location = new System.Drawing.Point(0, 90);
            this.lblPendingParcelsValue.Size = new System.Drawing.Size(280, 100);
            this.panelPendingParcels.Controls.Add(this.lblPendingParcelsValue);
            this.panelPendingParcels.Controls.Add(this.lblPendingParcelsTitle);
            this.panelDashboardContainer.Controls.Add(this.panelPendingParcels);

            // Collected Parcels Card
            this.panelCollectedParcels.BackColor = cardBg;
            this.panelCollectedParcels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCollectedParcels.Location = new System.Drawing.Point(790, 100);
            this.panelCollectedParcels.Size = new System.Drawing.Size(280, 200);
            this.panelCollectedIcon.BackColor = Color.FromArgb(22, 163, 74);
            this.panelCollectedIcon.Location = new System.Drawing.Point(0, 0);
            this.panelCollectedIcon.Size = new System.Drawing.Size(280, 50);
            this.lblCollectedIcon.Text = "✓";
            this.lblCollectedIcon.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblCollectedIcon.Location = new System.Drawing.Point(115, 8);
            this.lblCollectedIcon.Size = new System.Drawing.Size(50, 40);
            this.lblCollectedIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelCollectedIcon.Controls.Add(this.lblCollectedIcon);
            this.panelCollectedParcels.Controls.Add(this.panelCollectedIcon);
            this.lblCollectedParcelsTitle.Text = "Collected Parcels";
            this.lblCollectedParcelsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCollectedParcelsTitle.ForeColor = textDark;
            this.lblCollectedParcelsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCollectedParcelsTitle.Location = new System.Drawing.Point(0, 55);
            this.lblCollectedParcelsTitle.Size = new System.Drawing.Size(280, 30);
            this.lblCollectedParcelsValue.Text = "0";
            this.lblCollectedParcelsValue.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblCollectedParcelsValue.ForeColor = successColor;
            this.lblCollectedParcelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCollectedParcelsValue.Location = new System.Drawing.Point(0, 90);
            this.lblCollectedParcelsValue.Size = new System.Drawing.Size(280, 100);
            this.panelCollectedParcels.Controls.Add(this.lblCollectedParcelsValue);
            this.panelCollectedParcels.Controls.Add(this.lblCollectedParcelsTitle);
            this.panelDashboardContainer.Controls.Add(this.panelCollectedParcels);

            // ===== FORM =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Parcel Office Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.panelStudentTop.ResumeLayout(false);
            this.panelSchool.ResumeLayout(false);
            this.panelSchool.PerformLayout();
            this.panelDepartment.ResumeLayout(false);
            this.panelDepartment.PerformLayout();
            this.panelCourse.ResumeLayout(false);
            this.panelCourse.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panelStudentButtons.ResumeLayout(false);
            this.panelStudentButtons.PerformLayout();
            this.tabParcel.ResumeLayout(false);
            this.panelParcelContainer.ResumeLayout(false);
            this.panelParcelSearch.ResumeLayout(false);
            this.panelParcelSearch.PerformLayout();
            this.groupBoxStudentDetails.ResumeLayout(false);
            this.groupBoxStudentDetails.PerformLayout();
            this.groupBoxParcelDetails.ResumeLayout(false);
            this.groupBoxParcelDetails.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchTop.ResumeLayout(false);
            this.panelSearchTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcels)).EndInit();
            this.panelSearchButtons.ResumeLayout(false);
            this.panelSearchButtons.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.panelDashboardContainer.ResumeLayout(false);
            this.panelTotalParcels.ResumeLayout(false);
            this.panelPendingParcels.ResumeLayout(false);
            this.panelCollectedParcels.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabControl tabControl = sender as TabControl;
            
            if (e.Index >= tabControl.TabPages.Count) return;
            
            string tabName = tabControl.TabPages[e.Index].Text;
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);
            
            if (string.IsNullOrEmpty(tabName)) return;

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color primaryColor = Color.FromArgb(37, 99, 235);
            Color textDark = Color.FromArgb(30, 41, 59);
            Color borderColor = Color.FromArgb(203, 213, 225);
            Color lightBg = Color.FromArgb(248, 250, 252);

            int cornerRadius = 6;
            
            if (isSelected)
            {
                using (SolidBrush brush = new SolidBrush(primaryColor))
                {
                    FillRoundedRectangle(g, brush, tabBounds.X + 2, tabBounds.Y + 2, tabBounds.Width - 4, tabBounds.Height - 2, cornerRadius);
                }
                
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    Font boldFont = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                    SizeF textSize = g.MeasureString(tabName, boldFont);
                    float xPos = tabBounds.X + (tabBounds.Width - textSize.Width) / 2;
                    float yPos = tabBounds.Y + (tabBounds.Height - textSize.Height) / 2 + 2;
                    g.DrawString(tabName, boldFont, brush, xPos, yPos);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(lightBg))
                {
                    FillRoundedRectangle(g, brush, tabBounds.X + 2, tabBounds.Y + 2, tabBounds.Width - 4, tabBounds.Height - 2, cornerRadius);
                }
                
                using (SolidBrush brush = new SolidBrush(textDark))
                {
                    Font regularFont = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
                    SizeF textSize = g.MeasureString(tabName, regularFont);
                    float xPos = tabBounds.X + (tabBounds.Width - textSize.Width) / 2;
                    float yPos = tabBounds.Y + (tabBounds.Height - textSize.Height) / 2 + 2;
                    g.DrawString(tabName, regularFont, brush, xPos, yPos);
                }
                
                using (Pen pen = new Pen(borderColor))
                {
                    g.DrawRectangle(pen, tabBounds.X + 2, tabBounds.Y + 2, tabBounds.Width - 4, tabBounds.Height - 2);
                }
            }
        }

        private void FillRoundedRectangle(Graphics g, SolidBrush brush, float x, float y, float width, float height, int radius)
        {
            RectangleF rect = new RectangleF(x, y, width, height);
            using (GraphicsPath path = GetRoundedRectPath(rect, radius))
            {
                g.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundedRectPath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Dashboard Labels
        private System.Windows.Forms.Label lblTotalParcelsTitle;
        private System.Windows.Forms.Label lblPendingParcelsTitle;
        private System.Windows.Forms.Label lblCollectedParcelsTitle;
        private System.Windows.Forms.Label lblTotalParcelsValue;
        private System.Windows.Forms.Label lblPendingParcelsValue;
        private System.Windows.Forms.Label lblCollectedParcelsValue;
        private System.Windows.Forms.Label lblTotalIcon;
        private System.Windows.Forms.Label lblPendingIcon;
        private System.Windows.Forms.Label lblCollectedIcon;

        // Panels
        private System.Windows.Forms.Panel panelStudentTop;
        private System.Windows.Forms.Panel panelSchool;
        private System.Windows.Forms.Panel panelDepartment;
        private System.Windows.Forms.Panel panelCourse;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panelStudentButtons;
        private System.Windows.Forms.Panel panelParcelContainer;
        private System.Windows.Forms.Panel panelParcelSearch;
        private System.Windows.Forms.Panel panelSearchContainer;
        private System.Windows.Forms.Panel panelSearchTop;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Panel panelDashboardContainer;
        private System.Windows.Forms.Label panelDashboardTitle;
        private System.Windows.Forms.Panel panelTotalParcels;
        private System.Windows.Forms.Panel panelPendingParcels;
        private System.Windows.Forms.Panel panelCollectedParcels;
        private System.Windows.Forms.Panel panelTotalIcon;
        private System.Windows.Forms.Panel panelPendingIcon;
        private System.Windows.Forms.Panel panelCollectedIcon;

        // Title Labels
        private System.Windows.Forms.Label lblSchoolTitle;
        private System.Windows.Forms.Label lblDepartmentTitle;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblStudentTitle;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabParcel;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabDashboard;

        // Tab 1 controls
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Button btnAddStudent;

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblJsonInfo;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnBulkUpload;

        // Tab 2 controls
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
    }
}