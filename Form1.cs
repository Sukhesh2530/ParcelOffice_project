using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ParcelOffice_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            SetupPlaceholders();
            LoadSchools();
            LoadDepartments();
            LoadCourses();
            LoadStudents();
            LoadParcelComboBoxes();
            UpdateDashboard();
        }

        private void SetupPlaceholders()
        {
            // Set placeholder text for TextBoxes
            SetPlaceholder(txtSchoolName, "Enter School Name (e.g., School of Science)");
            SetPlaceholder(txtDepartmentName, "Enter Department Name (e.g., Computer Science)");
            SetPlaceholder(txtCourseName, "Enter Course Name (e.g., BCA, MBA)");
            SetPlaceholder(txtStudentName, "Enter Student Full Name");
            SetPlaceholder(txtStudentEmail, "Enter Email (e.g., student@gmail.com)");
            SetPlaceholder(txtStudentPhone, "Enter Phone Number (10 digits)");
            SetPlaceholder(txtTrackingNumber, "Enter Tracking Number (e.g., AW123456789IN)");
            SetPlaceholder(txtVendorName, "Enter courier/vendor name...");
            SetPlaceholder(txtSearch, "Search by Parcel ID / Student Name / Tracking Number / Vendor Name");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabSearch)
            {
                LoadParcels();
            }
            if (tabControl1.SelectedTab == tabDashboard)
            {
                UpdateDashboard();
            }
        }

        // ==================== TAB 1: STUDENT MANAGEMENT ====================

        #region Load Data Methods

        private void LoadSchools()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT SchoolId, SchoolName FROM Schools ORDER BY SchoolName");
                cmbSchool.DataSource = dt;
                cmbSchool.DisplayMember = "SchoolName";
                cmbSchool.ValueMember = "SchoolId";
                cmbSchool.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schools: " + ex.Message);
            }
        }

        private void LoadDepartments(int? schoolId = null)
        {
            try
            {
                DataTable dt;
                if (schoolId.HasValue && schoolId > 0)
                {
                    dt = DatabaseHelper.ExecuteQuery("SELECT DepartmentId, DepartmentName FROM Departments WHERE SchoolId = @schoolId ORDER BY DepartmentName",
                        new SqlParameter("@schoolId", schoolId));
                }
                else
                {
                    dt = DatabaseHelper.ExecuteQuery("SELECT DepartmentId, DepartmentName FROM Departments ORDER BY DepartmentName");
                }

                cmbDepartment.DataSource = dt;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentId";
                cmbDepartment.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }

        private void LoadCourses(int? deptId = null)
        {
            try
            {
                DataTable dt;
                if (deptId.HasValue && deptId > 0)
                {
                    dt = DatabaseHelper.ExecuteQuery("SELECT CourseId, CourseName FROM Courses WHERE DepartmentId = @deptId ORDER BY CourseName",
                        new SqlParameter("@deptId", deptId));
                }
                else
                {
                    dt = DatabaseHelper.ExecuteQuery("SELECT CourseId, CourseName FROM Courses ORDER BY CourseName");
                }

                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "CourseId";
                cmbCourse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                string query = @"
                    SELECT s.StudentId, s.StudentName, s.StudentEmail, s.StudentPhone, 
                           c.CourseName, d.DepartmentName, sc.SchoolName
                    FROM Students s
                    JOIN Courses c ON s.CourseId = c.CourseId
                    JOIN Departments d ON c.DepartmentId = d.DepartmentId
                    JOIN Schools sc ON d.SchoolId = sc.SchoolId
                    ORDER BY s.StudentName";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvStudents.DataSource = dt;

                // Configure columns
                if (dgvStudents.Columns.Count > 0)
                {
                    dgvStudents.Columns["StudentId"].Visible = false;
                    dgvStudents.Columns["StudentName"].HeaderText = "Student Name";
                    dgvStudents.Columns["StudentEmail"].HeaderText = "Email";
                    dgvStudents.Columns["StudentPhone"].HeaderText = "Phone";
                    dgvStudents.Columns["CourseName"].HeaderText = "Course";
                    dgvStudents.Columns["DepartmentName"].HeaderText = "Department";
                    dgvStudents.Columns["SchoolName"].HeaderText = "School";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void LoadParcelComboBoxes(int? schoolId = null, int? deptId = null, int? courseId = null)
        {
            try
            {
                // Load all students with their details for searchable ComboBox
                string query = @"
                    SELECT s.StudentId, s.StudentName, s.StudentEmail, s.StudentPhone, 
                           c.CourseName, d.DepartmentName, sc.SchoolName
                    FROM Students s
                    JOIN Courses c ON s.CourseId = c.CourseId
                    JOIN Departments d ON c.DepartmentId = d.DepartmentId
                    JOIN Schools sc ON d.SchoolId = sc.SchoolId
                    ORDER BY s.StudentName";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                // Create a list to hold display format for ComboBox
                List<StudentInfo> studentList = new List<StudentInfo>();
                foreach (DataRow row in dt.Rows)
                {
                    studentList.Add(new StudentInfo
                    {
                        StudentId = Convert.ToInt32(row["StudentId"]),
                        DisplayText = $"{row["StudentName"]} ({row["StudentEmail"]})",
                        StudentName = row["StudentName"].ToString(),
                        StudentEmail = row["StudentEmail"].ToString(),
                        StudentPhone = row["StudentPhone"].ToString(),
                        CourseName = row["CourseName"].ToString(),
                        DepartmentName = row["DepartmentName"].ToString(),
                        SchoolName = row["SchoolName"].ToString()
                    });
                }

                cmbStudentSearch.DataSource = studentList;
                cmbStudentSearch.DisplayMember = "DisplayText";
                cmbStudentSearch.ValueMember = "StudentId";
                cmbStudentSearch.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student search: " + ex.Message);
            }
        }

        // Helper class to hold student information
        private class StudentInfo
        {
            public int StudentId { get; set; }
            public string DisplayText { get; set; }
            public string StudentName { get; set; }
            public string StudentEmail { get; set; }
            public string StudentPhone { get; set; }
            public string CourseName { get; set; }
            public string DepartmentName { get; set; }
            public string SchoolName { get; set; }
        }

        #endregion

        #region Add Methods

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            string schoolName = txtSchoolName.Text.Trim();

            if (string.IsNullOrWhiteSpace(schoolName) || schoolName == txtSchoolName.Tag.ToString())
            {
                MessageBox.Show("Please enter a school name.");
                return;
            }

            try
            {
                // Check for duplicate
                object existing = DatabaseHelper.ExecuteScalar("SELECT SchoolId FROM Schools WHERE SchoolName = @name",
                    new SqlParameter("@name", schoolName));

                if (existing != null)
                {
                    MessageBox.Show("This school already exists.");
                    return;
                }

                string query = "INSERT INTO Schools (SchoolName) VALUES (@name)";
                DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@name", schoolName));

                MessageBox.Show("School added successfully!");
                txtSchoolName.Text = txtSchoolName.Tag.ToString();
                txtSchoolName.ForeColor = System.Drawing.Color.Gray;
                LoadSchools();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding school: " + ex.Message);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string deptName = txtDepartmentName.Text.Trim();

            if (cmbSchool.SelectedValue == null || string.IsNullOrWhiteSpace(deptName) || deptName == txtDepartmentName.Tag.ToString())
            {
                MessageBox.Show("Please select a school and enter a department name.");
                return;
            }

            try
            {
                int schoolId = Convert.ToInt32(cmbSchool.SelectedValue);

                // Check for duplicate
                object existing = DatabaseHelper.ExecuteScalar("SELECT DepartmentId FROM Departments WHERE SchoolId = @schoolId AND DepartmentName = @name",
                    new SqlParameter("@schoolId", schoolId),
                    new SqlParameter("@name", deptName));

                if (existing != null)
                {
                    MessageBox.Show("This department already exists in the selected school.");
                    return;
                }

                string query = "INSERT INTO Departments (SchoolId, DepartmentName) VALUES (@schoolId, @name)";
                DatabaseHelper.ExecuteNonQuery(query,
                    new SqlParameter("@schoolId", schoolId),
                    new SqlParameter("@name", deptName));

                MessageBox.Show("Department added successfully!");
                txtDepartmentName.Text = txtDepartmentName.Tag.ToString();
                txtDepartmentName.ForeColor = System.Drawing.Color.Gray;
                LoadDepartments(schoolId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text.Trim();

            if (cmbDepartment.SelectedValue == null || string.IsNullOrWhiteSpace(courseName) || courseName == txtCourseName.Tag.ToString())
            {
                MessageBox.Show("Please select a department and enter a course name.");
                return;
            }

            try
            {
                int deptId = Convert.ToInt32(cmbDepartment.SelectedValue);

                // Check for duplicate
                object existing = DatabaseHelper.ExecuteScalar("SELECT CourseId FROM Courses WHERE DepartmentId = @deptId AND CourseName = @name",
                    new SqlParameter("@deptId", deptId),
                    new SqlParameter("@name", courseName));

                if (existing != null)
                {
                    MessageBox.Show("This course already exists in the selected department.");
                    return;
                }

                string query = "INSERT INTO Courses (DepartmentId, CourseName) VALUES (@deptId, @name)";
                DatabaseHelper.ExecuteNonQuery(query,
                    new SqlParameter("@deptId", deptId),
                    new SqlParameter("@name", courseName));

                MessageBox.Show("Course added successfully!");
                txtCourseName.Text = txtCourseName.Tag.ToString();
                txtCourseName.ForeColor = System.Drawing.Color.Gray;
                LoadCourses(deptId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string studentEmail = txtStudentEmail.Text.Trim();
            string studentPhone = txtStudentPhone.Text.Trim();

            if (cmbCourse.SelectedValue == null || string.IsNullOrWhiteSpace(studentName) ||
                string.IsNullOrWhiteSpace(studentEmail) || string.IsNullOrWhiteSpace(studentPhone) ||
                studentName == txtStudentName.Tag.ToString() || studentEmail == txtStudentEmail.Tag.ToString() ||
                studentPhone == txtStudentPhone.Tag.ToString())
            {
                MessageBox.Show("Please fill all fields: Select course, enter name, email, and phone.");
                return;
            }

            if (studentPhone.Length != 10 || !studentPhone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                return;
            }

            if (!studentEmail.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            try
            {
                // Check for duplicate email
                object existing = DatabaseHelper.ExecuteScalar("SELECT StudentId FROM Students WHERE StudentEmail = @email",
                    new SqlParameter("@email", studentEmail));

                if (existing != null)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }

                string query = "INSERT INTO Students (StudentName, StudentEmail, StudentPhone, CourseId) VALUES (@name, @email, @phone, @courseId)";
                DatabaseHelper.ExecuteNonQuery(query,
                    new SqlParameter("@name", studentName),
                    new SqlParameter("@email", studentEmail),
                    new SqlParameter("@phone", studentPhone),
                    new SqlParameter("@courseId", Convert.ToInt32(cmbCourse.SelectedValue)));

                MessageBox.Show("Student added successfully!");
                txtStudentName.Text = txtStudentName.Tag.ToString();
                txtStudentEmail.Text = txtStudentEmail.Tag.ToString();
                txtStudentPhone.Text = txtStudentPhone.Tag.ToString();
                txtStudentName.ForeColor = System.Drawing.Color.Gray;
                txtStudentEmail.ForeColor = System.Drawing.Color.Gray;
                txtStudentPhone.ForeColor = System.Drawing.Color.Gray;
                LoadStudents();
                LoadParcelComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }

        #endregion

        #region Update and Delete Methods

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            try
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentId"].Value);
                string name = dgvStudents.SelectedRows[0].Cells["StudentName"].Value.ToString();
                string email = dgvStudents.SelectedRows[0].Cells["StudentEmail"].Value.ToString();
                string phone = dgvStudents.SelectedRows[0].Cells["StudentPhone"].Value.ToString();

                // Create an update form
                Form updateForm = new Form()
                {
                    Text = "Update Student",
                    Width = 400,
                    Height = 300,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                Label lblName = new Label() { Text = "Name:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
                TextBox txtName = new TextBox() { Text = name, Location = new System.Drawing.Point(20, 45), Width = 350 };

                Label lblEmail = new Label() { Text = "Email:", Location = new System.Drawing.Point(20, 80), AutoSize = true };
                TextBox txtEmail = new TextBox() { Text = email, Location = new System.Drawing.Point(20, 105), Width = 350 };

                Label lblPhone = new Label() { Text = "Phone:", Location = new System.Drawing.Point(20, 140), AutoSize = true };
                TextBox txtPhone = new TextBox() { Text = phone, Location = new System.Drawing.Point(20, 165), Width = 350 };

                Button btnSave = new Button() { Text = "Save", Location = new System.Drawing.Point(250, 210), Width = 120, DialogResult = DialogResult.OK };
                Button btnCancel = new Button() { Text = "Cancel", Location = new System.Drawing.Point(20, 210), Width = 120, DialogResult = DialogResult.Cancel };

                updateForm.Controls.Add(lblName);
                updateForm.Controls.Add(txtName);
                updateForm.Controls.Add(lblEmail);
                updateForm.Controls.Add(txtEmail);
                updateForm.Controls.Add(lblPhone);
                updateForm.Controls.Add(txtPhone);
                updateForm.Controls.Add(btnSave);
                updateForm.Controls.Add(btnCancel);
                updateForm.AcceptButton = btnSave;
                updateForm.CancelButton = btnCancel;

                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                    {
                        MessageBox.Show("All fields are required.");
                        return;
                    }

                    if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Phone number must be exactly 10 digits.");
                        return;
                    }

                    if (!txtEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }

                    // Check for duplicate email (excluding current student)
                    object existingEmail = DatabaseHelper.ExecuteScalar("SELECT StudentId FROM Students WHERE StudentEmail = @email AND StudentId != @id",
                        new SqlParameter("@email", txtEmail.Text),
                        new SqlParameter("@id", studentId));

                    if (existingEmail != null)
                    {
                        MessageBox.Show("This email is already registered to another student.");
                        return;
                    }

                    string query = "UPDATE Students SET StudentName = @name, StudentEmail = @email, StudentPhone = @phone WHERE StudentId = @id";
                    DatabaseHelper.ExecuteNonQuery(query,
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@email", txtEmail.Text),
                        new SqlParameter("@phone", txtPhone.Text),
                        new SqlParameter("@id", studentId));

                    MessageBox.Show("Student updated successfully!");
                    LoadStudents();
                    LoadParcelComboBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string studentName = dgvStudents.SelectedRows[0].Cells["StudentName"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {studentName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentId"].Value);

                string query = "DELETE FROM Students WHERE StudentId = @id";
                DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@id", studentId));

                MessageBox.Show("Student deleted successfully!");
                LoadStudents();
                LoadParcelComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }

        #endregion

        #region Combo Box Events

        private void cmbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSchool.SelectedValue != null && cmbSchool.SelectedValue is int)
            {
                int schoolId = Convert.ToInt32(cmbSchool.SelectedValue);
                LoadDepartments(schoolId);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue != null && cmbDepartment.SelectedValue is int)
            {
                int deptId = Convert.ToInt32(cmbDepartment.SelectedValue);
                LoadCourses(deptId);
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event can be used for future enhancements
        }

        #endregion

        #region Bulk Upload

        private void btnBulkUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON files (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(ofd.FileName);
                        ProcessJsonUpload(jsonContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
            }
        }

        private void ProcessJsonUpload(string jsonContent)
        {
            try
            {
                // Simple manual JSON parsing for .NET Framework 4.7.2 compatibility
                jsonContent = jsonContent.Trim();
                if (!jsonContent.StartsWith("[") || !jsonContent.EndsWith("]"))
                {
                    MessageBox.Show("JSON format must be an array of schools.");
                    return;
                }

                int schoolsAdded = 0, deptsAdded = 0, coursesAdded = 0, studentsAdded = 0;

                // Split schools by the pattern: {"School":...}
                string content = jsonContent.Substring(1, jsonContent.Length - 2);
                List<string> schoolObjects = SplitJsonObjects(content);

                foreach (string schoolObj in schoolObjects)
                {
                    string schoolName = ExtractJsonValue(schoolObj, "School");
                    if (string.IsNullOrWhiteSpace(schoolName))
                        continue;

                    int schoolId = EnsureSchoolExists(schoolName);
                    if (schoolId > 0) schoolsAdded++;

                    // Extract Departments array
                    string deptsArray = ExtractJsonArray(schoolObj, "Departments");
                    if (string.IsNullOrWhiteSpace(deptsArray))
                        continue;

                    List<string> deptObjects = SplitJsonObjects(deptsArray);
                    foreach (string deptObj in deptObjects)
                    {
                        string deptName = ExtractJsonValue(deptObj, "DepartmentName");
                        if (string.IsNullOrWhiteSpace(deptName))
                            continue;

                        int deptId = EnsureDepartmentExists(schoolId, deptName);
                        if (deptId > 0) deptsAdded++;

                        // Extract Courses array
                        string coursesArray = ExtractJsonArray(deptObj, "Courses");
                        if (string.IsNullOrWhiteSpace(coursesArray))
                            continue;

                        List<string> courseObjects = SplitJsonObjects(coursesArray);
                        foreach (string courseObj in courseObjects)
                        {
                            string courseName = ExtractJsonValue(courseObj, "CourseName");
                            if (string.IsNullOrWhiteSpace(courseName))
                                continue;

                            int courseId = EnsureCourseExists(deptId, courseName);
                            if (courseId > 0) coursesAdded++;

                            // Extract Students array
                            string studentsArray = ExtractJsonArray(courseObj, "Students");
                            if (string.IsNullOrWhiteSpace(studentsArray))
                                continue;

                            List<string> studentObjects = SplitJsonObjects(studentsArray);
                            foreach (string studentObj in studentObjects)
                            {
                                string studentName = ExtractJsonValue(studentObj, "Name");
                                string studentEmail = ExtractJsonValue(studentObj, "Email");
                                string studentPhone = ExtractJsonValue(studentObj, "Phone");

                                if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentEmail) || string.IsNullOrWhiteSpace(studentPhone))
                                    continue;

                                // Validate email format
                                if (!studentEmail.Contains("@"))
                                    continue;

                                // Validate phone (10 digits)
                                if (studentPhone.Length != 10 || !studentPhone.All(char.IsDigit))
                                    continue;

                                // Check if student email already exists
                                object existingStudent = DatabaseHelper.ExecuteScalar("SELECT StudentId FROM Students WHERE StudentEmail = @email",
                                    new SqlParameter("@email", studentEmail));

                                if (existingStudent == null)
                                {
                                    try
                                    {
                                        string query = "INSERT INTO Students (StudentName, StudentEmail, StudentPhone, CourseId) VALUES (@name, @email, @phone, @courseId)";
                                        DatabaseHelper.ExecuteNonQuery(query,
                                            new SqlParameter("@name", studentName),
                                            new SqlParameter("@email", studentEmail),
                                            new SqlParameter("@phone", studentPhone),
                                            new SqlParameter("@courseId", courseId));
                                        studentsAdded++;
                                    }
                                    catch { /* Skip duplicate emails */ }
                                }
                            }
                        }
                    }
                }

                LoadSchools();
                LoadDepartments();
                LoadCourses();
                LoadStudents();
                LoadParcelComboBoxes();

                MessageBox.Show($"Bulk upload completed!\n\nSchools: {schoolsAdded}\nDepartments: {deptsAdded}\nCourses: {coursesAdded}\nStudents: {studentsAdded}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing JSON: " + ex.Message);
            }
        }

        private string ExtractJsonValue(string json, string key)
        {
            try
            {
                string pattern = "\"" + key + "\"\\s*:\\s*\"([^\"]*)\"";
                System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(json, pattern);
                return match.Success ? match.Groups[1].Value : null;
            }
            catch
            {
                return null;
            }
        }

        private string ExtractJsonArray(string json, string arrayName)
        {
            try
            {
                int startIndex = json.IndexOf("\"" + arrayName + "\"");
                if (startIndex == -1)
                    return null;

                startIndex = json.IndexOf("[", startIndex);
                if (startIndex == -1)
                    return null;

                int bracketCount = 1;
                int endIndex = startIndex + 1;
                while (endIndex < json.Length && bracketCount > 0)
                {
                    if (json[endIndex] == '[')
                        bracketCount++;
                    else if (json[endIndex] == ']')
                        bracketCount--;
                    endIndex++;
                }

                return json.Substring(startIndex + 1, endIndex - startIndex - 2);
            }
            catch
            {
                return null;
            }
        }

        private List<string> SplitJsonObjects(string arrayContent)
        {
            List<string> objects = new List<string>();
            try
            {
                int braceCount = 0;
                int startIndex = 0;
                bool inString = false;

                for (int i = 0; i < arrayContent.Length; i++)
                {
                    if (arrayContent[i] == '"' && (i == 0 || arrayContent[i - 1] != '\\'))
                        inString = !inString;

                    if (!inString)
                    {
                        if (arrayContent[i] == '{')
                        {
                            if (braceCount == 0)
                                startIndex = i;
                            braceCount++;
                        }
                        else if (arrayContent[i] == '}')
                        {
                            braceCount--;
                            if (braceCount == 0)
                                objects.Add(arrayContent.Substring(startIndex, i - startIndex + 1));
                        }
                    }
                }
            }
            catch { }

            return objects;
        }

        private int EnsureSchoolExists(string schoolName)
        {
            try
            {
                object schoolId = DatabaseHelper.ExecuteScalar("SELECT SchoolId FROM Schools WHERE SchoolName = @name",
                    new SqlParameter("@name", schoolName));

                if (schoolId != null)
                    return Convert.ToInt32(schoolId);

                object newId = DatabaseHelper.ExecuteScalar("INSERT INTO Schools (SchoolName) OUTPUT INSERTED.SchoolId VALUES (@name)",
                    new SqlParameter("@name", schoolName));

                return newId != null ? Convert.ToInt32(newId) : 0;
            }
            catch
            {
                return 0;
            }
        }

        private int EnsureDepartmentExists(int schoolId, string deptName)
        {
            try
            {
                object deptId = DatabaseHelper.ExecuteScalar("SELECT DepartmentId FROM Departments WHERE SchoolId = @schoolId AND DepartmentName = @name",
                    new SqlParameter("@schoolId", schoolId),
                    new SqlParameter("@name", deptName));

                if (deptId != null)
                    return Convert.ToInt32(deptId);

                object newId = DatabaseHelper.ExecuteScalar("INSERT INTO Departments (SchoolId, DepartmentName) OUTPUT INSERTED.DepartmentId VALUES (@schoolId, @name)",
                    new SqlParameter("@schoolId", schoolId),
                    new SqlParameter("@name", deptName));

                return newId != null ? Convert.ToInt32(newId) : 0;
            }
            catch
            {
                return 0;
            }
        }

        private int EnsureCourseExists(int deptId, string courseName)
        {
            try
            {
                object courseId = DatabaseHelper.ExecuteScalar("SELECT CourseId FROM Courses WHERE DepartmentId = @deptId AND CourseName = @name",
                    new SqlParameter("@deptId", deptId),
                    new SqlParameter("@name", courseName));

                if (courseId != null)
                    return Convert.ToInt32(courseId);

                object newId = DatabaseHelper.ExecuteScalar("INSERT INTO Courses (DepartmentId, CourseName) OUTPUT INSERTED.CourseId VALUES (@deptId, @name)",
                    new SqlParameter("@deptId", deptId),
                    new SqlParameter("@name", courseName));

                return newId != null ? Convert.ToInt32(newId) : 0;
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        // ==================== TAB 2: PARCEL ENTRY ====================

        // ==================== TAB 2: PARCEL ENTRY ====================

        private void cmbStudentSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentSearch.SelectedItem is StudentInfo student)
            {
                try
                {
                    // Auto-fill all student details
                    txtName.Text = student.StudentName;
                    txtEmail.Text = student.StudentEmail;
                    txtPhone.Text = student.StudentPhone;
                    txtSchool.Text = student.SchoolName;
                    txtDepartment.Text = student.DepartmentName;
                    txtCourse.Text = student.CourseName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
            else
            {
                // Clear all fields if no student is selected
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtSchool.Clear();
                txtDepartment.Clear();
                txtCourse.Clear();
            }
        }

        // OLD PARCEL HANDLERS - DEPRECATED (replaced by cmbStudentSearch_SelectedIndexChanged)
        // These are kept for reference but are no longer used with the new UI
        /*
        private void cbParcelSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParcelSchool.SelectedValue is int schoolId && schoolId > 0)
            {
                LoadParcelComboBoxes(schoolId: schoolId);
            }
        }

        private void cbParcelDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParcelDepartment.SelectedValue is int deptId && deptId > 0 && cbParcelSchool.SelectedValue is int schoolId)
            {
                LoadParcelComboBoxes(schoolId: schoolId, deptId: deptId);
            }
        }

        private void cbParcelCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParcelCourse.SelectedValue is int courseId && courseId > 0)
            {
                LoadParcelComboBoxes(
                    schoolId: cbParcelSchool.SelectedValue is int ? Convert.ToInt32(cbParcelSchool.SelectedValue) : 0,
                    deptId: cbParcelDepartment.SelectedValue is int ? Convert.ToInt32(cbParcelDepartment.SelectedValue) : 0,
                    courseId: courseId);
            }
        }

        private void cbParcelStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParcelStudent.SelectedValue is int studentId && studentId > 0)
            {
                try
                {
                    DataTable dt = DatabaseHelper.ExecuteQuery("SELECT StudentEmail, StudentPhone FROM Students WHERE StudentId = @id",
                        new SqlParameter("@id", studentId));

                    if (dt.Rows.Count > 0)
                    {
                        txtParcelEmail.Text = dt.Rows[0]["StudentEmail"].ToString();
                        txtParcelPhone.Text = dt.Rows[0]["StudentPhone"].ToString();
                    }
                }
                catch { }
            }
        }
        */

        private void btnSaveParcel_Click(object sender, EventArgs e)
        {
            string trackingNumber = txtTrackingNumber.Text.Trim();
            string vendorName = txtVendorName.Text.Trim();

            if (vendorName == txtVendorName.Tag.ToString())
                vendorName = string.Empty;

            // Validate student selection
            if (cmbStudentSearch.SelectedItem == null || !(cmbStudentSearch.SelectedItem is StudentInfo))
            {
                MessageBox.Show("Please select a student from the search list.");
                return;
            }

            if (string.IsNullOrWhiteSpace(trackingNumber))
            {
                MessageBox.Show("Please enter a tracking number.");
                return;
            }

            try
            {
                StudentInfo student = cmbStudentSearch.SelectedItem as StudentInfo;
                int studentId = student.StudentId;
                string studentEmail = student.StudentEmail;
                string studentName = student.StudentName;

                string query = "INSERT INTO Parcels (StudentId, TrackingNumber, VendorName, ArrivalTime, Status) VALUES (@sid, @track, @vendorName, @arrival, @status)";
                DatabaseHelper.ExecuteNonQuery(query,
                    new SqlParameter("@sid", studentId),
                    new SqlParameter("@track", trackingNumber),
                    new SqlParameter("@vendorName", string.IsNullOrWhiteSpace(vendorName) ? (object)DBNull.Value : vendorName),
                    new SqlParameter("@arrival", DateTime.Now),
                    new SqlParameter("@status", "Pending"));

                // Get the newly inserted parcel ID
                int newParcelId = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT MAX(ParcelId) FROM Parcels WHERE StudentId = @sid AND TrackingNumber = @track",
                    new SqlParameter("@sid", studentId),
                    new SqlParameter("@track", trackingNumber)));

                // Auto-generate token and get collection time
                int tokenNumber = 0;
                string collectionTimeSlot = "";
                
                var slot = TimetableHelper.GetNextAvailableSlot(studentId);
                if (slot != null)
                {
                    DateTime slotStartTime = slot.Value.SlotStart;
                    DateTime slotEndTime = slot.Value.SlotEnd;

                    TimetableHelper.ScheduleType scheduleType = TimetableHelper.GetStudentScheduleType(studentId);
                    string slotName = TimetableHelper.GetSlotName(slotStartTime, slotEndTime, scheduleType);

                    object maxToken = DatabaseHelper.ExecuteScalar("SELECT MAX(TokenNumber) FROM Tokens WHERE CONVERT(date, SlotEndTime) = CONVERT(date, @slotDate)",
                        new SqlParameter("@slotDate", slotEndTime));

                    tokenNumber = (maxToken == DBNull.Value || maxToken == null) ? 1 : Convert.ToInt32(maxToken) + 1;

                    string tokenQuery = "INSERT INTO Tokens (ParcelId, TokenNumber, SlotStartTime, SlotEndTime, Status) VALUES (@pid, @tno, @start, @end, @status)";
                    DatabaseHelper.ExecuteNonQuery(tokenQuery,
                        new SqlParameter("@pid", newParcelId),
                        new SqlParameter("@tno", tokenNumber),
                        new SqlParameter("@start", slotStartTime),
                        new SqlParameter("@end", slotEndTime),
                        new SqlParameter("@status", "Active"));

                    collectionTimeSlot = TimetableHelper.FormatSlotTime(slotStartTime, slotEndTime) + $" ({slotName})";
                }

                // Send email with token and collection time
                EmailHelper.SendNotification(studentEmail, trackingNumber, vendorName, studentName, tokenNumber, collectionTimeSlot);

                string successMessage = "Parcel saved successfully!";
                if (tokenNumber > 0)
                {
                    successMessage += $"\n\nToken #{tokenNumber} generated automatically.\nCollection Time: {collectionTimeSlot}";
                }
                MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the parcels grid in Search tab
                LoadParcels();

                // Clear all fields
                cmbStudentSearch.SelectedIndex = -1;
                txtTrackingNumber.Clear();
                txtVendorName.Text = txtVendorName.Tag.ToString();
                txtVendorName.ForeColor = System.Drawing.Color.Gray;
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtSchool.Clear();
                txtDepartment.Clear();
                txtCourse.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving parcel: " + ex.Message);
            }
        }

        // ==================== TAB 3: SEARCH & MANAGE ====================

        private void LoadParcels(string search = "")
        {
            try
            {
                string query = @"
                    SELECT p.ParcelId, s.StudentName, p.TrackingNumber, p.VendorName, p.Status, p.ArrivalTime, p.CollectedBy 
                    FROM Parcels p 
                    JOIN Students s ON p.StudentId = s.StudentId
                    WHERE s.StudentName LIKE @search OR p.TrackingNumber LIKE @search OR p.VendorName LIKE @search OR CAST(p.ParcelId AS VARCHAR) LIKE @search
                    ORDER BY p.ArrivalTime DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@search", "%" + search + "%"));
                dgvParcels.DataSource = dt;

                if (dgvParcels.Columns.Count > 0)
                {
                    dgvParcels.Columns["ParcelId"].HeaderText = "Parcel ID";
                    dgvParcels.Columns["StudentName"].HeaderText = "Student Name";
                    dgvParcels.Columns["TrackingNumber"].HeaderText = "Tracking Number";
                    dgvParcels.Columns["VendorName"].HeaderText = "Vendor Name";
                    dgvParcels.Columns["Status"].HeaderText = "Status";
                    dgvParcels.Columns["ArrivalTime"].HeaderText = "Arrival Time";
                    dgvParcels.Columns["CollectedBy"].HeaderText = "Collected By";

                    dgvParcels.Columns["ParcelId"].ReadOnly = true;
                    dgvParcels.Columns["StudentName"].ReadOnly = true;
                    dgvParcels.Columns["TrackingNumber"].ReadOnly = true;
                    dgvParcels.Columns["Status"].ReadOnly = true;
                    dgvParcels.Columns["ArrivalTime"].ReadOnly = true;
                    dgvParcels.Columns["CollectedBy"].ReadOnly = true;
                    dgvParcels.Columns["VendorName"].ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parcels: " + ex.Message);
            }
        }

        private void UpdateParcelVendorName(int parcelId, string vendorName)
        {
            string query = "UPDATE Parcels SET VendorName = @vendorName WHERE ParcelId = @pid";
            DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@vendorName", string.IsNullOrWhiteSpace(vendorName) ? (object)DBNull.Value : vendorName),
                new SqlParameter("@pid", parcelId));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Ignore search if placeholder is shown
            if (searchTerm == txtSearch.Tag.ToString())
                searchTerm = "";

            LoadParcels(searchTerm);
        }

        private void btnGenerateToken_Click(object sender, EventArgs e)
        {
            if (dgvParcels.SelectedCells.Count > 0)
            {
                try
                {
                    int rowIndex = dgvParcels.SelectedCells[0].RowIndex;
                    int parcelId = Convert.ToInt32(dgvParcels.Rows[rowIndex].Cells["ParcelId"].Value);

                    // Get student ID associated with the parcel
                    object studentIdObj = DatabaseHelper.ExecuteScalar("SELECT StudentId FROM Parcels WHERE ParcelId = @pid",
                        new SqlParameter("@pid", parcelId));

                    if (studentIdObj == null)
                    {
                        MessageBox.Show("Could not find student information for this parcel.");
                        return;
                    }

                    int studentId = Convert.ToInt32(studentIdObj);

                    // Use TimetableHelper to find next available break slot
                    var slot = TimetableHelper.GetNextAvailableSlot(studentId);

                    if (slot == null)
                    {
                        MessageBox.Show("No available collection slots found. Please try again during university hours.");
                        return;
                    }

                    DateTime slotStartTime = slot.Value.SlotStart;
                    DateTime slotEndTime = slot.Value.SlotEnd;

                    // Get schedule type for the student
                    TimetableHelper.ScheduleType scheduleType = TimetableHelper.GetStudentScheduleType(studentId);
                    string slotName = TimetableHelper.GetSlotName(slotStartTime, slotEndTime, scheduleType);

                    // Generate next token number for the day
                    object maxToken = DatabaseHelper.ExecuteScalar("SELECT MAX(TokenNumber) FROM Tokens WHERE CONVERT(date, SlotEndTime) = CONVERT(date, @slotDate)",
                        new SqlParameter("@slotDate", slotEndTime));

                    int tokenNo = (maxToken == DBNull.Value || maxToken == null) ? 1 : Convert.ToInt32(maxToken) + 1;

                    // Insert token with intelligent slot information
                    string query = "INSERT INTO Tokens (ParcelId, TokenNumber, SlotStartTime, SlotEndTime, Status) VALUES (@pid, @tno, @start, @end, @status)";
                    DatabaseHelper.ExecuteNonQuery(query,
                        new SqlParameter("@pid", parcelId),
                        new SqlParameter("@tno", tokenNo),
                        new SqlParameter("@start", slotStartTime),
                        new SqlParameter("@end", slotEndTime),
                        new SqlParameter("@status", "Active"));

                    // Format and display token information
                    string formattedSlotTime = TimetableHelper.FormatSlotTime(slotStartTime, slotEndTime);
                    string message = $"✓ Token Generated Successfully\n\n" +
                                   $"Token Number: {tokenNo}\n\n" +
                                   $"Suggested Collection Time:\n" +
                                   $"{formattedSlotTime}\n\n" +
                                   $"({slotName})";

                    MessageBox.Show(message, "Token Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadParcels();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Token Generation Error] {ex.Message}");
                    MessageBox.Show("Error generating token: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select a parcel first.");
            }
        }

        private void btnMarkCollected_Click(object sender, EventArgs e)
        {
            if (dgvParcels.SelectedCells.Count > 0)
            {
                try
                {
                    int rowIndex = dgvParcels.SelectedCells[0].RowIndex;
                    int parcelId = Convert.ToInt32(dgvParcels.Rows[rowIndex].Cells["ParcelId"].Value);

                    Form prompt = new Form()
                    {
                        Width = 400,
                        Height = 200,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        Text = "Collect Parcel",
                        StartPosition = FormStartPosition.CenterScreen,
                        MaximizeBox = false,
                        MinimizeBox = false
                    };

                    Label textLabel = new Label() { Left = 20, Top = 20, Text = "Enter name of person collecting:", AutoSize = true };
                    TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 300 };
                    Button confirmation = new Button() { Text = "Ok", Left = 220, Width = 100, Top = 100, DialogResult = DialogResult.OK };
                    Button cancel = new Button() { Text = "Cancel", Left = 20, Width = 100, Top = 100, DialogResult = DialogResult.Cancel };

                    prompt.Controls.Add(textLabel);
                    prompt.Controls.Add(textBox);
                    prompt.Controls.Add(confirmation);
                    prompt.Controls.Add(cancel);
                    prompt.AcceptButton = confirmation;
                    prompt.CancelButton = cancel;

                    if (prompt.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        string collectedBy = textBox.Text;
                        string query = "UPDATE Parcels SET Status = 'Collected', CollectedBy = @cb, CollectedTime = GETDATE() WHERE ParcelId = @pid";
                        DatabaseHelper.ExecuteNonQuery(query, 
                            new SqlParameter("@cb", collectedBy),
                            new SqlParameter("@pid", parcelId));

                        MessageBox.Show("Marked as Collected");
                        LoadParcels();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error marking parcel as collected: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select a parcel first.");
            }
        }

        // ==================== TAB 4: DASHBOARD ====================

        private void UpdateDashboard()
        {
            try
            {
                int total = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Parcels") ?? 0);
                int pending = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Parcels WHERE Status = 'Pending'") ?? 0);
                int collected = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Parcels WHERE Status = 'Collected'") ?? 0);

                lblTotalParcelsValue.Text = total.ToString();
                lblPendingParcelsValue.Text = pending.ToString();
                lblCollectedParcelsValue.Text = collected.ToString();
            }
            catch { }
        }

        private void dgvParcels_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                DataGridViewColumn column = dgvParcels.Columns[e.ColumnIndex];
                if (column == null || column.Name != "VendorName")
                    return;

                object parcelIdValue = dgvParcels.Rows[e.RowIndex].Cells["ParcelId"].Value;
                if (parcelIdValue == null)
                    return;

                int parcelId = Convert.ToInt32(parcelIdValue);
                object vendorValue = dgvParcels.Rows[e.RowIndex].Cells["VendorName"].Value;
                string vendorName = vendorValue == null ? string.Empty : vendorValue.ToString().Trim();

                UpdateParcelVendorName(parcelId, vendorName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vendor name: " + ex.Message);
                LoadParcels(txtSearch.Text == txtSearch.Tag.ToString() ? "" : txtSearch.Text.Trim());
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
