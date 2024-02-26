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
            LabelCrsName.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCrsName.Location = new Point(300, 97);
            LabelCrsName.Name = "LabelCrsName";
            LabelCrsName.Size = new Size(119, 46);
            LabelCrsName.TabIndex = 0;
            LabelCrsName.Text = "label1";
            // 
            // NoQuestionlabel
            // 
            NoQuestionlabel.AutoSize = true;
            NoQuestionlabel.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoQuestionlabel.Location = new Point(300, 174);
            NoQuestionlabel.Name = "NoQuestionlabel";
            NoQuestionlabel.Size = new Size(119, 46);
            NoQuestionlabel.TabIndex = 1;
            NoQuestionlabel.Text = "label2";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDuration.Location = new Point(300, 247);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(119, 46);
            labelDuration.TabIndex = 2;
            labelDuration.Text = "label3";
            // 
            // StartExambtn
            // 
            StartExambtn.Font = new Font("Corbel", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartExambtn.Location = new Point(251, 340);
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
            ClientSize = new Size(800, 450);
            Controls.Add(StartExambtn);
            Controls.Add(labelDuration);
            Controls.Add(NoQuestionlabel);
            Controls.Add(LabelCrsName);
            Name = "ExamInfoForm";
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