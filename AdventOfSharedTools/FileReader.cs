namespace AdventOfSharedTools
{
    /// <summary>
    /// Contains methods to read text from a file. By default, it is looking for "input.txt" file.
    /// </summary>
    /// <param name="path"></param>
    public class FileReader(string path = "input.txt")
    {
        /// <summary>
        /// Reads entire resource and assigns output to a string variable.
        /// </summary>
        /// <returns>A string containing all the text in the file.</returns>
        public string ReadAll() => File.ReadAllText(path);

        /// <summary>
        /// Reads entire resource and assigns output to a array of strings - each representing seperate line from a resource.
        /// </summary>
        /// <returns>A string array containing all lines of the file.</returns>
        public string[] ReadLines() => File.ReadAllLines(path);
    }
}
