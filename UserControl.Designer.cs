namespace CourseWorkApp
{
    partial class UserControl
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
            this.usersBox = new System.Windows.Forms.ListBox();
            this.unBox = new System.Windows.Forms.TextBox();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightsBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersBox
            // 
            this.usersBox.FormattingEnabled = true;
            this.usersBox.ItemHeight = 15;
            this.usersBox.Location = new System.Drawing.Point(12, 12);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(178, 214);
            this.usersBox.TabIndex = 0;
            this.usersBox.SelectedIndexChanged += new System.EventHandler(this.usersBox_SelectedIndexChanged);
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(259, 20);
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(100, 23);
            this.unBox.TabIndex = 1;
            this.unBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unBox_KeyDown);
            // 
            // pswdBox
            // 
            this.pswdBox.Location = new System.Drawing.Point(259, 49);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.Size = new System.Drawing.Size(100, 23);
            this.pswdBox.TabIndex = 2;
            this.pswdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pswdBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // rightsBox
            // 
            this.rightsBox.AutoSize = true;
            this.rightsBox.Location = new System.Drawing.Point(196, 78);
            this.rightsBox.Name = "rightsBox";
            this.rightsBox.Size = new System.Drawing.Size(95, 19);
            this.rightsBox.TabIndex = 5;
            this.rightsBox.Text = "Admin rights";
            this.rightsBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(196, 103);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add user";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(196, 132);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(163, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete User";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(372, 235);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.rightsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.unBox);
            this.Controls.Add(this.usersBox);
            this.Name = "UserControl";
            this.Text = "UserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox usersBox;
        private TextBox unBox;
        private TextBox pswdBox;
        private Label label1;
        private Label label2;
        private CheckBox rightsBox;
        private Button addButton;
        private Button deleteButton;
    }
}