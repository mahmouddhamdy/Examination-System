namespace OnlineExamination
{
    partial class ExamInfoForm
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
            LabelCrsName = new Label();
            NoQuestionlabel = new Label();
            labelDuration = new Label();
            StartExambtn = new Button();
            SuspendLayout();
            // 
            // LabelCrsName
            // 
            LabelCrsName.AutoSize = true;
            LabelCrsName.Font = new Font("Corbel", 48.2086945F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCrsName.ForeColor = Color.FromArgb(0, 173, 181);
            LabelCrsName.Location = new Point(463, 132);
            LabelCrsName.Name = "LabelCrsName";
            LabelCrsName.Size = new Size(238, 94);
            LabelCrsName.TabIndex = 0;
            LabelCrsName.Text = "label1";
            // 
            // NoQuestionlabel
            // 
            NoQuestionlabel.AutoSize = true;
            NoQuestionlabel.Font = new Font("Corbel", 28.173914F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoQuestionlabel.ForeColor = Color.FromArgb(0, 173, 181);
            NoQuestionlabel.Location = new Point(463, 312);
            NoQuestionlabel.Name = "NoQuestionlabel";
            NoQuestionlabel.Size = new Size(139, 55);
            NoQuestionlabel.TabIndex = 1;
            NoQuestionlabel.Text = "label2";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Corbel", 28.173914F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDuration.ForeColor = Color.FromArgb(0, 173, 181);
            labelDuration.Location = new Point(463, 437);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(139, 55);
            labelDuration.TabIndex = 2;
            labelDuration.Text = "label3";
            // 
            // StartExambtn
            // 
            StartExambtn.Font = new Font("Corbel", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartExambtn.ForeColor = Color.FromArgb(0, 173, 181);
            StartExambtn.Location = new Point(566, 611);
            StartExambtn.Name = "StartExambtn";
            StartExambtn.Size = new Size(216, 60);
            StartExambtn.TabIndex = 3;
            StartExambtn.Text = "Start Exam";
            StartExambtn.UseVisualStyleBackColor = true;
            StartExambtn.Click += StartExambtn_Click;
            // 
            // ExamInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1407, 781);
            Controls.Add(StartExambtn);
            Controls.Add(labelDuration);
            Controls.Add(NoQuestionlabel);
            Controls.Add(LabelCrsName);
            MaximumSize = new Size(1425, 826);
            MinimumSize = new Size(1425, 826);
            Name = "ExamInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamInfoForm";
            FormClosing += ExamInfoForm_FormClosing;
            Load += ExamInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCrsName;
        private Label NoQuestionlabel;
        private Label labelDuration;
        private Button StartExambtn;
    }
}