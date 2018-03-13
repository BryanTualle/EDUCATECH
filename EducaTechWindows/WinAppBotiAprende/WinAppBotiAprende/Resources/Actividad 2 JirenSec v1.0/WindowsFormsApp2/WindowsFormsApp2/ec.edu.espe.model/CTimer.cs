using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApp2
{
    class CTimer
    {
        SoundPlayer player;
        public void timerTresChanchitos(Timer timer1, Timer timer2, Timer timer3, Timer timer4, Timer timer5, Timer timer6, Timer timer7, Timer timer8)
        {
            
            player = new SoundPlayer(Application.StartupPath + @"/images/" + "treschanchitos.wav");
            player.Play();
            timer1.Interval = 83000;
            timer1.Start();
            timer2.Interval = 113000;
            timer2.Start();
            timer3.Interval = 120000;
            timer3.Start();
            timer4.Interval = 150000;
            timer4.Start();
            timer5.Interval = 180000;
            timer5.Start();
            timer6.Interval = 190000;
            timer6.Start();
            timer7.Interval = 220000;
            timer7.Start();
            timer8.Interval = 240000;
            timer8.Start();


        }

        public void timerHanselGretel(Timer timer1, Timer timer2, Timer timer3, Timer timer4, Timer timer5, Timer timer6, Timer timer7, Timer timer8)
        {
            
            player = new SoundPlayer(Application.StartupPath + @"/images/" + "HanselGretel.wav");
            player.Play();
            timer1.Interval = 69000;
            timer1.Start();
            timer2.Interval = 85000;
            timer2.Start();
            timer3.Interval = 93000;
            timer3.Start();
            timer4.Interval = 146000;
            timer4.Start();
            timer5.Interval = 164000;
            timer5.Start();
            timer6.Interval = 179000;
            timer6.Start();
            timer7.Interval = 186000;
            timer7.Start();
            timer8.Interval = 202000;
            timer8.Start();

        }
    }
}
