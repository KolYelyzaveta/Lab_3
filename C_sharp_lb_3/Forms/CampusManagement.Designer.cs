namespace Lab_2.Forms
{
    partial class CampusManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampusManagement));
            this.tb_st_name = new System.Windows.Forms.TextBox();
            this.tb_hostelID = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.gb_CreatingStudent = new System.Windows.Forms.GroupBox();
            this.tb_st_sex = new System.Windows.Forms.TextBox();
            this.tb_st_ID = new System.Windows.Forms.TextBox();
            this.tb_st_course = new System.Windows.Forms.TextBox();
            this.tb_st_group = new System.Windows.Forms.TextBox();
            this.tb_st_faculty = new System.Windows.Forms.TextBox();
            this.tb_st_patronymic = new System.Windows.Forms.TextBox();
            this.tb_st_surname = new System.Windows.Forms.TextBox();
            this.gb_workerManager = new System.Windows.Forms.GroupBox();
            this.gb_radioPosition = new System.Windows.Forms.GroupBox();
            this.rb_head_economic = new System.Windows.Forms.RadioButton();
            this.rb_cleaner = new System.Windows.Forms.RadioButton();
            this.rb_commendant = new System.Windows.Forms.RadioButton();
            this.rb_guard = new System.Windows.Forms.RadioButton();
            this.tb_staff_ITN = new System.Windows.Forms.TextBox();
            this.tb_staff_surname = new System.Windows.Forms.TextBox();
            this.tb_staff_name = new System.Windows.Forms.TextBox();
            this.bt_addStuff = new System.Windows.Forms.Button();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.gb_calcProfits = new System.Windows.Forms.GroupBox();
            this.bt_calcProfit = new System.Windows.Forms.Button();
            this.rb_month = new System.Windows.Forms.RadioButton();
            this.rb_6month = new System.Windows.Forms.RadioButton();
            this.gb_studentManager = new System.Windows.Forms.GroupBox();
            this.bt_st_relocate = new System.Windows.Forms.Button();
            this.tb_Room_num_2 = new System.Windows.Forms.TextBox();
            this.tb_Room_num_1 = new System.Windows.Forms.TextBox();
            this.tb_Record_ID = new System.Windows.Forms.TextBox();
            this.bt_st_del = new System.Windows.Forms.Button();
            this.bt_st_add = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_CreatingStudent.SuspendLayout();
            this.gb_workerManager.SuspendLayout();
            this.gb_radioPosition.SuspendLayout();
            this.gb_calcProfits.SuspendLayout();
            this.gb_studentManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_st_name
            // 
            this.tb_st_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_name.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_name.Location = new System.Drawing.Point(184, 40);
            this.tb_st_name.Multiline = true;
            this.tb_st_name.Name = "tb_st_name";
            this.tb_st_name.PlaceholderText = "Ім\'я";
            this.tb_st_name.Size = new System.Drawing.Size(183, 39);
            this.tb_st_name.TabIndex = 12;
            this.tb_st_name.TextChanged += new System.EventHandler(this.tb_st_name_TextChanged);
            // 
            // tb_hostelID
            // 
            this.tb_hostelID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hostelID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_hostelID.Location = new System.Drawing.Point(410, 6);
            this.tb_hostelID.Multiline = true;
            this.tb_hostelID.Name = "tb_hostelID";
            this.tb_hostelID.Size = new System.Drawing.Size(50, 41);
            this.tb_hostelID.TabIndex = 9;
            this.tb_hostelID.TextChanged += new System.EventHandler(this.tb_hostelID_TextChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(282, 680);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(170, 46);
            this.bt_Cancel.TabIndex = 16;
            this.bt_Cancel.Text = "Назад";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_addStudents
            // 
            this.bt_addStudents.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_addStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStudents.FlatAppearance.BorderSize = 0;
            this.bt_addStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStudents.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStudents.ForeColor = System.Drawing.Color.MintCream;
            this.bt_addStudents.Location = new System.Drawing.Point(377, 143);
            this.bt_addStudents.Name = "bt_addStudents";
            this.bt_addStudents.Size = new System.Drawing.Size(180, 44);
            this.bt_addStudents.TabIndex = 15;
            this.bt_addStudents.Text = "Додати";
            this.bt_addStudents.UseVisualStyleBackColor = false;
            this.bt_addStudents.Click += new System.EventHandler(this.bt_addStudents_Click);
            // 
            // bt_showInfo
            // 
            this.bt_showInfo.BackColor = System.Drawing.Color.Teal;
            this.bt_showInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showInfo.FlatAppearance.BorderSize = 0;
            this.bt_showInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_showInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_showInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_showInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_showInfo.Location = new System.Drawing.Point(198, 49);
            this.bt_showInfo.Name = "bt_showInfo";
            this.bt_showInfo.Size = new System.Drawing.Size(272, 43);
            this.bt_showInfo.TabIndex = 23;
            this.bt_showInfo.Text = "Інформація";
            this.bt_showInfo.UseVisualStyleBackColor = false;
            this.bt_showInfo.Click += new System.EventHandler(this.bt_showInfo_Click);
            // 
            // gb_CreatingStudent
            // 
            this.gb_CreatingStudent.Controls.Add(this.tb_st_sex);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_ID);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_course);
            this.gb_CreatingStudent.Controls.Add(this.bt_addStudents);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_group);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_faculty);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_patronymic);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_surname);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_name);
            this.gb_CreatingStudent.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_CreatingStudent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_CreatingStudent.Location = new System.Drawing.Point(3, 106);
            this.gb_CreatingStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_CreatingStudent.Name = "gb_CreatingStudent";
            this.gb_CreatingStudent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_CreatingStudent.Size = new System.Drawing.Size(568, 191);
            this.gb_CreatingStudent.TabIndex = 25;
            this.gb_CreatingStudent.TabStop = false;
            this.gb_CreatingStudent.Text = "Новий студент";
            // 
            // tb_st_sex
            // 
            this.tb_st_sex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_sex.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_sex.Location = new System.Drawing.Point(482, 96);
            this.tb_st_sex.Multiline = true;
            this.tb_st_sex.Name = "tb_st_sex";
            this.tb_st_sex.PlaceholderText = "Стать";
            this.tb_st_sex.Size = new System.Drawing.Size(75, 41);
            this.tb_st_sex.TabIndex = 19;
            // 
            // tb_st_ID
            // 
            this.tb_st_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_ID.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_ID.Location = new System.Drawing.Point(0, 143);
            this.tb_st_ID.Multiline = true;
            this.tb_st_ID.Name = "tb_st_ID";
            this.tb_st_ID.PlaceholderText = "Ідентифікатор залікової книжки (опціонально)";
            this.tb_st_ID.Size = new System.Drawing.Size(367, 44);
            this.tb_st_ID.TabIndex = 18;
            // 
            // tb_st_course
            // 
            this.tb_st_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_course.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_course.Location = new System.Drawing.Point(388, 96);
            this.tb_st_course.Multiline = true;
            this.tb_st_course.Name = "tb_st_course";
            this.tb_st_course.PlaceholderText = "Курс ";
            this.tb_st_course.Size = new System.Drawing.Size(79, 41);
            this.tb_st_course.TabIndex = 17;
            // 
            // tb_st_group
            // 
            this.tb_st_group.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_group.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_group.Location = new System.Drawing.Point(184, 98);
            this.tb_st_group.Multiline = true;
            this.tb_st_group.Name = "tb_st_group";
            this.tb_st_group.PlaceholderText = "Група";
            this.tb_st_group.Size = new System.Drawing.Size(183, 39);
            this.tb_st_group.TabIndex = 16;
            // 
            // tb_st_faculty
            // 
            this.tb_st_faculty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_faculty.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_faculty.Location = new System.Drawing.Point(0, 96);
            this.tb_st_faculty.Multiline = true;
            this.tb_st_faculty.Name = "tb_st_faculty";
            this.tb_st_faculty.PlaceholderText = "Факультет";
            this.tb_st_faculty.Size = new System.Drawing.Size(178, 41);
            this.tb_st_faculty.TabIndex = 15;
            // 
            // tb_st_patronymic
            // 
            this.tb_st_patronymic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_patronymic.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_patronymic.Location = new System.Drawing.Point(373, 40);
            this.tb_st_patronymic.Multiline = true;
            this.tb_st_patronymic.Name = "tb_st_patronymic";
            this.tb_st_patronymic.PlaceholderText = "По батькові";
            this.tb_st_patronymic.Size = new System.Drawing.Size(184, 39);
            this.tb_st_patronymic.TabIndex = 14;
            this.tb_st_patronymic.TextChanged += new System.EventHandler(this.tb_st_patronymic_TextChanged);
            // 
            // tb_st_surname
            // 
            this.tb_st_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_surname.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_surname.Location = new System.Drawing.Point(0, 40);
            this.tb_st_surname.Multiline = true;
            this.tb_st_surname.Name = "tb_st_surname";
            this.tb_st_surname.PlaceholderText = "Прізвище";
            this.tb_st_surname.Size = new System.Drawing.Size(178, 39);
            this.tb_st_surname.TabIndex = 13;
            // 
            // gb_workerManager
            // 
            this.gb_workerManager.Controls.Add(this.gb_radioPosition);
            this.gb_workerManager.Controls.Add(this.tb_staff_ITN);
            this.gb_workerManager.Controls.Add(this.tb_staff_surname);
            this.gb_workerManager.Controls.Add(this.tb_staff_name);
            this.gb_workerManager.Controls.Add(this.bt_addStuff);
            this.gb_workerManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_workerManager.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_workerManager.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_workerManager.Location = new System.Drawing.Point(3, 471);
            this.gb_workerManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_workerManager.Name = "gb_workerManager";
            this.gb_workerManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_workerManager.Size = new System.Drawing.Size(568, 193);
            this.gb_workerManager.TabIndex = 27;
            this.gb_workerManager.TabStop = false;
            this.gb_workerManager.Text = "Управління робітниками";
            // 
            // gb_radioPosition
            // 
            this.gb_radioPosition.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gb_radioPosition.Controls.Add(this.rb_head_economic);
            this.gb_radioPosition.Controls.Add(this.rb_cleaner);
            this.gb_radioPosition.Controls.Add(this.rb_commendant);
            this.gb_radioPosition.Controls.Add(this.rb_guard);
            this.gb_radioPosition.Location = new System.Drawing.Point(373, 22);
            this.gb_radioPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_radioPosition.Name = "gb_radioPosition";
            this.gb_radioPosition.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_radioPosition.Size = new System.Drawing.Size(184, 171);
            this.gb_radioPosition.TabIndex = 25;
            this.gb_radioPosition.TabStop = false;
            this.gb_radioPosition.Text = "Посада";
            // 
            // rb_head_economic
            // 
            this.rb_head_economic.AutoSize = true;
            this.rb_head_economic.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_head_economic.Location = new System.Drawing.Point(7, 29);
            this.rb_head_economic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_head_economic.Name = "rb_head_economic";
            this.rb_head_economic.Size = new System.Drawing.Size(112, 32);
            this.rb_head_economic.TabIndex = 23;
            this.rb_head_economic.TabStop = true;
            this.rb_head_economic.Text = "Завгосп";
            this.rb_head_economic.UseVisualStyleBackColor = true;
            this.rb_head_economic.CheckedChanged += new System.EventHandler(this.rb_head_economic_CheckedChanged);
            // 
            // rb_cleaner
            // 
            this.rb_cleaner.AutoSize = true;
            this.rb_cleaner.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_cleaner.Location = new System.Drawing.Point(8, 118);
            this.rb_cleaner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_cleaner.Name = "rb_cleaner";
            this.rb_cleaner.Size = new System.Drawing.Size(178, 32);
            this.rb_cleaner.TabIndex = 24;
            this.rb_cleaner.TabStop = true;
            this.rb_cleaner.Text = "Прибиральник";
            this.rb_cleaner.UseVisualStyleBackColor = true;
            // 
            // rb_commendant
            // 
            this.rb_commendant.AutoSize = true;
            this.rb_commendant.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_commendant.Location = new System.Drawing.Point(7, 59);
            this.rb_commendant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_commendant.Name = "rb_commendant";
            this.rb_commendant.Size = new System.Drawing.Size(144, 32);
            this.rb_commendant.TabIndex = 21;
            this.rb_commendant.TabStop = true;
            this.rb_commendant.Text = "Комендант";
            this.rb_commendant.UseVisualStyleBackColor = true;
            // 
            // rb_guard
            // 
            this.rb_guard.AutoSize = true;
            this.rb_guard.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_guard.Location = new System.Drawing.Point(8, 90);
            this.rb_guard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_guard.Name = "rb_guard";
            this.rb_guard.Size = new System.Drawing.Size(143, 32);
            this.rb_guard.TabIndex = 22;
            this.rb_guard.TabStop = true;
            this.rb_guard.Text = "Охоронець";
            this.rb_guard.UseVisualStyleBackColor = true;
            this.rb_guard.CheckedChanged += new System.EventHandler(this.rb_guard_CheckedChanged);
            // 
            // tb_staff_ITN
            // 
            this.tb_staff_ITN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_staff_ITN.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_staff_ITN.Location = new System.Drawing.Point(0, 81);
            this.tb_staff_ITN.Multiline = true;
            this.tb_staff_ITN.Name = "tb_staff_ITN";
            this.tb_staff_ITN.PlaceholderText = "Індивідуальний податковий номер";
            this.tb_staff_ITN.Size = new System.Drawing.Size(367, 39);
            this.tb_staff_ITN.TabIndex = 20;
            // 
            // tb_staff_surname
            // 
            this.tb_staff_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_staff_surname.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_staff_surname.Location = new System.Drawing.Point(0, 38);
            this.tb_staff_surname.Multiline = true;
            this.tb_staff_surname.Name = "tb_staff_surname";
            this.tb_staff_surname.PlaceholderText = "Прізвище";
            this.tb_staff_surname.Size = new System.Drawing.Size(178, 37);
            this.tb_staff_surname.TabIndex = 19;
            // 
            // tb_staff_name
            // 
            this.tb_staff_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_staff_name.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_staff_name.Location = new System.Drawing.Point(189, 36);
            this.tb_staff_name.Multiline = true;
            this.tb_staff_name.Name = "tb_staff_name";
            this.tb_staff_name.PlaceholderText = "Ім\'я";
            this.tb_staff_name.Size = new System.Drawing.Size(178, 39);
            this.tb_staff_name.TabIndex = 18;
            this.tb_staff_name.TextChanged += new System.EventHandler(this.tb_staff_name_TextChanged);
            // 
            // bt_addStuff
            // 
            this.bt_addStuff.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_addStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStuff.FlatAppearance.BorderSize = 0;
            this.bt_addStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_addStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_addStuff.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStuff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_addStuff.Location = new System.Drawing.Point(99, 130);
            this.bt_addStuff.Name = "bt_addStuff";
            this.bt_addStuff.Size = new System.Drawing.Size(156, 51);
            this.bt_addStuff.TabIndex = 17;
            this.bt_addStuff.Text = "Додати ";
            this.bt_addStuff.UseVisualStyleBackColor = false;
            this.bt_addStuff.Click += new System.EventHandler(this.bt_addStuff_Click);
            // 
            // rb_year
            // 
            this.rb_year.AutoSize = true;
            this.rb_year.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_year.Location = new System.Drawing.Point(6, 44);
            this.rb_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_year.Name = "rb_year";
            this.rb_year.Size = new System.Drawing.Size(109, 35);
            this.rb_year.TabIndex = 28;
            this.rb_year.TabStop = true;
            this.rb_year.Text = "За рік";
            this.rb_year.UseVisualStyleBackColor = true;
            // 
            // gb_calcProfits
            // 
            this.gb_calcProfits.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_calcProfits.Controls.Add(this.bt_calcProfit);
            this.gb_calcProfits.Controls.Add(this.rb_month);
            this.gb_calcProfits.Controls.Add(this.rb_6month);
            this.gb_calcProfits.Controls.Add(this.rb_year);
            this.gb_calcProfits.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_calcProfits.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_calcProfits.Location = new System.Drawing.Point(577, 9);
            this.gb_calcProfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_calcProfits.Name = "gb_calcProfits";
            this.gb_calcProfits.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_calcProfits.Size = new System.Drawing.Size(193, 655);
            this.gb_calcProfits.TabIndex = 29;
            this.gb_calcProfits.TabStop = false;
            this.gb_calcProfits.Text = "Дохід";
            // 
            // bt_calcProfit
            // 
            this.bt_calcProfit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_calcProfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calcProfit.FlatAppearance.BorderSize = 0;
            this.bt_calcProfit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_calcProfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_calcProfit.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_calcProfit.ForeColor = System.Drawing.Color.Honeydew;
            this.bt_calcProfit.Location = new System.Drawing.Point(14, 177);
            this.bt_calcProfit.Name = "bt_calcProfit";
            this.bt_calcProfit.Size = new System.Drawing.Size(156, 57);
            this.bt_calcProfit.TabIndex = 31;
            this.bt_calcProfit.Text = "Розрахунок";
            this.bt_calcProfit.UseVisualStyleBackColor = false;
            this.bt_calcProfit.Click += new System.EventHandler(this.bt_calcProfit_Click);
            // 
            // rb_month
            // 
            this.rb_month.AutoSize = true;
            this.rb_month.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_month.Location = new System.Drawing.Point(6, 129);
            this.rb_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_month.Name = "rb_month";
            this.rb_month.Size = new System.Drawing.Size(156, 35);
            this.rb_month.TabIndex = 30;
            this.rb_month.TabStop = true;
            this.rb_month.Text = "За місяць";
            this.rb_month.UseVisualStyleBackColor = true;
            // 
            // rb_6month
            // 
            this.rb_6month.AutoSize = true;
            this.rb_6month.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_6month.Location = new System.Drawing.Point(6, 87);
            this.rb_6month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_6month.Name = "rb_6month";
            this.rb_6month.Size = new System.Drawing.Size(164, 35);
            this.rb_6month.TabIndex = 29;
            this.rb_6month.TabStop = true;
            this.rb_6month.Text = "За півроку";
            this.rb_6month.UseVisualStyleBackColor = true;
            this.rb_6month.CheckedChanged += new System.EventHandler(this.rb_6month_CheckedChanged);
            // 
            // gb_studentManager
            // 
            this.gb_studentManager.Controls.Add(this.bt_st_relocate);
            this.gb_studentManager.Controls.Add(this.tb_Room_num_2);
            this.gb_studentManager.Controls.Add(this.tb_Room_num_1);
            this.gb_studentManager.Controls.Add(this.tb_Record_ID);
            this.gb_studentManager.Controls.Add(this.bt_st_del);
            this.gb_studentManager.Controls.Add(this.bt_st_add);
            this.gb_studentManager.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_studentManager.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_studentManager.Location = new System.Drawing.Point(3, 300);
            this.gb_studentManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_studentManager.Name = "gb_studentManager";
            this.gb_studentManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_studentManager.Size = new System.Drawing.Size(568, 163);
            this.gb_studentManager.TabIndex = 26;
            this.gb_studentManager.TabStop = false;
            this.gb_studentManager.Text = "Перепоселення";
            this.gb_studentManager.Enter += new System.EventHandler(this.gb_studentManager_Enter);
            // 
            // bt_st_relocate
            // 
            this.bt_st_relocate.BackColor = System.Drawing.Color.Teal;
            this.bt_st_relocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_relocate.FlatAppearance.BorderSize = 0;
            this.bt_st_relocate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_st_relocate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_st_relocate.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_relocate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_st_relocate.Location = new System.Drawing.Point(348, 102);
            this.bt_st_relocate.Name = "bt_st_relocate";
            this.bt_st_relocate.Size = new System.Drawing.Size(209, 45);
            this.bt_st_relocate.TabIndex = 24;
            this.bt_st_relocate.Text = "Переселити";
            this.bt_st_relocate.UseVisualStyleBackColor = false;
            this.bt_st_relocate.Click += new System.EventHandler(this.bt_st_relocate_Click);
            // 
            // tb_Room_num_2
            // 
            this.tb_Room_num_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Room_num_2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Room_num_2.Location = new System.Drawing.Point(348, 45);
            this.tb_Room_num_2.Multiline = true;
            this.tb_Room_num_2.Name = "tb_Room_num_2";
            this.tb_Room_num_2.PlaceholderText = "Нова кімната";
            this.tb_Room_num_2.Size = new System.Drawing.Size(209, 44);
            this.tb_Room_num_2.TabIndex = 21;
            // 
            // tb_Room_num_1
            // 
            this.tb_Room_num_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Room_num_1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Room_num_1.Location = new System.Drawing.Point(246, 45);
            this.tb_Room_num_1.Multiline = true;
            this.tb_Room_num_1.Name = "tb_Room_num_1";
            this.tb_Room_num_1.PlaceholderText = "Кімната";
            this.tb_Room_num_1.Size = new System.Drawing.Size(96, 44);
            this.tb_Room_num_1.TabIndex = 20;
            this.tb_Room_num_1.TextChanged += new System.EventHandler(this.tb_Room_num_1_TextChanged);
            // 
            // tb_Record_ID
            // 
            this.tb_Record_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Record_ID.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Record_ID.Location = new System.Drawing.Point(14, 45);
            this.tb_Record_ID.Multiline = true;
            this.tb_Record_ID.Name = "tb_Record_ID";
            this.tb_Record_ID.PlaceholderText = "ID зал. книжки";
            this.tb_Record_ID.Size = new System.Drawing.Size(226, 44);
            this.tb_Record_ID.TabIndex = 19;
            // 
            // bt_st_del
            // 
            this.bt_st_del.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_st_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_del.FlatAppearance.BorderSize = 0;
            this.bt_st_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_st_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_st_del.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_del.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_st_del.Location = new System.Drawing.Point(184, 102);
            this.bt_st_del.Name = "bt_st_del";
            this.bt_st_del.Size = new System.Drawing.Size(158, 45);
            this.bt_st_del.TabIndex = 17;
            this.bt_st_del.Text = "Видалити ";
            this.bt_st_del.UseVisualStyleBackColor = false;
            this.bt_st_del.Click += new System.EventHandler(this.bt_st_del_Click);
            // 
            // bt_st_add
            // 
            this.bt_st_add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_st_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_add.FlatAppearance.BorderSize = 0;
            this.bt_st_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_st_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_st_add.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_add.ForeColor = System.Drawing.Color.Honeydew;
            this.bt_st_add.Location = new System.Drawing.Point(14, 102);
            this.bt_st_add.Name = "bt_st_add";
            this.bt_st_add.Size = new System.Drawing.Size(164, 45);
            this.bt_st_add.TabIndex = 15;
            this.bt_st_add.Text = "Додати ";
            this.bt_st_add.UseVisualStyleBackColor = false;
            this.bt_st_add.Click += new System.EventHandler(this.bt_st_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Гуртожиток №";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CampusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(778, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_studentManager);
            this.Controls.Add(this.gb_calcProfits);
            this.Controls.Add(this.gb_workerManager);
            this.Controls.Add(this.gb_CreatingStudent);
            this.Controls.Add(this.bt_showInfo);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.tb_hostelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "CampusManagement";
            this.Text = "Управління гуртожитком";
            this.Load += new System.EventHandler(this.CampusManagement_Load);
            this.gb_CreatingStudent.ResumeLayout(false);
            this.gb_CreatingStudent.PerformLayout();
            this.gb_workerManager.ResumeLayout(false);
            this.gb_workerManager.PerformLayout();
            this.gb_radioPosition.ResumeLayout(false);
            this.gb_radioPosition.PerformLayout();
            this.gb_calcProfits.ResumeLayout(false);
            this.gb_calcProfits.PerformLayout();
            this.gb_studentManager.ResumeLayout(false);
            this.gb_studentManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_st_name;
        private TextBox tb_hostelID;
        private Button bt_Cancel;
        private Button bt_addStudents;
        private Button bt_showInfo;
        private GroupBox gb_CreatingStudent;
        private GroupBox gb_workerManager;
        private Button bt_addStuff;
        private RadioButton rb_commendant;
        private GroupBox gb_calcProfits;
        private RadioButton rb_head_economic;
        private RadioButton rb_guard;
        private RadioButton rb_year;
        private Button bt_calcProfit;
        private RadioButton rb_month;
        private RadioButton rb_6month;
        private GroupBox gb_studentManager;
        private Button bt_st_del;
        private Button bt_st_add;
        private TextBox tb_st_sex;
        private TextBox tb_st_ID;
        private TextBox tb_st_course;
        private TextBox tb_st_group;
        private TextBox tb_st_faculty;
        private TextBox tb_st_patronymic;
        private TextBox tb_st_surname;
        private Button bt_st_relocate;
        private TextBox tb_Room_num_2;
        private TextBox tb_Room_num_1;
        private TextBox tb_Record_ID;
        private TextBox tb_staff_surname;
        private TextBox tb_staff_name;
        private GroupBox gb_radioPosition;
        private RadioButton rb_cleaner;
        private TextBox tb_staff_ITN;
        private ColorDialog colorDialog1;
        private Label label1;
    }
}