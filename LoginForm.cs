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

        ExaminationSystemDBContext context = new ExaminationSystemDBContext();


        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var res = context.Students.FirstOrDefault(s => s.Email == this.EmailTxt.Text);
            if (res != null)
            {

                this.ErrorLabel.Visible = false;
              
               // Trace.WriteLine(config.AppSettings.Settings["StudentID"].Value);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings"); this.Hide();
                config.AppSettings.Settings["StudentID"].Value = res.Email;
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
