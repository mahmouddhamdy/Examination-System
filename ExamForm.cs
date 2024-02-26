using Microsoft.EntityFrameworkCore;
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
using System.Web;
using System.Windows.Forms;

namespace OnlineExamination
{


    public partial class ExamForm : Form
    {
        public static int ExamID;
        QuestionInfo[] arr;

        BindingSource bindSrc;
        public ExamForm()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => context.Dispose();

        }
        ExaminationSystemDBContext context = new ExaminationSystemDBContext();
        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void ExamForm_Load(object sender, EventArgs e)
        {
            //this.Text = ExamID.ToString();
            List<QuestionsAndChoices> res = context.Database.SqlQuery<QuestionsAndChoices>($"exec questionsAndChoicesFromExamID 1").ToList();


            LoadQuestions(res);

            bindSrc = new(arr,"");

            this.LabelQuestion.DataBindings.Add("Text", bindSrc, "QuestionBody");

            if (arr[0].Question_Type1 == "MCQ")
            {
                panelMCQ.Visible = true;
                panelTF.Visible = false;

            }
            else
            {
                panelMCQ.Visible = false;
                panelTF.Visible = true;
            }





        }

        public record QuestionsAndChoices(string QuestionContent, string Choice_Number, string Content, string Question_Type);

        public class QuestionInfo
        {
            string questionBody;
            List<string> choices_Num = new List<string>();
            List<string> ContectChoices = new List<string>();
            string Question_Type;

            public string QuestionBody { get => questionBody; set => questionBody = value; }
            public List<string> Choices_Num { get => choices_Num; set => choices_Num = value; }
            public List<string> ContectChoices1 { get => ContectChoices; set => ContectChoices = value; }
            public string Question_Type1 { get => Question_Type; set => Question_Type = value; }
        };


        private void LoadQuestions(List<QuestionsAndChoices> res)
        {
            arr = new QuestionInfo[10];

            int indx = 0;
            int indx2 = 0;
            while (indx < res.Count)
            {
                ///MCQ >>> index+4 , ch+4
                ///
                arr[indx2] = new();
                arr[indx2].QuestionBody = res[indx].QuestionContent;

                if (res[indx].Question_Type == "MCQ")
                {

                    for (int j = 0; j < 4; j++)
                    {
                        arr[indx2].Choices_Num.Add(res[indx].Choice_Number);
                        arr[indx2].ContectChoices1.Add(res[indx].Content);
                        arr[indx2].Question_Type1 = "MCQ";
                        indx++;
                    }


                    indx2++;

                }
                else
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arr[indx2].Choices_Num.Add(res[indx].Choice_Number);
                        arr[indx2].ContectChoices1.Add(res[indx].Content);
                        arr[indx2].Question_Type1 = "T/F";
                        indx++;
                    }


                    indx2++;


                }

            }
        }

            int indx = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {

            bindSrc.MoveNext();
            if (arr[indx].Question_Type1 == "MCQ")
            {
                panelMCQ.Visible = true;
                panelTF.Visible= false;

            }
            else
            {
                panelMCQ.Visible= false;
                panelTF.Visible= true;
            }
           
            if (indx < 9)
            {
                indx++;
            }
            
           
        }

        private void ptnPrev_Click(object sender, EventArgs e)
        {
            bindSrc.MovePrevious();

            if (arr[indx].Question_Type1 == "MCQ")
            {
                panelMCQ.Visible = true;
                panelTF.Visible = false;

            }
            else
            {
                panelMCQ.Visible = false;
                panelTF.Visible = true;
            }

            if (indx > 0)
                indx--;
            
          
        }
    }
}
