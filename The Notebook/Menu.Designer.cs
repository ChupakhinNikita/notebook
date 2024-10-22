namespace The_Notebook
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonReadPeople = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChangePeople = new System.Windows.Forms.Button();
            this.buttonRedactorData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReadPeople
            // 
            this.buttonReadPeople.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonReadPeople.Location = new System.Drawing.Point(122, 148);
            this.buttonReadPeople.Name = "buttonReadPeople";
            this.buttonReadPeople.Size = new System.Drawing.Size(296, 47);
            this.buttonReadPeople.TabIndex = 30;
            this.buttonReadPeople.Text = "Просмотр контактов";
            this.buttonReadPeople.UseVisualStyleBackColor = true;
            this.buttonReadPeople.Click += new System.EventHandler(this.buttonReadPeople_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12.5F);
            this.label3.Location = new System.Drawing.Point(180, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Выберите действие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 17F);
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Главная страница";
            // 
            // buttonChangePeople
            // 
            this.buttonChangePeople.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonChangePeople.Location = new System.Drawing.Point(122, 216);
            this.buttonChangePeople.Name = "buttonChangePeople";
            this.buttonChangePeople.Size = new System.Drawing.Size(296, 47);
            this.buttonChangePeople.TabIndex = 31;
            this.buttonChangePeople.Text = "Редактирование контактов";
            this.buttonChangePeople.UseVisualStyleBackColor = true;
            this.buttonChangePeople.Click += new System.EventHandler(this.buttonChangePeople_Click);
            // 
            // buttonRedactorData
            // 
            this.buttonRedactorData.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonRedactorData.Location = new System.Drawing.Point(122, 362);
            this.buttonRedactorData.Name = "buttonRedactorData";
            this.buttonRedactorData.Size = new System.Drawing.Size(296, 47);
            this.buttonRedactorData.TabIndex = 33;
            this.buttonRedactorData.Text = "Редактирование своих данных";
            this.buttonRedactorData.UseVisualStyleBackColor = true;
            this.buttonRedactorData.Click += new System.EventHandler(this.buttonRedactorData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12.5F);
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Информация о контактах";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 13F);
            this.button1.Location = new System.Drawing.Point(122, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 62);
            this.button1.TabIndex = 35;
            this.button1.Text = "Формирование поздравлений с днем рождения ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(544, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRedactorData);
            this.Controls.Add(this.buttonChangePeople);
            this.Controls.Add(this.buttonReadPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReadPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChangePeople;
        private System.Windows.Forms.Button buttonRedactorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}