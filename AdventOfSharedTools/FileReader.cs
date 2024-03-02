namespace AdventOfSharedTools
{
    public class FileReader(string path = "input.txt")
    {
        public string ReadAll() => File.ReadAllText(path);
        public string[] ReadLines() => File.ReadAllLines(path);
    }
}
