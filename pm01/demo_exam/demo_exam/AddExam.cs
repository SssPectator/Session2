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
    public partial class AddExam : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public AddExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demo_exam add = new Demo_exam();
            add.id_WSR = Convert.ToInt32(idWsrTB.Text);
            add.Компетенция=competitionTB.Text;
            add.Дата_проведения=Convert.ToDateTime(dateExamPicker.Text);
            add.Кол_во_участников=Convert.ToInt32(membersTB.Text);
            add.Кол_во_линейных = Convert.ToInt32(lineTB.Text);
            add.Кол_вотехнических = Convert.ToInt32(techTB.Text);
            add.Кол_во_главных = Convert.ToInt32(chiefTB.Text);
            add.ЦПДЭ = CPDETB.Text;
            add.Учреждение = orgTB.Text;
            conn.Demo_exam.Add(add);
            conn.SaveChanges();
            MessageBox.Show("Запись успешно добавлена в базу данных!");
            this.Close();

        }
    }
}
