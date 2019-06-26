using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public class EpubExporter : IExporter
    {
        public bool Export(ComicBook cMFile)
        {
            if (null == cMFile)
            {
                return false;
            }
            Console.WriteLine("Le document a été exporté au format ePub");
            return true;
        }
    }
}
