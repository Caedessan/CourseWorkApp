namespace CourseWorkApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBox = new System.Windows.Forms.TextBox();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBconnect = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(106, 74);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(234, 23);
            this.loginBox.TabIndex = 0;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            this.loginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyDown);
            // 
            // pswdBox
            // 
            this.pswdBox.Location = new System.Drawing.Point(106, 103);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.Size = new System.Drawing.Size(234, 23);
            this.pswdBox.TabIndex = 1;
            this.pswdBox.TextChanged += new System.EventHandler(this.pswdBox_TextChanged);
            //this.pswdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DBconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // DBconnect
            // 
            this.DBconnect.Location = new System.Drawing.Point(107, 132);
            this.DBconnect.Name = "DBconnect";
            this.DBconnect.Size = new System.Drawing.Size(233, 23);
            this.DBconnect.TabIndex = 5;
            this.DBconnect.Text = "Connect to Server";
            this.DBconnect.UseVisualStyleBackColor = true;
            this.DBconnect.Click += new System.EventHandler(this.DBconnect_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(107, 158);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(0, 15);
            this.connectionLabel.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 268);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.DBconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.loginBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginBox;
        private TextBox pswdBox;
        private Label label1;
        private Label label2;
        private Button DBconnect;
        private Label connectionLabel;
    }
}