namespace OnlineExamination
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            informationPanel = new Panel();
            label2 = new Label();
            departmentLabel = new Label();
            pictureBox1 = new PictureBox();
            userName = new Label();
            pictureBox2 = new PictureBox();
            informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 62, 70);
            flowLayoutPanel1.Location = new Point(369, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1037, 657);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.FromArgb(34, 40, 49);
            informationPanel.Controls.Add(label2);
            informationPanel.Controls.Add(departmentLabel);
            informationPanel.Controls.Add(pictureBox1);
            informationPanel.Controls.Add(userName);
            informationPanel.Location = new Point(366, 0);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(1040, 127);
            informationPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 173, 181);
            label2.Location = new Point(691, 42);
            label2.Name = "label2";
            label2.Size = new Size(176, 40);
            label2.TabIndex = 4;
            label2.Text = "Department:";
            // 
            // departmentLabel
            // 
            departmentLabel.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.ForeColor = Color.FromArgb(0, 173, 181);
            departmentLabel.Location = new Point(873, 42);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(146, 50);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "Label";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ProfilePicture;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // userName
            // 
            userName.Font = new Font("Corbel", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.FromArgb(0, 173, 181);
            userName.Location = new Point(127, 25);
            userName.Name = "userName";
            userName.Size = new Size(436, 79);
            userName.TabIndex = 1;
            userName.Text = "label2";
            userName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(34, 40, 49);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(374, 781);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1407, 781);
            Controls.Add(pictureBox2);
            Controls.Add(informationPanel);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(1425, 826);
            MinimumSize = new Size(1425, 826);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += HomeForm_FormClosing;
            Load += Form2_Load;
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel informationPanel;
        private PictureBox pictureBox1;
        private Label userName;
        private Label label2;
        private Label departmentLabel;
        private PictureBox pictureBox2;
    }
}