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
            LabelQuestion = new Label();
            ptnPrev = new Button();
            btnNext = new Button();
            panelTF = new Panel();
            radioTF2 = new RadioButton();
            radioTF1 = new RadioButton();
            panelMCQ = new Panel();
            radioMCQ4 = new RadioButton();
            radioMCQ3 = new RadioButton();
            radioMCQ2 = new RadioButton();
            radioMCQ1 = new RadioButton();
            panelTF.SuspendLayout();
            panelMCQ.SuspendLayout();
            SuspendLayout();
            // 
            // LabelQuestion
            // 
            LabelQuestion.AutoSize = true;
            LabelQuestion.Font = new Font("Corbel", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelQuestion.ForeColor = Color.White;
            LabelQuestion.Location = new Point(12, 129);
            LabelQuestion.Name = "LabelQuestion";
            LabelQuestion.Size = new Size(89, 36);
            LabelQuestion.TabIndex = 0;
            LabelQuestion.Text = "label1";
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
            // panelTF
            // 
            panelTF.Controls.Add(radioTF2);
            panelTF.Controls.Add(radioTF1);
            panelTF.Location = new Point(26, 184);
            panelTF.Name = "panelTF";
            panelTF.Size = new Size(240, 120);
            panelTF.TabIndex = 3;
            // 
            // radioTF2
            // 
            radioTF2.AutoSize = true;
            radioTF2.Location = new Point(14, 65);
            radioTF2.Name = "radioTF2";
            radioTF2.Size = new Size(114, 24);
            radioTF2.TabIndex = 1;
            radioTF2.TabStop = true;
            radioTF2.Text = "radioButton2";
            radioTF2.UseVisualStyleBackColor = true;
            // 
            // radioTF1
            // 
            radioTF1.AutoSize = true;
            radioTF1.Location = new Point(14, 26);
            radioTF1.Name = "radioTF1";
            radioTF1.Size = new Size(114, 24);
            radioTF1.TabIndex = 0;
            radioTF1.TabStop = true;
            radioTF1.Text = "radioButton1";
            radioTF1.UseVisualStyleBackColor = true;
            // 
            // panelMCQ
            // 
            panelMCQ.Controls.Add(radioMCQ4);
            panelMCQ.Controls.Add(radioMCQ3);
            panelMCQ.Controls.Add(radioMCQ2);
            panelMCQ.Controls.Add(radioMCQ1);
            panelMCQ.Location = new Point(40, 184);
            panelMCQ.Name = "panelMCQ";
            panelMCQ.Size = new Size(240, 120);
            panelMCQ.TabIndex = 0;
            // 
            // radioMCQ4
            // 
            radioMCQ4.AutoSize = true;
            radioMCQ4.Location = new Point(16, 93);
            radioMCQ4.Name = "radioMCQ4";
            radioMCQ4.Size = new Size(114, 24);
            radioMCQ4.TabIndex = 3;
            radioMCQ4.TabStop = true;
            radioMCQ4.Text = "radioButton6";
            radioMCQ4.UseVisualStyleBackColor = true;
            // 
            // radioMCQ3
            // 
            radioMCQ3.AutoSize = true;
            radioMCQ3.Location = new Point(16, 65);
            radioMCQ3.Name = "radioMCQ3";
            radioMCQ3.Size = new Size(114, 24);
            radioMCQ3.TabIndex = 2;
            radioMCQ3.TabStop = true;
            radioMCQ3.Text = "radioButton5";
            radioMCQ3.UseVisualStyleBackColor = true;
            // 
            // radioMCQ2
            // 
            radioMCQ2.AutoSize = true;
            radioMCQ2.Location = new Point(16, 35);
            radioMCQ2.Name = "radioMCQ2";
            radioMCQ2.Size = new Size(114, 24);
            radioMCQ2.TabIndex = 1;
            radioMCQ2.TabStop = true;
            radioMCQ2.Text = "radioButton4";
            radioMCQ2.UseVisualStyleBackColor = true;
            // 
            // radioMCQ1
            // 
            radioMCQ1.AutoSize = true;
            radioMCQ1.Location = new Point(16, 5);
            radioMCQ1.Name = "radioMCQ1";
            radioMCQ1.Size = new Size(114, 24);
            radioMCQ1.TabIndex = 0;
            radioMCQ1.TabStop = true;
            radioMCQ1.Text = "radioButton3";
            radioMCQ1.UseVisualStyleBackColor = true;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMCQ);
            Controls.Add(panelTF);
            Controls.Add(btnNext);
            Controls.Add(ptnPrev);
            Controls.Add(LabelQuestion);
            Name = "ExamForm";
            Text = "ExamForm";
            FormClosing += ExamForm_FormClosing;
            Load += ExamForm_Load;
            panelTF.ResumeLayout(false);
            panelTF.PerformLayout();
            panelMCQ.ResumeLayout(false);
            panelMCQ.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelQuestion;
        private Button ptnPrev;
        private Button btnNext;
        private Panel panelTF;
        private Panel panelMCQ;
        private RadioButton radioTF2;
        private RadioButton radioTF1;
        private RadioButton radioMCQ4;
        private RadioButton radioMCQ3;
        private RadioButton radioMCQ2;
        private RadioButton radioMCQ1;
    }
}