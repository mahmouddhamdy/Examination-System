using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using OnlineExamination.Context;
using OnlineExamination.Entities;
using System.Configuration;
using System.Diagnostics;



namespace OnlineExamination
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => { this.context.Dispose(); };
        }
       public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        ExaminationSystemDBContext context = new ExaminationSystemDBContext();

        Student? res;
        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home;
             res = context.Students.FirstOrDefault(s => s.Email == this.EmailTxt.Text);
            if (res != null)
            {

                this.ErrorLabel.Visible = false;
              
               // Trace.WriteLine(config.AppSettings.Settings["StudentID"].Value);
                config.AppSettings.Settings["StudentMail"].Value = res.Email.ToString();
                config.AppSettings.Settings["StudentID"].Value = res.StudentId.ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings"); 
              //  Trace.WriteLine(config.AppSettings.Settings["StudentMail"].Value);
               // Trace.WriteLine(config.AppSettings.Settings["StudentID"].Value);
                this.Hide();
                home = new HomeForm();
                home.Show();

            }
            else
            {
                this.ErrorLabel.Visible = true;
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();

        }
    }
}
