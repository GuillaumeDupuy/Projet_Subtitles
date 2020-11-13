using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Subtitles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LectureFichier f = new LectureFichier();*/

            f.ReadFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\subtitles.txt");
        }
    }
}
