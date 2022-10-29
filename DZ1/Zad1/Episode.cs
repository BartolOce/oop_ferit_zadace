using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Episode
    {
        int viewers;
        double sum;
        double max;

        public Episode()
        {
            viewers = 0;
            sum = 0;
            max = 0;
        }

        public Episode(int viewers, double sum, double max)
        {
            this.viewers = viewers;
            this.sum = sum;
            this.max = max;
        }

        public void AddView(double score)
        {
            viewers++;

            sum += score;

            if (max < score)
            {
                max = score;
            }
        }

        public double GetMaxScore()
        {
            return max;
        }

        public double GetAverageScore()
        {
            return sum / viewers;
        }

        public int GetViewerCount()
        {
            return viewers;
        }
    }
}
