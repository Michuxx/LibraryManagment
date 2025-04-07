namespace LibraryManagmentProject.Forms
{
    partial class UserRegisterForm
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
            label1 = new Label();
            label2 = new Label();
            Password = new Label();
            label4 = new Label();
            registerNameInput = new TextBox();
            registerPasswordInput = new TextBox();
            registerConfirmPasswordInput = new TextBox();
            registerButton = new Button();
            backToLoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(306, 25);
            label1.Name = "label1";
            label1.Size = new Size(181, 58);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(190, 114);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 1;
            label2.Text = "Your Name";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Password.Location = new Point(190, 154);
            Password.Name = "Password";
            Password.Size = new Size(111, 23);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(190, 197);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // registerNameInput
            // 
            registerNameInput.Location = new Point(351, 114);
            registerNameInput.Name = "registerNameInput";
            registerNameInput.Size = new Size(298, 23);
            registerNameInput.TabIndex = 4;
            // 
            // registerPasswordInput
            // 
            registerPasswordInput.Location = new Point(351, 154);
            registerPasswordInput.Name = "registerPasswordInput";
            registerPasswordInput.Size = new Size(298, 23);
            registerPasswordInput.TabIndex = 5;
            // 
            // registerConfirmPasswordInput
            // 
            registerConfirmPasswordInput.Location = new Point(351, 197);
            registerConfirmPasswordInput.Name = "registerConfirmPasswordInput";
            registerConfirmPasswordInput.Size = new Size(298, 23);
            registerConfirmPasswordInput.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            registerButton.Location = new Point(330, 260);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(172, 39);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // backToLoginButton
            // 
            backToLoginButton.Location = new Point(330, 334);
            backToLoginButton.Name = "backToLoginButton";
            backToLoginButton.Size = new Size(172, 23);
            backToLoginButton.TabIndex = 8;
            backToLoginButton.Text = "Back To Login";
            backToLoginButton.UseVisualStyleBackColor = true;
            backToLoginButton.Click += backToLoginButton_Click;
            // 
            // UserRegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 393);
            Controls.Add(backToLoginButton);
            Controls.Add(registerButton);
            Controls.Add(registerConfirmPasswordInput);
            Controls.Add(registerPasswordInput);
            Controls.Add(registerNameInput);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "UserRegisterForm";
            Text = "UserRegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Password;
        private Label label4;
        private TextBox registerNameInput;
        private TextBox registerPasswordInput;
        private TextBox registerConfirmPasswordInput;
        private Button registerButton;
        private Button backToLoginButton;
    }
}