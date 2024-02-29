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
            RadioMCQ1 = new RadioButton();
            RadioMCQ2 = new RadioButton();
            RadioMCQ3 = new RadioButton();
            RadioMCQ4 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Corbel", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.ForeColor = Color.FromArgb(238, 238, 238);
            labelQuestion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            labelQuestion.Location = new Point(30, 22);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(836, 135);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "label1\r\n";
            // 
            // panel1
            // 
            panel1.ForeColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(RadioMCQ1);
            panel1.Controls.Add(RadioMCQ2);
            panel1.Controls.Add(RadioMCQ3);
            panel1.Controls.Add(RadioMCQ4);
            panel1.Location = new Point(30, 168);
            panel1.Name = "panel1";

            panel1.Size = new Size(800, 400);

            panel1.TabIndex = 1;
            // 
            // radioMCQ1
            // 
            RadioMCQ1.AutoSize = true;
            RadioMCQ1.Location = new Point(17, 3);
            RadioMCQ1.Name = "radioMCQ1";
            RadioMCQ1.Size = new Size(214, 124);
            RadioMCQ1.TabIndex = 2;
            RadioMCQ1.TabStop = true;
            RadioMCQ1.Text = "radioButton1";
            RadioMCQ1.UseVisualStyleBackColor = true;
            // 
            // radioMCQ2
            // 
            RadioMCQ2.AutoSize = true;
            RadioMCQ2.Location = new Point(17, 35);
            RadioMCQ2.Name = "radioMCQ2";
            RadioMCQ2.Size = new Size(214, 124);
            RadioMCQ2.TabIndex = 3;
            RadioMCQ2.TabStop = true;
            RadioMCQ2.Text = "radioButton2";
            RadioMCQ2.UseVisualStyleBackColor = true;
            // 
            // radioMCQ3
            // 
            RadioMCQ3.AutoSize = true;
            RadioMCQ3.Location = new Point(16, 66);
            RadioMCQ3.Name = "radioMCQ3";
            RadioMCQ3.Size = new Size(214, 124);
            RadioMCQ3.TabIndex = 4;
            RadioMCQ3.TabStop = true;
            RadioMCQ3.Text = "radioButton3";
            RadioMCQ3.UseVisualStyleBackColor = true;
            // 
            // radioMCQ4
            // 
            RadioMCQ4.AutoSize = true;
            RadioMCQ4.Location = new Point(16, 98);
            RadioMCQ4.Name = "radioMCQ4";
            RadioMCQ4.Size = new Size(214, 124);
            RadioMCQ4.TabIndex = 5;
            RadioMCQ4.TabStop = true;
            RadioMCQ4.Text = "radioButton4";
            RadioMCQ4.UseVisualStyleBackColor = true;
            // 
            // QuestionSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelQuestion);
            Name = "QuestionSection";
            Size = new Size(869, 385);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelQuestion;
        private Panel panel1;
        private RadioButton radioMCQ1;
        private RadioButton radioMCQ2;
        private RadioButton radioMCQ3;
        private RadioButton radioMCQ4;

        public RadioButton RadioMCQ1 { get => radioMCQ1; set => radioMCQ1 = value; }
        public RadioButton RadioMCQ2 { get => radioMCQ2; set => radioMCQ2 = value; }
        public RadioButton RadioMCQ3 { get => radioMCQ3; set => radioMCQ3 = value; }
        public RadioButton RadioMCQ4 { get => radioMCQ4; set => radioMCQ4 = value; }
    }
}
