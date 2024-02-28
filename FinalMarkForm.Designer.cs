namespace OnlineExamination
{
    partial class FinalMarkForm
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
            label1 = new Label();
            LabelGrade = new Label();
            btnGoToHome = new Button();
            ModelAnswersgrdView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ModelAnswersgrdView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 0;
            label1.Text = "Your Grade :";
            // 
            // LabelGrade
            // 
            LabelGrade.AutoSize = true;
            LabelGrade.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelGrade.Location = new Point(294, 21);
            LabelGrade.Name = "LabelGrade";
            LabelGrade.Size = new Size(119, 46);
            LabelGrade.TabIndex = 1;
            LabelGrade.Text = "label2";
            // 
            // btnGoToHome
            // 
            btnGoToHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGoToHome.Location = new Point(1246, 695);
            btnGoToHome.Name = "btnGoToHome";
            btnGoToHome.Size = new Size(149, 28);
            btnGoToHome.TabIndex = 2;
            btnGoToHome.Text = "Go To My Home";
            btnGoToHome.UseVisualStyleBackColor = true;
            btnGoToHome.Click += btnGoToHome_Click;
            // 
            // ModelAnswersgrdView
            // 
            ModelAnswersgrdView.BackgroundColor = Color.White;
            ModelAnswersgrdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModelAnswersgrdView.GridColor = Color.Black;
            ModelAnswersgrdView.Location = new Point(2, 70);
            ModelAnswersgrdView.Name = "ModelAnswersgrdView";
            ModelAnswersgrdView.RowHeadersWidth = 49;
            ModelAnswersgrdView.Size = new Size(1401, 699);
            ModelAnswersgrdView.TabIndex = 3;
            // 
            // FinalMarkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 781);
            Controls.Add(btnGoToHome);
            Controls.Add(LabelGrade);
            Controls.Add(label1);
            Controls.Add(ModelAnswersgrdView);
            MaximizeBox = false;
            MaximumSize = new Size(1425, 826);
            MinimizeBox = false;
            MinimumSize = new Size(1425, 826);
            Name = "FinalMarkForm";
            Text = "FinalMarkForm";
            FormClosing += FinalMarkForm_FormClosing;
            Load += FinalMarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)ModelAnswersgrdView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelGrade;
        private Button btnGoToHome;
        private DataGridView ModelAnswersgrdView;
    }
}