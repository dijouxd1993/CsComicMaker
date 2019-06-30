using ComicMakerLib;
using System;

namespace ComicMakerLib
{
    public class PDFExporter : IExporter
    {
        public bool Export(ComicBook comicBook)
        {
            if (null == comicBook)
            {
                return false;
            }
            Console.WriteLine("Le document a été exporté au format PDF");
            return true;
        }
    }
}