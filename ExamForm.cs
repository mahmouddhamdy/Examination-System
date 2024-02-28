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
        private System.Windows.Forms.Timer examTimer = new();
        private int remainingTime;

        bool flagClicked = false;
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
            List<QuestionsAndChoices> res = context.Database.SqlQuery<QuestionsAndChoices>($"exec questionsAndChoicesFromExamID {ExamID}").ToList();
            var exam = context.Exams.Where(x => x.ExamId == ExamID).FirstOrDefault(); //ExamID to be added
            LoadQuestions(res);

            QuesSection[indx] = new QuestionSection();
            QuesSection[indx] = new QuestionSection(arr[indx].QuestionBody, arr[indx].ContentChoices, arr[indx].ChoicesNum, arr[indx].QuestionType);

            this.panelQuestion.Controls.Add(QuesSection[indx]);
            Visited.Add(indx);
            bindSrc = new(QuesSection, "");



            StartTimer(int.Parse(exam.ExamDuration));

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
            checkForUserAnswer();


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
            string selectedTag = " ";

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
            checkForUserAnswer();

            finalizeUserAnswers();
            flagClicked=true;

        }

        private void finalizeUserAnswers()
        {
            FinalMarkForm finalMarkForm = new FinalMarkForm();

            var studentID = config.AppSettings.Settings["StudentID"].Value;
            string[] userAnswerValues = new string[10];
            string[] temp = new string[10];

            for (int i = 0; i < userAnswerValues.Length; i++)
            {
                userAnswerValues[i] = " ";
            }

            temp = userAnswer.Values.ToArray<string>();
            for (int i = 0; i < temp.Length; i++)
            {

                
                userAnswerValues[i] = temp[i];


            }

            Trace.WriteLine("test1");
            var result = context.Database.ExecuteSql($"""
                                                      Exam_Answers {ExamID}, {studentID},{userAnswerValues[0]},{userAnswerValues[1]},
                                                      {userAnswerValues[2]},{userAnswerValues[3]},{userAnswerValues[4]},{userAnswerValues[5]},
                                                      {userAnswerValues[6]},{userAnswerValues[7]},{userAnswerValues[8]},{userAnswerValues[9]}
                                                      """);
            Trace.WriteLine("test2");
            if (result != 0)
            {
                var r = context.Database.ExecuteSql($"Exam_Correct {ExamID} , {studentID}");
                if (r != 0)
                {
                     this.Hide();
                    //this.Close();
                    finalMarkForm.Show();
                }
            }
        }

        private void checkForUserAnswer()
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
        }

        private void StartTimer(int totalTimeInMinutes)
        {
            examTimer.Interval = 1000;
            examTimer.Tick += Timer_Tick;

            remainingTime = totalTimeInMinutes * 60; // Convert total time to seconds

            UpdateTimerLabel(); // Update the initial timer label

            examTimer.Start(); // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--; 

            if (remainingTime <= 0)
            {
                examTimer.Stop(); // Stop the timer if the time is up
                                  //MessageBox.Show("Time's up!");
                PerformEndActions(); // Call the function that will happen when the timer ends
            }
            UpdateTimerLabel();
        }

        private void PerformEndActions()
        {
            if (flagClicked == false)
            {
                checkForUserAnswer();
                finalizeUserAnswers();
            }
           
        }


        private void UpdateTimerLabel()
        {
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            lblTimer.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
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
