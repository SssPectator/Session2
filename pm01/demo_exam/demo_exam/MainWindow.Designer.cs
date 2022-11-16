namespace demo_exam
{
    partial class MainWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_exam = new System.Windows.Forms.Button();
            this.add_lineExperts = new System.Windows.Forms.Button();
            this.add_techExperts = new System.Windows.Forms.Button();
            this.add_chiefExperts = new System.Windows.Forms.Button();
            this.addMembersBT = new System.Windows.Forms.Button();
            this.searhButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_exam
            // 
            this.add_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_exam.Location = new System.Drawing.Point(12, 219);
            this.add_exam.Name = "add_exam";
            this.add_exam.Size = new System.Drawing.Size(156, 23);
            this.add_exam.TabIndex = 1;
            this.add_exam.Text = "Добавление экзамена";
            this.add_exam.UseVisualStyleBackColor = true;
            this.add_exam.Click += new System.EventHandler(this.add_exam_Click);
            // 
            // add_lineExperts
            // 
            this.add_lineExperts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_lineExperts.Location = new System.Drawing.Point(12, 248);
            this.add_lineExperts.Name = "add_lineExperts";
            this.add_lineExperts.Size = new System.Drawing.Size(156, 23);
            this.add_lineExperts.TabIndex = 2;
            this.add_lineExperts.Text = "Добавление лин. эксперта";
            this.add_lineExperts.UseVisualStyleBackColor = true;
            this.add_lineExperts.Click += new System.EventHandler(this.add_lineExperts_Click);
            // 
            // add_techExperts
            // 
            this.add_techExperts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_techExperts.Location = new System.Drawing.Point(12, 277);
            this.add_techExperts.Name = "add_techExperts";
            this.add_techExperts.Size = new System.Drawing.Size(156, 23);
            this.add_techExperts.TabIndex = 3;
            this.add_techExperts.Text = "Добавление тех. эксперта";
            this.add_techExperts.UseVisualStyleBackColor = true;
            this.add_techExperts.Click += new System.EventHandler(this.add_techExperts_Click);
            // 
            // add_chiefExperts
            // 
            this.add_chiefExperts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_chiefExperts.Location = new System.Drawing.Point(12, 306);
            this.add_chiefExperts.Name = "add_chiefExperts";
            this.add_chiefExperts.Size = new System.Drawing.Size(156, 23);
            this.add_chiefExperts.TabIndex = 4;
            this.add_chiefExperts.Text = "Доавбление гл. эксперта";
            this.add_chiefExperts.UseVisualStyleBackColor = true;
            this.add_chiefExperts.Click += new System.EventHandler(this.add_chiefExperts_Click);
            // 
            // addMembersBT
            // 
            this.addMembersBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMembersBT.Location = new System.Drawing.Point(12, 335);
            this.addMembersBT.Name = "addMembersBT";
            this.addMembersBT.Size = new System.Drawing.Size(156, 23);
            this.addMembersBT.TabIndex = 5;
            this.addMembersBT.Text = "Добавление участника";
            this.addMembersBT.UseVisualStyleBackColor = true;
            this.addMembersBT.Click += new System.EventHandler(this.addMembersBT_Click);
            // 
            // searhButton
            // 
            this.searhButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searhButton.Location = new System.Drawing.Point(174, 261);
            this.searhButton.Name = "searhButton";
            this.searhButton.Size = new System.Drawing.Size(189, 23);
            this.searhButton.TabIndex = 6;
            this.searhButton.Text = "Поиск";
            this.searhButton.UseVisualStyleBackColor = true;
            this.searhButton.Click += new System.EventHandler(this.searhButton_Click);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Location = new System.Drawing.Point(174, 335);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(189, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Демонстрационные экзамены",
            "Линейные эксперты",
            "Технические эксперты",
            "Главные эксперты",
            "Участники"});
            this.comboBox1.Location = new System.Drawing.Point(486, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выбор таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите ID из выведенной таблицы";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(174, 235);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(189, 20);
            this.searchTB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите ID из выведенной таблицы";
            // 
            // deleteTB
            // 
            this.deleteTB.Location = new System.Drawing.Point(174, 309);
            this.deleteTB.Name = "deleteTB";
            this.deleteTB.Size = new System.Drawing.Size(189, 20);
            this.deleteTB.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(691, 368);
            this.Controls.Add(this.deleteTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.searhButton);
            this.Controls.Add(this.addMembersBT);
            this.Controls.Add(this.add_chiefExperts);
            this.Controls.Add(this.add_techExperts);
            this.Controls.Add(this.add_lineExperts);
            this.Controls.Add(this.add_exam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрационные экзамены";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_exam;
        private System.Windows.Forms.Button add_lineExperts;
        private System.Windows.Forms.Button add_techExperts;
        private System.Windows.Forms.Button add_chiefExperts;
        private System.Windows.Forms.Button addMembersBT;
        private System.Windows.Forms.Button searhButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteTB;
    }
}

