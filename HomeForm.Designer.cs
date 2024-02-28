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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            informationPanel = new Panel();
            pictureBox1 = new PictureBox();
            userName = new Label();
            departmentLabel = new Label();
            label2 = new Label();
            informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightBlue;
            flowLayoutPanel1.Location = new Point(205, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1224, 686);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 748);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.SteelBlue;
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 827);
            panel2.TabIndex = 1;
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.LightBlue;
            informationPanel.Controls.Add(label2);
            informationPanel.Controls.Add(departmentLabel);
            informationPanel.Controls.Add(pictureBox1);
            informationPanel.Controls.Add(userName);
            informationPanel.Location = new Point(205, -7);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(1201, 141);
            informationPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ProfilePicture;
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // userName
            // 
            userName.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(123, 54);
            userName.Name = "userName";
            userName.Size = new Size(740, 32);
            userName.TabIndex = 1;
            userName.Text = "label2";
            userName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // departmentLabel
            // 
            departmentLabel.Font = new Font("Segoe UI", 12F);
            departmentLabel.Location = new Point(1000, 61);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(237, 25);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(873, 61);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 4;
            label2.Text = "Department:";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 820);
            Controls.Add(informationPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(1425, 867);
            MinimumSize = new Size(1425, 867);
            Name = "HomeForm";
            Text = "Form2";
            FormClosing += HomeForm_FormClosing;
            Load += Form2_Load;
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel informationPanel;
        private PictureBox pictureBox1;
        private Label userName;
        private Label label2;
        private Label departmentLabel;
    }
}