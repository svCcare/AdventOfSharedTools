namespace AdventOfSharedTools.Tests
{
    public class ConsoleOutputTestHelper : IDisposable
    {
        private readonly StringWriter _stringWriter;
        private readonly TextWriter _originalOutput;

        public ConsoleOutputTestHelper()
        {
            _stringWriter = new StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOuput()
        {
            return _stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}
