using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    public static class ReportGetStat
    {
        private static int columns = 8;

        public static List<ReportStat> Load(string mpath)
        {
            List<ReportStat> ras = new List<ReportStat>();

            using (var receive = new StreamReader(mpath))
            {
                int lnum = 0;
                while (!receive.EndOfStream)
                {
                    var line = receive.ReadLine();
                    lnum++;
                    if (lnum == 1)
                    {
                        continue;
                    }
                    var stats = line.Split('\t');

                    //not sure how to do this...
                    string name = string.Parse(stats[0]);
                    string artist = string.Parse(stats[1]);
                    string album = string.Parse(stats[2]);
                    string genre = string.Parse(stats[3]);

                    int size = Int32.Parse(stats[4]);
                    int time = Int32.Parse(stats[5]);
                    int year = Int32.Parse(stats[6]);
                    int plays = Int32.Parse(stats[7]);

                    ReportStat statlist = new ReportStat(name, artist, album, genre, size, time, year, plays);
                    ras.Add(statlist);
                }
            }
            return ras;
        }
    }
}
