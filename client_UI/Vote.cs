using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace client_UI
{
    public partial class Vote : Form
    {
        public static System.Timers.Timer vt = new System.Timers.Timer();
        public Vote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void start_timer_vote()
        {
            float setTime = 15;
            textTimer.Text = setTime.ToString();
            vt.Interval = 1000;
            vt.Elapsed += talkTimer_Tick;
            vt.Start();
        }

        private void talkTimer_Tick(object sender, ElapsedEventArgs e)
        {
            float setTime = float.Parse(textTimer.Text.ToString());
            setTime -= 1;
            textTimer.Text = setTime.ToString();
            Console.WriteLine(setTime);
            if (setTime <= 0)
            {
                vt.Elapsed -= talkTimer_Tick;
                vt.Stop();
                Console.WriteLine("test");
                //시간 초가 다 되면 서버로 정보를 보내면서 폼 닫기
                
            }
        }

        
    }
}
