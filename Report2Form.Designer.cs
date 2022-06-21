namespace CourseWorkApp
{
    partial class Report2Form
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
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posBox = new System.Windows.Forms.TextBox();
            this.salBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(77, 27);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(267, 23);
            this.employeeBox.TabIndex = 0;
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.employeeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee";
            // 
            // posBox
            // 
            this.posBox.Location = new System.Drawing.Point(69, 63);
            this.posBox.Name = "posBox";
            this.posBox.Size = new System.Drawing.Size(125, 23);
            this.posBox.TabIndex = 2;
            // 
            // salBox
            // 
            this.salBox.Location = new System.Drawing.Point(244, 63);
            this.salBox.Name = "salBox";
            this.salBox.Size = new System.Drawing.Size(100, 23);
            this.salBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(269, 104);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Report2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(361, 139);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salBox);
            this.Controls.Add(this.posBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeBox);
            this.Name = "Report2Form";
            this.Text = "Report2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox employeeBox;
        private Label label1;
        private TextBox posBox;
        private TextBox salBox;
        private Label label2;
        private Label label3;
        private Button exitButton;
    }
}