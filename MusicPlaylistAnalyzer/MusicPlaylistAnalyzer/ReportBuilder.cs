using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    public static class ReportBuilder
    {
        public static string CreateReport(List<ReportStat> ras)
        {
            string report = "Music Playlist Report";
            report += System.Environment.NewLine;
            report += System.Environment.NewLine;
            
            //WORKS?
            var q1 = from statlist in ras where statlist.Plays > 200 select statlist.Plays;
            report += "Songs that received 200 or more plays: ";
            report += System.Environment.NewLine;

            //NOT WORKS: Different way to do this?
            var q2 = 1; //how many songs are alternative;
            int count = 0;
            string type1 = "Alternative";
            var type3 = from statlist in ras select statlist.Genre;
            if(String.Equals(type1, type3, StringComparison.OrdinalIgnoreCase))
            {
                count++;
                q2 = count;
            }
            report += $"Number of Alternative Songs: {count}";
            report += System.Environment.NewLine;

            //NOT WORKS: Different way to do this?
            var q3 = 1; //how many songs are hiphop/ rap;
            int Count = 0;
            string type2 = "Hip-Hop/Rap";
            var type4 = from statlist in ras select statlist.Genre;
            if (String.Equals(type2, type4, StringComparison.OrdinalIgnoreCase))
            {
                count++;
                q3 = Count;
            }
            report += "Number of Hip-Hop/Rap Songs: ";
            report += System.Environment.NewLine;

            //WORKS?
            var q4 = from statlist in ras where statlist.Album == "Welcome to the Fishbowl" select statlist.Name;
            report += "Songs from the album Welcome to the Fishbowl: ";
            report += System.Environment.NewLine;

            //WORKS?
            var q5 = from statlist in ras where statlist.Year < 1970 select statlist.Year;
            report += "Songs from before 1970: ";
            report += System.Environment.NewLine;

            //NOT WORKS: Not sure how to do?
            var q6 =  //songs with names more than  85 char long;
            report += "Song name longer than 85 characters: ";
            report += System.Environment.NewLine;

            //WORKS?
            var q7 = (from statlist in ras select statlist.Time).Max();
            report += $"Longest Song (playtime): {q7}";
            report += System.Environment.NewLine;


            return report;
        }
    }
}
