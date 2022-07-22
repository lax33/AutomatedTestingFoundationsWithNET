using InputOutputString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InputOutputStringTests
{
    [TestClass()]
    public class ProgramTests
    {
        // Arrange
        private static readonly char[] line = {'v','j', '4', 'h', '4', 'j', 'h', 'j', 'o', 'l', 'r', '6', 'f',
            'd', 'f', 'g', '1', 'h', 'n', 'x', '7', 'w', 'e', 'w', 'r', '7', 'j',
            'g', 'i', 'l', '7', '1', 'd', 'f', 'r', 'h'};

        private static readonly char[] arr = { 'v', 'j', '4', 'h', 'o', 'l', 'r', '6', 'f', 'd', 'g', '1', 'n', 'x', '7', 'w', 'e', 'i' };

        // Act

        [TestMethod]
        public void SortChars_Test()
        {
            char[] result_SortChars = Program.SortChars(line).Where(x => x != '\0').ToArray();

            CollectionAssert.AreEqual(arr, result_SortChars);
        }

        [TestMethod]
        public void AmountMaxEquelChar_Test()
        {
            int result_AmountMaxEquelChar = Program.AmountMaxEquelChar(line);

            Assert.AreEqual(4, result_AmountMaxEquelChar);
        }

        [TestMethod]
        public void AmountDiffirentChar_Test()
        {
            int result_AmountDiffirentChar = Program.AmountDiffirentChar(arr);

            Assert.AreEqual(18, result_AmountDiffirentChar);
        }

        [TestMethod]
        public void AmountMaxEquelNumber_Test()
        {
            int result_AmountMaxEquelNumber = Program.AmountMaxEquelNumber(line);

            Assert.AreEqual(3, result_AmountMaxEquelNumber);
        }
    }
}