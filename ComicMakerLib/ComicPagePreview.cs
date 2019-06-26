using System;

namespace ComicMakerLib
{
    public class ComicPagePreview : IComicPage
    {
        public ComicPagePreview(int index)
        {
            Index = index;
        }

        public override string Show()
        {
            return "Page " + Index;
        }
    }
}
