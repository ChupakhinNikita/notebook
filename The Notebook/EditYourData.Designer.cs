namespace The_Notebook
{
    partial class EditYourData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYourData));
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxLoginReg = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.5F);
            this.label9.Location = new System.Drawing.Point(35, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.5F);
            this.label7.Location = new System.Drawing.Point(35, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Пароль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.5F);
            this.label8.Location = new System.Drawing.Point(35, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Логин";
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Font = new System.Drawing.Font("Consolas", 15F);
            this.textBoxPasswordReg.Location = new System.Drawing.Point(30, 278);
            this.textBoxPasswordReg.Multiline = true;
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(478, 36);
            this.textBoxPasswordReg.TabIndex = 31;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonChange.Location = new System.Drawing.Point(297, 349);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(198, 47);
            this.buttonChange.TabIndex = 30;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxLoginReg
            // 
            this.textBoxLoginReg.Font = new System.Drawing.Font("Consolas", 15F);
            this.textBoxLoginReg.Location = new System.Drawing.Point(30, 192);
            this.textBoxLoginReg.Multiline = true;
            this.textBoxLoginReg.Name = "textBoxLoginReg";
            this.textBoxLoginReg.Size = new System.Drawing.Size(478, 36);
            this.textBoxLoginReg.TabIndex = 29;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxName.Location = new System.Drawing.Point(30, 116);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(478, 36);
            this.textBoxName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Внесите изменения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 17F);
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Редактирование своих данных";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonBack.Location = new System.Drawing.Point(39, 349);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(198, 47);
            this.buttonBack.TabIndex = 35;
            this.buttonBack.Text = "На главную";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EditYourData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(544, 436);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPasswordReg);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxLoginReg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditYourData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.Load += new System.EventHandler(this.EditYourData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxLoginReg;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
    }
}