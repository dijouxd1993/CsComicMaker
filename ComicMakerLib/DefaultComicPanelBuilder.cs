using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public class DefaultComicPanelBuilder : IComicPanelBuilder
    {
        private ComicPanel comicPanel = new ComicPanel();
        public void AddComicModel(ComicModel comicModel)
        {
            throw new NotImplementedException();
        }

        public ComicPanel Build()
        {
            return this.comicPanel;
        }

        public void RemoveComicModel(ComicModel comicModel)
        {
           this.comicPanel
        }
    }
}
