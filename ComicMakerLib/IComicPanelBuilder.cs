using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public interface IComicPanelBuilder
    {
        void AddComicModel(ComicModel comicModel);
        void RemoveComicModel(ComicModel comicModel);
        ComicPanel  Build();
    }
}
