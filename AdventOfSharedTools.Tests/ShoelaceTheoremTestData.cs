using System.Collections;

namespace AdventOfSharedTools.Tests
{
    internal class ShoelaceTheoremTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int[][]
                {
                    [2,3],
                    [5,5],
                    [8,3],
                    [7,1],
                },
                12
            };

            //yield return new object[]
            //{
            //    new Location[]
            //    {
            //        new(0,0),
            //    }
            //};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}