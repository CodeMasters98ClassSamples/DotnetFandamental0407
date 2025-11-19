
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
            string access1 = "admin,1234";
            string access2 = "admin2,12345";
            string[] accessArray = access1.Split(',');
            string[] accessArray2 = access2.Split(',');

            List<UserLogin> users = new List<UserLogin>();
            users.Add(new UserLogin() { Password = accessArray[1], UserName = accessArray[0] });
            users.Add(new UserLogin() { Password = accessArray2[1], UserName = accessArray2[0] });

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
