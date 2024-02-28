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
            ptnPrev.BackColor = Color.FromArgb(34, 40, 49);
            ptnPrev.ForeColor = Color.FromArgb(238, 238, 238);
            ptnPrev.Location = new Point(382, 381);
            ptnPrev.Name = "ptnPrev";
            ptnPrev.Size = new Size(90, 29);
            ptnPrev.TabIndex = 1;
            ptnPrev.Text = "prev";
            ptnPrev.UseVisualStyleBackColor = false;
            ptnPrev.Click += ptnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(34, 40, 49);
            btnNext.ForeColor = Color.FromArgb(238, 238, 238);
            btnNext.Location = new Point(690, 381);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(90, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // panelQuestion
            // 
            panelQuestion.Location = new Point(21, 27);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(1315, 304);
            panelQuestion.TabIndex = 3;
            // 
            // finishExamButton
            // 
            finishExamButton.BackColor = Color.FromArgb(34, 40, 49);
            finishExamButton.ForeColor = Color.FromArgb(238, 238, 238);
            finishExamButton.Location = new Point(962, 381);
            finishExamButton.Name = "finishExamButton";
            finishExamButton.Size = new Size(94, 29);
            finishExamButton.TabIndex = 4;
            finishExamButton.Text = "Finish Exam";
            finishExamButton.UseVisualStyleBackColor = false;
            finishExamButton.Visible = false;
            finishExamButton.Click += finishExamButton_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.FromArgb(0, 173, 181);
            lblTimer.Font = new Font("Corbel", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(34, 40, 49);
            lblTimer.Location = new Point(1364, 27);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(97, 38);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "label1";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1473, 493);
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