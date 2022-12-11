using System;

namespace ClassLibrary
{
    public class Episode
    {
        public int Viewers { get; set; }
        public double Sum { get; set; }
        public double Max { get; set; }
        public Description Description { get; set; }

        public Episode(int viewers, double sum, double max, Description description)
        {
            Viewers = viewers;
            Sum = sum;
            Max = max;
            Description = description;
        }

        public void AddView(double score)
        {
            Viewers++;

            Sum += score;
            Sum = Math.Round(Sum, 4);

            if (Max < score)
            {
                Max = score;
                Max = Math.Round(Max, 2);
            }
        }

        public double GetMaxScore()
        {
            return Max;
        }

        public double GetAverageScore()
        {
            return Sum / Viewers;
        }

        public int GetViewerCount()
        {
            return Viewers;
        }

        public override string ToString()
        {
            string returnString = Viewers + "-" + Sum + "-" + Max + "-" + Description.Number + "-" + Description.Lenght + "-" + Description.Name;
            return returnString.Replace(",",".").Replace("-",",");
        }

        public static bool operator <(Episode lhs, Episode rhs)
        {
            return lhs.GetAverageScore() < rhs.GetAverageScore();
        }
        public static bool operator >(Episode lhs, Episode rhs)
        {
            return lhs.GetAverageScore() > rhs.GetAverageScore();
        }
    }
}