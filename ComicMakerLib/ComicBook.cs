using System.Collections.Generic;

namespace ComicMakerLib
{
    public class ComicBook
    {
        public List<ComicPagePreview> Previews { get; }
        public List<ComicPage> Pages { get; }
        public ComicPage Current { get; set;  }
        
        public ComicBook(List<ComicPagePreview> previews, List<ComicPage> pages)
        {
            Previews = previews;
            Pages = pages;
        }

        public string Clic(int index)
        {
            Current = Pages[index - 1];

            return Current.Show();
        }

        public string Show(int index)
        {
            if (Current == null || Current.Index != index)
            {
                return Previews[index - 1].Show();
            }
            else
            {
                return Current.Show();
            }
        }
    }
}
