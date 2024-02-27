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
using System.Web;
using System.Windows.Forms;

namespace OnlineExamination
{


    public partial class ExamForm : Form
    {
        public static int ExamID;
        QuestionInfo[] arr;
        int indx = 0;
        private List<int> Visited = new List<int>();
        private Dictionary<int, string> userAnswer = new();
        QuestionSection[] QuesSection = new QuestionSection[10];
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


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
            List<QuestionsAndChoices> res = context.Database.SqlQuery<QuestionsAndChoices>($"exec questionsAndChoicesFromExamID 1").ToList();
            LoadQuestions(res);

            QuesSection[indx] = new QuestionSection();
            QuesSection[indx] = new QuestionSection(arr[indx].QuestionBody, arr[indx].ContentChoices, arr[indx].ChoicesNum, arr[indx].QuestionType);

            this.panelQuestion.Controls.Add(QuesSection[indx]);
            Visited.Add(indx);
            bindSrc = new(QuesSection, "");





        }


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
                        arr[indx2].ChoicesNum.Add(res[indx].Choice_Number);
                        arr[indx2].ContentChoices.Add(res[indx].Content);
                        arr[indx2].QuestionType = "MCQ";
                        indx++;
                    }


                    indx2++;

                }
                else
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arr[indx2].ChoicesNum.Add(res[indx].Choice_Number);
                        arr[indx2].ContentChoices.Add(res[indx].Content);
                        arr[indx2].QuestionType = "T/F";
                        indx++;
                    }


                    indx2++;


                }

            }
        }




        private void btnNext_Click(object sender, EventArgs e)
        {

            bindSrc.MoveNext();
            bool indexExists = userAnswer.ContainsKey(indx);

            string selectedTag = getUserAnswer();
            if (indexExists)
            {
                userAnswer[indx] = selectedTag;
            }
            else
            {
                userAnswer.Add(indx, selectedTag);
            }


            if (indx < 9)
            {

                
                indx++;

                if (!Visited.Contains(indx))
                {
                    QuesSection[indx] = new QuestionSection();

                    QuesSection[indx] = new QuestionSection(arr[indx].QuestionBody, arr[indx].ContentChoices, arr[indx].ChoicesNum, arr[indx].QuestionType);

                    Visited.Add(indx);

                }

                this.panelQuestion.Controls.Clear();
                this.panelQuestion.Controls.Add(QuesSection[indx]);

            }
            if (indx == 9)
            {
                finishExamButton.Visible = true;
             
            }



        }

        private string getUserAnswer()
        {
            string selectedTag = "";

            if (QuesSection[indx].RadioMCQ1.Checked == true)
            {
                selectedTag = QuesSection[indx].RadioMCQ1.Tag.ToString();
            }

            else if (QuesSection[indx].RadioMCQ2.Checked == true)
            {
                selectedTag = QuesSection[indx].RadioMCQ2.Tag.ToString();


            }
            else if (QuesSection[indx].RadioMCQ3.Checked == true)
            {
                selectedTag = QuesSection[indx].RadioMCQ3.Tag.ToString();


            }
            else if (QuesSection[indx].RadioMCQ4.Checked == true)
            {
                selectedTag = QuesSection[indx].RadioMCQ4.Tag.ToString();


            }

            return selectedTag;
        }

        private void ptnPrev_Click(object sender, EventArgs e)
        {
            finishExamButton.Visible = false;
            bindSrc.MovePrevious();


            if (indx > 0)
            {
                indx--;
                this.panelQuestion.Controls.Clear();
                this.panelQuestion.Controls.Add(QuesSection[indx]);

            }




        }

        private void finishExamButton_Click(object sender, EventArgs e)
        {
            bool indexExists = userAnswer.ContainsKey(indx);

            string selectedTag = getUserAnswer();
            if (indexExists)
            {
                userAnswer[indx] = selectedTag;
            }
            else
            {
                userAnswer.Add(indx, selectedTag);
            }
            var studentID = config.AppSettings.Settings["StudentID"].Value;
            List<string> userAnswerValues = new();
            userAnswerValues = userAnswer.Values.ToList();
            var result = context.Database.ExecuteSql($"""
                                                      Exam_Answers {ExamID}, {studentID},{userAnswerValues[0]},{userAnswerValues[1]},
                                                      {userAnswerValues[2]},{userAnswerValues[3]},{userAnswerValues[4]},{userAnswerValues[5]},
                                                      {userAnswerValues[6]},{userAnswerValues[7]},{userAnswerValues[8]},{userAnswerValues[9]},)
                                                      """);
        }
    }

    public record QuestionsAndChoices(string QuestionContent, string Choice_Number, string Content, string Question_Type);

    public class QuestionInfo
    {
        string questionBody;
        List<string> choicesNum = new List<string>();
        List<string> contentChoices = new List<string>();
        string questionType;

        public string QuestionBody { get => questionBody; set => questionBody = value; }
        public List<string> ChoicesNum { get => choicesNum; set => choicesNum = value; }
        public List<string> ContentChoices { get => contentChoices; set => contentChoices = value; }
        public string QuestionType { get => questionType; set => questionType = value; }
    };
}
