
namespace ZDzaOcjenu
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
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(13, 13);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(142, 23);
            this.AddPerson.TabIndex = 0;
            this.AddPerson.Text = "Dodaj Osobu";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(189, 13);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(142, 23);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Dodaj Osobu";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // Borrow
            // 
            this.Borrow.Location = new System.Drawing.Point(103, 54);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(142, 23);
            this.Borrow.TabIndex = 2;
            this.Borrow.Text = "Zaduži";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 93);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.AddPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button Borrow;
    }
}

