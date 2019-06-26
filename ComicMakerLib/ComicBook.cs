using System;
using System.Collections.Generic;
using System.Text;

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

        public void Clic(int index)
        {
            if (Current == null)
            {
                Current = Pages[index];
            }

            Current.Show();
        }

        public void Show(int index)
        {
            if (Current == null)
            {
                Previews[index].Show();
            }
            else
            {
                Current.Show();
            }
        }
    }
}
