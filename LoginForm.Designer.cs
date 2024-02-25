namespace OnlineExamination
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            EmailTxt = new TextBox();
            LoginBtn = new Button();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.online_exam_software;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 778);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 48.2086945F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(941, 161);
            label1.Name = "label1";
            label1.Size = new Size(347, 94);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(922, 389);
            label2.Name = "label2";
            label2.Size = new Size(113, 46);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // EmailTxt
            // 
            EmailTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EmailTxt.BackColor = Color.SteelBlue;
            EmailTxt.Font = new Font("Corbel", 13.7739134F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EmailTxt.ForeColor = Color.White;
            EmailTxt.Location = new Point(934, 453);
            EmailTxt.Multiline = true;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(385, 45);
            EmailTxt.TabIndex = 5;
            EmailTxt.Text = "Email Address";
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginBtn.BackColor = Color.SteelBlue;
            LoginBtn.FlatAppearance.BorderColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 10;
            LoginBtn.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.DarkOrange;
            LoginBtn.Location = new Point(993, 619);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(268, 68);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Corbel", 13.7739134F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLabel.Location = new Point(941, 501);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(132, 27);
            ErrorLabel.TabIndex = 7;
            ErrorLabel.Text = "Wrong Email";
            ErrorLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1407, 781);
            Controls.Add(ErrorLabel);
            Controls.Add(LoginBtn);
            Controls.Add(EmailTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Form1";
            FormClosing += LoginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox EmailTxt;
        private Button LoginBtn;
        private Label ErrorLabel;
    }
}
