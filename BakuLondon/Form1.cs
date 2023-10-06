using BakuLondon.Properties;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace BakuLondon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Timer button2Timer;
        private Timer button1Timer;

        private void button2_Click(object sender, EventArgs e)
        {
            button1Timer?.Stop();
            this.BackgroundImage = Resources.London;
            button2Timer = new Timer();
            button2Timer.Interval = 1000;
            button2Timer.Tick += Timer_Tick;
           
                
            
            button2Timer.Start();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.baku;
            button1Timer = new Timer();
            button1Timer.Interval = 1000;
            button1Timer.Tick += Timer_Tick;
            
           
                button2Timer?.Stop();
            
            button1Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sender == button2Timer)
            {
                DateTime utcNow = DateTime.UtcNow;
                TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                DateTime londonTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, londonTimeZone);
                label2.ForeColor = Color.Red;
                label2.Visible = true;
                label2.Text = londonTime.ToString("HH:mm:ss");
            }
            else if (sender == button1Timer)
            {
                DateTime utcNow = DateTime.UtcNow;
                TimeZoneInfo azerbaijanTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
                DateTime azerbaijanTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, azerbaijanTimeZone);

                label2.ForeColor = Color.Red;
                label2.Visible = true; 
                label2.Text = azerbaijanTime.ToString("HH:mm:ss");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}