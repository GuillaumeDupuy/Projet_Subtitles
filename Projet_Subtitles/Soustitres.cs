using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Subtitles
{
    public class Soustitres
    {
        public int numberSubtitle;
        public TimeSpan StartTime;
        public TimeSpan EndTime;
        public string subtitle;

        public Soustitres(int number, string timer, string sub)
        {
            numberSubtitle = number;
            subtitle = sub;
            Temps(timer);
        }

    }
}
