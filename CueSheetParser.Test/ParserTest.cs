using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CueSheetParser.Test
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void Parse_shouldExtractPerformerWithoutQuotes()
        {
            var sheet = Parser.Parse(TestData.VeryBasicCue);
            Assert.AreEqual("Some Performer", sheet.Performer);
        }

        [TestMethod]
        public void Parse_shouldExtractTitle()
        {
            var sheet = Parser.Parse(TestData.VeryBasicCue);
            Assert.AreEqual("Some Title", sheet.Title);
        }

    }
}
