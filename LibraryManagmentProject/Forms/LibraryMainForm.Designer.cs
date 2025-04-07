
namespace LibraryManagmentProject
{
    partial class LibraryMainForm
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
            label1 = new Label();
            addBookButton = new Button();
            deleteBookButton = new Button();
            editBookButton = new Button();
            booksTable = new DataGridView();
            button1 = new Button();
            welcomeLabel = new Label();
            rentBookButton = new Button();
            showRented = new CheckBox();
            returnBookButton = new Button();
            searchBar = new TextBox();
            searchComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)booksTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(2, 12);
            label1.Name = "label1";
            label1.Size = new Size(1321, 42);
            label1.TabIndex = 0;
            label1.Text = "Your Library";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(1207, 96);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(103, 23);
            addBookButton.TabIndex = 1;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // deleteBookButton
            // 
            deleteBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBookButton.Cursor = Cursors.Hand;
            deleteBookButton.Location = new Point(1207, 154);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(103, 23);
            deleteBookButton.TabIndex = 2;
            deleteBookButton.Text = "Delete book";
            deleteBookButton.UseVisualStyleBackColor = true;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // editBookButton
            // 
            editBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBookButton.Location = new Point(1207, 125);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(103, 23);
            editBookButton.TabIndex = 3;
            editBookButton.Text = "Edit Book";
            editBookButton.UseVisualStyleBackColor = true;
            editBookButton.Click += editBookButton_Click_1;
            // 
            // booksTable
            // 
            booksTable.AllowUserToAddRows = false;
            booksTable.AllowUserToDeleteRows = false;
            booksTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            booksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksTable.Location = new Point(12, 197);
            booksTable.MultiSelect = false;
            booksTable.Name = "booksTable";
            booksTable.RowHeadersVisible = false;
            booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksTable.Size = new Size(1298, 384);
            booksTable.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            welcomeLabel.Location = new Point(12, 12);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(75, 19);
            welcomeLabel.TabIndex = 6;
            welcomeLabel.Text = "Welcome ";
            // 
            // rentBookButton
            // 
            rentBookButton.Location = new Point(1207, 67);
            rentBookButton.Name = "rentBookButton";
            rentBookButton.Size = new Size(103, 23);
            rentBookButton.TabIndex = 7;
            rentBookButton.Text = "Rent Book";
            rentBookButton.UseVisualStyleBackColor = true;
            rentBookButton.Click += rentBookButton_Click;
            // 
            // showRented
            // 
            showRented.AutoSize = true;
            showRented.Location = new Point(12, 172);
            showRented.Name = "showRented";
            showRented.Size = new Size(157, 19);
            showRented.TabIndex = 8;
            showRented.Text = "Show your rented Books ";
            showRented.UseVisualStyleBackColor = true;
            showRented.CheckedChanged += showRented_CheckedChanged;
            // 
            // returnBookButton
            // 
            returnBookButton.Enabled = false;
            returnBookButton.Location = new Point(12, 143);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(114, 23);
            returnBookButton.TabIndex = 9;
            returnBookButton.Text = "Return the book";
            returnBookButton.UseVisualStyleBackColor = true;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(253, 168);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(387, 23);
            searchBar.TabIndex = 10;
            searchBar.TextChanged += textBox1_TextChanged;
            // 
            // searchComboBox
            // 
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Location = new Point(646, 168);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(150, 23);
            searchComboBox.TabIndex = 15;
            // 
            // LibraryMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 591);
            Controls.Add(searchComboBox);
            Controls.Add(searchBar);
            Controls.Add(returnBookButton);
            Controls.Add(showRented);
            Controls.Add(rentBookButton);
            Controls.Add(welcomeLabel);
            Controls.Add(button1);
            Controls.Add(booksTable);
            Controls.Add(editBookButton);
            Controls.Add(deleteBookButton);
            Controls.Add(addBookButton);
            Controls.Add(label1);
            Name = "LibraryMainForm";
            Text = "LibraryManagment";
            ((System.ComponentModel.ISupportInitialize)booksTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Button addBookButton;
        private Button deleteBookButton;
        private Button editBookButton;
        private DataGridView booksTable;
        private Button button1;
        private Label welcomeLabel;
        private Button rentBookButton;
        private CheckBox showRented;
        private Button returnBookButton;
        private TextBox searchBar;
        private ComboBox searchComboBox;
    }
}
