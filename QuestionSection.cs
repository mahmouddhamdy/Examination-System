using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamination
{
    public partial class QuestionSection : UserControl
    {
        private string QuestionBody;
        private List<string> ChoicesContent;
        private List<string> ChoicesNum;
        private string TypeQuestion;
      

        public QuestionSection(string qb , List<string> cc  , List<string> CN , string TQ )
        {

            InitializeComponent();

            QuestionBody1 = qb;
            TypeQuestion1= TQ;
            ChoicesContent1 = cc;
            ChoicesNum1= CN;

        }

    
        public string QuestionBody1 { get => QuestionBody;
            set
            {
                QuestionBody = value;
                labelQuestion.Text = value;
            } 
        }

        public List<string> ChoicesContent1 { get => ChoicesContent;
            set 
            {
                ChoicesContent = value;


                if (TypeQuestion1 == "MCQ")
                {
                 
                    this.radioMCQ1.Text = ChoicesContent[0];
                    this.radioMCQ2.Text = ChoicesContent[1];
                    this.radioMCQ3.Text = ChoicesContent[2];
                    this.radioMCQ4.Text = ChoicesContent[3];

                   /* this.radioMCQ1.Tag = ChoicesNum[0];
                    this.radioMCQ2.Tag = ChoicesNum[1];
                    this.radioMCQ3.Tag = ChoicesNum[2];
                    this.radioMCQ4.Tag = ChoicesNum[3];

                    */


                    //this.radioMCQ3.Text = arr[indx].ContectChoices1[2];
                    // this.radioMCQ4.Text = arr[indx].ContectChoices1[3]

                }
                else
                {

                    this.radioMCQ1.Text = ChoicesContent[0];
                    this.radioMCQ3.Text = ChoicesContent[1];
                    this.radioMCQ2.Visible = false;
                    this.radioMCQ4.Visible = false;

                  /*  this.radioMCQ1.Tag = ChoicesNum[0];
                    this.radioMCQ3.Tag = ChoicesNum[1];
                  */

                    
                    
                }

            }
        }

        public List<string> ChoicesNum1 { get => ChoicesNum; set
            {
                ChoicesNum = value;
                if (TypeQuestion1 == "MCQ")
                {

                     this.radioMCQ1.Tag = ChoicesNum[0];
                     this.radioMCQ2.Tag = ChoicesNum[1];
                     this.radioMCQ3.Tag = ChoicesNum[2];
                     this.radioMCQ4.Tag = ChoicesNum[3];


                }
                else
                {
                      this.radioMCQ1.Tag = ChoicesNum[0];
                      this.radioMCQ3.Tag = ChoicesNum[1];


                }
            }
        }
        public string TypeQuestion1 { get => TypeQuestion; set => TypeQuestion = value; }
      

        public QuestionSection()
        {
            InitializeComponent();
        }

    }
}
