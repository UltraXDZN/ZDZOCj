
namespace ZDzaOcjenu
{
    partial class AddPerson
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
            this.saveB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.ageL = new System.Windows.Forms.Label();
            this.secondNameTB = new System.Windows.Forms.TextBox();
            this.secondNameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(144, 215);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 15;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(33, 215);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 14;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(81, 127);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 20);
            this.ageTB.TabIndex = 13;
            // 
            // ageL
            // 
            this.ageL.AutoSize = true;
            this.ageL.Location = new System.Drawing.Point(108, 111);
            this.ageL.Name = "ageL";
            this.ageL.Size = new System.Drawing.Size(41, 13);
            this.ageL.TabIndex = 12;
            this.ageL.Text = "Godine";
            // 
            // secondNameTB
            // 
            this.secondNameTB.Location = new System.Drawing.Point(81, 73);
            this.secondNameTB.Name = "secondNameTB";
            this.secondNameTB.Size = new System.Drawing.Size(100, 20);
            this.secondNameTB.TabIndex = 11;
            // 
            // secondNameL
            // 
            this.secondNameL.AutoSize = true;
            this.secondNameL.Location = new System.Drawing.Point(108, 57);
            this.secondNameL.Name = "secondNameL";
            this.secondNameL.Size = new System.Drawing.Size(44, 13);
            this.secondNameL.TabIndex = 10;
            this.secondNameL.Text = "Prezime";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(81, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 9;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(119, 9);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(24, 13);
            this.nameL.TabIndex = 8;
            this.nameL.Text = "Ime";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(81, 179);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 17;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(119, 163);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(18, 13);
            this.idL.TabIndex = 16;
            this.idL.Text = "ID";
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.ageL);
            this.Controls.Add(this.secondNameTB);
            this.Controls.Add(this.secondNameL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label ageL;
        private System.Windows.Forms.TextBox secondNameTB;
        private System.Windows.Forms.Label secondNameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label idL;
    }
}