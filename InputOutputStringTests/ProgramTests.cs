using InputOutputString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InputOutputStringTests
{
    [TestClass()]
    public class ProgramTests
    {

        private static readonly char[] line = {'v','j', '4', 'h', '4', 'j', 'h', 'j', 'o', 'l', 'r', '6', 'f',
            'd', 'f', 'g', '1', 'h', 'n', 'x', '7', 'w', 'e', 'w', 'r', '7', 'j',
            'g', 'i', 'l', '7', '1', 'd', 'f', 'r', 'h'};

        private static readonly char[] arr = { 'v', 'j', '4', 'h', 'o', 'l', 'r', '6', 'f', 'd', 'g', '1', 'n', 'x', '7', 'w', 'e', 'i'};


        static readonly char[] result_SortChars = Program.SortChars(line).Where(x => x != '\0').ToArray();

        readonly int result_AmountMaxEquelChar = Program.AmountMaxEquelChar(line);


        [TestMethod]
        public void SortChars_Test()
        {
            CollectionAssert.AreEqual(arr, result_SortChars);
        }

        [TestMethod]
        public void AmountMaxEquelChar_Test()
        {
            Assert.AreEqual(4, result_AmountMaxEquelChar);
        }
    }
}