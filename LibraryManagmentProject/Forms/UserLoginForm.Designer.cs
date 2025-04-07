namespace LibraryManagmentProject.Forms
{
    partial class UserLoginForm
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
            createAccButton = new Button();
            LoginButton = new Button();
            registerPasswordInput = new TextBox();
            registerNameInput = new TextBox();
            Password = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // createAccButton
            // 
            createAccButton.Location = new Point(301, 287);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(172, 23);
            createAccButton.TabIndex = 17;
            createAccButton.Text = "Create Account";
            createAccButton.UseVisualStyleBackColor = true;
            createAccButton.Click += backToLoginButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.Location = new Point(301, 194);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(172, 39);
            LoginButton.TabIndex = 16;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += registerButton_Click;
            // 
            // registerPasswordInput
            // 
            registerPasswordInput.Location = new Point(332, 135);
            registerPasswordInput.Name = "registerPasswordInput";
            registerPasswordInput.Size = new Size(298, 23);
            registerPasswordInput.TabIndex = 14;
            // 
            // registerNameInput
            // 
            registerNameInput.Location = new Point(332, 95);
            registerNameInput.Name = "registerNameInput";
            registerNameInput.Size = new Size(298, 23);
            registerNameInput.TabIndex = 13;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Password.Location = new Point(171, 135);
            Password.Name = "Password";
            Password.Size = new Size(107, 23);
            Password.TabIndex = 11;
            Password.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(171, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 10;
            label2.Text = "Your Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(285, 6);
            label3.Name = "label3";
            label3.Size = new Size(181, 58);
            label3.TabIndex = 9;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(171, 249);
            label1.Name = "label1";
            label1.Size = new Size(434, 35);
            label1.TabIndex = 18;
            label1.Text = "Do not have account ? Create one by clicking in button Below";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 354);
            Controls.Add(label1);
            Controls.Add(createAccButton);
            Controls.Add(LoginButton);
            Controls.Add(registerPasswordInput);
            Controls.Add(registerNameInput);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createAccButton;
        private Button LoginButton;
        private TextBox registerPasswordInput;
        private TextBox registerNameInput;
        private Label Password;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}