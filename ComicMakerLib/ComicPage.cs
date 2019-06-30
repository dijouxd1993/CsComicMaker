using System.Collections.Generic;

namespace ComicMakerLib
{
    public class ComicPage : IComicPage
    {
        
        public List<ComicPanel> Panels { get; }

        public ComicPage(int index, List<ComicPanel> panels)
        {
            Index = index;
            Panels = panels;
        }

        public override string Show()
        {
            return "Page " + Index + " Panel " + Panels.Count;
        }
    }
}
