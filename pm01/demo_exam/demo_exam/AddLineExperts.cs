using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_exam
{
    public partial class AddLineExperts : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public AddLineExperts()
        {
            InitializeComponent();
        }

        private void AddLineExpertsBT_Click(object sender, EventArgs e)
        {
            Line_experts add=new Line_experts();
            add.ФИО=fioTB.Text;
            add.Сертификат = certfTB.Text;
            add.exam_id =Convert.ToInt32(idExamTB.Text);
            conn.Line_experts.Add(add);
            conn.SaveChanges();
            MessageBox.Show("Запись успешно добавлена в базу данных!");
            this.Close();
        }

    
    }
}
