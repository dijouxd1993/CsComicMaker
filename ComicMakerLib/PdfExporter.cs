using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public class PdfExporter : IExporter
    {
        public bool Export(ComicBook cMFile)
        {
            Console.WriteLine("Le document a été exporté au format PDF");
            return true;
        }


    }
}
