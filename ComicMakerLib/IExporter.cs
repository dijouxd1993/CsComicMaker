using ComicMakerLib;

namespace ComicMakerLib
{
    public  interface IExporter
    {
        bool Export(ComicBook comicBook);
    }
}