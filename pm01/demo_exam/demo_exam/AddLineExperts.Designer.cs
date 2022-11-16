namespace demo_exam
{
    partial class AddLineExperts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.certfTB = new System.Windows.Forms.TextBox();
            this.idExamTB = new System.Windows.Forms.TextBox();
            this.AddLineExpertsBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сертификат";
           
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(12, 25);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(211, 20);
            this.fioTB.TabIndex = 2;
          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Экзамена";
      
            // 
            // certfTB
            // 
            this.certfTB.Location = new System.Drawing.Point(12, 64);
            this.certfTB.Name = "certfTB";
            this.certfTB.Size = new System.Drawing.Size(211, 20);
            this.certfTB.TabIndex = 4;
          
            // 
            // idExamTB
            // 
            this.idExamTB.Location = new System.Drawing.Point(12, 103);
            this.idExamTB.Name = "idExamTB";
            this.idExamTB.Size = new System.Drawing.Size(211, 20);
            this.idExamTB.TabIndex = 5;
         
            // 
            // AddLineExpertsBT
            // 
            this.AddLineExpertsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLineExpertsBT.Location = new System.Drawing.Point(12, 129);
            this.AddLineExpertsBT.Name = "AddLineExpertsBT";
            this.AddLineExpertsBT.Size = new System.Drawing.Size(211, 23);
            this.AddLineExpertsBT.TabIndex = 6;
            this.AddLineExpertsBT.Text = "Добавить линейного эксперта";
            this.AddLineExpertsBT.UseVisualStyleBackColor = true;
            this.AddLineExpertsBT.Click += new System.EventHandler(this.AddLineExpertsBT_Click);
            // 
            // AddLineExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 162);
            this.Controls.Add(this.AddLineExpertsBT);
            this.Controls.Add(this.idExamTB);
            this.Controls.Add(this.certfTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(255, 201);
            this.MinimumSize = new System.Drawing.Size(255, 201);
            this.Name = "AddLineExperts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление линейного эксперта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox certfTB;
        private System.Windows.Forms.TextBox idExamTB;
        private System.Windows.Forms.Button AddLineExpertsBT;
    }
}