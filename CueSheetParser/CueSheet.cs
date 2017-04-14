using System;
using System.Collections.Generic;

namespace CueSheetParser
{
    /// <summary>
    /// <seealso cref="http://web.archive.org/web/20070221154246/http://www.goldenhawk.com/download/cdrwin.pdf"/>
    /// </summary>
    public class CueSheet
    {

        public string File { get; set; }

        public string Performer { get; set; }

        public Rem Rem { get; }

        public Track Track { get; }

    }
}
