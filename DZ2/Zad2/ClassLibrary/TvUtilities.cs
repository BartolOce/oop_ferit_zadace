using System;
using System.Globalization;

namespace ClassLibrary
{
    public class TvUtilities
    {
        public static Episode Parse(string episodesInputs)
        {
            string[] strings = episodesInputs.Split(',');

            Description description = new Description(int.Parse(strings[3]), TimeSpan.Parse(strings[4]), strings[5]);

            return new Episode(int.Parse(strings[0]), double.Parse(strings[1], CultureInfo.InvariantCulture.NumberFormat), double.Parse(strings[2], CultureInfo.InvariantCulture.NumberFormat), description);
        }

        public static void Sort(Episode[] episodes)
        {

            for (int i = 0; i < episodes.Length - 1; i++)

                for (int j = i + 1; j < episodes.Length; j++)

                    if (episodes[i] < episodes[j])
                    {
                        (episodes[j], episodes[i]) = (episodes[i], episodes[j]);
                    }
        }

        public static double GenerateRandomScore()
        {
            Random rand = new Random();
            double score = rand.NextDouble() * 10;
            return score;
        }
    }
}