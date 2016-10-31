using Anchovy.API.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class LinesTests : AnchovyApiClientTests
    {
        private ILines _lines;

        [TestMethod]
        public void TestObjectLifecycle()
        {
            _lines = Service.Lines;
            PostTest();
            PutTest();
            DeleteTest();
        }

        private void DeleteTest()
        {
            if (Line.Id == null) return;
            var deletedLine = _lines.DeleteLine(Line.Id.Value);
            TestLine(Line, deletedLine);
        }

        private void GetTest(Line line)
        {
            if (line.Id == null) return;
            var gotLine = _lines.GetLine(line.Id.Value);
            TestLine(line, gotLine);
        }

        private void PutTest()
        {
            if (Line.Id == null) return;
            Line.Quantity = int.MaxValue;
            _lines.PutLine(Line.Id.Value, Line);
            GetTest(Line);
        }

        private void PostTest()
        {
            var postedLine = _lines.PostLine(Line);
            Line = postedLine;
            GetTest(Line);
        }

        public void TestLine(Line expected, Line actual)
        {
            if (expected.Id == null || actual.Id == null) return;
            Assert.AreEqual(expected.Id.Value, actual.Id.Value);
            Assert.AreEqual(expected.Quantity, actual.Quantity);
        }
    }
}
