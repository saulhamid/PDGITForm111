﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDGITForm
{
    public partial class Form1 : Form
    {
        StudentInfoDBEntities db = new StudentInfoDBEntities();
        //StudentService service = new StudentService();
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
            displaydata();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                student studentInfo = new student();
                studentInfo.Id = 1;
            studentInfo.Name = stuName.Text;
                studentInfo.Roll =stuRoll.Text;
            studentInfo.Age =Convert.ToInt32(stuAge.Text);
            studentInfo.Gender = stuGender.SelectedItem.ToString();
                //service.Insert(studentInfo);
                db.students.Add(studentInfo);
                db.SaveChanges();
                displaydata();
                clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.studentInfoDBDataSet.StudentInfo);

        }
        private void displaydata() {

            dataGridView1.DataSource = db.students.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());

            ID = Convert.ToInt32( dataGridView1.Rows[currentRow].Cells[1].Value);

            var data = db.students.Find(ID);

            stuName.Text = data.Name;
            stuAge.Text = data.Age.ToString();
            stuRoll.Text = data.Roll;
            stuGender.SelectedItem = data.Gender;

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());

            ID = Convert.ToInt32(dataGridView1.Rows[currentRow].Cells[0].Value);

            var data = db.students.Find(ID);

            stuName.Text = data.Name;
            stuAge.Text = data.Age.ToString();
            stuRoll.Text = data.Roll;
            stuGender.SelectedItem = data.Gender;
        }

        private void update_Click(object sender, DataGridViewCellEventArgs  e)
        {
            student studentInfo = db.students.Find(ID);
            studentInfo.Name = stuName.Text;
            studentInfo.Roll = stuRoll.Text;
            studentInfo.Age = Convert.ToInt32(stuAge.Text);
            studentInfo.Gender = stuGender.SelectedItem.ToString();
            db.SaveChanges();
            displaydata();
            clear();
        }
        private void updatebtn_Click(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());

            ID = Convert.ToInt32(dataGridView1.Rows[currentRow].Cells[0].Value);

            var data = db.students.Find(ID);

            stuName.Text = data.Name;
            stuAge.Text = data.Age.ToString();
            stuRoll.Text = data.Roll;
            stuGender.SelectedItem = data.Gender;
        }
            private void delete_Click(object sender, EventArgs e)
        {
            student studentInfo = db.students.Find(ID);
            db.students.Remove(studentInfo);
            db.SaveChanges();
            displaydata();
            clear();
        }
        private void clear() {
            stuName.Text = "";
            stuAge.Text = "";
            stuRoll.Text = "";
            stuGender.SelectedItem = "";

        }
    }
}
