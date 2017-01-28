namespace Point_Of_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userName_textField = new MetroFramework.Controls.MetroTextBox();
            this.password_textField = new MetroFramework.Controls.MetroTextBox();
            this.login_Button = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.exit_Button = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.userId_labe = new MetroFramework.Controls.MetroLabel();
            this.password_lable = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // userName_textField
            // 
            // 
            // 
            // 
            this.userName_textField.CustomButton.Image = null;
            this.userName_textField.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.userName_textField.CustomButton.Name = "";
            this.userName_textField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userName_textField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userName_textField.CustomButton.TabIndex = 1;
            this.userName_textField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName_textField.CustomButton.UseSelectable = true;
            this.userName_textField.CustomButton.Visible = false;
            this.userName_textField.Lines = new string[0];
            this.userName_textField.Location = new System.Drawing.Point(232, 88);
            this.userName_textField.MaxLength = 32767;
            this.userName_textField.Name = "userName_textField";
            this.userName_textField.PasswordChar = '\0';
            this.userName_textField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName_textField.SelectedText = "";
            this.userName_textField.SelectionLength = 0;
            this.userName_textField.SelectionStart = 0;
            this.userName_textField.Size = new System.Drawing.Size(159, 23);
            this.userName_textField.TabIndex = 0;
            this.userName_textField.UseSelectable = true;
            this.userName_textField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userName_textField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password_textField
            // 
            // 
            // 
            // 
            this.password_textField.CustomButton.Image = null;
            this.password_textField.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.password_textField.CustomButton.Name = "";
            this.password_textField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_textField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_textField.CustomButton.TabIndex = 1;
            this.password_textField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_textField.CustomButton.UseSelectable = true;
            this.password_textField.CustomButton.Visible = false;
            this.password_textField.Lines = new string[0];
            this.password_textField.Location = new System.Drawing.Point(232, 134);
            this.password_textField.MaxLength = 32767;
            this.password_textField.Name = "password_textField";
            this.password_textField.PasswordChar = '\0';
            this.password_textField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_textField.SelectedText = "";
            this.password_textField.SelectionLength = 0;
            this.password_textField.SelectionStart = 0;
            this.password_textField.Size = new System.Drawing.Size(159, 23);
            this.password_textField.TabIndex = 1;
            this.password_textField.UseSelectable = true;
            this.password_textField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_textField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_Button
            // 
            this.login_Button.Image = null;
            this.login_Button.Location = new System.Drawing.Point(232, 184);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseSelectable = true;
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Image = null;
            this.exit_Button.Location = new System.Drawing.Point(316, 184);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseSelectable = true;
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // userId_labe
            // 
            this.userId_labe.AutoSize = true;
            this.userId_labe.Location = new System.Drawing.Point(156, 88);
            this.userId_labe.Name = "userId_labe";
            this.userId_labe.Size = new System.Drawing.Size(75, 19);
            this.userId_labe.TabIndex = 4;
            this.userId_labe.Text = "User Name";
            // 
            // password_lable
            // 
            this.password_lable.AutoSize = true;
            this.password_lable.Location = new System.Drawing.Point(143, 134);
            this.password_lable.Name = "password_lable";
            this.password_lable.Size = new System.Drawing.Size(64, 19);
            this.password_lable.TabIndex = 5;
            this.password_lable.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(414, 334);
            this.Controls.Add(this.password_lable);
            this.Controls.Add(this.userId_labe);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_textField);
            this.Controls.Add(this.userName_textField);
            this.Name = "LoginForm";
            this.Text = "Login Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userName_textField;
        private MetroFramework.Controls.MetroTextBox password_textField;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton login_Button;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton exit_Button;
        private MetroFramework.Controls.MetroLabel userId_labe;
        private MetroFramework.Controls.MetroLabel password_lable;

    }
}

