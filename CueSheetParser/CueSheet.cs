using System;
using System.Collections.Generic;

namespace CueSheetParser
{
    /// <summary>
    /// <seealso cref="http://web.archive.org/web/20070221154246/http://www.goldenhawk.com/download/cdrwin.pdf"/>
    /// </summary>
    public class CueSheet
    {

        public string FilePath { get; internal set; }

        public string FileFormat { get; internal set; }

        public string Title { get; internal set; }

        public string Performer { get; internal set; }

        public readonly Rem Rem = new Rem();

        public readonly Track Track = new Track();

    }
}
