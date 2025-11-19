
using DotnetFandamental.WindowsFormAppPanel.Models;

namespace DotnetFandamental.WindowsFormAppPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<UserLogin> users = new List<UserLogin>();
            users.Add(new UserLogin() { Password = "1234", UserName = "admin" });
            users.Add(new UserLogin() { Password = "12345", UserName = "admin2" });

            //string str = Console.ReadLine();
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            bool isValidLogin = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == username && users[i].Password == password)
                {
                    isValidLogin = true;
                    break;
                }
            }

            if (isValidLogin)
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayOfWeekLabel.Text = "روز هفته: " + "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    dayOfWeekLabel.Text = "روز هفته: " + "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekLabel.Text = "روز هفته: " + "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekLabel.Text = "روز هفته: " + "4 شنبه";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekLabel.Text = "روز هفته: " + "5 شنبه";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeekLabel.Text = "روز هفته: " + "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekLabel.Text = "روز هفته: " + "شنبه";
                    break;
                default:
                    break;
            }
        }

        private void dayOfWeekLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
