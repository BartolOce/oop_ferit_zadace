namespace ClassLibrary
{
    public class Season
    {
        private int seasonIndex;
        private Episode[] episodes;
        public int Length { get; }

        public Season(int index, Episode[] episodes)
        {
            seasonIndex = index;
            this.episodes = episodes;
            Length = episodes.Length;
        }

        public Episode this[int index]
        {
            get => episodes[index];
            set => episodes[index] = value;
        }

        public int GetTotalViewers()
        {
            int totalViewers = 0;
            foreach(Episode episode in episodes)
            {
                totalViewers += episode.Viewers;
            }
            return totalViewers;
        }

        public DateTime GetBingeEnd()
        {
            DateTime bingeEnd = DateTime.Now;
            foreach (Episode episode in episodes)
            {
                bingeEnd += episode.Description.Lenght;
            }
            return bingeEnd;
        }

        public TimeSpan GetTotalDuration()
        {
            TimeSpan totalDuration = TimeSpan.Zero;
            foreach (Episode episode in episodes)
            {
                totalDuration += episode.Description.Lenght;
            }
            return totalDuration;
        }

        public override string ToString()
        {
            string output = $"Season {seasonIndex}:\n" + 
            "=================================================\n" +
            string.Join<Episode>(Environment.NewLine, episodes) + "\n" +
            "Report:\n" +
            "=================================================\n" +
            $"Total viewers: {GetTotalViewers()}\n" +
            $"Total duration: {GetTotalDuration()}\n" +
            "=================================================\n";

            return output;
        }
    }
}