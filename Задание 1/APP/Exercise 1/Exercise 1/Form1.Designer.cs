namespace Exercise_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbBy = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.cbTypedoc = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cbTypePhone = new System.Windows.Forms.ComboBox();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(64, 210);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(314, 20);
            this.tbFIO.TabIndex = 0;
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(103, 308);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(223, 20);
            this.tbSerial.TabIndex = 1;
            // 
            // tbBy
            // 
            this.tbBy.Location = new System.Drawing.Point(84, 353);
            this.tbBy.Name = "tbBy";
            this.tbBy.Size = new System.Drawing.Size(405, 20);
            this.tbBy.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(114, 399);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(223, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ф.И.О.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Серия и номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип документа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата выдачи:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кем выдан:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Тип телефона:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Номер телефона:";
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cbFloor.Location = new System.Drawing.Point(48, 233);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(69, 21);
            this.cbFloor.TabIndex = 15;
            this.cbFloor.Text = "Пол";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(103, 260);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(138, 20);
            this.dtBirth.TabIndex = 16;
            this.dtBirth.Value = new System.DateTime(2019, 9, 14, 0, 0, 0, 0);
            // 
            // cbTypedoc
            // 
            this.cbTypedoc.FormattingEnabled = true;
            this.cbTypedoc.Location = new System.Drawing.Point(103, 283);
            this.cbTypedoc.Name = "cbTypedoc";
            this.cbTypedoc.Size = new System.Drawing.Size(184, 21);
            this.cbTypedoc.TabIndex = 17;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(103, 330);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(138, 20);
            this.dtDate.TabIndex = 18;
            this.dtDate.Value = new System.DateTime(2019, 9, 14, 0, 0, 0, 0);
            // 
            // cbTypePhone
            // 
            this.cbTypePhone.FormattingEnabled = true;
            this.cbTypePhone.Location = new System.Drawing.Point(98, 375);
            this.cbTypePhone.Name = "cbTypePhone";
            this.cbTypePhone.Size = new System.Drawing.Size(184, 21);
            this.cbTypePhone.TabIndex = 19;
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(6, 10);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(668, 179);
            this.dgEmployee.TabIndex = 20;
            this.dgEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployee_CellDoubleClick);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(48, 425);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(161, 27);
            this.btAdd.TabIndex = 21;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(231, 425);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(161, 27);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(398, 425);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(161, 27);
            this.btDelete.TabIndex = 23;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Поиск:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(384, 210);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(285, 20);
            this.tbSearch.TabIndex = 25;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 470);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.cbTypePhone);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbTypedoc);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbBy);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.tbFIO);
            this.Name = "Form1";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbBy;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.ComboBox cbTypedoc;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ComboBox cbTypePhone;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

