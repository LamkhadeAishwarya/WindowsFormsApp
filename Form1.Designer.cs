namespace WindowsFormsApp
{
    partial class Form1
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label1UserName = new System.Windows.Forms.Label();
            this.label2Password = new System.Windows.Forms.Label();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(614, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(209, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox2username_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(614, 150);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(209, 22);
            this.textpassword.TabIndex = 2;
            // 
            // label1UserName
            // 
            this.label1UserName.AutoSize = true;
            this.label1UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UserName.Location = new System.Drawing.Point(431, 89);
            this.label1UserName.Name = "label1UserName";
            this.label1UserName.Size = new System.Drawing.Size(85, 16);
            this.label1UserName.TabIndex = 3;
            this.label1UserName.Text = "User Name";
            this.label1UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2Password
            // 
            this.label2Password.AutoSize = true;
            this.label2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Password.Location = new System.Drawing.Point(431, 153);
            this.label2Password.Name = "label2Password";
            this.label2Password.Size = new System.Drawing.Size(75, 16);
            this.label2Password.TabIndex = 4;
            this.label2Password.Text = "Password";
            this.label2Password.Click += new System.EventHandler(this.label2Password_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.Red;
            this.buttoncancel.Location = new System.Drawing.Point(629, 253);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 39);
            this.buttoncancel.TabIndex = 6;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.Location = new System.Drawing.Point(509, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = " Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 718);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.label2Password);
            this.Controls.Add(this.label1UserName);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label1UserName;
        private System.Windows.Forms.Label label2Password;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button btnLogin;
    }
}

