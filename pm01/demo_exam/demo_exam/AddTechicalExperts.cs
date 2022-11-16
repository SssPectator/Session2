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
    public partial class AddTechicalExperts : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public AddTechicalExperts()
        {
            InitializeComponent();
        }

        private void AddTechicalExpertsBT_Click(object sender, EventArgs e)
        {
            techical_experts add = new techical_experts();
            add.ФИО = fioTB.Text;
            add.Сертификат = certfTB.Text;
            add.exam_id = Convert.ToInt32(idExamTB.Text);
            conn.techical_experts.Add(add);
            conn.SaveChanges();
            MessageBox.Show("Запись успешно добавлена в базу данных!");
            this.Close();
        }
    }
}
