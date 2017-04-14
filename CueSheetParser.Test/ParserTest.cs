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
            var sheet = Parser.Parse(TestData.CueWithPerformer);
            Assert.AreEqual(sheet.Performer, "Some Performer");
        }
    }
}
