namespace demo_exam
{
    partial class AddChiefExperts
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
            this.AddChiefExpertsBT = new System.Windows.Forms.Button();
            this.idExamTB = new System.Windows.Forms.TextBox();
            this.certfTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddChiefExpertsBT
            // 
            this.AddChiefExpertsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChiefExpertsBT.Location = new System.Drawing.Point(12, 129);
            this.AddChiefExpertsBT.Name = "AddChiefExpertsBT";
            this.AddChiefExpertsBT.Size = new System.Drawing.Size(211, 23);
            this.AddChiefExpertsBT.TabIndex = 13;
            this.AddChiefExpertsBT.Text = "Добавить главного эксперта";
            this.AddChiefExpertsBT.UseVisualStyleBackColor = true;
            this.AddChiefExpertsBT.Click += new System.EventHandler(this.AddChiefExpertsBT_Click);
            // 
            // idExamTB
            // 
            this.idExamTB.Location = new System.Drawing.Point(12, 103);
            this.idExamTB.Name = "idExamTB";
            this.idExamTB.Size = new System.Drawing.Size(211, 20);
            this.idExamTB.TabIndex = 12;
            // 
            // certfTB
            // 
            this.certfTB.Location = new System.Drawing.Point(12, 64);
            this.certfTB.Name = "certfTB";
            this.certfTB.Size = new System.Drawing.Size(211, 20);
            this.certfTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Экзамена";
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(12, 25);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(211, 20);
            this.fioTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сертификат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // AddChiefExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 160);
            this.Controls.Add(this.AddChiefExpertsBT);
            this.Controls.Add(this.idExamTB);
            this.Controls.Add(this.certfTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(247, 199);
            this.MinimumSize = new System.Drawing.Size(247, 199);
            this.Name = "AddChiefExperts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доавбление главного эксперта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddChiefExpertsBT;
        private System.Windows.Forms.TextBox idExamTB;
        private System.Windows.Forms.TextBox certfTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}