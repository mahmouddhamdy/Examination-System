using Microsoft.EntityFrameworkCore;
using OnlineExamination.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamination
{
    public partial class HomeForm : Form
    {

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        ExaminationSystemDBContext context = new ExaminationSystemDBContext();
        string Email_student;
        ExamInfoForm examInfo = new();
        public HomeForm()
        {
            InitializeComponent();
            //  this.loginFrm = frm;
            this.FormClosing += (sender, e) => { this.context.Dispose(); };
            Email_student = config.AppSettings.Settings["StudentID"].Value;
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCourses();


            this.Text = Email_student;
       




        }

        private void LoadCourses()
        {
            var stud = context.Students.FirstOrDefault(s => s.Email == Email_student);

            var res = context.StudentCourses.Include(s => s.Course).ThenInclude(c=>c.Ins).Where(s => s.StudentId == stud!.StudentId).ToList();


            //var ins = context.Courses.Include(i=>i.Ins).Select(i => i).ToList();


            CourseSection[] courseSection = new CourseSection[res.Count];

            for (int i = 0; i < res.Count; i++)
            {

                string crsName ="";

                StringBuilder stringBuilder= new StringBuilder();
                foreach (var instructor in res[i].Course.Ins)
                {
                    stringBuilder.Append(instructor.InstructorName);
                    stringBuilder.Append(',');
                    
                }
                string instructorNames = stringBuilder.ToString();


                courseSection[i] = new CourseSection();

                courseSection[i].InsName = instructorNames;
                courseSection[i].CrsName = res[i].Course.CourseName;
                crsName = res[i].Course.CourseName;

                if (res[i].StudentGrade != null)
                {
                    courseSection[i].StartExamBtn.Visible = false;
                    courseSection[i].Gradevalue.Text = res[i].StudentGrade.ToString();
                    
                }
                else
                {
                    courseSection[i].Gradelabel.Visible = false;
                    courseSection[i].Gradevalue.Visible = false;
                    courseSection[i].AnswerExamBtn.Visible = false;

                    
                    courseSection[i].StartExamBtn.Click += (s, e) =>
                    {
                        this.Hide();
                        ExamInfoForm.crsName = crsName;
                        examInfo.Show();
                        
                        
                    };

                }

            

                this.flowLayoutPanel1.Controls.Add(courseSection[i]);

                
            }



        }
      
        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
