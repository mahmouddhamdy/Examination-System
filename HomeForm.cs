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
            //Trace.WriteLine(config.AppSettings.Settings["StudentID"].Value);
       
           /* foreach (var item in crs)
            {

                Trace.WriteLine(item.Course.CourseName);

            }
            */




        }
        private void LoadCourses()
        {
            var stud = context.Students.FirstOrDefault(s => s.Email == Email_student);


            var res = context.StudentCourses.Include(s => s.Course).Where(s => s.StudentId == stud!.StudentId).ToList();

            CourseSection[] courseSection = new CourseSection[res.Count];

            for (int i = 0; i < res.Count; i++)
            {


                courseSection[i] = new CourseSection();
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

                }

                courseSection[i].InsName = "hasssan";
                courseSection[i].CrsName = res[i].Course.CourseName;

                this.flowLayoutPanel1.Controls.Add(courseSection[i]);

                
            }



        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
