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

        //définition des élémenets pour le temps des sous-titres
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

       //définition des élémenets pour le temps des sous-titres
       public SubTitle(int number, string timer, string sub)
       {
           numberSubtitle = number;
           subtitle = sub;
           ParseTimer(timer);
       }

       //permet de couper le temps des sous-titres en jour, heures, secondes
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

       //récuperer le temps actuel des sous-titres
       private TimeSpan GetTimer(string timer)
       {
           char[] charsplitOn = { ':', ',' };
           string[] splitTimer = timer.Split(charsplitOn);

           return new TimeSpan(0, Int32.Parse(splitTimer[0]), Int32.Parse(splitTimer[1]), Int32.Parse(splitTimer[2]), Int32.Parse(splitTimer[3]));
       }

       //mettre les sous-titres au temps définis
       public async Task AddSubTitle()
       {
           await TimeToAdd();
           Console.WriteLine(subtitle);
           await TimeToDisplay();
           Console.Clear();
       }
 
       //fonction temps 
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
