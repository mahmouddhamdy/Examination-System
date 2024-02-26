using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using OnlineExamination.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamination
{
    public partial class ExamInfoForm : Form
    {
        public static string crsName;
        ExamForm examform = new();
        public ExamInfoForm()
        {
            InitializeComponent();

            this.FormClosing += (sender, e) => context.Dispose();
        }

        ExaminationSystemDBContext context = new();

        int r;
        private void ExamInfoForm_Load(object sender, EventArgs e)
        {


            try
            {
                Random random = new Random();
                int noTF = random.Next(0, 11);
                int noMCQ = 10 - noTF;


                r = context.Database.ExecuteSql($"exec Exam_Generation {crsName},{noMCQ},{noTF}");

                if (r != 0)
                {
                    var resExam = context.Exams.OrderBy(e => e.ExamId).Last();

                    this.LabelCrsName.Text = crsName;
                    this.NoQuestionlabel.Text = $"10 MCQ = {noMCQ} and T/F = {noTF}";
                    this.labelDuration.Text = resExam.ExamDuration.ToString();

                    ExamForm.ExamID = resExam.ExamId;
                }

            }
            catch { }


        }


        private void StartExambtn_Click(object sender, EventArgs e)
        {
            if (r != 0)
            {
                this.Hide();
                examform.Show();

            }

        }

        private void ExamInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
