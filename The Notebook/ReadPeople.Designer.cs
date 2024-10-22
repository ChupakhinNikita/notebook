namespace The_Notebook
{
    partial class ReadPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadPeople));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRedactorData = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNatureDating = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1536, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 17F);
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ваши контакты в системе:";
            // 
            // buttonRedactorData
            // 
            this.buttonRedactorData.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonRedactorData.Location = new System.Drawing.Point(30, 477);
            this.buttonRedactorData.Name = "buttonRedactorData";
            this.buttonRedactorData.Size = new System.Drawing.Size(575, 47);
            this.buttonRedactorData.TabIndex = 34;
            this.buttonRedactorData.Text = "Сортировать по алфавиту";
            this.buttonRedactorData.UseVisualStyleBackColor = true;
            this.buttonRedactorData.Click += new System.EventHandler(this.buttonRedactorData_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 13F);
            this.label12.Location = new System.Drawing.Point(714, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(530, 22);
            this.label12.TabIndex = 156;
            this.label12.Text = "Вывод контаков с определенном характером знакомства:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13F);
            this.label1.Location = new System.Drawing.Point(725, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 161;
            this.label1.Text = "Характер знакомства:";
            // 
            // textBoxNatureDating
            // 
            this.textBoxNatureDating.Font = new System.Drawing.Font("Consolas", 15F);
            this.textBoxNatureDating.Location = new System.Drawing.Point(941, 491);
            this.textBoxNatureDating.Name = "textBoxNatureDating";
            this.textBoxNatureDating.Size = new System.Drawing.Size(272, 31);
            this.textBoxNatureDating.TabIndex = 160;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MistyRose;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Consolas", 12F);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(760, 548);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 46);
            this.button10.TabIndex = 159;
            this.button10.Text = "Поиск людей";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MistyRose;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Consolas", 12F);
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(1360, 491);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(175, 46);
            this.button11.TabIndex = 158;
            this.button11.Text = "Экспорт в Excel";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 13F);
            this.button1.Location = new System.Drawing.Point(30, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(575, 49);
            this.button1.TabIndex = 162;
            this.button1.Text = "Сортировать по дате знакомства (от новых к старым)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13F);
            this.label3.Location = new System.Drawing.Point(24, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 163;
            this.label3.Text = "Сортировка конатктов:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1005, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 164;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(1360, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 46);
            this.button3.TabIndex = 165;
            this.button3.Text = "Экспорт в Word";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Consolas", 13F);
            this.button4.Location = new System.Drawing.Point(643, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 233);
            this.button4.TabIndex = 166;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Consolas", 13F);
            this.button5.Location = new System.Drawing.Point(1322, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 233);
            this.button5.TabIndex = 167;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 13F);
            this.buttonBack.Location = new System.Drawing.Point(12, 704);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(220, 47);
            this.buttonBack.TabIndex = 168;
            this.buttonBack.Text = "На главную";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 13F);
            this.button6.Location = new System.Drawing.Point(30, 613);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(575, 49);
            this.button6.TabIndex = 169;
            this.button6.Text = "Сортировать по дате добавления";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // ReadPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1560, 763);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNatureDating);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonRedactorData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReadPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.Load += new System.EventHandler(this.ReadPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRedactorData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNatureDating;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button6;
    }
}