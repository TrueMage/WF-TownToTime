using System.Diagnostics;
using System.Text.Json.Serialization;

namespace WF_TownToTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(DateTime.Now);
        }
        // ≈сли бы у мен€ было бы врем€ € бы покопалс€ ещЄ, но так как оно почти или уже кончилось, € вам решил хоть какой-то вариант отправить)
        // https://stackoverflow.com/questions/15171430/in-c-sharp-is-there-anyway-to-convert-a-city-name-to-its-timezone-name-tokyo
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            switch (textBox1.Text)
            {
                case "Moscow":
                    label1.Text = "Moscow " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Russian Standard Time");
                    break;

                case "Los Angeles":
                    label1.Text = "Los Angeles " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Pacific Standard Time");
                    break;

                case "New York":
                    label1.Text = "New York " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Eastern Standard Time");
                    break;

                case "London":
                    label1.Text = "London " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "GMT Standard Time");
                    break;

                case "New Delhi":
                    label1.Text = "New Delhi " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "India Standard Time");
                    break;

                case "Beijing":
                    label1.Text = "Beijing " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "China Standard Time");
                    break;

                case "Tokyo":
                    label1.Text = "Tokyo " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Tokyo Standard Time");
                    break;

                case "Chicago":
                    label1.Text = "Chicago " +
                        TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Central Standard Time");
                    break;

            }
        }
    }
}