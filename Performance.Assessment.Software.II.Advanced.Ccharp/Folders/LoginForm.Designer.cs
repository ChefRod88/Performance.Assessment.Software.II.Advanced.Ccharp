namespace Performance.Assessment.Software.II.Advanced.Ccharp
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblUserContext = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeZoneValue = new System.Windows.Forms.Label();
            this.lblLocationValue = new System.Windows.Forms.Label();
            this.lblTimeZoneValueA = new System.Windows.Forms.Label();
            this.lblLocationValueB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(242, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(82, 89);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            // 
            // lblUserContext
            // 
            this.lblUserContext.AutoSize = true;
            this.lblUserContext.Location = new System.Drawing.Point(82, 133);
            this.lblUserContext.Name = "lblUserContext";
            this.lblUserContext.Size = new System.Drawing.Size(55, 13);
            this.lblUserContext.TabIndex = 2;
            this.lblUserContext.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(82, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(186, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(186, 126);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(131, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(186, 85);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(131, 21);
            this.cbLanguage.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(127, 209);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 7;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intersys Global Solutions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to";
            // 
            // lblTimeZoneValue
            // 
            this.lblTimeZoneValue.AutoSize = true;
            this.lblTimeZoneValue.Location = new System.Drawing.Point(110, 257);
            this.lblTimeZoneValue.Name = "lblTimeZoneValue";
            this.lblTimeZoneValue.Size = new System.Drawing.Size(98, 13);
            this.lblTimeZoneValue.TabIndex = 10;
            this.lblTimeZoneValue.Text = "Current Time Zone:";
            // 
            // lblLocationValue
            // 
            this.lblLocationValue.AutoSize = true;
            this.lblLocationValue.Location = new System.Drawing.Point(110, 281);
            this.lblLocationValue.Name = "lblLocationValue";
            this.lblLocationValue.Size = new System.Drawing.Size(88, 13);
            this.lblLocationValue.TabIndex = 11;
            this.lblLocationValue.Text = "Current Location:";
            // 
            // lblTimeZoneValueA
            // 
            this.lblTimeZoneValueA.AutoSize = true;
            this.lblTimeZoneValueA.Location = new System.Drawing.Point(236, 257);
            this.lblTimeZoneValueA.Name = "lblTimeZoneValueA";
            this.lblTimeZoneValueA.Size = new System.Drawing.Size(0, 13);
            this.lblTimeZoneValueA.TabIndex = 12;
            // 
            // lblLocationValueB
            // 
            this.lblLocationValueB.AutoSize = true;
            this.lblLocationValueB.Location = new System.Drawing.Point(236, 281);
            this.lblLocationValueB.Name = "lblLocationValueB";
            this.lblLocationValueB.Size = new System.Drawing.Size(0, 13);
            this.lblLocationValueB.TabIndex = 13;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 321);
            this.Controls.Add(this.lblLocationValueB);
            this.Controls.Add(this.lblTimeZoneValueA);
            this.Controls.Add(this.lblLocationValue);
            this.Controls.Add(this.lblTimeZoneValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserContext);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "Intersys Global Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblUserContext;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeZoneValue;
        private System.Windows.Forms.Label lblLocationValue;
        private System.Windows.Forms.Label lblTimeZoneValueA;
        private System.Windows.Forms.Label lblLocationValueB;
    }
}

