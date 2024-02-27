namespace OnlineExamination
{
    partial class ExamForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptnPrev = new Button();
            btnNext = new Button();
            panelQuestion = new Panel();
            SuspendLayout();
            // 
            // ptnPrev
            // 
            ptnPrev.Location = new Point(40, 343);
            ptnPrev.Name = "ptnPrev";
            ptnPrev.Size = new Size(90, 28);
            ptnPrev.TabIndex = 1;
            ptnPrev.Text = "prev";
            ptnPrev.UseVisualStyleBackColor = true;
            ptnPrev.Click += ptnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(348, 343);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(90, 28);
            btnNext.TabIndex = 2;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // panelQuestion
            // 
            panelQuestion.Location = new Point(21, 26);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(822, 289);
            panelQuestion.TabIndex = 3;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(998, 501);
            Controls.Add(panelQuestion);
            Controls.Add(btnNext);
            Controls.Add(ptnPrev);
            Name = "ExamForm";
            Text = "ExamForm";
            FormClosing += ExamForm_FormClosing;
            Load += ExamForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button ptnPrev;
        private Button btnNext;
        private Panel panelQuestion;
    }
}