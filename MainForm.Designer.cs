namespace CourseWorkApp
{
    partial class MainForm
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
            this.employeesList = new System.Windows.Forms.ListBox();
            this.vacationButton = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.bossBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.pasportBox = new System.Windows.Forms.TextBox();
            this.birthplaceBox = new System.Windows.Forms.TextBox();
            this.addresBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.posdepButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.rep1Button = new System.Windows.Forms.Button();
            this.rep2Button = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.ItemHeight = 15;
            this.employeesList.Location = new System.Drawing.Point(12, 12);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(283, 349);
            this.employeesList.TabIndex = 0;
            this.employeesList.SelectedIndexChanged += new System.EventHandler(this.employeesList_SelectedIndexChanged);
            // 
            // vacationButton
            // 
            this.vacationButton.Location = new System.Drawing.Point(302, 305);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(198, 23);
            this.vacationButton.TabIndex = 85;
            this.vacationButton.Text = "Vacations";
            this.vacationButton.UseVisualStyleBackColor = true;
            this.vacationButton.Click += new System.EventHandler(this.vacationButton_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(375, 223);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(278, 23);
            this.departmentBox.TabIndex = 84;
            // 
            // bossBox
            // 
            this.bossBox.Enabled = false;
            this.bossBox.Location = new System.Drawing.Point(340, 250);
            this.bossBox.Margin = new System.Windows.Forms.Padding(2);
            this.bossBox.Name = "bossBox";
            this.bossBox.Size = new System.Drawing.Size(314, 23);
            this.bossBox.TabIndex = 83;
            // 
            // positionBox
            // 
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Location = new System.Drawing.Point(356, 196);
            this.positionBox.Margin = new System.Windows.Forms.Padding(2);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(298, 23);
            this.positionBox.TabIndex = 82;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(356, 116);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(298, 23);
            this.birthdayPicker.TabIndex = 81;
            // 
            // salaryBox
            // 
            this.salaryBox.Enabled = false;
            this.salaryBox.Location = new System.Drawing.Point(344, 277);
            this.salaryBox.Margin = new System.Windows.Forms.Padding(2);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(310, 23);
            this.salaryBox.TabIndex = 80;
            // 
            // pasportBox
            // 
            this.pasportBox.Location = new System.Drawing.Point(383, 90);
            this.pasportBox.Margin = new System.Windows.Forms.Padding(2);
            this.pasportBox.Name = "pasportBox";
            this.pasportBox.Size = new System.Drawing.Size(270, 23);
            this.pasportBox.TabIndex = 79;
            // 
            // birthplaceBox
            // 
            this.birthplaceBox.Location = new System.Drawing.Point(367, 142);
            this.birthplaceBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthplaceBox.Name = "birthplaceBox";
            this.birthplaceBox.Size = new System.Drawing.Size(287, 23);
            this.birthplaceBox.TabIndex = 78;
            // 
            // addresBox
            // 
            this.addresBox.Location = new System.Drawing.Point(353, 169);
            this.addresBox.Margin = new System.Windows.Forms.Padding(2);
            this.addresBox.Name = "addresBox";
            this.addresBox.Size = new System.Drawing.Size(300, 23);
            this.addresBox.TabIndex = 77;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(383, 63);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(270, 23);
            this.fnameBox.TabIndex = 76;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(359, 37);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(295, 23);
            this.surnameBox.TabIndex = 75;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(344, 12);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(310, 23);
            this.nameBox.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 253);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 73;
            this.label12.Text = "Boss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 72;
            this.label11.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 71;
            this.label10.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 70;
            this.label9.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Passport data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "Birth place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fathers name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Name";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(578, 430);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(72, 32);
            this.disconnectButton.TabIndex = 86;
            this.disconnectButton.Text = "Exit";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.posdepButton);
            this.adminPanel.Controls.Add(this.addUserButton);
            this.adminPanel.Controls.Add(this.editButton);
            this.adminPanel.Controls.Add(this.addEmployeeButton);
            this.adminPanel.Location = new System.Drawing.Point(302, 340);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(307, 84);
            this.adminPanel.TabIndex = 87;
            // 
            // posdepButton
            // 
            this.posdepButton.Location = new System.Drawing.Point(3, 61);
            this.posdepButton.Name = "posdepButton";
            this.posdepButton.Size = new System.Drawing.Size(302, 23);
            this.posdepButton.TabIndex = 5;
            this.posdepButton.Text = "Positions and Departments";
            this.posdepButton.UseVisualStyleBackColor = true;
            this.posdepButton.Click += new System.EventHandler(this.posdepButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(3, 32);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(302, 23);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Database users settings";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(153, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(151, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit data";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(3, 3);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(148, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add new Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // rep1Button
            // 
            this.rep1Button.Location = new System.Drawing.Point(12, 367);
            this.rep1Button.Name = "rep1Button";
            this.rep1Button.Size = new System.Drawing.Size(168, 28);
            this.rep1Button.TabIndex = 88;
            this.rep1Button.Text = "Department workers list";
            this.rep1Button.UseVisualStyleBackColor = true;
            this.rep1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rep2Button
            // 
            this.rep2Button.Location = new System.Drawing.Point(12, 396);
            this.rep2Button.Name = "rep2Button";
            this.rep2Button.Size = new System.Drawing.Size(168, 28);
            this.rep2Button.TabIndex = 89;
            this.rep2Button.Text = "Employment Details";
            this.rep2Button.UseVisualStyleBackColor = true;
            this.rep2Button.Click += new System.EventHandler(this.rep2Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.rep2Button);
            this.Controls.Add(this.rep1Button);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.vacationButton);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.bossBox);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.pasportBox);
            this.Controls.Add(this.birthplaceBox);
            this.Controls.Add(this.addresBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesList);
            this.Name = "MainForm";
            this.Text = "Company";
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employeesList;
        private Button vacationButton;
        private ComboBox departmentBox;
        private TextBox bossBox;
        private ComboBox positionBox;
        private DateTimePicker birthdayPicker;
        private TextBox salaryBox;
        private TextBox pasportBox;
        private TextBox birthplaceBox;
        private TextBox addresBox;
        private TextBox fnameBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button disconnectButton;
        private Panel adminPanel;
        private Button addUserButton;
        private Button editButton;
        private Button addEmployeeButton;
        private Button posdepButton;
        private Button rep1Button;
        private Button rep2Button;
    }
}