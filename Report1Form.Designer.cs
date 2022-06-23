namespace CourseWorkApp
{
    partial class Report1Form
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
            this.employeeList = new System.Windows.Forms.ListBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 15;
            this.employeeList.Location = new System.Drawing.Point(12, 41);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(335, 319);
            this.employeeList.TabIndex = 0;
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(92, 12);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(255, 23);
            this.departmentBox.TabIndex = 1;
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.departmentBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 363);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 15);
            this.amountLabel.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Report1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(359, 419);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.employeeList);
            this.Name = "Report1Form";
            this.Text = "Department workers list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employeeList;
        private ComboBox departmentBox;
        private Label label1;
        private Label amountLabel;
        private Button exitButton;
    }
}