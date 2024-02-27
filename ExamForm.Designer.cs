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
            finishExamButton = new Button();
            lblTimer = new Label();
            SuspendLayout();
            // 
            // ptnPrev
            // 
            ptnPrev.Location = new Point(382, 362);
            ptnPrev.Name = "ptnPrev";
            ptnPrev.Size = new Size(90, 28);
            ptnPrev.TabIndex = 1;
            ptnPrev.Text = "prev";
            ptnPrev.UseVisualStyleBackColor = true;
            ptnPrev.Click += ptnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(690, 362);
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
            panelQuestion.Size = new Size(1315, 289);
            panelQuestion.TabIndex = 3;
            // 
            // finishExamButton
            // 
            finishExamButton.Location = new Point(962, 362);
            finishExamButton.Name = "finishExamButton";
            finishExamButton.Size = new Size(94, 28);
            finishExamButton.TabIndex = 4;
            finishExamButton.Text = "Finish Exam";
            finishExamButton.UseVisualStyleBackColor = true;
            finishExamButton.Visible = false;
            finishExamButton.Click += finishExamButton_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Corbel", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(1342, 26);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(89, 36);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "label1";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1488, 473);
            Controls.Add(lblTimer);
            Controls.Add(finishExamButton);
            Controls.Add(panelQuestion);
            Controls.Add(btnNext);
            Controls.Add(ptnPrev);
            Name = "ExamForm";
            Text = "ExamForm";
            FormClosing += ExamForm_FormClosing;
            Load += ExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ptnPrev;
        private Button btnNext;
        private Panel panelQuestion;
        private Button finishExamButton;
        private Label lblTimer;
    }
}