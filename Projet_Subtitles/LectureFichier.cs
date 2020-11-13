using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Subtitles
{
    public class DocSub
    {
        public enum StatusLine { NumberLine, TimerLine,S SubTitleLine, EmptyLine };
        public List<string> allLineOfFile;
        public List<Soustitres> allSubTitle;
        public string path;

        public void Lire(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    allLineOfFile = new List<string>();

                    string line;

                    while ((line = sr.ReadLine()) != null)
                        allLineOfFile.Add(line);

                    Analyse();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /*private void Analyse()
        {
            int nbSub = -1;
            string Timer = "";
            string Subs = "";
            StatusLine statusL = StatusLine.NumberLine;
            allSubTitle = new List<Soustitres>();
        }*/

    }
}
