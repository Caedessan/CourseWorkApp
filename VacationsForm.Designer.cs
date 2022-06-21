namespace CourseWorkApp
{
    partial class VacationsForm
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
            this.vacationsList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.EditButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grantedLabel = new System.Windows.Forms.Label();
            this.usedLabel = new System.Windows.Forms.Label();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vacationsList
            // 
            this.vacationsList.FormattingEnabled = true;
            this.vacationsList.ItemHeight = 15;
            this.vacationsList.Location = new System.Drawing.Point(12, 12);
            this.vacationsList.Name = "vacationsList";
            this.vacationsList.Size = new System.Drawing.Size(185, 244);
            this.vacationsList.TabIndex = 0;
            this.vacationsList.SelectedIndexChanged += new System.EventHandler(this.vacationsList_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // startPicker
            // 
            this.startPicker.Location = new System.Drawing.Point(277, 12);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(200, 23);
            this.startPicker.TabIndex = 5;
            // 
            // endPicker
            // 
            this.endPicker.Location = new System.Drawing.Point(277, 54);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(200, 23);
            this.endPicker.TabIndex = 6;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(84, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.AddButton);
            this.adminPanel.Controls.Add(this.EditButton);
            this.adminPanel.Location = new System.Drawing.Point(217, 83);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(200, 32);
            this.adminPanel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Days off used:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Days off granted:";
            // 
            // grantedLabel
            // 
            this.grantedLabel.AutoSize = true;
            this.grantedLabel.Location = new System.Drawing.Point(316, 215);
            this.grantedLabel.Name = "grantedLabel";
            this.grantedLabel.Size = new System.Drawing.Size(0, 15);
            this.grantedLabel.TabIndex = 11;
            // 
            // usedLabel
            // 
            this.usedLabel.AutoSize = true;
            this.usedLabel.Location = new System.Drawing.Point(300, 241);
            this.usedLabel.Name = "usedLabel";
            this.usedLabel.Size = new System.Drawing.Size(0, 15);
            this.usedLabel.TabIndex = 12;
            // 
            // VacationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(501, 272);
            this.Controls.Add(this.usedLabel);
            this.Controls.Add(this.grantedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacationsList);
            this.Name = "VacationsForm";
            this.Text = "Vacations";
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox vacationsList;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private DateTimePicker startPicker;
        private DateTimePicker endPicker;
        private Button EditButton;
        private Panel adminPanel;
        private Label label3;
        private Label label4;
        private Label grantedLabel;
        private Label usedLabel;
    }
}