namespace LibraryManagmentProject
{
    partial class AddOrEditBookForm
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
            titleText = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbTitle = new TextBox();
            tbAuthor = new TextBox();
            thPb = new TextBox();
            tbGenre = new TextBox();
            tbIsbn = new TextBox();
            AddNewBookButton = new Button();
            cancelAddingButton = new Button();
            amountOfCopiesInput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleText
            // 
            titleText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleText.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            titleText.Location = new Point(12, 9);
            titleText.Name = "titleText";
            titleText.Size = new Size(776, 44);
            titleText.TabIndex = 0;
            titleText.Text = "Create Book";
            titleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(188, 93);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(188, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(188, 153);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 3;
            label4.Text = "Published Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(188, 183);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 4;
            label5.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(188, 212);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 5;
            label6.Text = "ISBN";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(325, 93);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(276, 23);
            tbTitle.TabIndex = 6;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(325, 123);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(276, 23);
            tbAuthor.TabIndex = 7;
            // 
            // thPb
            // 
            thPb.Location = new Point(325, 153);
            thPb.Name = "thPb";
            thPb.Size = new Size(276, 23);
            thPb.TabIndex = 8;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(325, 183);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(276, 23);
            tbGenre.TabIndex = 9;
            // 
            // tbIsbn
            // 
            tbIsbn.Location = new Point(325, 212);
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(276, 23);
            tbIsbn.TabIndex = 10;
            // 
            // AddNewBookButton
            // 
            AddNewBookButton.Location = new Point(202, 298);
            AddNewBookButton.Name = "AddNewBookButton";
            AddNewBookButton.Size = new Size(108, 23);
            AddNewBookButton.TabIndex = 11;
            AddNewBookButton.Text = "Add New Book";
            AddNewBookButton.UseVisualStyleBackColor = true;
            AddNewBookButton.Click += button1_Click;
            // 
            // cancelAddingButton
            // 
            cancelAddingButton.Location = new Point(474, 298);
            cancelAddingButton.Name = "cancelAddingButton";
            cancelAddingButton.Size = new Size(111, 23);
            cancelAddingButton.TabIndex = 12;
            cancelAddingButton.Text = "Cancel";
            cancelAddingButton.UseVisualStyleBackColor = true;
            cancelAddingButton.Click += button1_Click_1;
            // 
            // amountOfCopiesInput
            // 
            amountOfCopiesInput.Location = new Point(325, 241);
            amountOfCopiesInput.Name = "amountOfCopiesInput";
            amountOfCopiesInput.Size = new Size(276, 23);
            amountOfCopiesInput.TabIndex = 14;
            amountOfCopiesInput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(188, 243);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 13;
            label1.Text = "Amount Of Copies";
            // 
            // AddOrEditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(amountOfCopiesInput);
            Controls.Add(label1);
            Controls.Add(cancelAddingButton);
            Controls.Add(AddNewBookButton);
            Controls.Add(tbIsbn);
            Controls.Add(tbGenre);
            Controls.Add(thPb);
            Controls.Add(tbAuthor);
            Controls.Add(tbTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titleText);
            Name = "AddOrEditBookForm";
            Text = "CreateOrEditForm";
            Load += AddOrEditBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbTitle;
        private TextBox tbAuthor;
        private TextBox thPb;
        private TextBox tbGenre;
        private TextBox tbIsbn;
        private Button AddNewBookButton;

        private void label4_Click(object sender, EventArgs e)
        {
            // Add your event handler code here
        }
        private Button cancelAddingButton;
        private TextBox amountOfCopiesInput;
        private Label label1;
    }
}
