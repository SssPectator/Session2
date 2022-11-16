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
    public partial class AddMembers : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public AddMembers()
        {
            InitializeComponent();
        }

        private void AddMembersBT_Click(object sender, EventArgs e)
        {
            Members add = new Members();
            add.ФИО = fioTB.Text;
            add.Учреждение = orgTB.Text;
            add.exam_id = Convert.ToInt32(idExamTB.Text);
            conn.Members.Add(add);
            conn.SaveChanges();
            MessageBox.Show("Запись успешно добавлена в базу данных!");
            this.Close();

        }
    }
}
