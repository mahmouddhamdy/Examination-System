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
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(233, 49);
            label1.TabIndex = 0;
            label1.Text = "Your Grade :";
            // 
            // LabelGrade
            // 
            LabelGrade.AutoSize = true;
            LabelGrade.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelGrade.Location = new Point(331, 25);
            LabelGrade.Name = "LabelGrade";
            LabelGrade.Size = new Size(126, 49);
            LabelGrade.TabIndex = 1;
            LabelGrade.Text = "label2";
            // 
            // btnGoToHome
            // 
            btnGoToHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGoToHome.Location = new Point(1302, 506);
            btnGoToHome.Margin = new Padding(3, 4, 3, 4);
            btnGoToHome.Name = "btnGoToHome";
            btnGoToHome.Size = new Size(168, 34);
            btnGoToHome.TabIndex = 2;
            btnGoToHome.Text = "Go To My Home";
            btnGoToHome.UseVisualStyleBackColor = true;
            btnGoToHome.Click += btnGoToHome_Click;
            // 
            // ModelAnswersgrdView
            // 
            ModelAnswersgrdView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ModelAnswersgrdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModelAnswersgrdView.Location = new Point(12, 95);
            ModelAnswersgrdView.Margin = new Padding(3, 4, 3, 4);
            ModelAnswersgrdView.Name = "ModelAnswersgrdView";
            ModelAnswersgrdView.RowHeadersWidth = 49;
            ModelAnswersgrdView.Size = new Size(1458, 388);
            ModelAnswersgrdView.TabIndex = 3;
            // 
            // FinalMarkForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 553);
            Controls.Add(ModelAnswersgrdView);
            Controls.Add(btnGoToHome);
            Controls.Add(LabelGrade);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
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