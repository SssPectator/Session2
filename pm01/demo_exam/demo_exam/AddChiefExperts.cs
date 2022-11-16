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
    public partial class AddChiefExperts : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public AddChiefExperts()
        {
            InitializeComponent();
        }

        private void AddChiefExpertsBT_Click(object sender, EventArgs e)
        {
            Chief_experts add = new Chief_experts();
            add.ФИО = fioTB.Text;
            add.Сертификат = certfTB.Text;
            add.exam_id = Convert.ToInt32(idExamTB.Text);
            conn.Chief_experts.Add(add);
            conn.SaveChanges();
            MessageBox.Show("Запись успешно добавлена в базу данных!");
            this.Close();
        }
    }
}
