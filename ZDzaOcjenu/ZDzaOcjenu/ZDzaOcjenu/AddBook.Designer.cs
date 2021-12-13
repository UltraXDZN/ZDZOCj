
namespace ZDzaOcjenu
{
    partial class AddBook
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
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.bookAuthorL = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(95, 9);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(24, 13);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "Ime";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(57, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 1;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(57, 73);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(100, 20);
            this.authorTB.TabIndex = 3;
            // 
            // bookAuthorL
            // 
            this.bookAuthorL.AutoSize = true;
            this.bookAuthorL.Location = new System.Drawing.Point(87, 57);
            this.bookAuthorL.Name = "bookAuthorL";
            this.bookAuthorL.Size = new System.Drawing.Size(32, 13);
            this.bookAuthorL.TabIndex = 2;
            this.bookAuthorL.Text = "Autor";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(12, 159);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 6;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(123, 159);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 7;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(55, 125);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 9;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(95, 109);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(18, 13);
            this.idL.TabIndex = 8;
            this.idL.Text = "ID";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 254);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.bookAuthorL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.Label bookAuthorL;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label idL;
    }
}