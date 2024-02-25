namespace OnlineExamination
{
    partial class CourseSection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CrsNamelbl = new Label();
            InsNameLBl = new Label();
            GradeValue = new Label();
            btnExam = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            GradeLabel = new Label();
            btnAnswer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CrsNamelbl
            // 
            CrsNamelbl.AutoSize = true;
            CrsNamelbl.Font = new Font("Arial", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrsNamelbl.ForeColor = SystemColors.ControlLightLight;
            CrsNamelbl.Location = new Point(551, 38);
            CrsNamelbl.Name = "CrsNamelbl";
            CrsNamelbl.Size = new Size(119, 26);
            CrsNamelbl.TabIndex = 0;
            CrsNamelbl.Text = "Crs Name ";
            // 
            // InsNameLBl
            // 
            InsNameLBl.AutoSize = true;
            InsNameLBl.Font = new Font("Arial", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsNameLBl.ForeColor = Color.White;
            InsNameLBl.Location = new Point(551, 109);
            InsNameLBl.Name = "InsNameLBl";
            InsNameLBl.Size = new Size(101, 26);
            InsNameLBl.TabIndex = 1;
            InsNameLBl.Text = "InsName";
            // 
            // GradeValue
            // 
            GradeValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GradeValue.AutoSize = true;
            GradeValue.Font = new Font("Arial", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradeValue.ForeColor = SystemColors.ControlLight;
            GradeValue.Location = new Point(938, 42);
            GradeValue.Name = "GradeValue";
            GradeValue.Size = new Size(74, 26);
            GradeValue.TabIndex = 2;
            GradeValue.Text = "Grade";
            // 
            // btnExam
            // 
            btnExam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExam.BackColor = Color.White;
            btnExam.Font = new Font("Arial", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExam.ForeColor = Color.DarkOrange;
            btnExam.Location = new Point(822, 101);
            btnExam.Name = "btnExam";
            btnExam.Size = new Size(190, 37);
            btnExam.TabIndex = 3;
            btnExam.Text = "Start Exam";
            btnExam.UseVisualStyleBackColor = false;
         
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_02_25_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(310, 35);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 5;
            label1.Text = "Course Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(310, 105);
            label2.Name = "label2";
            label2.Size = new Size(221, 30);
            label2.TabIndex = 6;
            label2.Text = "Instractor Name:";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Font = new Font("Arial", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradeLabel.ForeColor = Color.White;
            GradeLabel.Location = new Point(751, 38);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(162, 30);
            GradeLabel.TabIndex = 7;
            GradeLabel.Text = "Your Grade:";
            // 
            // btnAnswer
            // 
            btnAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnswer.BackColor = Color.White;
            btnAnswer.Font = new Font("Arial", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnswer.ForeColor = Color.DarkOrange;
            btnAnswer.Location = new Point(812, 101);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(190, 37);
            btnAnswer.TabIndex = 8;
            btnAnswer.Text = "Your Answers";
            btnAnswer.UseVisualStyleBackColor = false;
            // 
            // CourseSection
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(btnAnswer);
            Controls.Add(GradeLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExam);
            Controls.Add(GradeValue);
            Controls.Add(InsNameLBl);
            Controls.Add(CrsNamelbl);
            Name = "CourseSection";
            Size = new Size(1151, 176);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CrsNamelbl;
        private Label InsNameLBl;
        private Label GradeValue;
        private Button btnExam;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label GradeLabel;
        private Button btnAnswer;
    }
}
