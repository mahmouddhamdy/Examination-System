namespace OnlineExamination
{
    partial class QuestionSection
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
            labelQuestion = new Label();
            panel1 = new Panel();
            radioMCQ1 = new RadioButton();
            radioMCQ2 = new RadioButton();
            radioMCQ3 = new RadioButton();
            radioMCQ4 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Corbel", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(36, 9);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(109, 42);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioMCQ1);
            panel1.Controls.Add(radioMCQ2);
            panel1.Controls.Add(radioMCQ3);
            panel1.Controls.Add(radioMCQ4);
            panel1.Location = new Point(20, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 120);
            panel1.TabIndex = 1;
            // 
            // radioMCQ1
            // 
            radioMCQ1.AutoSize = true;
            radioMCQ1.Location = new Point(17, 3);
            radioMCQ1.Name = "radioMCQ1";
            radioMCQ1.Size = new Size(114, 24);
            radioMCQ1.TabIndex = 2;
            radioMCQ1.TabStop = true;
            radioMCQ1.Text = "radioButton1";
            radioMCQ1.UseVisualStyleBackColor = true;
            // 
            // radioMCQ2
            // 
            radioMCQ2.AutoSize = true;
            radioMCQ2.Location = new Point(17, 33);
            radioMCQ2.Name = "radioMCQ2";
            radioMCQ2.Size = new Size(114, 24);
            radioMCQ2.TabIndex = 3;
            radioMCQ2.TabStop = true;
            radioMCQ2.Text = "radioButton2";
            radioMCQ2.UseVisualStyleBackColor = true;
            // 
            // radioMCQ3
            // 
            radioMCQ3.AutoSize = true;
            radioMCQ3.Location = new Point(16, 63);
            radioMCQ3.Name = "radioMCQ3";
            radioMCQ3.Size = new Size(114, 24);
            radioMCQ3.TabIndex = 4;
            radioMCQ3.TabStop = true;
            radioMCQ3.Text = "radioButton3";
            radioMCQ3.UseVisualStyleBackColor = true;
            // 
            // radioMCQ4
            // 
            radioMCQ4.AutoSize = true;
            radioMCQ4.Location = new Point(16, 93);
            radioMCQ4.Name = "radioMCQ4";
            radioMCQ4.Size = new Size(114, 24);
            radioMCQ4.TabIndex = 5;
            radioMCQ4.TabStop = true;
            radioMCQ4.Text = "radioButton4";
            radioMCQ4.UseVisualStyleBackColor = true;
            // 
            // QuestionSection
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelQuestion);
            Name = "QuestionSection";
            Size = new Size(719, 222);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuestion;
        private Panel panel1;
        private RadioButton radioMCQ1;
        private RadioButton radioMCQ2;
        private RadioButton radioMCQ3;
        private RadioButton radioMCQ4;
    }
}
