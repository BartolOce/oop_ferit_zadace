namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        private string fileName;

        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }

        public void Print(string message)
        {
            File.WriteAllText(fileName, message);
        }
    }
}