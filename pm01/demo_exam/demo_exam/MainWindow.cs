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
    public partial class MainWindow : Form
    {
        pm01v2Entities conn = new pm01v2Entities();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = conn.Demo_exam.ToList();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = conn.Line_experts.ToList();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = conn.techical_experts.ToList();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = conn.Chief_experts.ToList();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.DataSource = conn.Members.ToList();
            }
        }

        private void add_exam_Click(object sender, EventArgs e)
        {
            AddExam addexam = new AddExam();
            addexam.Show();
        }

        private void add_lineExperts_Click(object sender, EventArgs e)
        {
            AddLineExperts addLineExperts = new AddLineExperts();
            addLineExperts.Show();
        }

        private void add_techExperts_Click(object sender, EventArgs e)
        {
            AddTechicalExperts addTechicalExperts = new AddTechicalExperts();
            addTechicalExperts.Show();
        }

        private void add_chiefExperts_Click(object sender, EventArgs e)
        {
            AddChiefExperts addChiefExperts = new AddChiefExperts();
            addChiefExperts.Show();
        }

        private void addMembersBT_Click(object sender, EventArgs e)
        {
            AddMembers addmembers = new AddMembers();
            addmembers.Show();
        }

        private void searhButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = conn.Demo_exam.Where(c=>c.ID_EXAM.ToString().Contains(searchTB.Text)).ToList();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = conn.Line_experts.Where(c => c.ID_LINE.ToString().Contains(searchTB.Text)).ToList();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = conn.techical_experts.Where(c => c.ID_TECHICAL.ToString().Contains(searchTB.Text)).ToList();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = conn.Chief_experts.Where(c => c.ID_CHIEF.ToString().Contains(searchTB.Text)).ToList();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.DataSource = conn.Members.Where(c => c.ID_MEMBERS.ToString().Contains(searchTB.Text)).ToList();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Demo_exam select = conn.Demo_exam.Where(c => c.ID_EXAM.ToString().Contains(deleteTB.Text)).First();
                conn.Demo_exam.Remove(select);
                conn.SaveChanges();
                deleteTB.Clear();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Line_experts select = conn.Line_experts.Where(c => c.ID_LINE.ToString().Contains(deleteTB.Text)).First();
                conn.Line_experts.Remove(select);
                conn.SaveChanges();
                deleteTB.Clear();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                techical_experts select = conn.techical_experts.Where(c => c.ID_TECHICAL.ToString().Contains(deleteTB.Text)).First();
                conn.techical_experts.Remove(select);
                conn.SaveChanges();
                deleteTB.Clear();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Chief_experts select = conn.Chief_experts.Where(c => c.ID_CHIEF.ToString().Contains(deleteTB.Text)).First();
                conn.Chief_experts.Remove(select);
                conn.SaveChanges();
                deleteTB.Clear();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Members select = conn.Members.Where(c => c.ID_MEMBERS.ToString().Contains(deleteTB.Text)).First();
                conn.Members.Remove(select);
                conn.SaveChanges();
                deleteTB.Clear();
            }
        }
    }
}
