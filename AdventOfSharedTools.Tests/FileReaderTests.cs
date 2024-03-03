using FluentAssertions;
using Xunit;

namespace AdventOfSharedTools.Tests
{
    public class FileReaderTests : IDisposable
    {
        private const string FileName = "input.txt";
        private const string CustomFileName = "inputCustom.txt";
        private readonly string ExpectedReadAll = "testInput\r\nanotherLine";
        private readonly string[] ExpectedReadLines = ["testInput", "anotherLine"];

        [Fact]
        public void ReadAll_ForDefaultParameter_WhenFileExists_ReturnsFileContent()
        {
            var fileReader = new FileReader();

            var input = fileReader.ReadAll();

            input.Should().Be(ExpectedReadAll);
        }

        [Fact]
        public void ReadAll_ForDefaultParameter_WhenFileDontExists_ThrowsException()
        {
            File.Delete(FileName);

            var fileReader = new FileReader();

            Action act = () => fileReader.ReadAll();

            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void ReadAll_ForCustomParameter_WhenFileExists_ReturnsFileContent()
        {
            var fileReader = new FileReader(CustomFileName);

            var input = fileReader.ReadAll();

            input.Should().Be(ExpectedReadAll);
        }

        [Fact]
        public void ReadAll_ForCustomParameter_WhenFileDontExists_ThrowsException()
        {
            File.Delete(CustomFileName);

            var fileReader = new FileReader(CustomFileName);

            Action act = () => fileReader.ReadAll();

            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void ReadLines_ForDefaultParameter_WhenFileExists_ReturnsFileContent()
        {
            var fileReader = new FileReader();

            var inputLines = fileReader.ReadLines();

            inputLines.Length.Should().Be(ExpectedReadLines.Length);
            for (int i = 0; i < inputLines.Length; i++)
            {
                inputLines[i].Should().Be(ExpectedReadLines[i]);
            }
        }

        [Fact]
        public void ReadLines_ForDefaultParameter_WhenFileDontExists_ThrowsException()
        {
            File.Delete(FileName);

            var fileReader = new FileReader();

            Action act = () => fileReader.ReadLines();

            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void ReadLines_ForCustomParameter_WhenFileExists_ReturnsFileContent()
        {
            var fileReader = new FileReader(CustomFileName);

            var inputLines = fileReader.ReadLines();

            inputLines.Length.Should().Be(ExpectedReadLines.Length);
            for (int i = 0; i < inputLines.Length; i++)
            {
                inputLines[i].Should().Be(ExpectedReadLines[i]);
            }
        }

        [Fact]
        public void ReadLines_ForCustomParameter_WhenFileDontExists_ThrowsException()
        {
            File.Delete(CustomFileName);

            var fileReader = new FileReader(CustomFileName);

            Action act = () => fileReader.ReadLines();

            act.Should().Throw<FileNotFoundException>();
        }

        public void Dispose()
        {
            CreateFileIfNeeded(FileName);
            CreateFileIfNeeded(CustomFileName);
        }

        private void CreateFileIfNeeded(string fileName)
        {
            if (File.Exists(fileName))
            {
                return;
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.Write(ExpectedReadAll);
            }
        }
    }
}
