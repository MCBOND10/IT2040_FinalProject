using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //if wrong num of files, do this
            if (args.Length != 2)
            {
                Console.WriteLine("");
                Console.WriteLine("MUSIC ANALYZER \n\nFormat: MusicPlaylistAnalyzer.exe <music_playlist_file_path> <report_file_path>");
                Console.WriteLine("Place holder for professional sounding directions.");
                Console.WriteLine("NOTE: Please input in proper format");
                Console.WriteLine("");
            }
            else
            {
                string mpath = args[0];
                string rpath = args[1];

                List<ReportStat> ras = null;
                ras = ReportGetStat.Load(mpath);
                var report = ReportBuilder.CreateReport(ras);
                System.IO.File.WriteAllText(rpath, report);
            }
        }
    }
}
