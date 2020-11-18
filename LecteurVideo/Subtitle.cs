using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Subtitle
{
    class Subtitle
    {
        public string subt;
        public int timeStart;
        public int timeEnd;

        public Subtitle(string SUBTITLE, int TIME, int End)
        {
            subt = SUBTITLE;
            timeStart = TIME;
            timeEnd = End;
        }
    }

    /*public class SubTitle
   {
       public int numberSubtitle;
       public TimeSpan StartTime;
       public TimeSpan EndTime;
       public string subtitle;

       public SubTitle(int number, string timer, string sub)
       {
           numberSubtitle = number;
           subtitle = sub;
           ParseTimer(timer);
       }

       private void ParseTimer(string timer)
       {
           Regex r = new Regex(@"\d{2}:\d{2}:\d{1,2},\d{3} ?--> ?\d{2}:\d{2}:\d{1,2},\d{3}");

           if (r.IsMatch(timer))
           {
               string[] splitOn = { "-->", " --> " };
               string[] timerSplit = timer.Split(splitOn, StringSplitOptions.None);
               StartTime = GetTimer(timerSplit[0]);
               EndTime = GetTimer(timerSplit[1]);
           }
       }

       private TimeSpan GetTimer(string timer)
       {
           char[] charsplitOn = { ':', ',' };
           string[] splitTimer = timer.Split(charsplitOn);

           return new TimeSpan(0, Int32.Parse(splitTimer[0]), Int32.Parse(splitTimer[1]), Int32.Parse(splitTimer[2]), Int32.Parse(splitTimer[3]));
       }

       public async Task AddSubTitle()
       {
           await TimeToAdd();
           Console.WriteLine(subtitle);
           await TimeToDisplay();
           Console.Clear();
       }

       public async Task TimeToAdd()
       {
           await Task.Delay(StartTime);
       }

       public async Task TimeToDisplay()
       {
           await Task.Delay(EndTime - StartTime);
       }

       public async Task TimeToRemove()
       {
           await Task.Delay(EndTime);
       }
   }*/
}
