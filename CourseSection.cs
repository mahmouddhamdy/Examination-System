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
    public partial class CourseSection : UserControl
    {
        public CourseSection()
        {
            InitializeComponent();
        }

        private string crsName;
        private string insName;




        public string CrsName
        {
            get => crsName;
            set
            {
                crsName = value;
                this.CrsNamelbl.Text = value;
            }
        }
        public string InsName
        {
            get => insName;
            set
            {
                insName = value;
                this.InsNameLBl.Text = value;
            }
        }

        public Label Gradelabel { get => this.GradeLabel; }
        public Label Gradevalue { get => this.GradeValue; set => this.GradeValue = value; }

        public Button StartExamBtn { get => this.btnExam; set => this.btnExam = value; }
        public Button AnswerExamBtn { get => this.btnAnswer; set => this.btnAnswer = value; }


    }
}
