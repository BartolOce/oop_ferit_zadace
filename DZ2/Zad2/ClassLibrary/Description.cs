using System;

namespace ClassLibrary
{
    public class Description
    {
        public int Number { get; set; }
        public TimeSpan Lenght { get; set; }
        public string Name { get; set; }

        public Description(int episodeNumber, TimeSpan episodeLenght, string episodeName)
        {
            this.Number = episodeNumber;
            this.Lenght = episodeLenght;
            this.Name = episodeName;
        }

        public override string ToString()
        {
            return Number + "," + Lenght + "," + Name;
        }
    }
}