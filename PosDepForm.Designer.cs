namespace CourseWorkApp
{
    partial class PosDepForm
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
            this.posList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posAddButton = new System.Windows.Forms.Button();
            this.posNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vacationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.posEditButton = new System.Windows.Forms.Button();
            this.depEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.abbBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depNameBox = new System.Windows.Forms.TextBox();
            this.depAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentList = new System.Windows.Forms.ListBox();
            this.depHeadBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // posList
            // 
            this.posList.FormattingEnabled = true;
            this.posList.ItemHeight = 15;
            this.posList.Location = new System.Drawing.Point(12, 32);
            this.posList.Name = "posList";
            this.posList.Size = new System.Drawing.Size(174, 94);
            this.posList.TabIndex = 0;
            this.posList.SelectedIndexChanged += new System.EventHandler(this.posList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Positions";
            // 
            // posAddButton
            // 
            this.posAddButton.Location = new System.Drawing.Point(12, 132);
            this.posAddButton.Name = "posAddButton";
            this.posAddButton.Size = new System.Drawing.Size(80, 23);
            this.posAddButton.TabIndex = 2;
            this.posAddButton.Text = "Add";
            this.posAddButton.UseVisualStyleBackColor = true;
            this.posAddButton.Click += new System.EventHandler(this.posAddButton_Click);
            // 
            // posNameBox
            // 
            this.posNameBox.Location = new System.Drawing.Point(254, 37);
            this.posNameBox.Name = "posNameBox";
            this.posNameBox.Size = new System.Drawing.Size(100, 23);
            this.posNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vacations";
            // 
            // vacationBox
            // 
            this.vacationBox.Location = new System.Drawing.Point(254, 66);
            this.vacationBox.Name = "vacationBox";
            this.vacationBox.Size = new System.Drawing.Size(100, 23);
            this.vacationBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(254, 95);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(100, 23);
            this.salaryBox.TabIndex = 7;
            // 
            // posEditButton
            // 
            this.posEditButton.Location = new System.Drawing.Point(98, 132);
            this.posEditButton.Name = "posEditButton";
            this.posEditButton.Size = new System.Drawing.Size(88, 23);
            this.posEditButton.TabIndex = 9;
            this.posEditButton.Text = "Edit ";
            this.posEditButton.UseVisualStyleBackColor = true;
            this.posEditButton.Click += new System.EventHandler(this.posEditButton_Click);
            // 
            // depEdit
            // 
            this.depEdit.Location = new System.Drawing.Point(448, 132);
            this.depEdit.Name = "depEdit";
            this.depEdit.Size = new System.Drawing.Size(86, 23);
            this.depEdit.TabIndex = 19;
            this.depEdit.Text = "Edit ";
            this.depEdit.UseVisualStyleBackColor = true;
            this.depEdit.Click += new System.EventHandler(this.depEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Head Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Abbriviation";
            // 
            // abbBox
            // 
            this.abbBox.Location = new System.Drawing.Point(618, 66);
            this.abbBox.Name = "abbBox";
            this.abbBox.Size = new System.Drawing.Size(121, 23);
            this.abbBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // depNameBox
            // 
            this.depNameBox.Location = new System.Drawing.Point(618, 37);
            this.depNameBox.Name = "depNameBox";
            this.depNameBox.Size = new System.Drawing.Size(121, 23);
            this.depNameBox.TabIndex = 13;
            // 
            // depAdd
            // 
            this.depAdd.Location = new System.Drawing.Point(360, 132);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(82, 23);
            this.depAdd.TabIndex = 12;
            this.depAdd.Text = "Add";
            this.depAdd.UseVisualStyleBackColor = true;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Departments";
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.ItemHeight = 15;
            this.departmentList.Location = new System.Drawing.Point(360, 32);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(174, 94);
            this.departmentList.TabIndex = 10;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // depHeadBox
            // 
            this.depHeadBox.FormattingEnabled = true;
            this.depHeadBox.Location = new System.Drawing.Point(618, 95);
            this.depHeadBox.Name = "depHeadBox";
            this.depHeadBox.Size = new System.Drawing.Size(242, 23);
            this.depHeadBox.TabIndex = 20;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(771, 132);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 23);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(780, 66);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 15);
            this.amountLabel.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(745, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Amount of employees:";
            // 
            // PosDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(872, 167);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.depHeadBox);
            this.Controls.Add(this.depEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.abbBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depNameBox);
            this.Controls.Add(this.depAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departmentList);
            this.Controls.Add(this.posEditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vacationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posNameBox);
            this.Controls.Add(this.posAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posList);
            this.Name = "PosDepForm";
            this.Text = "Positions and Departments Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox posList;
        private Label label1;
        private Button posAddButton;
        private TextBox posNameBox;
        private Label label2;
        private Label label3;
        private TextBox vacationBox;
        private Label label4;
        private TextBox salaryBox;
        private Button posEditButton;
        private Button depEdit;
        private Label label5;
        private Label label6;
        private TextBox abbBox;
        private Label label7;
        private TextBox depNameBox;
        private Button depAdd;
        private Label label8;
        private ListBox departmentList;
        private ComboBox depHeadBox;
        private Button ExitButton;
        private Label amountLabel;
        private Label label9;
    }
}