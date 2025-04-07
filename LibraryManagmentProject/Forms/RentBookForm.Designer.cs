namespace LibraryManagmentProject.Forms
{
    partial class RentBookForm
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
            CloseButton = new Button();
            rentThisBookButton = new Button();
            rentNameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            amountOfCopiesInput = new TextBox();
            returnDatePicker = new DateTimePicker();
            maxCopies = new Label();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(437, 222);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(117, 23);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // rentThisBookButton
            // 
            rentThisBookButton.Location = new Point(249, 222);
            rentThisBookButton.Name = "rentThisBookButton";
            rentThisBookButton.Size = new Size(117, 23);
            rentThisBookButton.TabIndex = 1;
            rentThisBookButton.Text = "Rent";
            rentThisBookButton.UseVisualStyleBackColor = true;
            rentThisBookButton.Click += button2_Click;
            // 
            // rentNameLabel
            // 
            rentNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rentNameLabel.Location = new Point(177, 9);
            rentNameLabel.Name = "rentNameLabel";
            rentNameLabel.Size = new Size(467, 51);
            rentNameLabel.TabIndex = 2;
            rentNameLabel.Text = "Renting a Book id = ";
            rentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(163, 110);
            label2.Name = "label2";
            label2.Size = new Size(170, 19);
            label2.TabIndex = 3;
            label2.Text = "amount Of Copies to Rent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(163, 153);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 4;
            label3.Text = "return date";
            // 
            // amountOfCopiesInput
            // 
            amountOfCopiesInput.Location = new Point(339, 109);
            amountOfCopiesInput.Name = "amountOfCopiesInput";
            amountOfCopiesInput.Size = new Size(215, 23);
            amountOfCopiesInput.TabIndex = 5;
            // 
            // returnDatePicker
            // 
            returnDatePicker.Location = new Point(339, 153);
            returnDatePicker.Name = "returnDatePicker";
            returnDatePicker.Size = new Size(215, 23);
            returnDatePicker.TabIndex = 6;
            // 
            // maxCopies
            // 
            maxCopies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            maxCopies.Location = new Point(560, 109);
            maxCopies.Name = "maxCopies";
            maxCopies.Size = new Size(75, 23);
            maxCopies.TabIndex = 7;
            maxCopies.Text = " / ";
            // 
            // RentBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maxCopies);
            Controls.Add(returnDatePicker);
            Controls.Add(amountOfCopiesInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rentNameLabel);
            Controls.Add(rentThisBookButton);
            Controls.Add(CloseButton);
            Name = "RentBookForm";
            Text = "RentBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button rentThisBookButton;
        private Label rentNameLabel;
        private Label label2;
        private Label label3;
        private TextBox amountOfCopiesInput;
        private DateTimePicker returnDatePicker;
        private Label maxCopies;
    }
}