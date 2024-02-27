using Microsoft.EntityFrameworkCore;
using OnlineExamination.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamination
{
    public partial class FinalMarkForm : Form
    {
        public static int CrsId;

        ExaminationSystemDBContext context = new ExaminationSystemDBContext();
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


    



        
        public FinalMarkForm()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => context.Dispose();
        }

        private void FinalMarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FinalMarkForm_Load(object sender, EventArgs e)
        {
            var studentID = config.AppSettings.Settings["StudentID"].Value;
            var res = context.StudentCourses.Where(c => c.StudentId == int.Parse(studentID) && c.CourseId==CrsId ).FirstOrDefault();

            this.LabelGrade.Text = $"{res.StudentGrade.ToString()}%";

           /// var courseData = context.Database.SqlQuery<examData>($"exec ExamQuestions_StudentAnswers_ModelAnswers @examID={}, @studentID={studentID}")  Complete

        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.Show();
        }
        /*
        private record examData(string Question, string StudentAnswer, string ModelAnswer);
        */
      
    }
}
