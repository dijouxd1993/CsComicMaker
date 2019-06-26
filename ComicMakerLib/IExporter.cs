using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public interface IExporter
    {
        bool Export(ComicBook cMFile);
    }
}
